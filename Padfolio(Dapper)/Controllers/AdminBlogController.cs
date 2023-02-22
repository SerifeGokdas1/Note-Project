using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Padfolio_Dapper_.Models;
using Dapper;

namespace Padfolio_Dapper_.Controllers
{
    public class AdminBlogController : Controller
    {
        // GET: AdminBlog
        public ActionResult Index()
        {
            return View(DP.ReturnList<Blogs>("BList"));
        }
        public ActionResult BAddUpdate(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BlogId", id);
                return View(DP.ReturnList<Blogs>("BlogNoList", param).FirstOrDefault<Blogs>());

            }
        }
        [HttpPost]
        public ActionResult BAddUpdate(Blogs personel)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@BlogId", personel.BlogId);
            param.Add("@BlogTitle", personel.BlogTitle);
            param.Add("@BlogPost", personel.BlogPost);
            DP.EXReturn("BlogAddUpdate", param);
            return RedirectToAction("Index");
        }
        public ActionResult BDelete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@BlogId", id);
            DP.EXReturn("BDelete", param);
            return RedirectToAction("Index");
        }
    }
}