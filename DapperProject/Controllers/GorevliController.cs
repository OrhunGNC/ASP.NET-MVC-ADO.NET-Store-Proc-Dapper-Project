using System;
using DapperProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DapperProject.Controllers
{
    public class GorevliController : Controller
    {
        // GET: Gorevli
        public ActionResult Index()
        {
            return View(DP.Listeleme<GorevliModel>("ViewGorevliAll"));
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
                param.Add("@GorevliNo", id);
                return View(DP.Listeleme<GorevliModel>("ViewGorevliByNo", param).FirstOrDefault<GorevliModel>());
            }
        }
        [HttpPost]
        public ActionResult EY(GorevliModel gorevli)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@GorevliNo",gorevli.GorevliNo);
            param.Add("@AdSoyad",gorevli.AdSoyad);
            param.Add("@Yas",gorevli.Yas);
            param.Add("@Telefon",gorevli.Telefon);
            param.Add("@MesaiDurum",gorevli.MesaiDurum);
            param.Add("@Maas",gorevli.Maas);
            param.Add("@Prim",gorevli.Prim);
            param.Add("@SalonNo",gorevli.SalonNo);
            DP.ExecuteReturn("GorevliEY", param);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id=0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@GorevliNo", id);
            DP.ExecuteReturn("GorevliDel", param); 
            return RedirectToAction("Index");
        }
    }
}