using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BLC
{
    #region Enumeration
    public enum Enum_EntityNameFormat
    {
        FML,
        FLM,
        MFL,
        MLF,
        LFM,
        LMF
    }
    #endregion
    public partial class BLC
    {
        #region Members
        public string _KeyPublic = "<RSAKeyValue><Modulus>2rR6f89bEyTkmmaUu/97+s4nyo6nH14QZ6I60UJlGjdVZB3qOX5/8wt01Sl0sss84q/fU3nsqDh33vS5FEmmRKzdRVBYS+EfDEVh6VDeXi3JQP9E/iNsYusCJUYWhU/6d4e+KgxlAwe/Uu/sIIjY2KUZIBv6fy5JZ8Y3wwC/VQ8=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        public string _KeySet = "<RSAKeyValue><Modulus>2rR6f89bEyTkmmaUu/97+s4nyo6nH14QZ6I60UJlGjdVZB3qOX5/8wt01Sl0sss84q/fU3nsqDh33vS5FEmmRKzdRVBYS+EfDEVh6VDeXi3JQP9E/iNsYusCJUYWhU/6d4e+KgxlAwe/Uu/sIIjY2KUZIBv6fy5JZ8Y3wwC/VQ8=</Modulus><Exponent>AQAB</Exponent><P>7kNI6DCzqJ6LEK/4ToYwoaAIpmjeeiNpgXqMsBtoJMKfm+H4hwODqXWXnbJBLFj7LOusS8NlJgp9kMPyCG2j3w==</P><Q>6vx37xhAC+yClipDUjipUbYdQgGA2VHRFh2DiKpMxFwP1sj1fWX3/wUc/4SdVFdex1URPm3IF0hdrhJIYnT00Q==</Q><DP>T6Aw51gPUpTZiNQmOafi7MDc4zA82bin89uO1PPz1AUu7huQwR5Ni/5+kvcVjMqX9qU0SYWdch8jY5P4eRSbJQ==</DP><DQ>kCr1Kiumn6orNBYZ14gL2aXxrV1ev/YCYZ8Z4+8XyiDxVsVUV+sHi96HO/0QyX4RGBqIydRwvlgXoYR2BHHdAQ==</DQ><InverseQ>CAafwu1Ko1GiOmDGW6hQniKxHeRghyeUqu/5zn8bAjmYMpZV4kCNVxUsGuTfRpPdDeun3zQyrZ86gdDQ2kjqVQ==</InverseQ><D>qNM01MCeT1LlXQLewZjgfaTyNnyUKbSU+UrUGIEmRmx8cEJfcm5iGp23XG0Z9oLIxzx4Kpotw1WDwwoqbKzFuURdjctduvT+cUiy97LDQXFVNY4YyQtEgU6SzxluTtF3yyXpqSeIVOGHuKej4AsoJ1QgVUawn55g0+4VrjfxI0E=</D></RSAKeyValue>";
        #endregion        
        #region Setup
        #region EditSetup
        #region EditSetup
        public void EditSetup(SetupEntry i_SetupEntry)
        {
            #region Declaration And Initialization Section.
            Tools.Tools oTools = new Tools.Tools();
            #endregion
            #region Environment Related Code Handling
            Params_GetEnvCode oParams_GetEnvCode = new Params_GetEnvCode();
            oParams_GetEnvCode.My_Environment = this.Environment;
            oParams_GetEnvCode.My_MethodName = "EditSetup";
            oParams_GetEnvCode.My_Type = typeof(BLC);
            MethodInfo oMethodInfo = EnvCode.GetEnvCode(oParams_GetEnvCode);
            if (oMethodInfo != null)
            {
                oMethodInfo.Invoke(this, new object[] { i_SetupEntry });
                return;
            }
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("EditSetup");
            }
            #endregion
            #region Body Section.
            i_SetupEntry.ENTRY_USER_ID = this.UserID;
            i_SetupEntry.OWNER_ID = this.OwnerID;
            i_SetupEntry.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
            oTools.InvokeMethod(_AppContext, "UP_EDIT_SETUP", i_SetupEntry);
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("EditSetup");
            }
            #endregion
        }
        #endregion
        #endregion
        #endregion
        #region Ticket
        #region ResolveTicket
        public Dictionary<string, string> ResolveTicket(string i_Input)
        {
            #region Declaration And Initialization Section.
            Dictionary<string, string> oList = new Dictionary<string, string>();
            string str_Ticket_PlainText = string.Empty;
            Crypto.Crypto oCrypto = new Crypto.Crypto();
            string[] oMainTempList = null;
            string[] oSubTempList = null;
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("ResolveTicket");
            }
            #endregion
            #region Body Section.
            if (!string.IsNullOrEmpty(i_Input))
            {
                //str_Ticket_PlainText = oCrypto.Decrypt(i_Input, _KeySet);
                str_Ticket_PlainText = i_Input;

                if (!string.IsNullOrEmpty(str_Ticket_PlainText))
                {
                    oMainTempList = str_Ticket_PlainText.Split(new string[] { "[~!@]" }, StringSplitOptions.RemoveEmptyEntries);

                    var oQuery = from oItem in oMainTempList
                                 select oItem;

                    foreach (var oRow in oQuery)
                    {
                        oSubTempList = oRow.Split(new string[] { ":" }, StringSplitOptions.None);
                        oList.Add(oSubTempList[0], oSubTempList[1]);
                    }
                }
            }
            else
            {
                oList.Add("USER_ID", "1");
                oList.Add("OWNER_ID", "1");
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("ResolveTicket");
            }
            #endregion
            #region Return Section.
            return oList;
            #endregion
        }
        #endregion
        #region IsValidTicket
        public bool IsValidTicket(string i_Input)
        {
            #region Declaration And Initialization Section.
            bool Is_ValidTicket = false;
            long? i_MinutesElapsedSinceMidnight = 0;
            string str_CurrentDate = string.Empty;
            Tools.Tools oTools = new Tools.Tools();
            Dictionary<string, string> oTicketParts = new Dictionary<string, string>();
            #endregion
            #region Environment Related Code Handling
            Params_GetEnvCode oParams_GetEnvCode = new Params_GetEnvCode();
            oParams_GetEnvCode.My_Environment = this.Environment;
            oParams_GetEnvCode.My_MethodName = "IsValidTicket";
            oParams_GetEnvCode.My_Type = typeof(BLC);
            MethodInfo oMethodInfo = EnvCode.GetEnvCode(oParams_GetEnvCode);
            if (oMethodInfo != null)
            {
                return Convert.ToBoolean(oMethodInfo.Invoke(this, new object[] { i_Input }));
                // Intentially Left Empty.
            }
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("IsValidTicket");
            }
            #endregion
            #region Body Section.
            try
            {
                oTicketParts = ResolveTicket(i_Input);
                str_CurrentDate = oTools.GetDateString(DateTime.Today);

                if (oTicketParts["START_DATE"] == str_CurrentDate) // Session Started In Different Day.
                {
                    i_MinutesElapsedSinceMidnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;

                    if (i_MinutesElapsedSinceMidnight <= Convert.ToInt32(oTicketParts["START_MINUTE"]) + Convert.ToInt32(oTicketParts["SESSION_PERIOD"]))
                    {
                        Is_ValidTicket = true;
                    }
                }

            }
            catch (Exception ex)
            {
                Is_ValidTicket = false;
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("IsValidTicket");
            }
            #endregion
            #region Return Section.
            return Is_ValidTicket;
            #endregion
        }
        #endregion
        #endregion

        #region Authentication 
        public User Authenticate(Params_Authenticate i_Params_Authenticate)
        {
            User oUser = new User();
            Crypto.MiniCryptoHelper oCrypto = new Crypto.MiniCryptoHelper();
            Crypto.Crypto iCrypto = new Crypto.Crypto();
            var oQuery = _AppContext.Get_User_By_USERNAME(i_Params_Authenticate.Username);
            if ((oQuery != null) && (oQuery.Count > 0))
            {
                var Pass = oCrypto.Encrypt(i_Params_Authenticate.Password);
                if (Pass == oQuery[0].PASSWORD)
                {

                    oUser.USER_ID = oQuery[0].USER_ID;
                    oUser.USERNAME = oQuery[0].USERNAME;
                    oUser.PASSWORD = oQuery[0].PASSWORD;
                    oUser.FULLNAME = oQuery[0].FULLNAME;
                    oUser.USER_TYPE_CODE = oQuery[0].USER_TYPE_CODE;
                    oUser.IS_ACTIVE = oQuery[0].IS_ACTIVE;
                    oUser.OWNER_ID = oQuery[0].OWNER_ID;

                    var i_MinutesElapsedSinceMidnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;
                    var str_ticket_PlainText = string.Format(
                        "USER_ID:{0}[~!@]OWNER_ID:{1}[~!@]START_DATE:{2}[~!@]START_MINUTE:{3}[~!@]SESSION_PERIOD:{4}",
                        oUser.USER_ID,
                        oUser.OWNER_ID,
                        oTools.GetDateString(DateTime.Today),
                        i_MinutesElapsedSinceMidnight.ToString(),
                        60
                        );

                    oUser.My_Ticket = iCrypto.Encrypt(str_ticket_PlainText, _KeyPublic);



                }
                else
                {
                    throw new BLCException("Invalid Email or Password");
                }
            }
            else
            {
                throw new BLCException("Invalid Email or Password");
            }

            //   var Pass = oCrypto.Encrypt(i_Params_Authenticate.Password);


            return oUser;
        }
        #endregion
    }
    #region Business Entities
    #region Setup
    #region SetupEntry
    public class SetupEntry
    {
        #region Properties
        public Int32? OWNER_ID { get; set; }
        public string TBL_NAME { get; set; }
        public string CODE_NAME { get; set; }
        public bool? ISSYSTEM { get; set; }
        public bool? ISDELETEABLE { get; set; }
        public bool? ISUPDATEABLE { get; set; }
        public bool? ISVISIBLE { get; set; }
        public bool? ISDELETED { get; set; }
        public Int32? DISPLAY_ORDER { get; set; }
        public string CODE_VALUE_EN { get; set; }
        public string CODE_VALUE_FR { get; set; }
        public string CODE_VALUE_AR { get; set; }
        public string ENTRY_DATE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string NOTES { get; set; }

        public string INVARIANT_VALUE { get; set; }
        #endregion
    }
    #endregion    
    #endregion
    #region Uploaded_file
    public partial class Uploaded_file
    {
        public string My_URL { get; set; }
    }

    public partial class Team_member
    {
        public List<Uploaded_file> My_Uploaded_files { get; set; }
    }

    public partial class Section
    {
        public List<Uploaded_file> My_Uploaded_files { get; set; }
    }

    public class Params_Authenticate
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public partial class User
    {
        public string My_Ticket { get; set; }
    }
    #endregion
    #endregion
}


