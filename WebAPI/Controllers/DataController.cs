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
#region Activate_Account
[HttpPost]
[Route("Activate_Account")]
public Result_Activate_Account Activate_Account(Params_Activate_Account i_Params_Activate_Account)
{
#region Declaration And Initialization Section.
User oReturnValue = new User();
string i_Ticket = string.Empty;
Result_Activate_Account oResult_Activate_Account = new Result_Activate_Account();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Activate_Account);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Activate_Account(i_Params_Activate_Account);
oResult_Activate_Account.My_Result = oReturnValue;
oResult_Activate_Account.My_Params_Activate_Account = i_Params_Activate_Account;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Activate_Account.ExceptionMsg = string.Format("Activate_Account : {0}", ex.Message);
}
else
{
oResult_Activate_Account.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Activate_Account;
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
#region Change_Password
[HttpPost]
[Route("Change_Password")]
public Result_Change_Password Change_Password(Params_Change_Password i_Params_Change_Password)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Change_Password oResult_Change_Password = new Result_Change_Password();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Change_Password);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Change_Password(i_Params_Change_Password);
oResult_Change_Password.My_Params_Change_Password = i_Params_Change_Password;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Change_Password.ExceptionMsg = string.Format("Change_Password : {0}", ex.Message);
}
else
{
oResult_Change_Password.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Change_Password;
#endregion
}
#endregion
#region Delete_News
[HttpPost]
[Route("Delete_News")]
public Result_Delete_News Delete_News(Params_Delete_News i_Params_Delete_News)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_News oResult_Delete_News = new Result_Delete_News();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_News);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_News(i_Params_Delete_News);
oResult_Delete_News.My_Params_Delete_News = i_Params_Delete_News;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_News.ExceptionMsg = string.Format("Delete_News : {0}", ex.Message);
}
else
{
oResult_Delete_News.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_News;
#endregion
}
#endregion
#region Delete_News_source
[HttpPost]
[Route("Delete_News_source")]
public Result_Delete_News_source Delete_News_source(Params_Delete_News_source i_Params_Delete_News_source)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_News_source oResult_Delete_News_source = new Result_Delete_News_source();
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
oBLC.Delete_News_source(i_Params_Delete_News_source);
oResult_Delete_News_source.My_Params_Delete_News_source = i_Params_Delete_News_source;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_News_source.ExceptionMsg = string.Format("Delete_News_source : {0}", ex.Message);
}
else
{
oResult_Delete_News_source.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_News_source;
#endregion
}
#endregion
#region Delete_Team_member
[HttpPost]
[Route("Delete_Team_member")]
public Result_Delete_Team_member Delete_Team_member(Params_Delete_Team_member i_Params_Delete_Team_member)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Team_member oResult_Delete_Team_member = new Result_Delete_Team_member();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Team_member);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Team_member(i_Params_Delete_Team_member);
oResult_Delete_Team_member.My_Params_Delete_Team_member = i_Params_Delete_Team_member;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Team_member.ExceptionMsg = string.Format("Delete_Team_member : {0}", ex.Message);
}
else
{
oResult_Delete_Team_member.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Team_member;
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
#region Edit_News
[HttpPost]
[Route("Edit_News")]
public Result_Edit_News Edit_News(News i_News)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_News oResult_Edit_News = new Result_Edit_News();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_News);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_News(i_News);
oResult_Edit_News.My_News = i_News;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_News.ExceptionMsg = string.Format("Edit_News : {0}", ex.Message);
}
else
{
oResult_Edit_News.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_News;
#endregion
}
#endregion
#region Edit_News_source
[HttpPost]
[Route("Edit_News_source")]
public Result_Edit_News_source Edit_News_source(News_source i_News_source)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_News_source oResult_Edit_News_source = new Result_Edit_News_source();
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
oBLC.Edit_News_source(i_News_source);
oResult_Edit_News_source.My_News_source = i_News_source;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_News_source.ExceptionMsg = string.Format("Edit_News_source : {0}", ex.Message);
}
else
{
oResult_Edit_News_source.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_News_source;
#endregion
}
#endregion
#region Edit_Section
[HttpPost]
[Route("Edit_Section")]
public Result_Edit_Section Edit_Section(Section i_Section)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Section oResult_Edit_Section = new Result_Edit_Section();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Section);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Section(i_Section);
oResult_Edit_Section.My_Section = i_Section;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Section.ExceptionMsg = string.Format("Edit_Section : {0}", ex.Message);
}
else
{
oResult_Edit_Section.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Section;
#endregion
}
#endregion
#region Edit_Team_member
[HttpPost]
[Route("Edit_Team_member")]
public Result_Edit_Team_member Edit_Team_member(Team_member i_Team_member)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Team_member oResult_Edit_Team_member = new Result_Edit_Team_member();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Team_member);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Team_member(i_Team_member);
oResult_Edit_Team_member.My_Team_member = i_Team_member;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Team_member.ExceptionMsg = string.Format("Edit_Team_member : {0}", ex.Message);
}
else
{
oResult_Edit_Team_member.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Team_member;
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
#region Forgot_Password
[HttpPost]
[Route("Forgot_Password")]
public Result_Forgot_Password Forgot_Password(Params_Forgot_Password i_Params_Forgot_Password)
{
#region Declaration And Initialization Section.
User oReturnValue = new User();
string i_Ticket = string.Empty;
Result_Forgot_Password oResult_Forgot_Password = new Result_Forgot_Password();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Forgot_Password);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Forgot_Password(i_Params_Forgot_Password);
oResult_Forgot_Password.My_Result = oReturnValue;
oResult_Forgot_Password.My_Params_Forgot_Password = i_Params_Forgot_Password;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Forgot_Password.ExceptionMsg = string.Format("Forgot_Password : {0}", ex.Message);
}
else
{
oResult_Forgot_Password.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Forgot_Password;
#endregion
}
#endregion
#region Get_News_By_Where
[HttpPost]
[Route("Get_News_By_Where")]
public Result_Get_News_By_Where Get_News_By_Where(Params_Get_News_By_Where i_Params_Get_News_By_Where)
{
#region Declaration And Initialization Section.
List<News>  oReturnValue = new List<News> ();
string i_Ticket = string.Empty;
Result_Get_News_By_Where oResult_Get_News_By_Where = new Result_Get_News_By_Where();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_News_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_News_By_Where(i_Params_Get_News_By_Where);
oResult_Get_News_By_Where.My_Result = oReturnValue;
oResult_Get_News_By_Where.My_Params_Get_News_By_Where = i_Params_Get_News_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_News_By_Where.ExceptionMsg = string.Format("Get_News_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_News_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_News_By_Where;
#endregion
}
#endregion
#region Get_Section_By_OWNER_ID
[HttpPost]
[Route("Get_Section_By_OWNER_ID")]
public Result_Get_Section_By_OWNER_ID Get_Section_By_OWNER_ID(Params_Get_Section_By_OWNER_ID i_Params_Get_Section_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Section>  oReturnValue = new List<Section> ();
string i_Ticket = string.Empty;
Result_Get_Section_By_OWNER_ID oResult_Get_Section_By_OWNER_ID = new Result_Get_Section_By_OWNER_ID();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Section_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Section_By_OWNER_ID(i_Params_Get_Section_By_OWNER_ID);
oResult_Get_Section_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Section_By_OWNER_ID.My_Params_Get_Section_By_OWNER_ID = i_Params_Get_Section_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Section_By_OWNER_ID.ExceptionMsg = string.Format("Get_Section_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Section_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Section_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Section_By_SECTION_ID
[HttpPost]
[Route("Get_Section_By_SECTION_ID")]
public Result_Get_Section_By_SECTION_ID Get_Section_By_SECTION_ID(Params_Get_Section_By_SECTION_ID i_Params_Get_Section_By_SECTION_ID)
{
#region Declaration And Initialization Section.
Section oReturnValue = new Section();
string i_Ticket = string.Empty;
Result_Get_Section_By_SECTION_ID oResult_Get_Section_By_SECTION_ID = new Result_Get_Section_By_SECTION_ID();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Section_By_SECTION_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Section_By_SECTION_ID(i_Params_Get_Section_By_SECTION_ID);
oResult_Get_Section_By_SECTION_ID.My_Result = oReturnValue;
oResult_Get_Section_By_SECTION_ID.My_Params_Get_Section_By_SECTION_ID = i_Params_Get_Section_By_SECTION_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Section_By_SECTION_ID.ExceptionMsg = string.Format("Get_Section_By_SECTION_ID : {0}", ex.Message);
}
else
{
oResult_Get_Section_By_SECTION_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Section_By_SECTION_ID;
#endregion
}
#endregion
#region Get_Section_With_Uploaded_Files
[HttpPost]
[Route("Get_Section_With_Uploaded_Files")]
public Result_Get_Section_With_Uploaded_Files Get_Section_With_Uploaded_Files(Params_Get_Section_With_Uploaded_Files i_Params_Get_Section_With_Uploaded_Files)
{
#region Declaration And Initialization Section.
List<Section>  oReturnValue = new List<Section> ();
string i_Ticket = string.Empty;
Result_Get_Section_With_Uploaded_Files oResult_Get_Section_With_Uploaded_Files = new Result_Get_Section_With_Uploaded_Files();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Section_With_Uploaded_Files);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Section_With_Uploaded_Files(i_Params_Get_Section_With_Uploaded_Files);
oResult_Get_Section_With_Uploaded_Files.My_Result = oReturnValue;
oResult_Get_Section_With_Uploaded_Files.My_Params_Get_Section_With_Uploaded_Files = i_Params_Get_Section_With_Uploaded_Files;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Section_With_Uploaded_Files.ExceptionMsg = string.Format("Get_Section_With_Uploaded_Files : {0}", ex.Message);
}
else
{
oResult_Get_Section_With_Uploaded_Files.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Section_With_Uploaded_Files;
#endregion
}
#endregion
#region Get_Team_member_By_OWNER_ID
[HttpPost]
[Route("Get_Team_member_By_OWNER_ID")]
public Result_Get_Team_member_By_OWNER_ID Get_Team_member_By_OWNER_ID(Params_Get_Team_member_By_OWNER_ID i_Params_Get_Team_member_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Team_member>  oReturnValue = new List<Team_member> ();
string i_Ticket = string.Empty;
Result_Get_Team_member_By_OWNER_ID oResult_Get_Team_member_By_OWNER_ID = new Result_Get_Team_member_By_OWNER_ID();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Team_member_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Team_member_By_OWNER_ID(i_Params_Get_Team_member_By_OWNER_ID);
oResult_Get_Team_member_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Team_member_By_OWNER_ID.My_Params_Get_Team_member_By_OWNER_ID = i_Params_Get_Team_member_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Team_member_By_OWNER_ID.ExceptionMsg = string.Format("Get_Team_member_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Team_member_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Team_member_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Team_member_With_Uploaded_Files
[HttpPost]
[Route("Get_Team_member_With_Uploaded_Files")]
public Result_Get_Team_member_With_Uploaded_Files Get_Team_member_With_Uploaded_Files(Params_Get_Team_member_With_Uploaded_Files i_Params_Get_Team_member_With_Uploaded_Files)
{
#region Declaration And Initialization Section.
List<Team_member>  oReturnValue = new List<Team_member> ();
string i_Ticket = string.Empty;
Result_Get_Team_member_With_Uploaded_Files oResult_Get_Team_member_With_Uploaded_Files = new Result_Get_Team_member_With_Uploaded_Files();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Team_member_With_Uploaded_Files);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Team_member_With_Uploaded_Files(i_Params_Get_Team_member_With_Uploaded_Files);
oResult_Get_Team_member_With_Uploaded_Files.My_Result = oReturnValue;
oResult_Get_Team_member_With_Uploaded_Files.My_Params_Get_Team_member_With_Uploaded_Files = i_Params_Get_Team_member_With_Uploaded_Files;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Team_member_With_Uploaded_Files.ExceptionMsg = string.Format("Get_Team_member_With_Uploaded_Files : {0}", ex.Message);
}
else
{
oResult_Get_Team_member_With_Uploaded_Files.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Team_member_With_Uploaded_Files;
#endregion
}
#endregion
#region Get_User_By_OWNER_ID
[HttpPost]
[Route("Get_User_By_OWNER_ID")]
public Result_Get_User_By_OWNER_ID Get_User_By_OWNER_ID(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<User>  oReturnValue = new List<User> ();
string i_Ticket = string.Empty;
Result_Get_User_By_OWNER_ID oResult_Get_User_By_OWNER_ID = new Result_Get_User_By_OWNER_ID();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_User_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_User_By_OWNER_ID(i_Params_Get_User_By_OWNER_ID);
oResult_Get_User_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_User_By_OWNER_ID.My_Params_Get_User_By_OWNER_ID = i_Params_Get_User_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_User_By_OWNER_ID.ExceptionMsg = string.Format("Get_User_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_User_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_User_By_OWNER_ID;
#endregion
}
#endregion
#region Get_User_By_USER_ID
[HttpPost]
[Route("Get_User_By_USER_ID")]
public Result_Get_User_By_USER_ID Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
#region Declaration And Initialization Section.
User oReturnValue = new User();
string i_Ticket = string.Empty;
Result_Get_User_By_USER_ID oResult_Get_User_By_USER_ID = new Result_Get_User_By_USER_ID();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_User_By_USER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID);
oResult_Get_User_By_USER_ID.My_Result = oReturnValue;
oResult_Get_User_By_USER_ID.My_Params_Get_User_By_USER_ID = i_Params_Get_User_By_USER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_User_By_USER_ID.ExceptionMsg = string.Format("Get_User_By_USER_ID : {0}", ex.Message);
}
else
{
oResult_Get_User_By_USER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_User_By_USER_ID;
#endregion
}
#endregion
#region Verify_Account
[HttpPost]
[Route("Verify_Account")]
public Result_Verify_Account Verify_Account(Params_Verify_Account i_Params_Verify_Account)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Verify_Account oResult_Verify_Account = new Result_Verify_Account();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Verify_Account);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Verify_Account(i_Params_Verify_Account);
oResult_Verify_Account.My_Params_Verify_Account = i_Params_Verify_Account;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Verify_Account.ExceptionMsg = string.Format("Verify_Account : {0}", ex.Message);
}
else
{
oResult_Verify_Account.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Verify_Account;
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
#region Result_Activate_Account
public partial class Result_Activate_Account : Action_Result
{
#region Properties.
public User My_Result { get; set; }
public Params_Activate_Account My_Params_Activate_Account { get; set; }
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
#region Result_Change_Password
public partial class Result_Change_Password : Action_Result
{
#region Properties.
public Params_Change_Password My_Params_Change_Password { get; set; }
#endregion
}
#endregion
#region Result_Delete_News
public partial class Result_Delete_News : Action_Result
{
#region Properties.
public Params_Delete_News My_Params_Delete_News { get; set; }
#endregion
}
#endregion
#region Result_Delete_News_source
public partial class Result_Delete_News_source : Action_Result
{
#region Properties.
public Params_Delete_News_source My_Params_Delete_News_source { get; set; }
#endregion
}
#endregion
#region Result_Delete_Team_member
public partial class Result_Delete_Team_member : Action_Result
{
#region Properties.
public Params_Delete_Team_member My_Params_Delete_Team_member { get; set; }
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
#region Result_Edit_News
public partial class Result_Edit_News : Action_Result
{
#region Properties.
public News My_News { get; set; }
#endregion
}
#endregion
#region Result_Edit_News_source
public partial class Result_Edit_News_source : Action_Result
{
#region Properties.
public News_source My_News_source { get; set; }
#endregion
}
#endregion
#region Result_Edit_Section
public partial class Result_Edit_Section : Action_Result
{
#region Properties.
public Section My_Section { get; set; }
#endregion
}
#endregion
#region Result_Edit_Team_member
public partial class Result_Edit_Team_member : Action_Result
{
#region Properties.
public Team_member My_Team_member { get; set; }
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
#region Result_Forgot_Password
public partial class Result_Forgot_Password : Action_Result
{
#region Properties.
public User My_Result { get; set; }
public Params_Forgot_Password My_Params_Forgot_Password { get; set; }
#endregion
}
#endregion
#region Result_Get_News_By_Where
public partial class Result_Get_News_By_Where : Action_Result
{
#region Properties.
public List<News>  My_Result { get; set; }
public Params_Get_News_By_Where My_Params_Get_News_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Section_By_OWNER_ID
public partial class Result_Get_Section_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Section>  My_Result { get; set; }
public Params_Get_Section_By_OWNER_ID My_Params_Get_Section_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Section_By_SECTION_ID
public partial class Result_Get_Section_By_SECTION_ID : Action_Result
{
#region Properties.
public Section My_Result { get; set; }
public Params_Get_Section_By_SECTION_ID My_Params_Get_Section_By_SECTION_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Section_With_Uploaded_Files
public partial class Result_Get_Section_With_Uploaded_Files : Action_Result
{
#region Properties.
public List<Section>  My_Result { get; set; }
public Params_Get_Section_With_Uploaded_Files My_Params_Get_Section_With_Uploaded_Files { get; set; }
#endregion
}
#endregion
#region Result_Get_Team_member_By_OWNER_ID
public partial class Result_Get_Team_member_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Team_member>  My_Result { get; set; }
public Params_Get_Team_member_By_OWNER_ID My_Params_Get_Team_member_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Team_member_With_Uploaded_Files
public partial class Result_Get_Team_member_With_Uploaded_Files : Action_Result
{
#region Properties.
public List<Team_member>  My_Result { get; set; }
public Params_Get_Team_member_With_Uploaded_Files My_Params_Get_Team_member_With_Uploaded_Files { get; set; }
#endregion
}
#endregion
#region Result_Get_User_By_OWNER_ID
public partial class Result_Get_User_By_OWNER_ID : Action_Result
{
#region Properties.
public List<User>  My_Result { get; set; }
public Params_Get_User_By_OWNER_ID My_Params_Get_User_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_User_By_USER_ID
public partial class Result_Get_User_By_USER_ID : Action_Result
{
#region Properties.
public User My_Result { get; set; }
public Params_Get_User_By_USER_ID My_Params_Get_User_By_USER_ID { get; set; }
#endregion
}
#endregion
#region Result_Verify_Account
public partial class Result_Verify_Account : Action_Result
{
#region Properties.
public Params_Verify_Account My_Params_Verify_Account { get; set; }
#endregion
}
#endregion
