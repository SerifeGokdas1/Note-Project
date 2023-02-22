using Padfolio_Dapper_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Padfolio_Dapper_.Controllers
{
    public class UserAdminWhyController : Controller
    {
        // GET: UserWhy
        public ActionResult Index()
        {
            return View(DP.ReturnList<WhyPadfolios>("WList"));
        }
    }
}