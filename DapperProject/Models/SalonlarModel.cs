using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace DapperProject.Models
{
    public class SalonlarModel
    {
        public int SalonNo { get; set; }
        public string SalonAdi { get; set; }    
        public int SalonKapiNo { get; set; }
        public string YapilanIslem { get; set; }
        public int IslemSayisi { get; set; }
    }
}