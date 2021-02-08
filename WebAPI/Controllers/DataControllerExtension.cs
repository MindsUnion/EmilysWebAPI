
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using BLC;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

public partial class DataController
{
    [HttpPost]
    [Route("Upload_Image")]
    public async Task<IActionResult> Upload_Image()
    {
        #region Declaration And Initialization Section.
        string str_REL_ENTITY = string.Empty;
        string str_REL_FIELD = string.Empty;
        string str_REL_KEY = string.Empty;

        string str_File_Name = string.Empty;        
        string str_Extension = string.Empty;
        string str_Main_Folder = ConfigurationManager.AppSettings["UPLOAD_DOCUMENT_LOCATION"];
        string str_File_Full_Path = string.Empty;

        Uploaded_file oUploaded_file = new Uploaded_file();
        List<string> oList_FileNames = new List<string>();
        Tools.Tools oTools = new Tools.Tools();
        #endregion


        #region Body Section.

        #region Extract Required Data from Query string  
        #region REL_ENTITY
        if
             (
                 (HttpContext.Request.Query["REL_ENTITY"].FirstOrDefault() != null) &&
                 (HttpContext.Request.Query["REL_ENTITY"].ToString() != "")
             )
        {
            str_REL_ENTITY = HttpContext.Request.Query["REL_ENTITY"].ToString();
        }
        #endregion
        #region REL_FIELD
        if
             (
                 (HttpContext.Request.Query["REL_FIELD"].FirstOrDefault() != null) &&
                 (HttpContext.Request.Query["REL_FIELD"].ToString() != "")
             )
        {
            str_REL_FIELD = HttpContext.Request.Query["REL_FIELD"].ToString();
        }
        #endregion
        #region REL_KEY
        if
             (
                 (HttpContext.Request.Query["REL_KEY"].FirstOrDefault() != null) &&
                 (HttpContext.Request.Query["REL_KEY"].ToString() != "")
             )
        {
            str_REL_KEY = HttpContext.Request.Query["REL_KEY"].ToString();
        }
        #endregion
        #endregion

        #region Loop Over Each Uploaded File
        foreach (var formFile in Request.Form.Files)
        {
            if (formFile.Length <= 0) { continue; }
            

            #region Extract Extension
            str_Extension = formFile.FileName.Substring
                                    (
                                       formFile.FileName.LastIndexOf(".") + 1,
                                       formFile.FileName.Length - formFile.FileName.LastIndexOf(".") - 1 
                                    );
            #endregion

            #region Create Uploaded_file entry
            oUploaded_file = new Uploaded_file();
            oUploaded_file.UPLOADED_FILE_ID = -1;
            oUploaded_file.REL_ENTITY = str_REL_ENTITY;
            oUploaded_file.REL_FIELD = str_REL_FIELD;
            oUploaded_file.REL_KEY = Convert.ToInt64(str_REL_KEY);
            oUploaded_file.SIZE = -1;
            oUploaded_file.EXTENSION = str_Extension;
            oUploaded_file.STAMP = oTools.Get_Unique_String();

            BLC.BLC oBLC_Default = new BLC.BLC();
            BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer("", BLC.BLC.Enum_API_Method.Authenticate);
            using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
            {
                oBLC.Edit_Uploaded_file(oUploaded_file);
            }
            #endregion

            #region File Info
            str_File_Name = string.Format("{0}.{1}", oUploaded_file.UPLOADED_FILE_ID.ToString(), str_Extension);            
            str_File_Full_Path = string.Format(@"{0}{1}", str_Main_Folder, str_File_Name);
            #endregion

            #region Save File on Disk
            using (var stream = new FileStream(str_File_Full_Path, FileMode.Create))
            {
                await formFile.CopyToAsync(stream);
                oList_FileNames.Add(str_File_Name);
            }
            #endregion
        }
        #endregion

        #endregion 

        #region Return Section.            
        return Ok(new { count = Request.Form.Files.Count, filenames = oList_FileNames });
        #endregion
    }
}


