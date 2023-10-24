using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace DapperProject.Models
{
    public class HizmetlerModel
    {
        public int HizmetNo { get; set; }
        public string HizmetAdi { get; set; }   
        public string HizmetAmaci { get; set; }
        public decimal HizmetTutar { get; set; }
        public string OdemeTuru { get; set; }
        public int GorevliNo { get; set; }

    }
}