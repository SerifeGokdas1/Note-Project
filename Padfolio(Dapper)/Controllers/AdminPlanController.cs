using Dapper;
using Padfolio_Dapper_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Padfolio_Dapper_.Controllers
{
    public class AdminPlanController : Controller
    {
        // GET: AdminPlan
        public ActionResult Index()
        {
            return View(DP.ReturnList<Plans>("PList"));
        }
        public ActionResult PAddUpdate(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@PlanId", id);
                return View(DP.ReturnList<Plans>("PlanNoList", param).FirstOrDefault<Plans>());

            }
        }
        [HttpPost]
        public ActionResult PAddUpdate(Plans personel)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@PlanId", personel.PlanId);
            param.Add("@PlanTitle", personel.PlanTitle);
            param.Add("@PPrice", personel.PPrice);
            param.Add("@PExplanation", personel.PExplanation);
            DP.EXReturn("PlanAddUpdate", param);
            return RedirectToAction("Index");
        }
        public ActionResult PDelete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@PlanId", id);
            DP.EXReturn("PDelete", param);
            return RedirectToAction("Index");
        }
    }
}