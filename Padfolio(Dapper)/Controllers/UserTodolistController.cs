using Dapper;
using Padfolio_Dapper_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Padfolio_Dapper_.Controllers
{
    public class UserTodolistController : Controller
    {
        // GET: UserTodolist
        public ActionResult Index()
        {
            return View(DP.ReturnList<Todolists>("TList"));
        }
        public ActionResult TAddUpdate(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@TodolistId", id);
                return View(DP.ReturnList<Todolists>("TodoNoList", param).FirstOrDefault<Todolists>());

            }
        }
        [HttpPost]
        public ActionResult TAddUpdate(Todolists personel)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@TodolistId", personel.TodolistId);
            param.Add("@TodolistTitle", personel.TodolistTitle);
            param.Add("@TodolistExplanation", personel.TodolistExplanation);
            DP.EXReturn("TodolistAddUpdate", param);
            return RedirectToAction("Index");
        }
        public ActionResult TDelete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@TodolistId", id);
            DP.EXReturn("TDelete", param);
            return RedirectToAction("Index");
        }
    }
}