using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Padfolio_Dapper_.Models;
using Microsoft.SqlServer.Server;

namespace Padfolio_Dapper_.Controllers
{
    [AllowAnonymous]
    public class UserLoginController : Controller
    {
        // GET: UserAdmin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(User user)
        {
            using (PadfolioEntities1 db = new PadfolioEntities1())
            {
                var result = db.UserInformations.Where(x => x.UserNameSurname == user.UserNameSurname && x.UserPassword == user.UserPassword);
                if (result.Count() != 0)
                {
                    FormsAuthentication.SetAuthCookie(user.UserNameSurname, false);
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    TempData["msg"] = "hatalı";
                }

            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return View("Login");
        }
    }
}