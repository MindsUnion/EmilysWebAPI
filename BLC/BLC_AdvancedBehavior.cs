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
public News Get_News_By_NEWS_ID_Adv(Params_Get_News_By_NEWS_ID i_Params_Get_News_By_NEWS_ID)
{
News oNews = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_News_By_NEWS_ID_Adv");}
#region Body Section.
DALC.News oDBEntry = _AppContext.Get_News_By_NEWS_ID_Adv(i_Params_Get_News_By_NEWS_ID.NEWS_ID);
oNews = new News();
oTools.CopyPropValues(oDBEntry, oNews);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_News_By_NEWS_ID_Adv");}
return oNews;
}
public Section Get_Section_By_SECTION_ID_Adv(Params_Get_Section_By_SECTION_ID i_Params_Get_Section_By_SECTION_ID)
{
Section oSection = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Section_By_SECTION_ID_Adv");}
#region Body Section.
DALC.Section oDBEntry = _AppContext.Get_Section_By_SECTION_ID_Adv(i_Params_Get_Section_By_SECTION_ID.SECTION_ID);
oSection = new Section();
oTools.CopyPropValues(oDBEntry, oSection);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Section_By_SECTION_ID_Adv");}
return oSection;
}
public Team_member Get_Team_member_By_TEAM_MEMBER_ID_Adv(Params_Get_Team_member_By_TEAM_MEMBER_ID i_Params_Get_Team_member_By_TEAM_MEMBER_ID)
{
Team_member oTeam_member = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Team_member_By_TEAM_MEMBER_ID_Adv");}
#region Body Section.
DALC.Team_member oDBEntry = _AppContext.Get_Team_member_By_TEAM_MEMBER_ID_Adv(i_Params_Get_Team_member_By_TEAM_MEMBER_ID.TEAM_MEMBER_ID);
oTeam_member = new Team_member();
oTools.CopyPropValues(oDBEntry, oTeam_member);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Team_member_By_TEAM_MEMBER_ID_Adv");}
return oTeam_member;
}
public User Get_User_By_USER_ID_Adv(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_Adv");}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID_Adv(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_Adv");}
return oUser;
}
public List<News> Get_News_By_NEWS_ID_List_Adv(Params_Get_News_By_NEWS_ID_List i_Params_Get_News_By_NEWS_ID_List)
{
News oNews = null;
List<News> oList = new List<News>();
Params_Get_News_By_NEWS_ID_List_SP oParams_Get_News_By_NEWS_ID_List_SP = new Params_Get_News_By_NEWS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_News_By_NEWS_ID_List_Adv");}
#region Body Section.
List<DALC.News> oList_DBEntries = _AppContext.Get_News_By_NEWS_ID_List_Adv(i_Params_Get_News_By_NEWS_ID_List.NEWS_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_News_By_NEWS_ID_List_Adv");}
return oList;
}
public List<Section> Get_Section_By_SECTION_ID_List_Adv(Params_Get_Section_By_SECTION_ID_List i_Params_Get_Section_By_SECTION_ID_List)
{
Section oSection = null;
List<Section> oList = new List<Section>();
Params_Get_Section_By_SECTION_ID_List_SP oParams_Get_Section_By_SECTION_ID_List_SP = new Params_Get_Section_By_SECTION_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Section_By_SECTION_ID_List_Adv");}
#region Body Section.
List<DALC.Section> oList_DBEntries = _AppContext.Get_Section_By_SECTION_ID_List_Adv(i_Params_Get_Section_By_SECTION_ID_List.SECTION_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Section_By_SECTION_ID_List_Adv");}
return oList;
}
public List<Team_member> Get_Team_member_By_TEAM_MEMBER_ID_List_Adv(Params_Get_Team_member_By_TEAM_MEMBER_ID_List i_Params_Get_Team_member_By_TEAM_MEMBER_ID_List)
{
Team_member oTeam_member = null;
List<Team_member> oList = new List<Team_member>();
Params_Get_Team_member_By_TEAM_MEMBER_ID_List_SP oParams_Get_Team_member_By_TEAM_MEMBER_ID_List_SP = new Params_Get_Team_member_By_TEAM_MEMBER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Team_member_By_TEAM_MEMBER_ID_List_Adv");}
#region Body Section.
List<DALC.Team_member> oList_DBEntries = _AppContext.Get_Team_member_By_TEAM_MEMBER_ID_List_Adv(i_Params_Get_Team_member_By_TEAM_MEMBER_ID_List.TEAM_MEMBER_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Team_member_By_TEAM_MEMBER_ID_List_Adv");}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List_Adv(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List_Adv");}
return oList;
}
public List<News> Get_News_By_OWNER_ID_Adv(Params_Get_News_By_OWNER_ID i_Params_Get_News_By_OWNER_ID)
{
List<News> oList = new List<News>();
News oNews = new News();
if (OnPreEvent_General != null){OnPreEvent_General("Get_News_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.News> oList_DBEntries = _AppContext.Get_News_By_OWNER_ID_Adv(i_Params_Get_News_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_News_By_OWNER_ID_Adv");}
return oList;
}
public List<Section> Get_Section_By_OWNER_ID_Adv(Params_Get_Section_By_OWNER_ID i_Params_Get_Section_By_OWNER_ID)
{
List<Section> oList = new List<Section>();
Section oSection = new Section();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Section_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Section> oList_DBEntries = _AppContext.Get_Section_By_OWNER_ID_Adv(i_Params_Get_Section_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Section_By_OWNER_ID_Adv");}
return oList;
}
public List<Team_member> Get_Team_member_By_OWNER_ID_Adv(Params_Get_Team_member_By_OWNER_ID i_Params_Get_Team_member_By_OWNER_ID)
{
List<Team_member> oList = new List<Team_member>();
Team_member oTeam_member = new Team_member();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Team_member_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Team_member> oList_DBEntries = _AppContext.Get_Team_member_By_OWNER_ID_Adv(i_Params_Get_Team_member_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Team_member_By_OWNER_ID_Adv");}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID_Adv(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID_Adv");}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME_Adv(i_Params_Get_User_By_USERNAME.USERNAME);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME_Adv");}
return oList;
}
public List<News> Get_News_By_Criteria_Adv(Params_Get_News_By_Criteria i_Params_Get_News_By_Criteria)
{
List<News> oList = new List<News>();
long? tmp_TOTAL_COUNT = 0;
News oNews = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_News_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_News_By_Criteria.OWNER_ID == null) || (i_Params_Get_News_By_Criteria.OWNER_ID == 0)) { i_Params_Get_News_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_News_By_Criteria.START_ROW == null) { i_Params_Get_News_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_News_By_Criteria.END_ROW == null) || (i_Params_Get_News_By_Criteria.END_ROW == 0)) { i_Params_Get_News_By_Criteria.END_ROW = 1000000; }
List<DALC.News> oList_DBEntries = _AppContext.Get_News_By_Criteria_Adv(i_Params_Get_News_By_Criteria.TITLE,i_Params_Get_News_By_Criteria.DESCRIPTION,i_Params_Get_News_By_Criteria.OWNER_ID,i_Params_Get_News_By_Criteria.START_ROW,i_Params_Get_News_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_News_By_Criteria_Adv");}
return oList;
}
public List<News> Get_News_By_Where_Adv(Params_Get_News_By_Where i_Params_Get_News_By_Where)
{
List<News> oList = new List<News>();
long? tmp_TOTAL_COUNT = 0;
News oNews = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_News_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_News_By_Where.OWNER_ID == null) || (i_Params_Get_News_By_Where.OWNER_ID == 0)) { i_Params_Get_News_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_News_By_Where.START_ROW == null) { i_Params_Get_News_By_Where.START_ROW = 0; }
if ((i_Params_Get_News_By_Where.END_ROW == null) || (i_Params_Get_News_By_Where.END_ROW == 0)) { i_Params_Get_News_By_Where.END_ROW = 1000000; }
List<DALC.News> oList_DBEntries = _AppContext.Get_News_By_Where_Adv(i_Params_Get_News_By_Where.TITLE,i_Params_Get_News_By_Where.DESCRIPTION,i_Params_Get_News_By_Where.OWNER_ID,i_Params_Get_News_By_Where.START_ROW,i_Params_Get_News_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_News_By_Where_Adv");}
return oList;
}
public List<Section> Get_Section_By_Criteria_Adv(Params_Get_Section_By_Criteria i_Params_Get_Section_By_Criteria)
{
List<Section> oList = new List<Section>();
long? tmp_TOTAL_COUNT = 0;
Section oSection = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Section_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Section_By_Criteria.OWNER_ID == null) || (i_Params_Get_Section_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Section_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Section_By_Criteria.START_ROW == null) { i_Params_Get_Section_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Section_By_Criteria.END_ROW == null) || (i_Params_Get_Section_By_Criteria.END_ROW == 0)) { i_Params_Get_Section_By_Criteria.END_ROW = 1000000; }
List<DALC.Section> oList_DBEntries = _AppContext.Get_Section_By_Criteria_Adv(i_Params_Get_Section_By_Criteria.SECTION_NAME,i_Params_Get_Section_By_Criteria.OWNER_ID,i_Params_Get_Section_By_Criteria.START_ROW,i_Params_Get_Section_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Section_By_Criteria_Adv");}
return oList;
}
public List<Section> Get_Section_By_Where_Adv(Params_Get_Section_By_Where i_Params_Get_Section_By_Where)
{
List<Section> oList = new List<Section>();
long? tmp_TOTAL_COUNT = 0;
Section oSection = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Section_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Section_By_Where.OWNER_ID == null) || (i_Params_Get_Section_By_Where.OWNER_ID == 0)) { i_Params_Get_Section_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Section_By_Where.START_ROW == null) { i_Params_Get_Section_By_Where.START_ROW = 0; }
if ((i_Params_Get_Section_By_Where.END_ROW == null) || (i_Params_Get_Section_By_Where.END_ROW == 0)) { i_Params_Get_Section_By_Where.END_ROW = 1000000; }
List<DALC.Section> oList_DBEntries = _AppContext.Get_Section_By_Where_Adv(i_Params_Get_Section_By_Where.SECTION_NAME,i_Params_Get_Section_By_Where.OWNER_ID,i_Params_Get_Section_By_Where.START_ROW,i_Params_Get_Section_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Section_By_Where_Adv");}
return oList;
}
public List<Team_member> Get_Team_member_By_Criteria_Adv(Params_Get_Team_member_By_Criteria i_Params_Get_Team_member_By_Criteria)
{
List<Team_member> oList = new List<Team_member>();
long? tmp_TOTAL_COUNT = 0;
Team_member oTeam_member = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Team_member_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Team_member_By_Criteria.OWNER_ID == null) || (i_Params_Get_Team_member_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Team_member_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Team_member_By_Criteria.START_ROW == null) { i_Params_Get_Team_member_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Team_member_By_Criteria.END_ROW == null) || (i_Params_Get_Team_member_By_Criteria.END_ROW == 0)) { i_Params_Get_Team_member_By_Criteria.END_ROW = 1000000; }
List<DALC.Team_member> oList_DBEntries = _AppContext.Get_Team_member_By_Criteria_Adv(i_Params_Get_Team_member_By_Criteria.MEMBER_NAME,i_Params_Get_Team_member_By_Criteria.POSITION,i_Params_Get_Team_member_By_Criteria.MAJOR,i_Params_Get_Team_member_By_Criteria.OWNER_ID,i_Params_Get_Team_member_By_Criteria.START_ROW,i_Params_Get_Team_member_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Team_member_By_Criteria_Adv");}
return oList;
}
public List<Team_member> Get_Team_member_By_Where_Adv(Params_Get_Team_member_By_Where i_Params_Get_Team_member_By_Where)
{
List<Team_member> oList = new List<Team_member>();
long? tmp_TOTAL_COUNT = 0;
Team_member oTeam_member = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Team_member_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Team_member_By_Where.OWNER_ID == null) || (i_Params_Get_Team_member_By_Where.OWNER_ID == 0)) { i_Params_Get_Team_member_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Team_member_By_Where.START_ROW == null) { i_Params_Get_Team_member_By_Where.START_ROW = 0; }
if ((i_Params_Get_Team_member_By_Where.END_ROW == null) || (i_Params_Get_Team_member_By_Where.END_ROW == 0)) { i_Params_Get_Team_member_By_Where.END_ROW = 1000000; }
List<DALC.Team_member> oList_DBEntries = _AppContext.Get_Team_member_By_Where_Adv(i_Params_Get_Team_member_By_Where.MEMBER_NAME,i_Params_Get_Team_member_By_Where.POSITION,i_Params_Get_Team_member_By_Where.MAJOR,i_Params_Get_Team_member_By_Where.OWNER_ID,i_Params_Get_Team_member_By_Where.START_ROW,i_Params_Get_Team_member_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Team_member_By_Where_Adv");}
return oList;
}
public List<User> Get_User_By_Criteria_Adv(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria_Adv(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.FULLNAME,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria_Adv");}
return oList;
}
public List<User> Get_User_By_Where_Adv(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where_Adv(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.FULLNAME,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where_Adv");}
return oList;
}
}
}
