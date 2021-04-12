using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLC;
using System.Configuration;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VerificationController : ControllerBase
    {
        #region Activate_Account
        [HttpGet]
        [Route("Activate_Account")]
        public RedirectResult Activate_Account([FromQuery] Params_Activate_Account i_Params_Activate_Account)
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
                BLCInitializer oBLCInitializer = new BLCInitializer();
                oBLCInitializer.UserID = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
                oBLCInitializer.OwnerID = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
                oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
                oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
                using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
                {
                    oReturnValue = oBLC.Activate_Account(i_Params_Activate_Account);
                    oResult_Activate_Account.My_Result = oReturnValue;
                    oResult_Activate_Account.My_Params_Activate_Account = i_Params_Activate_Account;
                }
            }
            catch (Exception ex)
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
           return Redirect("http://localhost:4200/ActivatedSuccessfully");

        }
        #endregion
    }

}