using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using DapperProject.Models;

namespace DapperProject.Controllers
{
    public class SalonlarController : Controller
    {
        // GET: Salonlar
        public ActionResult Index()
        {
            return View(DP.Listeleme<SalonlarModel>("ViewSalonlarAll"));
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
                param.Add("@SalonNo", id);
                return View(DP.Listeleme<SalonlarModel>("ViewSalonlarByNo", param).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult EY(SalonlarModel salonlar)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SalonNo", salonlar.SalonNo);
            param.Add("@SalonAdi", salonlar.SalonAdi);
            param.Add("@SalonKapiNo", salonlar.SalonKapiNo);
            param.Add("@YapilanIslem", salonlar.YapilanIslem);
            param.Add("@IslemSayisi", salonlar.IslemSayisi);
            DP.ExecuteReturn("SalonlarEY", param);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SalonNo", id);
            DP.ExecuteReturn("SalonlarDel", param);
            return RedirectToAction("Index");
        }
    }
}