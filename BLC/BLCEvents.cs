using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using BLC;
namespace BLC
{
public partial class BLC
{

#region Enum_API_Method
public enum Enum_API_Method
{
Authenticate
}
#endregion

#region Prepare_BLCInitializer
public BLCInitializer Prepare_BLCInitializer(string i_Ticket, Enum_API_Method i_Enum_API_Method)
{
#region Declaration And Initialization Section.
BLCInitializer oBLCInitializer = new BLCInitializer();
BLC oBLC_Default = new BLC();
string str_CUSTOM_BLC_INIT = string.Empty;
#endregion
#region Body Section.
if (this.OnPreEvent_BLC_Init != null)
{
oBLCInitializer = this.OnPreEvent_BLC_Init(i_Ticket, i_Enum_API_Method);
return oBLCInitializer;
}
else
{
oBLCInitializer.UserID = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
}
#endregion
#region Return Section.
return oBLCInitializer;
#endregion
}
#endregion

#region General Pre/Post events
public delegate void PreEvent_Handler_General(string i_MethodName);
public delegate void PostEvent_Handler_General(string i_MethodName);
public event PreEvent_Handler_General OnPreEvent_General;
public event PostEvent_Handler_General OnPostEvent_General;
#endregion
#region General Pre/Post BLC_Init
public delegate BLCInitializer PreEvent_Handler_BLC_Init(string i_Ticket, Enum_API_Method i_Enum_API_Method);
public delegate BLCInitializer PostEvent_Handler_BLC_Init(string i_Ticket, Enum_API_Method i_Enum_API_Method);
public event PreEvent_Handler_BLC_Init OnPreEvent_BLC_Init;
public event PostEvent_Handler_BLC_Init OnPostEvent_BLC_Init;
#endregion
public  delegate void PreEvent_Handler_Get_Section_By_OWNER_ID(Params_Get_Section_By_OWNER_ID i_Params_Get_Section_By_OWNER_ID);
public  delegate void  PostEvent_Handler_Get_Section_By_OWNER_ID(ref List<Section>  i_Result, Params_Get_Section_By_OWNER_ID i_Params_Get_Section_By_OWNER_ID);
public event PreEvent_Handler_Get_Section_By_OWNER_ID OnPreEvent_Get_Section_By_OWNER_ID;
public event PostEvent_Handler_Get_Section_By_OWNER_ID OnPostEvent_Get_Section_By_OWNER_ID;
public  delegate void PreEvent_Handler_Get_Team_member_By_OWNER_ID(Params_Get_Team_member_By_OWNER_ID i_Params_Get_Team_member_By_OWNER_ID);
public  delegate void  PostEvent_Handler_Get_Team_member_By_OWNER_ID(ref List<Team_member>  i_Result, Params_Get_Team_member_By_OWNER_ID i_Params_Get_Team_member_By_OWNER_ID);
public event PreEvent_Handler_Get_Team_member_By_OWNER_ID OnPreEvent_Get_Team_member_By_OWNER_ID;
public event PostEvent_Handler_Get_Team_member_By_OWNER_ID OnPostEvent_Get_Team_member_By_OWNER_ID;
public  delegate void PreEvent_Handler_Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file);
public  delegate void  PostEvent_Handler_Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file);
public event PreEvent_Handler_Delete_Uploaded_file OnPreEvent_Delete_Uploaded_file;
public event PostEvent_Handler_Delete_Uploaded_file OnPostEvent_Delete_Uploaded_file;
public  delegate void PreEvent_Handler_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
public  delegate void  PostEvent_Handler_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
public event PreEvent_Handler_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
public event PostEvent_Handler_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD OnPostEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
public  delegate void PreEvent_Handler_Edit_Uploaded_file(Uploaded_file i_Uploaded_file,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Uploaded_file(Uploaded_file i_Uploaded_file,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Uploaded_file OnPreEvent_Edit_Uploaded_file;
public event PostEvent_Handler_Edit_Uploaded_file OnPostEvent_Edit_Uploaded_file;
#region Uploaded Files Events Handlers
#region Register_Uploaded_Events_Handlers
public void Register_Uploaded_Events_Handlers()
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
this.OnPreEvent_Edit_Uploaded_file += BLC_OnPreEvent_Edit_Uploaded_file;
this.OnPreEvent_Delete_Uploaded_file += BLC_OnPreEvent_Delete_Uploaded_file;
this.OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD += BLC_OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
this.OnPostEvent_Get_Team_member_By_OWNER_ID += BLC_OnPostEvent_Get_Team_member_By_OWNER_ID_Uploaded_Files;
this.OnPostEvent_Get_Section_By_OWNER_ID += BLC_OnPostEvent_Get_Section_By_OWNER_ID_Uploaded_Files;
#endregion
}
#endregion
#region BLC_OnPostEvent_Get_Team_member_By_OWNER_ID_Uploaded_Files
private void BLC_OnPostEvent_Get_Team_member_By_OWNER_ID_Uploaded_Files(ref List<Team_member> i_Result, Params_Get_Team_member_By_OWNER_ID i_Params_Get_Team_member_By_OWNER_ID)
{
#region Declaration And Initialization Section.
Uploaded_file oUploaded_file = new Uploaded_file();
List<Uploaded_file> oList_Uploaded_files = new List<Uploaded_file>();
string str_WEB_PATH = ConfigurationManager.AppSettings["WEB_PATH"].ToString();
#endregion
if (i_Result != null)
{
foreach (var oRow_Team_member in i_Result)
{
#region Images
oRow_Team_member.My_Uploaded_files = Get_Uploaded_Files("TBL_TEAM_MEMBER", "TEAM_MEMBER_IMAGE", oRow_Team_member.TEAM_MEMBER_ID);
if (oRow_Team_member.My_Uploaded_files != null)
{
foreach (var oRow_Uploaded_file in oRow_Team_member.My_Uploaded_files)
{
oRow_Uploaded_file.My_URL = string.Format("{0}/Files/Uploaded/{1}.{2}", str_WEB_PATH, oRow_Uploaded_file.UPLOADED_FILE_ID.ToString(), oRow_Uploaded_file.EXTENSION);
}
}
#endregion
}
}
}
#endregion
#region BLC_OnPostEvent_Get_Section_By_OWNER_ID_Uploaded_Files
private void BLC_OnPostEvent_Get_Section_By_OWNER_ID_Uploaded_Files(ref List<Section> i_Result, Params_Get_Section_By_OWNER_ID i_Params_Get_Section_By_OWNER_ID)
{
#region Declaration And Initialization Section.
Uploaded_file oUploaded_file = new Uploaded_file();
List<Uploaded_file> oList_Uploaded_files = new List<Uploaded_file>();
string str_WEB_PATH = ConfigurationManager.AppSettings["WEB_PATH"].ToString();
#endregion
if (i_Result != null)
{
foreach (var oRow_Section in i_Result)
{
#region Images
oRow_Section.My_Uploaded_files = Get_Uploaded_Files("TBL_SECTION", "SECTION_IMAGE", oRow_Section.SECTION_ID);
if (oRow_Section.My_Uploaded_files != null)
{
foreach (var oRow_Uploaded_file in oRow_Section.My_Uploaded_files)
{
oRow_Uploaded_file.My_URL = string.Format("{0}/Files/Uploaded/{1}.{2}", str_WEB_PATH, oRow_Uploaded_file.UPLOADED_FILE_ID.ToString(), oRow_Uploaded_file.EXTENSION);
}
}
#endregion
}
}
}
#endregion
#region Get_Uploaded_Files
public List<Uploaded_file> Get_Uploaded_Files(string i_REL_ENTITY,string i_REL_FIELD,long? i_REL_KEY)
{
#region Declaration And Initialization Section.
List<Uploaded_file> oList_Uploaded_files = new List<Uploaded_file>();
Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD();
#endregion
#region Body Section.
oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD();
oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_ENTITY = i_REL_ENTITY;
oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_FIELD = i_REL_FIELD;
oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_KEY = i_REL_KEY;
oList_Uploaded_files = Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
#endregion
#region Return Section.
return oList_Uploaded_files;
#endregion
}
#endregion
#region BLC_OnPreEvent_Edit_Uploaded_file
void BLC_OnPreEvent_Edit_Uploaded_file(Uploaded_file i_Uploaded_file, BLC.Enum_EditMode i_Enum_EditMode)
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
i_Uploaded_file.STAMP = oTools.Get_Unique_String();
#endregion
}
#endregion
#region BLC_OnPreEvent_Delete_Uploaded_file
void BLC_OnPreEvent_Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file)
{
#region Declaration And Initialization Section.
string str_Full_Path = string.Empty;
Uploaded_file oUploaded_file = new Uploaded_file();
Params_Get_Uploaded_file_By_UPLOADED_FILE_ID oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID = new Params_Get_Uploaded_file_By_UPLOADED_FILE_ID();
string str_Main_Folder = ConfigurationManager.AppSettings["UPLOAD_DOCUMENT_LOCATION"];
#endregion
#region Body Section.
oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID = new Params_Get_Uploaded_file_By_UPLOADED_FILE_ID();
oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID.UPLOADED_FILE_ID = i_Params_Delete_Uploaded_file.UPLOADED_FILE_ID;
oUploaded_file = Get_Uploaded_file_By_UPLOADED_FILE_ID(oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID);
str_Full_Path = string.Format(@"{0}\{1}.{2}", str_Main_Folder, oUploaded_file.UPLOADED_FILE_ID.ToString(), oUploaded_file.EXTENSION);
File.Delete(str_Full_Path);
#endregion
}
#endregion
#region BLC_OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
private void BLC_OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD)
{
#region Declaration And Initialization Section.
string str_Full_Path = string.Empty;
Uploaded_file oUploaded_file = new Uploaded_file();
List<Uploaded_file> oList_Uploaded_files = new List<Uploaded_file>();
Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD();
string str_Main_Folder = ConfigurationManager.AppSettings["UPLOAD_DOCUMENT_LOCATION"];
#endregion
#region Body Section.
oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD();
oTools.CopyPropValues(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD, oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
oList_Uploaded_files = Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
if ((oList_Uploaded_files != null) && (oList_Uploaded_files.Count > 0))
{
oUploaded_file = oList_Uploaded_files[oList_Uploaded_files.Count - 1];
str_Full_Path = string.Format(@"{0}\{1}.{2}", str_Main_Folder, oUploaded_file.UPLOADED_FILE_ID.ToString(), oUploaded_file.EXTENSION);
File.Delete(str_Full_Path);
}
#endregion
}
#endregion
#endregion
#region Cach Dropper
public void Initialize_Cash_Dropper()
{
}
#endregion
}
}
