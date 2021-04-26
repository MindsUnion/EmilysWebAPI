using Crypto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace BLC
{
    #region BLC
    public partial class BLC : IDisposable
    {
        #region Enumeration
        public enum Enum_Language
        {
            English = 0,
            French = 1,
            Arabic = 2
        }
        public enum Enum_BR_Codes
        {
            BR_9999,  // Invalid Credentials
            BR_0000,  // Uniqueness Violation                      
            BR_0001   // Password should be at least 4 characters 
        }
        public enum Enum_EditMode
        {
            Add,
            Update
        }
        public enum Enum_Environment
        {
            BHS = 0,
            MS  = 1
        }
        public enum Enum_GradeMode
        {
            Over_One_Hundred = 0,
            Assignment = 1
        }
        #endregion
        #region Members
        private string _ConnectionString = string.Empty;
        DALC.IDALC _AppContext = null;     
        #endregion
        #region Properties
	public Tools.Tools oTools { get; set; }
        public string ConnectionString
        {
            get
            {
                return _ConnectionString;
            }
            set
            {
                _ConnectionString = value;
            }
        }
        public long? UserID { get; set; }
        public Int32? OwnerID { get; set; }
        public Enum_Language Language { get; set; }
        public string Messages_FilePath { get; set; }
        public List<Message> Messages { get; set; }
        public Enum_Environment Environment { get; set; }
        
        #endregion       
        #region Constructor
        public BLC()
        {
            #region Declaration And Initialization Section.
            #endregion
            #region Body Section.
            #endregion
        }
        public BLC(BLCInitializer i_BLCInitializer)
        {
            #region Declaration And Initialization Section.    
            Tools.Tools oTools = new Tools.Tools(); 
            #endregion
            #region Body Section.
            // ---------------------
            ConnectionString = i_BLCInitializer.ConnectionString;
            UserID = i_BLCInitializer.UserID;
            OwnerID = i_BLCInitializer.OwnerID;
            Language = i_BLCInitializer.Language;
            Messages_FilePath = i_BLCInitializer.Messages_FilePath;
            _AppContext = new DALC.MSSQL_DALC(_ConnectionString);
            this.oTools = new Tools.Tools();
            // ---------------------

            // ---------------------
            LoadMessages();
            SubscribeToEvents();
            //Initialize_Audit_Mechanism();
            // ---------------------
                      

            #endregion
        }
        #endregion
        #region Subscribe To Events
        public void SubscribeToEvents()
        {
            #region Declaration And Initialization Section.
            #endregion
            #region Body Section.
            this.OnPostEvent_Get_Section_By_SECTION_ID += BLC_OnPostEvent_Get_Section_By_SECTION_ID;
            this.OnPostEvent_Get_Team_member_By_OWNER_ID += BLC_OnPostEvent_Get_Team_member_By_OWNER_ID;
           this.OnPreEvent_Edit_Team_member += BLC_OnPreEvent_Edit_Team_member;
            this.OnPostEvent_Edit_Section += BLC_OnPostEvent_Edit_Section;
            this.OnPostEvent_Get_Team_member_By_EMAIL += BLC_OnPostEvent_Get_Team_member_By_EMAIL;
            this.OnPostEvent_Get_News_By_Where += BLC_OnPostEvent_Get_News_By_Where;
            Register_Uploaded_Events_Handlers();
            #endregion
        }

        private void BLC_OnPostEvent_Get_News_By_Where(ref List<News> i_Result, Params_Get_News_By_Where i_Params_Get_News_By_Where)
        {
            Params_Get_News_source_By_NEWS_ID newsSource = new Params_Get_News_source_By_NEWS_ID();
            foreach (var item in i_Result)
            {
                newsSource.NEWS_ID = item.NEWS_ID;
                List<News_source> sources = new List<News_source>();
                sources = Get_News_source_By_NEWS_ID(newsSource);
                item.sources = sources;
            }

            Uploaded_file oUploaded_file = new Uploaded_file();
            List<Uploaded_file> oList_Uploaded_files = new List<Uploaded_file>();
            Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY newsImages = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY();
            newsImages.REL_ENTITY = "[TBL_NEWS]";

            string str_WEB_PATH = ConfigurationManager.AppSettings["WEB_PATH"].ToString();
            foreach (var item in i_Result)
            {
                newsImages.REL_KEY = item.NEWS_ID;
                if (i_Result != null)
                {

                    item.My_Uploaded_files = Get_Uploaded_file_By_REL_ENTITY_REL_KEY(newsImages);
                    if (item.My_Uploaded_files != null)
                    {
                        foreach (var oRow_Uploaded_file in item.My_Uploaded_files)
                        {
                            oRow_Uploaded_file.My_URL = string.Format("{0}/Files/Uploaded/{1}.{2}", str_WEB_PATH, oRow_Uploaded_file.UPLOADED_FILE_ID.ToString(), oRow_Uploaded_file.EXTENSION);
                        }
                    }
                }
            }
        }

        private void BLC_OnPostEvent_Edit_Section(Section i_Section, Enum_EditMode i_Enum_EditMode)
        {
           if (i_Section.My_Uploaded_files.Count > 1)
            {
                Params_Delete_Uploaded_file deleteUploadedFile = new Params_Delete_Uploaded_file();
                deleteUploadedFile.UPLOADED_FILE_ID = i_Section.My_Uploaded_files[0].UPLOADED_FILE_ID;
                Delete_Uploaded_file(deleteUploadedFile);
            }
        }

        private void BLC_OnPreEvent_Edit_Team_member(Team_member i_Team_member, Enum_EditMode i_Enum_EditMode)
        {


            User oUser = new User();
            oUser.OWNER_ID = 1;
            MiniCryptoHelper oCrypto = new MiniCryptoHelper();
            switch (i_Enum_EditMode)
            {

                case Enum_EditMode.Add:
                    var oQuery = _AppContext.Get_Team_member_By_EMAIL(i_Team_member.EMAIL);
                    if (oQuery.Count == 1)
                    {
                        throw new BLCException("The email address is already taken. Please choose another one.");
                    }
                    else
                    {
                        if (i_Team_member.EMAIL != null || i_Team_member.PASSWORD != null)
                        {
                            oUser.USER_ID = -1;
                            oUser.FULLNAME = i_Team_member.MEMBER_NAME;
                            oUser.USERNAME = i_Team_member.EMAIL;
                            i_Team_member.PASSWORD = oCrypto.Encrypt(i_Team_member.PASSWORD);
                            oUser.PASSWORD = i_Team_member.PASSWORD;
                            oUser.USER_TYPE_CODE = "001";
                            oUser.IS_ACTIVE = false;
                            Edit_User(oUser);

                            Params_Verify_Account oParams = new Params_Verify_Account();
                            oParams.User_ID = oUser.USER_ID;
                            oParams.UserName = oUser.USERNAME;

                            Verify_Account(oParams);
                        }
                    }
                    break;

                case Enum_EditMode.Update:
                    Params_Get_Team_member_By_TEAM_MEMBER_ID teamMemberId = new Params_Get_Team_member_By_TEAM_MEMBER_ID();
                    teamMemberId.TEAM_MEMBER_ID = i_Team_member.TEAM_MEMBER_ID;
                    var oldTeamMember = Get_Team_member_By_TEAM_MEMBER_ID(teamMemberId);
                    Params_Get_User_By_USERNAME member = new Params_Get_User_By_USERNAME();
                    member.USERNAME = oldTeamMember.EMAIL;
                    var teamMember = Get_User_By_USERNAME(member);
                    oUser.USER_ID = teamMember[0].USER_ID;
                    oUser.USER_TYPE_CODE = "001";
                    oUser.FULLNAME = i_Team_member.MEMBER_NAME;
                    if (teamMember[0].USERNAME != i_Team_member.EMAIL)
                    {
                        oUser.IS_ACTIVE = false;
                        oUser.USERNAME = i_Team_member.EMAIL;
                        Params_Verify_Account verifyAcc = new Params_Verify_Account();
                        verifyAcc.User_ID = teamMember[0].USER_ID;
                        verifyAcc.UserName = i_Team_member.EMAIL;
                        Verify_Account(verifyAcc);
                    }
                    else
                    {
                        oUser.IS_ACTIVE = true;
                        oUser.USERNAME = i_Team_member.EMAIL;

                    }

                    if (teamMember[0].PASSWORD == i_Team_member.PASSWORD)
                    {
                        oUser.PASSWORD = i_Team_member.PASSWORD;
                    }
                    else
                    {
                        i_Team_member.PASSWORD = oCrypto.Encrypt(i_Team_member.PASSWORD);
                        oUser.PASSWORD = i_Team_member.PASSWORD;
                    }
                    Edit_User(oUser);
                    break;
            }
        }

        private void BLC_OnPostEvent_Get_Section_By_SECTION_ID(ref Section i_Result, Params_Get_Section_By_SECTION_ID i_Params_Get_Section_By_SECTION_ID)
        {

            Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY sectionWithFile = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY();
            sectionWithFile.REL_KEY = i_Result.SECTION_ID;
            sectionWithFile.REL_ENTITY = "[TBL_SECTION]";
           

            Uploaded_file oUploaded_file = new Uploaded_file();
            List<Uploaded_file> oList_Uploaded_files = new List<Uploaded_file>();
            string str_WEB_PATH = ConfigurationManager.AppSettings["WEB_PATH"].ToString();
            if (i_Result != null)
            {
                i_Result.My_Uploaded_files = Get_Uploaded_file_By_REL_ENTITY_REL_KEY(sectionWithFile);
                if (i_Result.My_Uploaded_files != null)
                {
                    foreach (var oRow_Uploaded_file in i_Result.My_Uploaded_files)
                    {
                        oRow_Uploaded_file.My_URL = string.Format("{0}/Files/Uploaded/{1}.{2}", str_WEB_PATH, oRow_Uploaded_file.UPLOADED_FILE_ID.ToString(), oRow_Uploaded_file.EXTENSION);
                    }
                }
            }
        }

        private void BLC_OnPostEvent_Get_Team_member_By_OWNER_ID(ref List<Team_member> i_Result, Params_Get_Team_member_By_OWNER_ID i_Params_Get_Team_member_By_OWNER_ID)
        {
            Uploaded_file oUploaded_file = new Uploaded_file();
            List<Uploaded_file> oList_Uploaded_files = new List<Uploaded_file>();
            Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY teamMemberProfile = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY();
            teamMemberProfile.REL_ENTITY = "[TBL_TEAM_MEMBER]";

            string str_WEB_PATH = ConfigurationManager.AppSettings["WEB_PATH"].ToString();
            foreach (var item in i_Result)
            {
                teamMemberProfile.REL_KEY = item.TEAM_MEMBER_ID;
                if (i_Result != null)
                {

                    item.My_Uploaded_files = Get_Uploaded_file_By_REL_ENTITY_REL_KEY(teamMemberProfile);
                    if (item.My_Uploaded_files != null)
                    {
                        foreach (var oRow_Uploaded_file in item.My_Uploaded_files)
                        {
                            oRow_Uploaded_file.My_URL = string.Format("{0}/Files/Uploaded/{1}.{2}", str_WEB_PATH, oRow_Uploaded_file.UPLOADED_FILE_ID.ToString(), oRow_Uploaded_file.EXTENSION);
                        }
                    }
                }
            }
        }
                
            

            private void BLC_OnPostEvent_Get_Team_member_By_EMAIL(List<Team_member> i_Result, Params_Get_Team_member_By_EMAIL i_Params_Get_Team_member_By_EMAIL)
            {

            Uploaded_file oUploaded_file = new Uploaded_file();
            List<Uploaded_file> oList_Uploaded_files = new List<Uploaded_file>();
            Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY teamMemberProfile = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY();
            teamMemberProfile.REL_ENTITY = "[TBL_TEAM_MEMBER]";

            string str_WEB_PATH = ConfigurationManager.AppSettings["WEB_PATH"].ToString();
            foreach (var item in i_Result)
            {
                teamMemberProfile.REL_KEY = item.TEAM_MEMBER_ID;
                if (i_Result != null)
                {

                    item.My_Uploaded_files = Get_Uploaded_file_By_REL_ENTITY_REL_KEY(teamMemberProfile);
                    if (item.My_Uploaded_files != null)
                    {
                        foreach (var oRow_Uploaded_file in item.My_Uploaded_files)
                        {
                            oRow_Uploaded_file.My_URL = string.Format("{0}/Files/Uploaded/{1}.{2}", str_WEB_PATH, oRow_Uploaded_file.UPLOADED_FILE_ID.ToString(), oRow_Uploaded_file.EXTENSION);
                        }
                    }
                }
            }
        }

            #endregion
            #region IDisposable Members
            public void Dispose()
        {
            #region Body Section.
            #endregion
        }
        #endregion
        #region LoadMessages
        public void LoadMessages()
        {
            #region Declaration And Initialization Section.
            XElement oRoot = null;
            XElement oLanguage = null;
            #endregion
            #region Body Section.
            this.Messages = new List<Message>();

            if (!string.IsNullOrEmpty(this.Messages_FilePath))
            {
                oRoot = XElement.Load(this.Messages_FilePath);
                if (oRoot != null)
                {
                    switch (Language)
                    {
                        case Enum_Language.English:
                            oLanguage = oRoot.Element("ENGLISH");
                            break;
                        case Enum_Language.Arabic:
                            oLanguage = oRoot.Element("ARABIC");
                            break;
                        default:
                            oLanguage = oRoot.Element("ENGLISH");
                            break;
                    }

                    foreach (var oItem in oLanguage.Elements("MESSAGE"))
                    {
                        this.Messages.Add(new Message() { Code = oItem.Attribute("CODE").Value, Content = oItem.Attribute("CONTENT").Value });
                    }
                }
            }
            #endregion
        }
        #endregion
        #region GetMessageContent
        public string GetMessageContent(Enum_BR_Codes i_BR_Code)
        {
            #region Declaration And Initialization Section.
            string str_ReturnValue = string.Empty;
            #endregion
            #region Body Section.
            var oResult = this.Messages.First(x => x.Code == i_BR_Code.ToString());
            str_ReturnValue = oResult.Content;
            #endregion
            #region Return Section.
            return str_ReturnValue;
            #endregion
        }
        #endregion
        #region GetMessageContent
        public string GetMessageContent(Enum_BR_Codes i_BR_Code, Dictionary<string, string> i_PlaceHolders)
        {
            #region Declaration And Initialization Section.
            string str_ReturnValue = string.Empty;
            #endregion
            #region Body Section.
            var oResult = this.Messages.First(x => x.Code == i_BR_Code.ToString());
            str_ReturnValue = oResult.Content;

            foreach (var oItem in i_PlaceHolders)
            {
                str_ReturnValue = str_ReturnValue.Replace(oItem.Key, oItem.Value);
            }
            #endregion
            #region Return Section.
            return str_ReturnValue;
            #endregion
        }
        #endregion
        #region Events Implementation

        #endregion
    }
    #endregion
    #region BLCInitializer
    public class BLCInitializer
    {
        #region Properties
        public string ConnectionString { get; set; }
        public long? UserID { get; set; }
        public Int32? OwnerID { get; set; }
        public BLC.Enum_Language Language { get; set; }
        public string Messages_FilePath { get; set; }
        #endregion
    }
    #endregion
    #region Message
    public class Message
    {
        #region Properties
        public string Code { get; set; }
        public string Content { get; set; } 
        #endregion
    }
    #endregion
    #region EnvCode Attribute
    #region EnvCode
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Constructor, AllowMultiple = true)]
    public class EnvCode : System.Attribute
    {
        #region Properties
        public BLC.Enum_Environment Environment { get; set; }
        public string MethodName { get; set; }
        #endregion
        #region Constructor
        public EnvCode(BLC.Enum_Environment i_Environment, string i_MethodName)
        {
            #region Body Section.
            Environment = i_Environment;
            MethodName = i_MethodName;
            #endregion
        }
        #endregion
        #region Behavior
        #region GetEnvCode
        public static MethodInfo GetEnvCode(Params_GetEnvCode i_Params_GetEnvCode)
        {
            #region Declaration And Initialization Section.
            MethodInfo[] oMethods = null;
            MethodInfo oMethodInfo = null;
            object[] oAttributes = null;
            EnvCode oEnvCode = null;

            bool Is_AlreadyFound = false;
            MethodInfo oMethodInfo_ReturnValue = null;
            #endregion
            #region Body Section.

            // ----------------------
            oMethods = i_Params_GetEnvCode.My_Type.GetMethods();
            // ----------------------

            // ----------------------
            for (int i = 0; i < oMethods.GetLength(0); i++)
            {
                // ----------------------
                if (Is_AlreadyFound == true)
                {
                    break;
                }
                // ----------------------

                // ----------------------
                oMethodInfo = oMethods[i];
                oAttributes = oMethodInfo.GetCustomAttributes(true);
                // ----------------------

                // ----------------------
                foreach (Attribute oAttribute in oAttributes)
                {
                    if (oAttribute is EnvCode)
                    {
                        oEnvCode = oAttribute as EnvCode;
                        if (oEnvCode != null)
                        {
                            if ((oEnvCode.Environment == i_Params_GetEnvCode.My_Environment) && (oEnvCode.MethodName == i_Params_GetEnvCode.My_MethodName))
                            {
                                oMethodInfo_ReturnValue = oMethodInfo;
                                Is_AlreadyFound = true;
                                break;
                            }
                        }
                    }
                }
                // ----------------------
            }
            // ----------------------
            #endregion
            #region Return Section.
            return oMethodInfo_ReturnValue;
            #endregion
        }
        #endregion
        #endregion
    }
    #endregion
    #region Params_GetEnvCode
    public class Params_GetEnvCode
    {
        #region Properties.
        public System.Type My_Type { get; set; }
        public BLC.Enum_Environment My_Environment { get; set; }
        public string My_MethodName { get; set; }
        #endregion
    }
    #endregion
    #endregion
}


