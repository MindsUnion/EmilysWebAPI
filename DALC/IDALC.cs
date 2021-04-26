using System;
using System.Collections.Generic;
namespace DALC
{
#region Repositories
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
public News My_News {get;set;}
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
#endregion 
public partial interface IDALC
{
News Get_News_By_NEWS_ID ( Int32? NEWS_ID);
News_source Get_News_source_By_NEWS_SOURCE_ID ( Int32? NEWS_SOURCE_ID);
Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID);
Section Get_Section_By_SECTION_ID ( Int32? SECTION_ID);
Team_member Get_Team_member_By_TEAM_MEMBER_ID ( Int32? TEAM_MEMBER_ID);
Uploaded_file Get_Uploaded_file_By_UPLOADED_FILE_ID ( long? UPLOADED_FILE_ID);
User Get_User_By_USER_ID ( long? USER_ID);
News Get_News_By_NEWS_ID_Adv ( Int32? NEWS_ID);
News_source Get_News_source_By_NEWS_SOURCE_ID_Adv ( Int32? NEWS_SOURCE_ID);
Section Get_Section_By_SECTION_ID_Adv ( Int32? SECTION_ID);
Team_member Get_Team_member_By_TEAM_MEMBER_ID_Adv ( Int32? TEAM_MEMBER_ID);
User Get_User_By_USER_ID_Adv ( long? USER_ID);
List<News> Get_News_By_NEWS_ID_List ( List<Int32?> NEWS_ID_LIST);
List<News_source> Get_News_source_By_NEWS_SOURCE_ID_List ( List<Int32?> NEWS_SOURCE_ID_LIST);
List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST);
List<Section> Get_Section_By_SECTION_ID_List ( List<Int32?> SECTION_ID_LIST);
List<Team_member> Get_Team_member_By_TEAM_MEMBER_ID_List ( List<Int32?> TEAM_MEMBER_ID_LIST);
List<Uploaded_file> Get_Uploaded_file_By_UPLOADED_FILE_ID_List ( List<long?> UPLOADED_FILE_ID_LIST);
List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST);
List<News> Get_News_By_NEWS_ID_List_Adv ( List<Int32?> NEWS_ID_LIST);
List<News_source> Get_News_source_By_NEWS_SOURCE_ID_List_Adv ( List<Int32?> NEWS_SOURCE_ID_LIST);
List<Section> Get_Section_By_SECTION_ID_List_Adv ( List<Int32?> SECTION_ID_LIST);
List<Team_member> Get_Team_member_By_TEAM_MEMBER_ID_List_Adv ( List<Int32?> TEAM_MEMBER_ID_LIST);
List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST);
List<News> Get_News_By_OWNER_ID ( Int32? OWNER_ID);
List<News_source> Get_News_source_By_OWNER_ID ( Int32? OWNER_ID);
List<News_source> Get_News_source_By_NEWS_ID ( Int32? NEWS_ID);
List<Section> Get_Section_By_OWNER_ID ( Int32? OWNER_ID);
List<Team_member> Get_Team_member_By_OWNER_ID ( Int32? OWNER_ID);
List<Team_member> Get_Team_member_By_EMAIL ( string EMAIL);
List<Uploaded_file> Get_Uploaded_file_By_OWNER_ID ( Int32? OWNER_ID);
List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY ( string REL_ENTITY);
List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY ( string REL_ENTITY, long? REL_KEY);
List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD ( string REL_ENTITY, long? REL_KEY, string REL_FIELD);
List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME ( string USERNAME);
List<News> Get_News_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<News_source> Get_News_source_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<News_source> Get_News_source_By_NEWS_ID_Adv ( Int32? NEWS_ID);
List<Section> Get_Section_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Team_member> Get_Team_member_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Team_member> Get_Team_member_By_EMAIL_Adv ( string EMAIL);
List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME_Adv ( string USERNAME);
List<News_source> Get_News_source_By_NEWS_ID_List ( List<Int32?> NEWS_ID_LIST);
List<News_source> Get_News_source_By_NEWS_ID_List_Adv ( List<Int32?> NEWS_ID_LIST);
List<News> Get_News_By_Criteria ( string TITLE, string SUBTITLE, string DESCRIPTION, string IMG_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<News> Get_News_By_Where ( string TITLE, string SUBTITLE, string DESCRIPTION, string IMG_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<News_source> Get_News_source_By_Criteria ( string NEWS_SOURCE_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<News_source> Get_News_source_By_Where ( string NEWS_SOURCE_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Section> Get_Section_By_Criteria ( string SECTION_NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Section> Get_Section_By_Where ( string SECTION_NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Team_member> Get_Team_member_By_Criteria ( string MEMBER_NAME, string FULLNAME, string EMAIL, string PASSWORD, string POSITION, string MAJOR, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Team_member> Get_Team_member_By_Where ( string MEMBER_NAME, string FULLNAME, string EMAIL, string PASSWORD, string POSITION, string MAJOR, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Uploaded_file> Get_Uploaded_file_By_Criteria ( string REL_ENTITY, string REL_FIELD, string EXTENSION, string STAMP, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Uploaded_file> Get_Uploaded_file_By_Where ( string REL_ENTITY, string REL_FIELD, string EXTENSION, string STAMP, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string FULLNAME, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string FULLNAME, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<News> Get_News_By_Criteria_Adv ( string TITLE, string SUBTITLE, string DESCRIPTION, string IMG_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<News> Get_News_By_Where_Adv ( string TITLE, string SUBTITLE, string DESCRIPTION, string IMG_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<News_source> Get_News_source_By_Criteria_Adv ( string NEWS_SOURCE_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<News_source> Get_News_source_By_Where_Adv ( string NEWS_SOURCE_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Section> Get_Section_By_Criteria_Adv ( string SECTION_NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Section> Get_Section_By_Where_Adv ( string SECTION_NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Team_member> Get_Team_member_By_Criteria_Adv ( string MEMBER_NAME, string FULLNAME, string EMAIL, string PASSWORD, string POSITION, string MAJOR, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Team_member> Get_Team_member_By_Where_Adv ( string MEMBER_NAME, string FULLNAME, string EMAIL, string PASSWORD, string POSITION, string MAJOR, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string FULLNAME, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string FULLNAME, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<News_source> Get_News_source_By_Criteria_InList ( string NEWS_SOURCE_NAME, List<Int32?> NEWS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<News_source> Get_News_source_By_Where_InList ( string NEWS_SOURCE_NAME, List<Int32?> NEWS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<News_source> Get_News_source_By_Criteria_InList_Adv ( string NEWS_SOURCE_NAME, List<Int32?> NEWS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<News_source> Get_News_source_By_Where_InList_Adv ( string NEWS_SOURCE_NAME, List<Int32?> NEWS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
void Delete_News ( Int32? NEWS_ID);
void Delete_News_source ( Int32? NEWS_SOURCE_ID);
void Delete_Owner ( Int32? OWNER_ID);
void Delete_Section ( Int32? SECTION_ID);
void Delete_Team_member ( Int32? TEAM_MEMBER_ID);
void Delete_Uploaded_file ( long? UPLOADED_FILE_ID);
void Delete_User ( long? USER_ID);
void Delete_News_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_News_source_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_News_source_By_NEWS_ID ( Int32? NEWS_ID);
void Delete_Section_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Team_member_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Team_member_By_EMAIL ( string EMAIL);
void Delete_Uploaded_file_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Uploaded_file_By_REL_ENTITY ( string REL_ENTITY);
void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY ( string REL_ENTITY, long? REL_KEY);
void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD ( string REL_ENTITY, long? REL_KEY, string REL_FIELD);
void Delete_User_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_User_By_USERNAME ( string USERNAME);
Int32? Edit_News ( Int32? NEWS_ID, string TITLE, string SUBTITLE, string DESCRIPTION, string IMG_NAME, bool? IS_DISPLAYABLE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_News_source ( Int32? NEWS_SOURCE_ID, string NEWS_SOURCE_NAME, Int32? NEWS_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE);
Int32? Edit_Section ( Int32? SECTION_ID, string SECTION_NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Team_member ( Int32? TEAM_MEMBER_ID, string MEMBER_NAME, string FULLNAME, string EMAIL, string PASSWORD, string POSITION, string MAJOR, string DESCRIPTION, bool? ADMIN, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Uploaded_file ( long? UPLOADED_FILE_ID, string REL_ENTITY, long? REL_KEY, string REL_FIELD, Int32? SIZE, string EXTENSION, string STAMP, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string FULLNAME, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE);
List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID);
List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE);
List<dynamic> GET_TBL_SETUP ();
List<dynamic> UP_BULK_UPSERT_NEWS ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_NEWS_SOURCE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_SECTION ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_TEAM_MEMBER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_UPLOADED_FILE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT);
List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS);
List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES);
List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME);
List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME);
List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName);
List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE);
List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE);
List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME);
List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD);
}
}
