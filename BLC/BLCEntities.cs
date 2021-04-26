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
#region Params_Get_News_By_NEWS_ID
public partial class Params_Get_News_By_NEWS_ID
{
#region Properties
public Int32? NEWS_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_News_source_By_NEWS_SOURCE_ID
public partial class Params_Get_News_source_By_NEWS_SOURCE_ID
{
#region Properties
public Int32? NEWS_SOURCE_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Owner_By_OWNER_ID
public partial class Params_Get_Owner_By_OWNER_ID
{
#region Properties
public Int32? OWNER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Section_By_SECTION_ID
public partial class Params_Get_Section_By_SECTION_ID
{
#region Properties
public Int32? SECTION_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Team_member_By_TEAM_MEMBER_ID
public partial class Params_Get_Team_member_By_TEAM_MEMBER_ID
{
#region Properties
public Int32? TEAM_MEMBER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Uploaded_file_By_UPLOADED_FILE_ID
public partial class Params_Get_Uploaded_file_By_UPLOADED_FILE_ID
{
#region Properties
public long? UPLOADED_FILE_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_User_By_USER_ID
public partial class Params_Get_User_By_USER_ID
{
#region Properties
public long? USER_ID {get;set;}

#endregion
}
#endregion
public partial class Params_Get_News_By_NEWS_ID_List
{
public List<Int32?> NEWS_ID_LIST {get;set;}
}
public partial class Params_Get_News_By_NEWS_ID_List_SP
{
public string NEWS_ID_LIST {get;set;}

}
public partial class Params_Get_News_source_By_NEWS_SOURCE_ID_List
{
public List<Int32?> NEWS_SOURCE_ID_LIST {get;set;}
}
public partial class Params_Get_News_source_By_NEWS_SOURCE_ID_List_SP
{
public string NEWS_SOURCE_ID_LIST {get;set;}

}
public partial class Params_Get_Owner_By_OWNER_ID_List
{
public List<Int32?> OWNER_ID_LIST {get;set;}
}
public partial class Params_Get_Owner_By_OWNER_ID_List_SP
{
public string OWNER_ID_LIST {get;set;}

}
public partial class Params_Get_Section_By_SECTION_ID_List
{
public List<Int32?> SECTION_ID_LIST {get;set;}
}
public partial class Params_Get_Section_By_SECTION_ID_List_SP
{
public string SECTION_ID_LIST {get;set;}

}
public partial class Params_Get_Team_member_By_TEAM_MEMBER_ID_List
{
public List<Int32?> TEAM_MEMBER_ID_LIST {get;set;}
}
public partial class Params_Get_Team_member_By_TEAM_MEMBER_ID_List_SP
{
public string TEAM_MEMBER_ID_LIST {get;set;}

}
public partial class Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List
{
public List<long?> UPLOADED_FILE_ID_LIST {get;set;}
}
public partial class Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP
{
public string UPLOADED_FILE_ID_LIST {get;set;}

}
public partial class Params_Get_User_By_USER_ID_List
{
public List<long?> USER_ID_LIST {get;set;}
}
public partial class Params_Get_User_By_USER_ID_List_SP
{
public string USER_ID_LIST {get;set;}

}
public partial class Params_Get_News_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_News_source_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_News_source_By_NEWS_ID
{
public Int32? NEWS_ID {get;set;}

}
public partial class Params_Get_Section_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Team_member_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Team_member_By_EMAIL
{
public string EMAIL {get;set;}

}
public partial class Params_Get_Uploaded_file_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Uploaded_file_By_REL_ENTITY
{
public string REL_ENTITY {get;set;}

}
public partial class Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}

}
public partial class Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
public string REL_FIELD {get;set;}

}
public partial class Params_Get_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_User_By_USERNAME
{
public string USERNAME {get;set;}

}
public partial class Params_Get_News_source_By_NEWS_ID_List
{
public List<Int32?> NEWS_ID_LIST {get;set;}

}
public partial class Params_Get_News_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string SUBTITLE {get;set;}
public string DESCRIPTION {get;set;}
public string IMG_NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_News_By_Where
{

public Int32? OWNER_ID {get;set;}
public string TITLE {get;set;}
public string SUBTITLE {get;set;}
public string DESCRIPTION {get;set;}
public string IMG_NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_News_source_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NEWS_SOURCE_NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_News_source_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NEWS_SOURCE_NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Section_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string SECTION_NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Section_By_Where
{

public Int32? OWNER_ID {get;set;}
public string SECTION_NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Team_member_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string MEMBER_NAME {get;set;}
public string FULLNAME {get;set;}
public string EMAIL {get;set;}
public string PASSWORD {get;set;}
public string POSITION {get;set;}
public string MAJOR {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Team_member_By_Where
{

public Int32? OWNER_ID {get;set;}
public string MEMBER_NAME {get;set;}
public string FULLNAME {get;set;}
public string EMAIL {get;set;}
public string PASSWORD {get;set;}
public string POSITION {get;set;}
public string MAJOR {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Uploaded_file_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string REL_ENTITY {get;set;}
public string REL_FIELD {get;set;}
public string EXTENSION {get;set;}
public string STAMP {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Uploaded_file_By_Where
{

public Int32? OWNER_ID {get;set;}
public string REL_ENTITY {get;set;}
public string REL_FIELD {get;set;}
public string EXTENSION {get;set;}
public string STAMP {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string FULLNAME {get;set;}
public string USER_TYPE_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Where
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string FULLNAME {get;set;}
public string USER_TYPE_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_News_source_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string NEWS_SOURCE_NAME {get;set;}
public List<Int32?> NEWS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_News_source_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string NEWS_SOURCE_NAME {get;set;}
public string NEWS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_News_source_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string NEWS_SOURCE_NAME {get;set;}
public List<Int32?> NEWS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_News_source_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string NEWS_SOURCE_NAME {get;set;}
public string NEWS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
#region Params_Delete_News
public partial class Params_Delete_News
{
#region Properties
public Int32? NEWS_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_News_source
public partial class Params_Delete_News_source
{
#region Properties
public Int32? NEWS_SOURCE_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Owner
public partial class Params_Delete_Owner
{
#region Properties
public Int32? OWNER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Section
public partial class Params_Delete_Section
{
#region Properties
public Int32? SECTION_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Team_member
public partial class Params_Delete_Team_member
{
#region Properties
public Int32? TEAM_MEMBER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Uploaded_file
public partial class Params_Delete_Uploaded_file
{
#region Properties
public long? UPLOADED_FILE_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_User
public partial class Params_Delete_User
{
#region Properties
public long? USER_ID {get;set;}
#endregion
}
#endregion
public partial class Params_Delete_News_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_News_source_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_News_source_By_NEWS_ID
{
public Int32? NEWS_ID {get;set;}
}
public partial class Params_Delete_Section_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Team_member_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Team_member_By_EMAIL
{
public string EMAIL {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_REL_ENTITY
{
public string REL_ENTITY {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
public string REL_FIELD {get;set;}
}
public partial class Params_Delete_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_User_By_USERNAME
{
public string USERNAME {get;set;}
}
public partial class News
{
public Int32? NEWS_ID {get;set;}
public string TITLE {get;set;}
public string SUBTITLE {get;set;}
public string DESCRIPTION {get;set;}
public string IMG_NAME {get;set;}
public bool? IS_DISPLAYABLE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class News_source
{
public Int32? NEWS_SOURCE_ID {get;set;}
public string NEWS_SOURCE_NAME {get;set;}
public Int32? NEWS_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Owner
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Section
{
public Int32? SECTION_ID {get;set;}
public string SECTION_NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Team_member
{
public Int32? TEAM_MEMBER_ID {get;set;}
public string MEMBER_NAME {get;set;}
public string FULLNAME {get;set;}
public string EMAIL {get;set;}
public string PASSWORD {get;set;}
public string POSITION {get;set;}
public string MAJOR {get;set;}
public string DESCRIPTION {get;set;}
public bool? ADMIN {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Uploaded_file
{
public long? UPLOADED_FILE_ID {get;set;}
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
public string REL_FIELD {get;set;}
public Int32? SIZE {get;set;}
public string EXTENSION {get;set;}
public string STAMP {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class User
{
public long? USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string FULLNAME {get;set;}
public string USER_TYPE_CODE {get;set;}
public bool? IS_ACTIVE {get;set;}
public string ENTRY_DATE {get;set;}
}
#region Params_Edit_News_List
public partial class Params_Edit_News_List
{
#region Properties
public List<News> My_List_To_Edit { get; set; }
public List<News> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_News_source_List
public partial class Params_Edit_News_source_List
{
#region Properties
public List<News_source> My_List_To_Edit { get; set; }
public List<News_source> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Owner_List
public partial class Params_Edit_Owner_List
{
#region Properties
public List<Owner> My_List_To_Edit { get; set; }
public List<Owner> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Section_List
public partial class Params_Edit_Section_List
{
#region Properties
public List<Section> My_List_To_Edit { get; set; }
public List<Section> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Team_member_List
public partial class Params_Edit_Team_member_List
{
#region Properties
public List<Team_member> My_List_To_Edit { get; set; }
public List<Team_member> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Uploaded_file_List
public partial class Params_Edit_Uploaded_file_List
{
#region Properties
public List<Uploaded_file> My_List_To_Edit { get; set; }
public List<Uploaded_file> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_User_List
public partial class Params_Edit_User_List
{
#region Properties
public List<User> My_List_To_Edit { get; set; }
public List<User> My_List_To_Delete { get; set; }
#endregion
}
#endregion
}
