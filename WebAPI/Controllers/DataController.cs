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
#region Result_Edit_News
public partial class Result_Edit_News : Action_Result
{
#region Properties.
public News My_News { get; set; }
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
#region Result_Get_Team_member_By_OWNER_ID
public partial class Result_Get_Team_member_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Team_member>  My_Result { get; set; }
public Params_Get_Team_member_By_OWNER_ID My_Params_Get_Team_member_By_OWNER_ID { get; set; }
#endregion
}
#endregion
