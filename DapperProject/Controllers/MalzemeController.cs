using DapperProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DapperProject.Controllers
{
    public class MalzemeController : Controller
    {
        // GET: Malzeme
        public ActionResult Index()
        {
            return View(DP.Listeleme<MalzemeModel>("ViewMalzemeAll"));
        }
        public ActionResult EY(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MalzemeNo", id);
                return View(DP.Listeleme<MalzemeModel>("ViewMalzemeByNo", param).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult EY(MalzemeModel malzeme)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@MalzemeNo", malzeme.MalzemeNo);
            param.Add("@MalzemeAdi", malzeme.MalzemeAdi);
            param.Add("@MalzemeTutar", malzeme.MalzemeTutar);
            param.Add("@HizmetNo", malzeme.HizmetNo);
            param.Add("@Fayda", malzeme.Fayda);
            param.Add("@Aciklama", malzeme.Aciklama);
            DP.ExecuteReturn("MalzemeEY", param);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@MalzemeNo", id);
            DP.ExecuteReturn("MalzemeDel", param);
            return RedirectToAction("Index");
        }
    }
}