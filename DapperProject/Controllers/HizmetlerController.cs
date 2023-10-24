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
    public class HizmetlerController : Controller
    {
        // GET: Hizmetler
        public ActionResult Index()
        {
            return View(DP.Listeleme<HizmetlerModel>("ViewHizmetlerAll"));
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
                param.Add("@HizmetNo", id);
                return View(DP.Listeleme<HizmetlerModel>("ViewHizmetlerByNo", param).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult EY(HizmetlerModel hizmetler)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@HizmetNo", hizmetler.HizmetNo);
            param.Add("@HizmetAdi", hizmetler.HizmetAdi);
            param.Add("@HizmetAmaci", hizmetler.HizmetAmaci);
            param.Add("@HizmetTutar", hizmetler.HizmetTutar);
            param.Add("@OdemeTuru", hizmetler.OdemeTuru);
            param.Add("@GorevliNo", hizmetler.GorevliNo);
            DP.ExecuteReturn("HizmetlerEY", param);
            return RedirectToAction("Index");
        }
        public ActionResult Delete (int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@HizmetNo", id);
            DP.ExecuteReturn("HizmetlerDel", param);
            return RedirectToAction("Index");
        }
    }
}