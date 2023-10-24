using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data.SqlClient;
namespace DapperProject.Models
{
    public class DP
    {
        public static string connectionString = @"Server=DESKTOP-4B2QQPV\SQLKODLAB;Database=Proje;Integrated Security=true;";
        public static void ExecuteReturn(string procadi,DynamicParameters param = null)
        {
            using(SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();
                db.Execute(procadi, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public static IEnumerable<T> Listeleme<T>(string procadi,DynamicParameters param = null)
        {
            using(SqlConnection db =new SqlConnection(connectionString))
            {
                db.Open();
                return db.Query<T>(procadi, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}