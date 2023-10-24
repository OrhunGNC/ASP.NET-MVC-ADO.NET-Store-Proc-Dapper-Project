using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace DapperProject.Models
{
    public class GorevliModel
    {
        public int GorevliNo { get; set; }
        public string AdSoyad { get; set; } 
        public int Yas { get; set; }
        public string Telefon { get; set; } 
        public string MesaiDurum { get; set; }  
        public decimal Maas { get ; set; }  
        public decimal Prim { get; set; }
        public int SalonNo { get; set; }
    }
}