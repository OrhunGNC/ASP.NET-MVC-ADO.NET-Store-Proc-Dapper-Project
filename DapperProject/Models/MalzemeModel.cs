using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace DapperProject.Models
{
    public class MalzemeModel
    {
        public int MalzemeNo { get; set; }
        public string MalzemeAdi { get; set; }
        public decimal MalzemeTutar { get; set; }
        public int HizmetNo { get; set; }
        public string Fayda { get; set; }
        public string Aciklama { get; set; }

    }
}