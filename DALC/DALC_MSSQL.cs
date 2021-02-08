using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Dynamic;
namespace DALC
{
public partial class MSSQL_DALC : IDALC
{
public News Get_News_By_NEWS_ID ( Int32? NEWS_ID)
{
News o = new News();
dynamic p = new ExpandoObject();
p.NEWS_ID = NEWS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_NEWS_BY_NEWS_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID)
{
Owner o = new Owner();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Section Get_Section_By_SECTION_ID ( Int32? SECTION_ID)
{
Section o = new Section();
dynamic p = new ExpandoObject();
p.SECTION_ID = SECTION_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SECTION_BY_SECTION_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Team_member Get_Team_member_By_TEAM_MEMBER_ID ( Int32? TEAM_MEMBER_ID)
{
Team_member o = new Team_member();
dynamic p = new ExpandoObject();
p.TEAM_MEMBER_ID = TEAM_MEMBER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TEAM_MEMBER_BY_TEAM_MEMBER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Uploaded_file Get_Uploaded_file_By_UPLOADED_FILE_ID ( long? UPLOADED_FILE_ID)
{
Uploaded_file o = new Uploaded_file();
dynamic p = new ExpandoObject();
p.UPLOADED_FILE_ID = UPLOADED_FILE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_UPLOADED_FILE_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public User Get_User_By_USER_ID ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public News Get_News_By_NEWS_ID_Adv ( Int32? NEWS_ID)
{
News o = new News();
dynamic p = new ExpandoObject();
p.NEWS_ID = NEWS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_NEWS_BY_NEWS_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Section Get_Section_By_SECTION_ID_Adv ( Int32? SECTION_ID)
{
Section o = new Section();
dynamic p = new ExpandoObject();
p.SECTION_ID = SECTION_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SECTION_BY_SECTION_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Team_member Get_Team_member_By_TEAM_MEMBER_ID_Adv ( Int32? TEAM_MEMBER_ID)
{
Team_member o = new Team_member();
dynamic p = new ExpandoObject();
p.TEAM_MEMBER_ID = TEAM_MEMBER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TEAM_MEMBER_BY_TEAM_MEMBER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public User Get_User_By_USER_ID_Adv ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public List<News> Get_News_By_NEWS_ID_List ( List<Int32?> NEWS_ID_LIST)
{
List<News> oList = new List<News>();
dynamic p = new ExpandoObject();
p.NEWS_ID_LIST = string.Join(",", NEWS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_NEWS_BY_NEWS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
News o = new News();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.OWNER_ID_LIST = string.Join(",", OWNER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Section> Get_Section_By_SECTION_ID_List ( List<Int32?> SECTION_ID_LIST)
{
List<Section> oList = new List<Section>();
dynamic p = new ExpandoObject();
p.SECTION_ID_LIST = string.Join(",", SECTION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SECTION_BY_SECTION_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Section o = new Section();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Team_member> Get_Team_member_By_TEAM_MEMBER_ID_List ( List<Int32?> TEAM_MEMBER_ID_LIST)
{
List<Team_member> oList = new List<Team_member>();
dynamic p = new ExpandoObject();
p.TEAM_MEMBER_ID_LIST = string.Join(",", TEAM_MEMBER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEAM_MEMBER_BY_TEAM_MEMBER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Team_member o = new Team_member();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_UPLOADED_FILE_ID_List ( List<long?> UPLOADED_FILE_ID_LIST)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.UPLOADED_FILE_ID_LIST = string.Join(",", UPLOADED_FILE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_UPLOADED_FILE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<News> Get_News_By_NEWS_ID_List_Adv ( List<Int32?> NEWS_ID_LIST)
{
List<News> oList = new List<News>();
dynamic p = new ExpandoObject();
p.NEWS_ID_LIST = string.Join(",", NEWS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_NEWS_BY_NEWS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
News o = new News();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Section> Get_Section_By_SECTION_ID_List_Adv ( List<Int32?> SECTION_ID_LIST)
{
List<Section> oList = new List<Section>();
dynamic p = new ExpandoObject();
p.SECTION_ID_LIST = string.Join(",", SECTION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SECTION_BY_SECTION_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Section o = new Section();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Team_member> Get_Team_member_By_TEAM_MEMBER_ID_List_Adv ( List<Int32?> TEAM_MEMBER_ID_LIST)
{
List<Team_member> oList = new List<Team_member>();
dynamic p = new ExpandoObject();
p.TEAM_MEMBER_ID_LIST = string.Join(",", TEAM_MEMBER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEAM_MEMBER_BY_TEAM_MEMBER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Team_member o = new Team_member();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<News> Get_News_By_OWNER_ID ( Int32? OWNER_ID)
{
List<News> oList = new List<News>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_NEWS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
News o = new News();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Section> Get_Section_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Section> oList = new List<Section>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SECTION_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Section o = new Section();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Team_member> Get_Team_member_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Team_member> oList = new List<Team_member>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEAM_MEMBER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Team_member o = new Team_member();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY ( string REL_ENTITY)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.REL_ENTITY = REL_ENTITY;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_REL_ENTITY", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY ( string REL_ENTITY, long? REL_KEY)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.REL_ENTITY = REL_ENTITY; p.REL_KEY = REL_KEY;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_REL_ENTITY_REL_KEY", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD ( string REL_ENTITY, long? REL_KEY, string REL_FIELD)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.REL_ENTITY = REL_ENTITY; p.REL_KEY = REL_KEY; p.REL_FIELD = REL_FIELD;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_REL_ENTITY_REL_KEY_REL_FIELD", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<News> Get_News_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<News> oList = new List<News>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_NEWS_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
News o = new News();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Section> Get_Section_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Section> oList = new List<Section>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SECTION_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Section o = new Section();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Team_member> Get_Team_member_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Team_member> oList = new List<Team_member>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEAM_MEMBER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Team_member o = new Team_member();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<News> Get_News_By_Criteria ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<News> oList = new List<News>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_NEWS_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
News o = new News();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<News> Get_News_By_Where ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<News> oList = new List<News>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_NEWS_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
News o = new News();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Section> Get_Section_By_Criteria ( string SECTION_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Section> oList = new List<Section>();
dynamic p = new ExpandoObject();
p.SECTION_NAME = SECTION_NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SECTION_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Section o = new Section();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Section> Get_Section_By_Where ( string SECTION_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Section> oList = new List<Section>();
dynamic p = new ExpandoObject();
p.SECTION_NAME = SECTION_NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SECTION_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Section o = new Section();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Team_member> Get_Team_member_By_Criteria ( string MEMBER_NAME, string POSITION, string MAJOR, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Team_member> oList = new List<Team_member>();
dynamic p = new ExpandoObject();
p.MEMBER_NAME = MEMBER_NAME; p.POSITION = POSITION; p.MAJOR = MAJOR; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEAM_MEMBER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Team_member o = new Team_member();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Team_member> Get_Team_member_By_Where ( string MEMBER_NAME, string POSITION, string MAJOR, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Team_member> oList = new List<Team_member>();
dynamic p = new ExpandoObject();
p.MEMBER_NAME = MEMBER_NAME; p.POSITION = POSITION; p.MAJOR = MAJOR; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEAM_MEMBER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Team_member o = new Team_member();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_Criteria ( string REL_ENTITY, string REL_FIELD, string EXTENSION, string STAMP, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.REL_ENTITY = REL_ENTITY; p.REL_FIELD = REL_FIELD; p.EXTENSION = EXTENSION; p.STAMP = STAMP; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_Where ( string REL_ENTITY, string REL_FIELD, string EXTENSION, string STAMP, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.REL_ENTITY = REL_ENTITY; p.REL_FIELD = REL_FIELD; p.EXTENSION = EXTENSION; p.STAMP = STAMP; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string FULLNAME, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.FULLNAME = FULLNAME; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string FULLNAME, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.FULLNAME = FULLNAME; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<News> Get_News_By_Criteria_Adv ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<News> oList = new List<News>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_NEWS_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
News o = new News();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<News> Get_News_By_Where_Adv ( string TITLE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<News> oList = new List<News>();
dynamic p = new ExpandoObject();
p.TITLE = TITLE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_NEWS_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
News o = new News();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Section> Get_Section_By_Criteria_Adv ( string SECTION_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Section> oList = new List<Section>();
dynamic p = new ExpandoObject();
p.SECTION_NAME = SECTION_NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SECTION_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Section o = new Section();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Section> Get_Section_By_Where_Adv ( string SECTION_NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Section> oList = new List<Section>();
dynamic p = new ExpandoObject();
p.SECTION_NAME = SECTION_NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SECTION_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Section o = new Section();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Team_member> Get_Team_member_By_Criteria_Adv ( string MEMBER_NAME, string POSITION, string MAJOR, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Team_member> oList = new List<Team_member>();
dynamic p = new ExpandoObject();
p.MEMBER_NAME = MEMBER_NAME; p.POSITION = POSITION; p.MAJOR = MAJOR; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEAM_MEMBER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Team_member o = new Team_member();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Team_member> Get_Team_member_By_Where_Adv ( string MEMBER_NAME, string POSITION, string MAJOR, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Team_member> oList = new List<Team_member>();
dynamic p = new ExpandoObject();
p.MEMBER_NAME = MEMBER_NAME; p.POSITION = POSITION; p.MAJOR = MAJOR; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TEAM_MEMBER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Team_member o = new Team_member();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string FULLNAME, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.FULLNAME = FULLNAME; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string FULLNAME, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.FULLNAME = FULLNAME; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public void Delete_News ( Int32? NEWS_ID)
{
var p = new { NEWS_ID = NEWS_ID };
ExecuteDelete("UPG_DELETE_NEWS", p);
}
public void Delete_Owner ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_OWNER", p);
}
public void Delete_Section ( Int32? SECTION_ID)
{
var p = new { SECTION_ID = SECTION_ID };
ExecuteDelete("UPG_DELETE_SECTION", p);
}
public void Delete_Team_member ( Int32? TEAM_MEMBER_ID)
{
var p = new { TEAM_MEMBER_ID = TEAM_MEMBER_ID };
ExecuteDelete("UPG_DELETE_TEAM_MEMBER", p);
}
public void Delete_Uploaded_file ( long? UPLOADED_FILE_ID)
{
var p = new { UPLOADED_FILE_ID = UPLOADED_FILE_ID };
ExecuteDelete("UPG_DELETE_UPLOADED_FILE", p);
}
public void Delete_User ( long? USER_ID)
{
var p = new { USER_ID = USER_ID };
ExecuteDelete("UPG_DELETE_USER", p);
}
public void Delete_News_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_NEWS_BY_OWNER_ID", p);
}
public void Delete_Section_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_SECTION_BY_OWNER_ID", p);
}
public void Delete_Team_member_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_TEAM_MEMBER_BY_OWNER_ID", p);
}
public void Delete_Uploaded_file_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_UPLOADED_FILE_BY_OWNER_ID", p);
}
public void Delete_Uploaded_file_By_REL_ENTITY ( string REL_ENTITY)
{
var p = new { REL_ENTITY = REL_ENTITY };
ExecuteDelete("UPG_DELETE_UPLOADED_FILE_BY_REL_ENTITY", p);
}
public void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY ( string REL_ENTITY, long? REL_KEY)
{
var p = new { REL_ENTITY = REL_ENTITY,REL_KEY = REL_KEY };
ExecuteDelete("UPG_DELETE_UPLOADED_FILE_BY_REL_ENTITY_REL_KEY", p);
}
public void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD ( string REL_ENTITY, long? REL_KEY, string REL_FIELD)
{
var p = new { REL_ENTITY = REL_ENTITY,REL_KEY = REL_KEY,REL_FIELD = REL_FIELD };
ExecuteDelete("UPG_DELETE_UPLOADED_FILE_BY_REL_ENTITY_REL_KEY_REL_FIELD", p);
}
public void Delete_User_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_USER_BY_OWNER_ID", p);
}
public void Delete_User_By_USERNAME ( string USERNAME)
{
var p = new { USERNAME = USERNAME };
ExecuteDelete("UPG_DELETE_USER_BY_USERNAME", p);
}
public Int32? Edit_News ( Int32? NEWS_ID, string TITLE, string DESCRIPTION, bool? IS_DISPLAYABLE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
News oNews = new News();
oNews.NEWS_ID = NEWS_ID;oNews.TITLE = TITLE;oNews.DESCRIPTION = DESCRIPTION;oNews.IS_DISPLAYABLE = IS_DISPLAYABLE;oNews.ENTRY_USER_ID = ENTRY_USER_ID;oNews.ENTRY_DATE = ENTRY_DATE;oNews.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_NEWS", oNews, "NEWS_ID");
return oNews.NEWS_ID;
}
public Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE)
{
Owner oOwner = new Owner();
oOwner.OWNER_ID = OWNER_ID;oOwner.CODE = CODE;oOwner.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE;oOwner.DESCRIPTION = DESCRIPTION;oOwner.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_OWNER", oOwner, "OWNER_ID");
return oOwner.OWNER_ID;
}
public Int32? Edit_Section ( Int32? SECTION_ID, string SECTION_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Section oSection = new Section();
oSection.SECTION_ID = SECTION_ID;oSection.SECTION_NAME = SECTION_NAME;oSection.ENTRY_USER_ID = ENTRY_USER_ID;oSection.ENTRY_DATE = ENTRY_DATE;oSection.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_SECTION", oSection, "SECTION_ID");
return oSection.SECTION_ID;
}
public Int32? Edit_Team_member ( Int32? TEAM_MEMBER_ID, string MEMBER_NAME, string POSITION, string MAJOR, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Team_member oTeam_member = new Team_member();
oTeam_member.TEAM_MEMBER_ID = TEAM_MEMBER_ID;oTeam_member.MEMBER_NAME = MEMBER_NAME;oTeam_member.POSITION = POSITION;oTeam_member.MAJOR = MAJOR;oTeam_member.ENTRY_USER_ID = ENTRY_USER_ID;oTeam_member.ENTRY_DATE = ENTRY_DATE;oTeam_member.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_TEAM_MEMBER", oTeam_member, "TEAM_MEMBER_ID");
return oTeam_member.TEAM_MEMBER_ID;
}
public long? Edit_Uploaded_file ( long? UPLOADED_FILE_ID, string REL_ENTITY, long? REL_KEY, string REL_FIELD, Int32? SIZE, string EXTENSION, string STAMP, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Uploaded_file oUploaded_file = new Uploaded_file();
oUploaded_file.UPLOADED_FILE_ID = UPLOADED_FILE_ID;oUploaded_file.REL_ENTITY = REL_ENTITY;oUploaded_file.REL_KEY = REL_KEY;oUploaded_file.REL_FIELD = REL_FIELD;oUploaded_file.SIZE = SIZE;oUploaded_file.EXTENSION = EXTENSION;oUploaded_file.STAMP = STAMP;oUploaded_file.ENTRY_USER_ID = ENTRY_USER_ID;oUploaded_file.ENTRY_DATE = ENTRY_DATE;oUploaded_file.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_UPLOADED_FILE", oUploaded_file, "UPLOADED_FILE_ID");
return oUploaded_file.UPLOADED_FILE_ID;
}
public long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string FULLNAME, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE)
{
User oUser = new User();
oUser.USER_ID = USER_ID;oUser.OWNER_ID = OWNER_ID;oUser.USERNAME = USERNAME;oUser.PASSWORD = PASSWORD;oUser.FULLNAME = FULLNAME;oUser.USER_TYPE_CODE = USER_TYPE_CODE;oUser.IS_ACTIVE = IS_ACTIVE;oUser.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_USER", oUser, "USER_ID");
return oUser.USER_ID;
}
public List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_DISTINCT_SETUP_TBL", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.TBL_NAME = GV<String>(X["TBL_NAME"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LAST_VALUE = GV<Int64>(X["LAST_VALUE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_TBL_SETUP ()
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_TBL_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.EXISTS = EXISTS;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_CHECK_USER_EXISTENCE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
EXISTS = p.EXISTS;
return oList;
}
public List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME; p.ISSYSTEM = ISSYSTEM; p.ISDELETEABLE = ISDELETEABLE; p.ISUPDATEABLE = ISUPDATEABLE; p.ISVISIBLE = ISVISIBLE; p.ISDELETED = ISDELETED; p.DISPLAY_ORDER = DISPLAY_ORDER; p.CODE_VALUE_EN = CODE_VALUE_EN; p.CODE_VALUE_FR = CODE_VALUE_FR; p.CODE_VALUE_AR = CODE_VALUE_AR; p.ENTRY_DATE = ENTRY_DATE; p.ENTRY_USER_ID = ENTRY_USER_ID; p.NOTES = NOTES;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EDIT_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_PARAMETERS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.PARAM_NAME = GV<String>(X["PARAM_NAME"]);o.PARAM_TYPE = GV<String>(X["PARAM_TYPE"]);o.IS_OUTPUT = GV<Boolean>(X["IS_OUTPUT"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_RESULT_SCHEMA", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.COLUMN_NAME = GV<String>(X["COLUMN_NAME"]);o.COLUMN_TYPE = GV<String>(X["COLUMN_TYPE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.@tableName = @tableName;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GENERATE_INSERT_STATEMENTS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE; p.VALUE = VALUE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
VALUE = p.VALUE;
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.ISDELETED = ISDELETED; p.ISVISIBLE = ISVISIBLE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRIES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_USER_BY_CREDENTIALS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
}
}
