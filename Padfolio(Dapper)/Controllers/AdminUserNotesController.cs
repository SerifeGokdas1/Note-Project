using Dapper;
using Padfolio_Dapper_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Padfolio_Dapper_.Controllers
{
    public class AdminUserNotesController : Controller
    {
        // GET: AdminUserNotes
        public ActionResult Index()
        {
            return View(DP.ReturnList<UserNotes>("UserNoteList"));
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
                param.Add("@UserNoteId", id);
                return View(DP.ReturnList<UserNotes>("UserNoteNoList", param).FirstOrDefault<UserNotes>());

            }
        }
        [HttpPost]
        public ActionResult UAddUpdate(UserNotes personel)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@UserNoteId", personel.UserNoteId);
            param.Add("@UserNoteTitle", personel.UserNoteTitle);
            param.Add("@UserNoteExplanation", personel.UserNoteExplanation);
            DP.EXReturn("UserNoteAddUpdate", param);
            return RedirectToAction("Index");
        }
        public ActionResult UDelete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@UserNoteId", id);
            DP.EXReturn("UserNoteDelete", param);
            return RedirectToAction("Index");
        }
    }
}