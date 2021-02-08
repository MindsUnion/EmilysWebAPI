using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Configuration;
using DALC;
//using System.Data.Linq;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Reflection;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Threading;







namespace BLC
{
public partial class BLC
{
#region Members
#region Used For Delete Operations
private News _News;
private Owner _Owner;
private Section _Section;
private Team_member _Team_member;
private Uploaded_file _Uploaded_file;
private User _User;
#endregion
#region Stop Executing Flags For Edit and Delete Operations
private bool _Stop_Edit_News_Execution;
private bool _Stop_Delete_News_Execution;
private bool _Stop_Edit_Owner_Execution;
private bool _Stop_Delete_Owner_Execution;
private bool _Stop_Edit_Section_Execution;
private bool _Stop_Delete_Section_Execution;
private bool _Stop_Edit_Team_member_Execution;
private bool _Stop_Delete_Team_member_Execution;
private bool _Stop_Edit_Uploaded_file_Execution;
private bool _Stop_Delete_Uploaded_file_Execution;
private bool _Stop_Edit_User_Execution;
private bool _Stop_Delete_User_Execution;
#endregion
#endregion
public News Get_News_By_NEWS_ID(Params_Get_News_By_NEWS_ID i_Params_Get_News_By_NEWS_ID)
{
News oNews = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_News_By_NEWS_ID");}
#region Body Section.
DALC.News oDBEntry = _AppContext.Get_News_By_NEWS_ID(i_Params_Get_News_By_NEWS_ID.NEWS_ID);
oNews = new News();
oTools.CopyPropValues(oDBEntry, oNews);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_News_By_NEWS_ID");}
return oNews;
}
public Owner Get_Owner_By_OWNER_ID(Params_Get_Owner_By_OWNER_ID i_Params_Get_Owner_By_OWNER_ID)
{
Owner oOwner = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID");}
#region Body Section.
DALC.Owner oDBEntry = _AppContext.Get_Owner_By_OWNER_ID(i_Params_Get_Owner_By_OWNER_ID.OWNER_ID);
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID");}
return oOwner;
}
public Section Get_Section_By_SECTION_ID(Params_Get_Section_By_SECTION_ID i_Params_Get_Section_By_SECTION_ID)
{
Section oSection = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Section_By_SECTION_ID");}
#region Body Section.
DALC.Section oDBEntry = _AppContext.Get_Section_By_SECTION_ID(i_Params_Get_Section_By_SECTION_ID.SECTION_ID);
oSection = new Section();
oTools.CopyPropValues(oDBEntry, oSection);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Section_By_SECTION_ID");}
return oSection;
}
public Team_member Get_Team_member_By_TEAM_MEMBER_ID(Params_Get_Team_member_By_TEAM_MEMBER_ID i_Params_Get_Team_member_By_TEAM_MEMBER_ID)
{
Team_member oTeam_member = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Team_member_By_TEAM_MEMBER_ID");}
#region Body Section.
DALC.Team_member oDBEntry = _AppContext.Get_Team_member_By_TEAM_MEMBER_ID(i_Params_Get_Team_member_By_TEAM_MEMBER_ID.TEAM_MEMBER_ID);
oTeam_member = new Team_member();
oTools.CopyPropValues(oDBEntry, oTeam_member);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Team_member_By_TEAM_MEMBER_ID");}
return oTeam_member;
}
public Uploaded_file Get_Uploaded_file_By_UPLOADED_FILE_ID(Params_Get_Uploaded_file_By_UPLOADED_FILE_ID i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID)
{
Uploaded_file oUploaded_file = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID");}
#region Body Section.
DALC.Uploaded_file oDBEntry = _AppContext.Get_Uploaded_file_By_UPLOADED_FILE_ID(i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID.UPLOADED_FILE_ID);
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID");}
return oUploaded_file;
}
public User Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID");}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID");}
return oUser;
}
public List<News> Get_News_By_NEWS_ID_List(Params_Get_News_By_NEWS_ID_List i_Params_Get_News_By_NEWS_ID_List)
{
News oNews = null;
List<News> oList = new List<News>();
Params_Get_News_By_NEWS_ID_List_SP oParams_Get_News_By_NEWS_ID_List_SP = new Params_Get_News_By_NEWS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_News_By_NEWS_ID_List");}
#region Body Section.
List<DALC.News> oList_DBEntries = _AppContext.Get_News_By_NEWS_ID_List(i_Params_Get_News_By_NEWS_ID_List.NEWS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oNews = new News();
oTools.CopyPropValues(oDBEntry, oNews);
oList.Add(oNews);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_News_By_NEWS_ID_List");}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List(Params_Get_Owner_By_OWNER_ID_List i_Params_Get_Owner_By_OWNER_ID_List)
{
Owner oOwner = null;
List<Owner> oList = new List<Owner>();
Params_Get_Owner_By_OWNER_ID_List_SP oParams_Get_Owner_By_OWNER_ID_List_SP = new Params_Get_Owner_By_OWNER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID_List");}
#region Body Section.
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_OWNER_ID_List(i_Params_Get_Owner_By_OWNER_ID_List.OWNER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID_List");}
return oList;
}
public List<Section> Get_Section_By_SECTION_ID_List(Params_Get_Section_By_SECTION_ID_List i_Params_Get_Section_By_SECTION_ID_List)
{
Section oSection = null;
List<Section> oList = new List<Section>();
Params_Get_Section_By_SECTION_ID_List_SP oParams_Get_Section_By_SECTION_ID_List_SP = new Params_Get_Section_By_SECTION_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Section_By_SECTION_ID_List");}
#region Body Section.
List<DALC.Section> oList_DBEntries = _AppContext.Get_Section_By_SECTION_ID_List(i_Params_Get_Section_By_SECTION_ID_List.SECTION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSection = new Section();
oTools.CopyPropValues(oDBEntry, oSection);
oList.Add(oSection);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Section_By_SECTION_ID_List");}
return oList;
}
public List<Team_member> Get_Team_member_By_TEAM_MEMBER_ID_List(Params_Get_Team_member_By_TEAM_MEMBER_ID_List i_Params_Get_Team_member_By_TEAM_MEMBER_ID_List)
{
Team_member oTeam_member = null;
List<Team_member> oList = new List<Team_member>();
Params_Get_Team_member_By_TEAM_MEMBER_ID_List_SP oParams_Get_Team_member_By_TEAM_MEMBER_ID_List_SP = new Params_Get_Team_member_By_TEAM_MEMBER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Team_member_By_TEAM_MEMBER_ID_List");}
#region Body Section.
List<DALC.Team_member> oList_DBEntries = _AppContext.Get_Team_member_By_TEAM_MEMBER_ID_List(i_Params_Get_Team_member_By_TEAM_MEMBER_ID_List.TEAM_MEMBER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeam_member = new Team_member();
oTools.CopyPropValues(oDBEntry, oTeam_member);
oList.Add(oTeam_member);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Team_member_By_TEAM_MEMBER_ID_List");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_UPLOADED_FILE_ID_List(Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List)
{
Uploaded_file oUploaded_file = null;
List<Uploaded_file> oList = new List<Uploaded_file>();
Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP = new Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID_List");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_UPLOADED_FILE_ID_List(i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List.UPLOADED_FILE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID_List");}
return oList;
}
public List<User> Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List");}
return oList;
}
public List<News> Get_News_By_OWNER_ID(Params_Get_News_By_OWNER_ID i_Params_Get_News_By_OWNER_ID)
{
List<News> oList = new List<News>();
News oNews = new News();
if (OnPreEvent_General != null){OnPreEvent_General("Get_News_By_OWNER_ID");}
#region Body Section.
List<DALC.News> oList_DBEntries = _AppContext.Get_News_By_OWNER_ID(i_Params_Get_News_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oNews = new News();
oTools.CopyPropValues(oDBEntry, oNews);
oList.Add(oNews);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_News_By_OWNER_ID");}
return oList;
}
public List<Section> Get_Section_By_OWNER_ID(Params_Get_Section_By_OWNER_ID i_Params_Get_Section_By_OWNER_ID)
{
List<Section> oList = new List<Section>();
Section oSection = new Section();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Section_By_OWNER_ID");}
#region PreEvent_Get_Section_By_OWNER_ID
if (OnPreEvent_Get_Section_By_OWNER_ID != null)
{
OnPreEvent_Get_Section_By_OWNER_ID(i_Params_Get_Section_By_OWNER_ID);
}
#endregion
#region Body Section.
List<DALC.Section> oList_DBEntries = _AppContext.Get_Section_By_OWNER_ID(i_Params_Get_Section_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSection = new Section();
oTools.CopyPropValues(oDBEntry, oSection);
oList.Add(oSection);
}
}
#endregion
#region PostEvent_Get_Section_By_OWNER_ID
if (OnPostEvent_Get_Section_By_OWNER_ID != null)
{
OnPostEvent_Get_Section_By_OWNER_ID(ref oList,i_Params_Get_Section_By_OWNER_ID);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Section_By_OWNER_ID");}
return oList;
}
public List<Team_member> Get_Team_member_By_OWNER_ID(Params_Get_Team_member_By_OWNER_ID i_Params_Get_Team_member_By_OWNER_ID)
{
List<Team_member> oList = new List<Team_member>();
Team_member oTeam_member = new Team_member();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Team_member_By_OWNER_ID");}
#region PreEvent_Get_Team_member_By_OWNER_ID
if (OnPreEvent_Get_Team_member_By_OWNER_ID != null)
{
OnPreEvent_Get_Team_member_By_OWNER_ID(i_Params_Get_Team_member_By_OWNER_ID);
}
#endregion
#region Body Section.
List<DALC.Team_member> oList_DBEntries = _AppContext.Get_Team_member_By_OWNER_ID(i_Params_Get_Team_member_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeam_member = new Team_member();
oTools.CopyPropValues(oDBEntry, oTeam_member);
oList.Add(oTeam_member);
}
}
#endregion
#region PostEvent_Get_Team_member_By_OWNER_ID
if (OnPostEvent_Get_Team_member_By_OWNER_ID != null)
{
OnPostEvent_Get_Team_member_By_OWNER_ID(ref oList,i_Params_Get_Team_member_By_OWNER_ID);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Team_member_By_OWNER_ID");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_OWNER_ID(Params_Get_Uploaded_file_By_OWNER_ID i_Params_Get_Uploaded_file_By_OWNER_ID)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_OWNER_ID");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_OWNER_ID(i_Params_Get_Uploaded_file_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_OWNER_ID");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY(Params_Get_Uploaded_file_By_REL_ENTITY i_Params_Get_Uploaded_file_By_REL_ENTITY)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_REL_ENTITY");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_REL_ENTITY(i_Params_Get_Uploaded_file_By_REL_ENTITY.REL_ENTITY);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_REL_ENTITY");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY(Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_REL_ENTITY_REL_KEY(i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_ENTITY,i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_KEY);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_ENTITY,i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_KEY,i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_FIELD);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
return oList;
}
public List<User> Get_User_By_OWNER_ID(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID");}
return oList;
}
public List<User> Get_User_By_USERNAME(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME(i_Params_Get_User_By_USERNAME.USERNAME);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME");}
return oList;
}
public List<News> Get_News_By_Criteria(Params_Get_News_By_Criteria i_Params_Get_News_By_Criteria)
{
List<News> oList = new List<News>();
News oNews = new News();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_News_By_Criteria");}
#region Body Section.
if ((i_Params_Get_News_By_Criteria.OWNER_ID == null) || (i_Params_Get_News_By_Criteria.OWNER_ID == 0)) { i_Params_Get_News_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_News_By_Criteria.START_ROW == null) { i_Params_Get_News_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_News_By_Criteria.END_ROW == null) || (i_Params_Get_News_By_Criteria.END_ROW == 0)) { i_Params_Get_News_By_Criteria.END_ROW = 1000000; }
List<DALC.News> oList_DBEntries = _AppContext.Get_News_By_Criteria(i_Params_Get_News_By_Criteria.TITLE,i_Params_Get_News_By_Criteria.DESCRIPTION,i_Params_Get_News_By_Criteria.OWNER_ID,i_Params_Get_News_By_Criteria.START_ROW,i_Params_Get_News_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oNews = new News();
oTools.CopyPropValues(oDBEntry, oNews);
oList.Add(oNews);
}
}
i_Params_Get_News_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_News_By_Criteria");}
return oList;
}
public List<News> Get_News_By_Where(Params_Get_News_By_Where i_Params_Get_News_By_Where)
{
List<News> oList = new List<News>();
News oNews = new News();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_News_By_Where");}
#region Body Section.
if ((i_Params_Get_News_By_Where.OWNER_ID == null) || (i_Params_Get_News_By_Where.OWNER_ID == 0)) { i_Params_Get_News_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_News_By_Where.START_ROW == null) { i_Params_Get_News_By_Where.START_ROW = 0; }
if ((i_Params_Get_News_By_Where.END_ROW == null) || (i_Params_Get_News_By_Where.END_ROW == 0)) { i_Params_Get_News_By_Where.END_ROW = 1000000; }
List<DALC.News> oList_DBEntries = _AppContext.Get_News_By_Where(i_Params_Get_News_By_Where.TITLE,i_Params_Get_News_By_Where.DESCRIPTION,i_Params_Get_News_By_Where.OWNER_ID,i_Params_Get_News_By_Where.START_ROW,i_Params_Get_News_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oNews = new News();
oTools.CopyPropValues(oDBEntry, oNews);
oList.Add(oNews);
}
}
i_Params_Get_News_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_News_By_Where");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria(Params_Get_Owner_By_Criteria i_Params_Get_Owner_By_Criteria)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria.START_ROW == null) { i_Params_Get_Owner_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria.END_ROW == null) || (i_Params_Get_Owner_By_Criteria.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria(i_Params_Get_Owner_By_Criteria.CODE,i_Params_Get_Owner_By_Criteria.DESCRIPTION,i_Params_Get_Owner_By_Criteria.OWNER_ID,i_Params_Get_Owner_By_Criteria.START_ROW,i_Params_Get_Owner_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria");}
return oList;
}
public List<Owner> Get_Owner_By_Where(Params_Get_Owner_By_Where i_Params_Get_Owner_By_Where)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where");}
#region Body Section.
if ((i_Params_Get_Owner_By_Where.OWNER_ID == null) || (i_Params_Get_Owner_By_Where.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where.START_ROW == null) { i_Params_Get_Owner_By_Where.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where.END_ROW == null) || (i_Params_Get_Owner_By_Where.END_ROW == 0)) { i_Params_Get_Owner_By_Where.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where(i_Params_Get_Owner_By_Where.CODE,i_Params_Get_Owner_By_Where.DESCRIPTION,i_Params_Get_Owner_By_Where.OWNER_ID,i_Params_Get_Owner_By_Where.START_ROW,i_Params_Get_Owner_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2(Params_Get_Owner_By_Criteria_V2 i_Params_Get_Owner_By_Criteria_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria_V2.START_ROW == null) { i_Params_Get_Owner_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Owner_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria_V2(i_Params_Get_Owner_By_Criteria_V2.CODE,i_Params_Get_Owner_By_Criteria_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Criteria_V2.DESCRIPTION,i_Params_Get_Owner_By_Criteria_V2.OWNER_ID,i_Params_Get_Owner_By_Criteria_V2.START_ROW,i_Params_Get_Owner_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria_V2");}
return oList;
}
public List<Owner> Get_Owner_By_Where_V2(Params_Get_Owner_By_Where_V2 i_Params_Get_Owner_By_Where_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Owner_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where_V2.START_ROW == null) { i_Params_Get_Owner_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where_V2.END_ROW == null) || (i_Params_Get_Owner_By_Where_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Where_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where_V2(i_Params_Get_Owner_By_Where_V2.CODE,i_Params_Get_Owner_By_Where_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Where_V2.DESCRIPTION,i_Params_Get_Owner_By_Where_V2.OWNER_ID,i_Params_Get_Owner_By_Where_V2.START_ROW,i_Params_Get_Owner_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where_V2");}
return oList;
}
public List<Section> Get_Section_By_Criteria(Params_Get_Section_By_Criteria i_Params_Get_Section_By_Criteria)
{
List<Section> oList = new List<Section>();
Section oSection = new Section();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Section_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Section_By_Criteria.OWNER_ID == null) || (i_Params_Get_Section_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Section_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Section_By_Criteria.START_ROW == null) { i_Params_Get_Section_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Section_By_Criteria.END_ROW == null) || (i_Params_Get_Section_By_Criteria.END_ROW == 0)) { i_Params_Get_Section_By_Criteria.END_ROW = 1000000; }
List<DALC.Section> oList_DBEntries = _AppContext.Get_Section_By_Criteria(i_Params_Get_Section_By_Criteria.SECTION_NAME,i_Params_Get_Section_By_Criteria.OWNER_ID,i_Params_Get_Section_By_Criteria.START_ROW,i_Params_Get_Section_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSection = new Section();
oTools.CopyPropValues(oDBEntry, oSection);
oList.Add(oSection);
}
}
i_Params_Get_Section_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Section_By_Criteria");}
return oList;
}
public List<Section> Get_Section_By_Where(Params_Get_Section_By_Where i_Params_Get_Section_By_Where)
{
List<Section> oList = new List<Section>();
Section oSection = new Section();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Section_By_Where");}
#region Body Section.
if ((i_Params_Get_Section_By_Where.OWNER_ID == null) || (i_Params_Get_Section_By_Where.OWNER_ID == 0)) { i_Params_Get_Section_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Section_By_Where.START_ROW == null) { i_Params_Get_Section_By_Where.START_ROW = 0; }
if ((i_Params_Get_Section_By_Where.END_ROW == null) || (i_Params_Get_Section_By_Where.END_ROW == 0)) { i_Params_Get_Section_By_Where.END_ROW = 1000000; }
List<DALC.Section> oList_DBEntries = _AppContext.Get_Section_By_Where(i_Params_Get_Section_By_Where.SECTION_NAME,i_Params_Get_Section_By_Where.OWNER_ID,i_Params_Get_Section_By_Where.START_ROW,i_Params_Get_Section_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSection = new Section();
oTools.CopyPropValues(oDBEntry, oSection);
oList.Add(oSection);
}
}
i_Params_Get_Section_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Section_By_Where");}
return oList;
}
public List<Team_member> Get_Team_member_By_Criteria(Params_Get_Team_member_By_Criteria i_Params_Get_Team_member_By_Criteria)
{
List<Team_member> oList = new List<Team_member>();
Team_member oTeam_member = new Team_member();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Team_member_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Team_member_By_Criteria.OWNER_ID == null) || (i_Params_Get_Team_member_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Team_member_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Team_member_By_Criteria.START_ROW == null) { i_Params_Get_Team_member_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Team_member_By_Criteria.END_ROW == null) || (i_Params_Get_Team_member_By_Criteria.END_ROW == 0)) { i_Params_Get_Team_member_By_Criteria.END_ROW = 1000000; }
List<DALC.Team_member> oList_DBEntries = _AppContext.Get_Team_member_By_Criteria(i_Params_Get_Team_member_By_Criteria.MEMBER_NAME,i_Params_Get_Team_member_By_Criteria.POSITION,i_Params_Get_Team_member_By_Criteria.MAJOR,i_Params_Get_Team_member_By_Criteria.OWNER_ID,i_Params_Get_Team_member_By_Criteria.START_ROW,i_Params_Get_Team_member_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeam_member = new Team_member();
oTools.CopyPropValues(oDBEntry, oTeam_member);
oList.Add(oTeam_member);
}
}
i_Params_Get_Team_member_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Team_member_By_Criteria");}
return oList;
}
public List<Team_member> Get_Team_member_By_Where(Params_Get_Team_member_By_Where i_Params_Get_Team_member_By_Where)
{
List<Team_member> oList = new List<Team_member>();
Team_member oTeam_member = new Team_member();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Team_member_By_Where");}
#region Body Section.
if ((i_Params_Get_Team_member_By_Where.OWNER_ID == null) || (i_Params_Get_Team_member_By_Where.OWNER_ID == 0)) { i_Params_Get_Team_member_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Team_member_By_Where.START_ROW == null) { i_Params_Get_Team_member_By_Where.START_ROW = 0; }
if ((i_Params_Get_Team_member_By_Where.END_ROW == null) || (i_Params_Get_Team_member_By_Where.END_ROW == 0)) { i_Params_Get_Team_member_By_Where.END_ROW = 1000000; }
List<DALC.Team_member> oList_DBEntries = _AppContext.Get_Team_member_By_Where(i_Params_Get_Team_member_By_Where.MEMBER_NAME,i_Params_Get_Team_member_By_Where.POSITION,i_Params_Get_Team_member_By_Where.MAJOR,i_Params_Get_Team_member_By_Where.OWNER_ID,i_Params_Get_Team_member_By_Where.START_ROW,i_Params_Get_Team_member_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTeam_member = new Team_member();
oTools.CopyPropValues(oDBEntry, oTeam_member);
oList.Add(oTeam_member);
}
}
i_Params_Get_Team_member_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Team_member_By_Where");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_Criteria(Params_Get_Uploaded_file_By_Criteria i_Params_Get_Uploaded_file_By_Criteria)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID == null) || (i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Uploaded_file_By_Criteria.START_ROW == null) { i_Params_Get_Uploaded_file_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Uploaded_file_By_Criteria.END_ROW == null) || (i_Params_Get_Uploaded_file_By_Criteria.END_ROW == 0)) { i_Params_Get_Uploaded_file_By_Criteria.END_ROW = 1000000; }
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_Criteria(i_Params_Get_Uploaded_file_By_Criteria.REL_ENTITY,i_Params_Get_Uploaded_file_By_Criteria.REL_FIELD,i_Params_Get_Uploaded_file_By_Criteria.EXTENSION,i_Params_Get_Uploaded_file_By_Criteria.STAMP,i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID,i_Params_Get_Uploaded_file_By_Criteria.START_ROW,i_Params_Get_Uploaded_file_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
i_Params_Get_Uploaded_file_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_Criteria");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_Where(Params_Get_Uploaded_file_By_Where i_Params_Get_Uploaded_file_By_Where)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_Where");}
#region Body Section.
if ((i_Params_Get_Uploaded_file_By_Where.OWNER_ID == null) || (i_Params_Get_Uploaded_file_By_Where.OWNER_ID == 0)) { i_Params_Get_Uploaded_file_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Uploaded_file_By_Where.START_ROW == null) { i_Params_Get_Uploaded_file_By_Where.START_ROW = 0; }
if ((i_Params_Get_Uploaded_file_By_Where.END_ROW == null) || (i_Params_Get_Uploaded_file_By_Where.END_ROW == 0)) { i_Params_Get_Uploaded_file_By_Where.END_ROW = 1000000; }
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_Where(i_Params_Get_Uploaded_file_By_Where.REL_ENTITY,i_Params_Get_Uploaded_file_By_Where.REL_FIELD,i_Params_Get_Uploaded_file_By_Where.EXTENSION,i_Params_Get_Uploaded_file_By_Where.STAMP,i_Params_Get_Uploaded_file_By_Where.OWNER_ID,i_Params_Get_Uploaded_file_By_Where.START_ROW,i_Params_Get_Uploaded_file_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
i_Params_Get_Uploaded_file_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_Where");}
return oList;
}
public List<User> Get_User_By_Criteria(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.FULLNAME,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria");}
return oList;
}
public List<User> Get_User_By_Where(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where");}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.FULLNAME,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where");}
return oList;
}
public void Delete_News(Params_Delete_News i_Params_Delete_News)
{
Params_Get_News_By_NEWS_ID oParams_Get_News_By_NEWS_ID = new Params_Get_News_By_NEWS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_News");}
#region Body Section.
try
{
oParams_Get_News_By_NEWS_ID.NEWS_ID = i_Params_Delete_News.NEWS_ID;
_News = Get_News_By_NEWS_ID_Adv(oParams_Get_News_By_NEWS_ID);
if (_News != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_News_Execution)
{
_Stop_Delete_News_Execution = false;
return;
}
_AppContext.Delete_News(i_Params_Delete_News.NEWS_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_News");}
}
public void Delete_Owner(Params_Delete_Owner i_Params_Delete_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Owner");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Owner_Execution)
{
_Stop_Delete_Owner_Execution = false;
return;
}
_AppContext.Delete_Owner(i_Params_Delete_Owner.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Owner");}
}
public void Delete_Section(Params_Delete_Section i_Params_Delete_Section)
{
Params_Get_Section_By_SECTION_ID oParams_Get_Section_By_SECTION_ID = new Params_Get_Section_By_SECTION_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Section");}
#region Body Section.
try
{
oParams_Get_Section_By_SECTION_ID.SECTION_ID = i_Params_Delete_Section.SECTION_ID;
_Section = Get_Section_By_SECTION_ID_Adv(oParams_Get_Section_By_SECTION_ID);
if (_Section != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Section_Execution)
{
_Stop_Delete_Section_Execution = false;
return;
}
_AppContext.Delete_Section(i_Params_Delete_Section.SECTION_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Section");}
}
public void Delete_Team_member(Params_Delete_Team_member i_Params_Delete_Team_member)
{
Params_Get_Team_member_By_TEAM_MEMBER_ID oParams_Get_Team_member_By_TEAM_MEMBER_ID = new Params_Get_Team_member_By_TEAM_MEMBER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Team_member");}
#region Body Section.
try
{
oParams_Get_Team_member_By_TEAM_MEMBER_ID.TEAM_MEMBER_ID = i_Params_Delete_Team_member.TEAM_MEMBER_ID;
_Team_member = Get_Team_member_By_TEAM_MEMBER_ID_Adv(oParams_Get_Team_member_By_TEAM_MEMBER_ID);
if (_Team_member != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Team_member_Execution)
{
_Stop_Delete_Team_member_Execution = false;
return;
}
_AppContext.Delete_Team_member(i_Params_Delete_Team_member.TEAM_MEMBER_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Team_member");}
}
public void Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Uploaded_file
if (OnPreEvent_Delete_Uploaded_file != null)
{
OnPreEvent_Delete_Uploaded_file(i_Params_Delete_Uploaded_file);
}
#endregion
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file(i_Params_Delete_Uploaded_file.UPLOADED_FILE_ID);
#region PostEvent_Delete_Uploaded_file
if (OnPostEvent_Delete_Uploaded_file != null)
{
OnPostEvent_Delete_Uploaded_file(i_Params_Delete_Uploaded_file);
}
#endregion
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file");}
}
public void Delete_User(Params_Delete_User i_Params_Delete_User)
{
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User");}
#region Body Section.
try
{
oParams_Get_User_By_USER_ID.USER_ID = i_Params_Delete_User.USER_ID;
_User = Get_User_By_USER_ID_Adv(oParams_Get_User_By_USER_ID);
if (_User != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User(i_Params_Delete_User.USER_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User");}
}
public void Delete_News_By_OWNER_ID(Params_Delete_News_By_OWNER_ID i_Params_Delete_News_By_OWNER_ID)
{
Params_Get_News_By_OWNER_ID oParams_Get_News_By_OWNER_ID = new Params_Get_News_By_OWNER_ID();
List<News> _List_News = new List<News>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_News_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_News_Execution)
{
_Stop_Delete_News_Execution = false;
return;
}
_AppContext.Delete_News_By_OWNER_ID(i_Params_Delete_News_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_News_By_OWNER_ID");}
}
public void Delete_Section_By_OWNER_ID(Params_Delete_Section_By_OWNER_ID i_Params_Delete_Section_By_OWNER_ID)
{
Params_Get_Section_By_OWNER_ID oParams_Get_Section_By_OWNER_ID = new Params_Get_Section_By_OWNER_ID();
List<Section> _List_Section = new List<Section>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Section_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Section_Execution)
{
_Stop_Delete_Section_Execution = false;
return;
}
_AppContext.Delete_Section_By_OWNER_ID(i_Params_Delete_Section_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Section_By_OWNER_ID");}
}
public void Delete_Team_member_By_OWNER_ID(Params_Delete_Team_member_By_OWNER_ID i_Params_Delete_Team_member_By_OWNER_ID)
{
Params_Get_Team_member_By_OWNER_ID oParams_Get_Team_member_By_OWNER_ID = new Params_Get_Team_member_By_OWNER_ID();
List<Team_member> _List_Team_member = new List<Team_member>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Team_member_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Team_member_Execution)
{
_Stop_Delete_Team_member_Execution = false;
return;
}
_AppContext.Delete_Team_member_By_OWNER_ID(i_Params_Delete_Team_member_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Team_member_By_OWNER_ID");}
}
public void Delete_Uploaded_file_By_OWNER_ID(Params_Delete_Uploaded_file_By_OWNER_ID i_Params_Delete_Uploaded_file_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_OWNER_ID(i_Params_Delete_Uploaded_file_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_OWNER_ID");}
}
public void Delete_Uploaded_file_By_REL_ENTITY(Params_Delete_Uploaded_file_By_REL_ENTITY i_Params_Delete_Uploaded_file_By_REL_ENTITY)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_REL_ENTITY");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_REL_ENTITY(i_Params_Delete_Uploaded_file_By_REL_ENTITY.REL_ENTITY);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_REL_ENTITY");}
}
public void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_REL_ENTITY_REL_KEY(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_ENTITY,i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_KEY);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY");}
}
public void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
if (OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD != null)
{
OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
}
#endregion
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_ENTITY,i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_KEY,i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_FIELD);
#region PostEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
if (OnPostEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD != null)
{
OnPostEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
}
#endregion
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
}
public void Delete_User_By_OWNER_ID(Params_Delete_User_By_OWNER_ID i_Params_Delete_User_By_OWNER_ID)
{
Params_Get_User_By_OWNER_ID oParams_Get_User_By_OWNER_ID = new Params_Get_User_By_OWNER_ID();
List<User> _List_User = new List<User>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_OWNER_ID(i_Params_Delete_User_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_OWNER_ID");}
}
public void Delete_User_By_USERNAME(Params_Delete_User_By_USERNAME i_Params_Delete_User_By_USERNAME)
{
Params_Get_User_By_USERNAME oParams_Get_User_By_USERNAME = new Params_Get_User_By_USERNAME();
List<User> _List_User = new List<User>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_USERNAME");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_USERNAME(i_Params_Delete_User_By_USERNAME.USERNAME);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_USERNAME");}
}
public void Edit_News(News i_News) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_News.NEWS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_News");}
#region Body Section.
if ((i_News.NEWS_ID == null) || (i_News.NEWS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_News"); }
i_News.ENTRY_USER_ID = this.UserID;
i_News.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_News.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_News_Execution)
{
_Stop_Edit_News_Execution = false;
return;
}
i_News.NEWS_ID = _AppContext.Edit_News
(
i_News.NEWS_ID
,i_News.TITLE
,i_News.DESCRIPTION
,i_News.IS_DISPLAYABLE
,i_News.ENTRY_USER_ID
,i_News.ENTRY_DATE
,i_News.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_News");}
}
public void Edit_Owner(Owner i_Owner) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Owner.OWNER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner");}
#region Body Section.
if ((i_Owner.OWNER_ID == null) || (i_Owner.OWNER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Owner"); }
i_Owner.ENTRY_DATE    = oTools.GetDateTimeString(DateTime.Now);
i_Owner.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Owner_Execution)
{
_Stop_Edit_Owner_Execution = false;
return;
}
i_Owner.OWNER_ID = _AppContext.Edit_Owner
(
i_Owner.OWNER_ID
,i_Owner.CODE
,i_Owner.MAINTENANCE_DUE_DATE
,i_Owner.DESCRIPTION
,i_Owner.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner");}
}
public void Edit_Section(Section i_Section) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Section.SECTION_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Section");}
#region Body Section.
if ((i_Section.SECTION_ID == null) || (i_Section.SECTION_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Section"); }
i_Section.ENTRY_USER_ID = this.UserID;
i_Section.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Section.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Section_Execution)
{
_Stop_Edit_Section_Execution = false;
return;
}
i_Section.SECTION_ID = _AppContext.Edit_Section
(
i_Section.SECTION_ID
,i_Section.SECTION_NAME
,i_Section.ENTRY_USER_ID
,i_Section.ENTRY_DATE
,i_Section.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Section");}
}
public void Edit_Team_member(Team_member i_Team_member) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Team_member.TEAM_MEMBER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Team_member");}
#region Body Section.
if ((i_Team_member.TEAM_MEMBER_ID == null) || (i_Team_member.TEAM_MEMBER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Team_member"); }
i_Team_member.ENTRY_USER_ID = this.UserID;
i_Team_member.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Team_member.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Team_member_Execution)
{
_Stop_Edit_Team_member_Execution = false;
return;
}
i_Team_member.TEAM_MEMBER_ID = _AppContext.Edit_Team_member
(
i_Team_member.TEAM_MEMBER_ID
,i_Team_member.MEMBER_NAME
,i_Team_member.POSITION
,i_Team_member.MAJOR
,i_Team_member.ENTRY_USER_ID
,i_Team_member.ENTRY_DATE
,i_Team_member.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Team_member");}
}
public void Edit_Uploaded_file(Uploaded_file i_Uploaded_file) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Uploaded_file.UPLOADED_FILE_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Uploaded_file");}
#region Body Section.
if ((i_Uploaded_file.UPLOADED_FILE_ID == null) || (i_Uploaded_file.UPLOADED_FILE_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Uploaded_file"); }
i_Uploaded_file.ENTRY_USER_ID = this.UserID;
i_Uploaded_file.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Uploaded_file.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Uploaded_file
if (OnPreEvent_Edit_Uploaded_file != null)
{
OnPreEvent_Edit_Uploaded_file(i_Uploaded_file,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Uploaded_file_Execution)
{
_Stop_Edit_Uploaded_file_Execution = false;
return;
}
i_Uploaded_file.UPLOADED_FILE_ID = _AppContext.Edit_Uploaded_file
(
i_Uploaded_file.UPLOADED_FILE_ID
,i_Uploaded_file.REL_ENTITY
,i_Uploaded_file.REL_KEY
,i_Uploaded_file.REL_FIELD
,i_Uploaded_file.SIZE
,i_Uploaded_file.EXTENSION
,i_Uploaded_file.STAMP
,i_Uploaded_file.ENTRY_USER_ID
,i_Uploaded_file.ENTRY_DATE
,i_Uploaded_file.OWNER_ID
);
#region PostEvent_Edit_Uploaded_file
if (OnPostEvent_Edit_Uploaded_file != null)
{
OnPostEvent_Edit_Uploaded_file(i_Uploaded_file,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Uploaded_file");}
}
public void Edit_User(User i_User) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_User.USER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User");}
#region Body Section.
if ((i_User.USER_ID == null) || (i_User.USER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_User"); }
i_User.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_User.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_User_Execution)
{
_Stop_Edit_User_Execution = false;
return;
}
i_User.USER_ID = _AppContext.Edit_User
(
i_User.USER_ID
,i_User.OWNER_ID
,i_User.USERNAME
,i_User.PASSWORD
,i_User.FULLNAME
,i_User.USER_TYPE_CODE
,i_User.IS_ACTIVE
,i_User.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User");}
}
public void Edit_News_List(List<News> i_List_News)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_News_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_News != null)
{
foreach (var oRow in i_List_News)
{
Edit_News(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_News_List");}
}
public void Edit_News_List(Params_Edit_News_List i_Params_Edit_News_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_News_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_News_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_News_List.My_List_To_Delete)
{
Delete_News(new Params_Delete_News() { NEWS_ID = oRow.NEWS_ID });
}
}
if (i_Params_Edit_News_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_News_List.My_List_To_Edit)
{
Edit_News(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_News_List");}
}
public void Edit_Owner_List(List<Owner> i_List_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Owner != null)
{
foreach (var oRow in i_List_Owner)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Owner_List(Params_Edit_Owner_List i_Params_Edit_Owner_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Owner_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Delete)
{
Delete_Owner(new Params_Delete_Owner() { OWNER_ID = oRow.OWNER_ID });
}
}
if (i_Params_Edit_Owner_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Edit)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Section_List(List<Section> i_List_Section)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Section_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Section != null)
{
foreach (var oRow in i_List_Section)
{
Edit_Section(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Section_List");}
}
public void Edit_Section_List(Params_Edit_Section_List i_Params_Edit_Section_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Section_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Section_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Section_List.My_List_To_Delete)
{
Delete_Section(new Params_Delete_Section() { SECTION_ID = oRow.SECTION_ID });
}
}
if (i_Params_Edit_Section_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Section_List.My_List_To_Edit)
{
Edit_Section(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Section_List");}
}
public void Edit_Team_member_List(List<Team_member> i_List_Team_member)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Team_member_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Team_member != null)
{
foreach (var oRow in i_List_Team_member)
{
Edit_Team_member(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Team_member_List");}
}
public void Edit_Team_member_List(Params_Edit_Team_member_List i_Params_Edit_Team_member_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Team_member_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Team_member_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Team_member_List.My_List_To_Delete)
{
Delete_Team_member(new Params_Delete_Team_member() { TEAM_MEMBER_ID = oRow.TEAM_MEMBER_ID });
}
}
if (i_Params_Edit_Team_member_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Team_member_List.My_List_To_Edit)
{
Edit_Team_member(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Team_member_List");}
}
public void Edit_Uploaded_file_List(List<Uploaded_file> i_List_Uploaded_file)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Uploaded_file_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Uploaded_file != null)
{
foreach (var oRow in i_List_Uploaded_file)
{
Edit_Uploaded_file(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Uploaded_file_List");}
}
public void Edit_Uploaded_file_List(Params_Edit_Uploaded_file_List i_Params_Edit_Uploaded_file_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Uploaded_file_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Uploaded_file_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Uploaded_file_List.My_List_To_Delete)
{
Delete_Uploaded_file(new Params_Delete_Uploaded_file() { UPLOADED_FILE_ID = oRow.UPLOADED_FILE_ID });
}
}
if (i_Params_Edit_Uploaded_file_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Uploaded_file_List.My_List_To_Edit)
{
Edit_Uploaded_file(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Uploaded_file_List");}
}
public void Edit_User_List(List<User> i_List_User)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_User != null)
{
foreach (var oRow in i_List_User)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
public void Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_User_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Delete)
{
Delete_User(new Params_Delete_User() { USER_ID = oRow.USER_ID });
}
}
if (i_Params_Edit_User_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Edit)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
}
}
