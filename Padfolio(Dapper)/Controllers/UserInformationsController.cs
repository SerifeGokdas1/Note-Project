using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Padfolio_Dapper_.Models;
using Dapper;

namespace Padfolio_Dapper_.Controllers
{
    public class UserInformationsController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View(DP.ReturnList<UserInformations>("UserInfList"));
        }
        public ActionResult UAddUpdate(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@UserId", id);
                return View(DP.ReturnList<UserInformations>("UserNoList", param).FirstOrDefault<UserInformations>());

            }
        }
        [HttpPost]
        public ActionResult UAddUpdate(UserInformations personel)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@UserId", personel.UserId);
            param.Add("@UserNameSurname", personel.UserNameSurname);
            param.Add("@UserPassword", personel.UserPassword);
            DP.EXReturn("UserAddUpdate", param);
            return RedirectToAction("Index");
        }
        public ActionResult UDelete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@UserId", id);
            DP.EXReturn("UserInfDelete", param);
            return RedirectToAction("Index");
        }
    }
}