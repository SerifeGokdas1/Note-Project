using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Padfolio_Dapper_.Models;
using Dapper;
using System.Reflection;

namespace Padfolio_Dapper_.Controllers
{
    public class AdminInformationController : Controller
    {
        // GET: Admin
    
        public ActionResult Index()
        {
            return View(DP.ReturnList<AdminInformations>("ALisT"));
        }
        
        public ActionResult AAddUpdate(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AdminId", id);
                return View(DP.ReturnList<AdminInformations>("AdminNoList", param).FirstOrDefault<AdminInformations>());

            }
        }
        [HttpPost]
        public ActionResult AAddUpdate(AdminInformations personel)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@AdminId", personel.AdminId);
            param.Add("@AdminNameSurname", personel.AdminNameSurname);
            param.Add("@AdminPassword", personel.AdminPassword);
            DP.EXReturn("AdminAddUpdate", param);
            return RedirectToAction("Index");
        }
        public ActionResult ADelete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@AdminId", id);
            DP.EXReturn("ADlete", param);
            return RedirectToAction("Index");
        }

        

       


    }
}