using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BLC;
[Route("api/[controller]")]
[ApiController]
public partial class DataController : ControllerBase
{
#region Members
#endregion
#region Extract_Ticket
private string Extract_Ticket()
{
#region Declaration And Initialization Section.
string str_Ticket = string.Empty;
#endregion
if(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null)
{
str_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
#region Return Section.
return str_Ticket;
#endregion
}
#endregion
#region IsValidWebTicket
private bool IsValidWebTicket(string i_Input)
{
#region Declaration And Initialization Section.
bool Is_Valid = false;
BLCInitializer oBLCInitializer = new BLCInitializer();
#endregion
#region Body Section.
BLC.BLC oBLC_Default = new BLC.BLC();
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
Is_Valid = oBLC.IsValidTicket(i_Input);
}
#endregion
#region Return Section.
return Is_Valid;
#endregion
}
#endregion
#region Authenticate
[HttpPost]
[Route("Authenticate")]
public Result_Authenticate Authenticate(Params_Authenticate i_Params_Authenticate)
{
#region Declaration And Initialization Section.
User oReturnValue = new User();
string i_Ticket = string.Empty;
Result_Authenticate oResult_Authenticate = new Result_Authenticate();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Authenticate(i_Params_Authenticate);
oResult_Authenticate.My_Result = oReturnValue;
oResult_Authenticate.My_Params_Authenticate = i_Params_Authenticate;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Authenticate.ExceptionMsg = string.Format("Authenticate : {0}", ex.Message);
}
else
{
oResult_Authenticate.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Authenticate;
#endregion
}
#endregion
#region Delete_Uploaded_file
[HttpPost]
[Route("Delete_Uploaded_file")]
public Result_Delete_Uploaded_file Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Uploaded_file oResult_Delete_Uploaded_file = new Result_Delete_Uploaded_file();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Uploaded_file(i_Params_Delete_Uploaded_file);
oResult_Delete_Uploaded_file.My_Params_Delete_Uploaded_file = i_Params_Delete_Uploaded_file;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Uploaded_file.ExceptionMsg = string.Format("Delete_Uploaded_file : {0}", ex.Message);
}
else
{
oResult_Delete_Uploaded_file.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Uploaded_file;
#endregion
}
#endregion
#region Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
[HttpPost]
[Route("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD")]
public Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD oResult_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = new Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
oResult_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.My_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.ExceptionMsg = string.Format("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD : {0}", ex.Message);
}
else
{
oResult_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
#endregion
}
#endregion
#region Edit_Uploaded_file
[HttpPost]
[Route("Edit_Uploaded_file")]
public Result_Edit_Uploaded_file Edit_Uploaded_file(Uploaded_file i_Uploaded_file)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Uploaded_file oResult_Edit_Uploaded_file = new Result_Edit_Uploaded_file();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Uploaded_file(i_Uploaded_file);
oResult_Edit_Uploaded_file.My_Uploaded_file = i_Uploaded_file;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Uploaded_file.ExceptionMsg = string.Format("Edit_Uploaded_file : {0}", ex.Message);
}
else
{
oResult_Edit_Uploaded_file.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Uploaded_file;
#endregion
}
#endregion
}

#region Action_Result
public partial class Action_Result
{
#region Properties.
public string ExceptionMsg { get; set; }
#endregion
#region Constructor
public Action_Result()
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
this.ExceptionMsg = string.Empty;
#endregion
}
#endregion
}
#endregion
#region Result_Authenticate
public partial class Result_Authenticate : Action_Result
{
#region Properties.
public User My_Result { get; set; }
public Params_Authenticate My_Params_Authenticate { get; set; }
#endregion
}
#endregion
#region Result_Delete_Uploaded_file
public partial class Result_Delete_Uploaded_file : Action_Result
{
#region Properties.
public Params_Delete_Uploaded_file My_Params_Delete_Uploaded_file { get; set; }
#endregion
}
#endregion
#region Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
public partial class Result_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD : Action_Result
{
#region Properties.
public Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD My_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD { get; set; }
#endregion
}
#endregion
#region Result_Edit_Uploaded_file
public partial class Result_Edit_Uploaded_file : Action_Result
{
#region Properties.
public Uploaded_file My_Uploaded_file { get; set; }
#endregion
}
#endregion
