using Reports.IServises;
using Reports.Models;
using Reports.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Reports.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserServise _userServise;
        public AccountController(IUserServise _userServise)
        {
            this._userServise = _userServise;
        }

        [HttpGet]
        public async Task<ActionResult> Login() => View();



        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            var curUser = await _userServise.GetCurUser(model);
            if (curUser != null)
            {
                CurrentUser.User = curUser;
                if (curUser.AccessReport1 && curUser.AccessReport2)
                {
                    return RedirectToAction("Choice", "Shipping");
                }
                else if (curUser.AccessReport1)
                {
                    return RedirectToAction("ShowReportPlanFact", "Shipping");
                }
                else if (curUser.AccessReport2)
                {
                    return RedirectToAction("ShowReportFactGrouping", "Shipping");
                }
                return RedirectToAction("Login", "Account");

            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
    }
}