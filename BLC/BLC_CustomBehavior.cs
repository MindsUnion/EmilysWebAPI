using Crypto;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MailKit.Net.Smtp;
using MimeKit;

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
                str_Ticket_PlainText = oCrypto.Decrypt(i_Input, _KeySet);
               // str_Ticket_PlainText = i_Input;

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
            User user = new User();
            Crypto.MiniCryptoHelper oCrypto = new Crypto.MiniCryptoHelper();
            Crypto.Crypto iCrypto = new Crypto.Crypto();
            var oQuery = _AppContext.Get_User_By_USERNAME(i_Params_Authenticate.Username);
            if ((oQuery != null) && (oQuery.Count > 0))
            {
                var Pass = oCrypto.Encrypt(i_Params_Authenticate.Password);
                if (Pass == oQuery[0].PASSWORD)
                {
                   
                    user.USER_ID = oQuery[0].USER_ID;
                    user.USERNAME = oQuery[0].USERNAME;
                    user.PASSWORD = oQuery[0].PASSWORD;
                    user.FULLNAME = oQuery[0].FULLNAME;
                    user.USER_TYPE_CODE = oQuery[0].USER_TYPE_CODE;
                    user.IS_ACTIVE = oQuery[0].IS_ACTIVE;
                    user.OWNER_ID = oQuery[0].OWNER_ID;

                    var i_MinutesElapsedSinceMidnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;
                    var str_ticket_PlainText = string.Format(
                        "USER_ID:{0}[~!@]OWNER_ID:{1}[~!@]START_DATE:{2}[~!@]START_MINUTE:{3}[~!@]SESSION_PERIOD:{4}",
                     user.USER_ID,
                       user.OWNER_ID,
                        oTools.GetDateString(DateTime.Today),
                        i_MinutesElapsedSinceMidnight.ToString(),
                        60
                        );

                    user.My_Ticket = iCrypto.Encrypt(str_ticket_PlainText, _KeyPublic);
                    Params_Get_Team_member_By_EMAIL teamMemberProfile = new Params_Get_Team_member_By_EMAIL();
                    teamMemberProfile.EMAIL = i_Params_Authenticate.Username;

                    user.memberProfile = Get_Team_member_By_EMAIL(teamMemberProfile);



                }
                else
                {
                    throw new BLCException("Email ou mot de passe invalide");
                }
            }
            else
            {
                throw new BLCException("Email ou mot de passe invalide");
            }


            return user;
        }
        #endregion



        #region Section with file.
        public List<Section> Get_Section_With_Uploaded_Files (Params_Get_Section_With_Uploaded_Files i_Params_Get_Section_With_Uploaded_Files)
        {
            List<Section> sections = new List<Section>();
            List<Section> sectionsWithFiles = new List<Section>();
            Params_Get_Section_By_OWNER_ID sectionOwnerId = new Params_Get_Section_By_OWNER_ID();
            sectionOwnerId.OWNER_ID = 1;
            sections = Get_Section_By_OWNER_ID(sectionOwnerId);
            foreach (var item in sections)
            {
                if(item.SECTION_ID == i_Params_Get_Section_With_Uploaded_Files.sectionId)
                {
                    sectionsWithFiles.Add(item);
                }
            }
            return sectionsWithFiles;
        }
        #endregion

        #region Team Member with profile
        public List<Team_member> Get_Team_member_With_Uploaded_Files(Params_Get_Team_member_With_Uploaded_Files i_Params_Get_Team_member_With_Uploaded_Files)
        {
            List<Team_member> teamMembers = new List<Team_member>();
            List<Team_member> membersWithProfile = new List<Team_member>();
            Params_Get_Team_member_By_OWNER_ID member = new Params_Get_Team_member_By_OWNER_ID();
            member.OWNER_ID = 1;
            teamMembers = Get_Team_member_By_OWNER_ID(member);
            foreach (var item in teamMembers)
            {
                
                    membersWithProfile.Add(item);
                
            }
            return membersWithProfile;
        }
        #endregion

        #region Email Verification

        public User Verify_Account(Params_Verify_Account i_Params_Verify_Account)
        {
            User oUser = new User();
            Crypto.MiniCryptoHelper oCrypto = new Crypto.MiniCryptoHelper();
            var oQuery = _AppContext.Get_User_By_USERNAME(i_Params_Verify_Account.UserName);

            if ((oQuery != null) && (oQuery.Count > 0))
            {
                oUser.USER_ID = oQuery[0].USER_ID;
                oUser.USERNAME = oQuery[0].USERNAME;
                oUser.OWNER_ID = oQuery[0].OWNER_ID;

                var msg = new MimeMessage();
                msg.From.Add(new MailboxAddress("Amar", "amar27.z.az@gmail.com"));

                msg.To.Add(new MailboxAddress("User", oUser.USERNAME));
                msg.Subject = "Email Verification";
                msg.Body = new TextPart("plain")
                {
                    Text = string.Format("Salut! Veuillez cliquer sur le lien suivant pour activer votre compte!\n http://localhost:5000/api/Verification/Activate_Account?USER_ID=" + i_Params_Verify_Account.User_ID)
                };

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("amar27.z.az@gmail.com", "1872019MA");
                    client.Send(msg);
                    client.Disconnect(true);
                }


            }
            return oUser;

        }

        #endregion

        #region Email Activation
        public User Activate_Account(Params_Activate_Account i_Params_Activate_Account)
        {
            User oUser = new User();
            var result = _AppContext.Get_User_By_USER_ID(i_Params_Activate_Account.USER_ID);
            if (result == null)
            {
                throw new BLCException("Activation echouée");
            }

            else
            {
                oUser.FULLNAME = result.FULLNAME;
                oUser.ENTRY_DATE = result.ENTRY_DATE;
                oUser.USERNAME = result.USERNAME;
                oUser.PASSWORD = result.PASSWORD;
                oUser.USER_TYPE_CODE = result.USER_TYPE_CODE;
                oUser.OWNER_ID = result.OWNER_ID;
                oUser.USER_ID = i_Params_Activate_Account.USER_ID;
                oUser.IS_ACTIVE = true;
                Edit_User(oUser);
            }
            return oUser;

        }
        #endregion

        #region Forgot Password
        public User Forgot_Password(Params_Forgot_Password i_Params_Forgot_Password)
        {
            User oUser = new User();
            var oQuery = _AppContext.Get_User_By_USERNAME(i_Params_Forgot_Password.USERNAME);

            if ((oQuery != null) && (oQuery.Count > 0))
            {
                var msg = new MimeMessage();
                msg.From.Add(new MailboxAddress("Association Emilys", "emilysassociation@gmail.com"));

                msg.To.Add(new MailboxAddress("User", oQuery[0].USERNAME));
                msg.Subject = "Réinitialiser le mot de passe";
                msg.Body = new TextPart("plain")
                {
                    Text = string.Format("Salut! Veuillez cliquer sur le lien suivant pour réinitialiser votre mot de passe!\nhttp://localhost:4200/RécupérationDuCompte/" + oQuery[0].USER_ID)
                };

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("emilysassociation@gmail.com", "Mimi1706");
                    client.Send(msg);
                    client.Disconnect(true);
                }

                oUser.ENTRY_DATE = oQuery[0].ENTRY_DATE;
                oUser.USERNAME = oQuery[0].USERNAME;
                oUser.PASSWORD = oQuery[0].PASSWORD;
                oUser.USER_TYPE_CODE = oQuery[0].USER_TYPE_CODE;
                oUser.OWNER_ID = oQuery[0].OWNER_ID;
                oUser.USER_ID = oQuery[0].USER_ID;
                oUser.IS_ACTIVE = true;


            }
            else
            {
                throw new BLCException("L'email est faux! Veuillez fournir un e-mail correct");
            }
            return oUser;

        }
        #endregion

        #region Reset Password
    
        public void Change_Password(Params_Change_Password i_Params_Change_Password)
        {
            MiniCryptoHelper oCrypt = new MiniCryptoHelper();
        
            List<Team_member> member = new List<Team_member>();

            var oQuery = _AppContext.Get_User_By_USER_ID(i_Params_Change_Password.USER_ID);
            if (oQuery != null)
            {

                Params_Get_Team_member_By_EMAIL memberParams = new Params_Get_Team_member_By_EMAIL();
                memberParams.EMAIL = oQuery.USERNAME;
                member = Get_Team_member_By_EMAIL(memberParams);

                foreach (var item in member)
                {
                    item.TEAM_MEMBER_ID = item.TEAM_MEMBER_ID;
                    item.FULLNAME = item.FULLNAME;
                    item.POSITION = item.POSITION;
                    item.MAJOR = item.MAJOR;
                    item.DESCRIPTION = item.DESCRIPTION;
                    item.EMAIL = item.EMAIL;
                    item.PASSWORD = i_Params_Change_Password.PASSWORD;
                  
                    Edit_Team_member(item);
                }

            }
            else
            {
                throw new Exception("ERREUR");
            }
            

        }
        #endregion

        #region Contact Us Form
        public List<object> Contact_Us(Params_Contact_Us i_Params_Contact_Us)
        {

            List<object> ol = new List<object>();
            var fName = i_Params_Contact_Us.FirstName;
            var Lname = i_Params_Contact_Us.LastName;
            var userEmail = i_Params_Contact_Us.email;
            var formType = i_Params_Contact_Us.HelpOrExp;
            var messageUser = i_Params_Contact_Us.msgUser;
            ol.Add(fName);
            ol.Add(Lname);
            ol.Add(userEmail);
            ol.Add(formType);
            ol.Add(messageUser);
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Association Emilys", "contact@association-emilys.com"));
            message.To.Add(new MailboxAddress("Emilys", "associationemilys@gmail.com"));
            message.Subject = "Contactez-nous Formulaire";
            message.Body = new TextPart("plain")
            {
                Text = String.Format("Nouveau message pour aujourd'hui!\nPrénom: {0}\nNom: {1}\nEmail: {2}\nDemandez-vous de l'aide ou dites-nous votre expérience? {3}\nMessage: {4}", fName, Lname, userEmail, formType, messageUser)
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.ionos.fr", 465, true);
                client.Authenticate("contact@association-emilys.com", "Ass29!04");
                client.Send(message);
                client.Disconnect(true);
            }

            return ol;
        }
        #endregion

        #region Members Form
        //public List<object> MemberD(DataDetails form)
        //{
        //    //DataDetails form = new DataDetails();
        //    List<object> ol = new List<object>();
        //    var firstName = form.FirstName;
        //    var lastName = form.LastName;
        //    var address = form.Address;
        //    var postalCode = form.postalCode;
        //    var city = form.city;
        //    var type = form.type;
        //    var email = form.email;
        //    ol.Add(firstName);
        //    ol.Add(lastName);
        //    ol.Add(address);
        //    ol.Add(postalCode);
        //    ol.Add(city);
        //    ol.Add(type);
        //    ol.Add(email);
        //    var message = new MimeMessage();
        //    message.From.Add(new MailboxAddress("Association Emilys", "contact@association-emilys.com"));

        //    message.To.Add(new MailboxAddress("Emilys", "associationemilys@gmail.com"));
        //    message.Subject = "Formulaire d'adhésion";
        //    message.Body = new TextPart("Plain")

        //    {
        //        Text = String.Format("Nouveau membre pour aujourd'hui!\n Prénom: {0}\nNom: {1}\nAdresse: {2}\nCode postal: {3}\n Ville: {4}\n Type de membre: {5}\n E-mail: {6} ", firstName, lastName, address, postalCode, city, type, email)
        //    };

        //    using (var client = new SmtpClient())
        //    {
        //        client.Connect("smtp.gmail.com", 587, false);
        //        client.Authenticate("contact@association-emilys.com", "Ass29!04");
        //        client.Send(message);
        //        client.Disconnect(true);
        //    }

        //    Console.WriteLine("Done");
        //    return ol;
        //}

        #endregion

        #region Donators Form

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

    public partial class Params_Get_Section_With_Uploaded_Files
    {
        public int? sectionId { get; set; }
    }

    public class Params_Authenticate
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public partial class User
    {
        public string My_Ticket { get; set; }
        public List<Team_member> memberProfile { get; set; }
    }
    public partial class Params_Get_Team_member_With_Uploaded_Files { }

    public class Params_Verify_Account
    {
        public long? User_ID { get; set; }
        public string UserName { get; set; }
    }

    public class Params_Activate_Account
    {
        public int USER_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
    }

    public class Params_Forgot_Password
    {
        public int USER_ID { get; set; }
        public string USERNAME { get; set; }

        public string PASSWORD { get; set; }
    }

    public class Params_Change_Password
    {
        public int USER_ID { get; set; }
        public string PASSWORD { get; set; }

        public string USERNAME { get; set; }
    }

    public class Params_Contact_Us
    {
        public string HelpOrExp { get; set; }
        public string OnOff { get; set; }
        public string msgUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int postalCode { get; set; }
        public string city { get; set; }
        public string type { get; set; }
        public int amount { get; set; }
        public string email { get; set; }
    }
    #endregion
    #endregion
}


