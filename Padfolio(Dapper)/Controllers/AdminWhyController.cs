using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Padfolio_Dapper_.Models;
using Dapper;

namespace Padfolio_Dapper_.Controllers
{
    public class AdminWhyController : Controller
    {
        // GET: AdminWhy
        public ActionResult Index()
        {
            return View(DP.ReturnList<WhyPadfolios>("WList"));
        }
        public ActionResult WAddUpdate(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@WhyId", id);
                return View(DP.ReturnList<WhyPadfolios>("WNoList", param).FirstOrDefault<WhyPadfolios>());

            }
        }
        [HttpPost]
        public ActionResult WAddUpdate(WhyPadfolios personel)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@WhyId", personel.WhyId);
            param.Add("@WhyTitle", personel.WhyTitle);
            param.Add("@WhyExplanation", personel.WhyExplanation);
            DP.EXReturn("WhyAddUpdate", param);
            return RedirectToAction("Index");
        }
        public ActionResult WDelete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@WhyId", id);
            DP.EXReturn("WDelete", param);
            return RedirectToAction("Index");
        }
    }
}