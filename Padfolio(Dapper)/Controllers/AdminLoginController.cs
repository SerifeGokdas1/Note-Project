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
    public class AdminLoginController : Controller
    {
        // GET: AdminLogin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login (Admin admin)
        {
            using (PadfolioEntities1 db= new PadfolioEntities1())
            {
                var result = db.AdminInformations.Where(x => x.AdminNameSurname == admin.AdminNameSurname && x.AdminPassword == admin.AdminPassword);
                if(result.Count() != 0)
                {
                    FormsAuthentication.SetAuthCookie(admin.AdminNameSurname, false);
                    return RedirectToAction("Index", "AdminBlog");
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