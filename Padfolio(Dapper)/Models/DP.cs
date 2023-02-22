using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Padfolio_Dapper_.Models
{
    public class DP
    {
        private static string connectionString =
            @"Server=DESKTOP-V44T9NQ\SQLEXPRESS;Database=Padfolio;Integrated Security=true;";
        public static void EXReturn(String procadi, DynamicParameters param = null)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                baglanti.Execute(procadi, param, commandType: CommandType.StoredProcedure);
            }
        }

        public static IEnumerable<T> ReturnList<T>(string procadi, DynamicParameters param = null)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                return baglanti.Query<T>(procadi, param, commandType:
                    CommandType.StoredProcedure);
            }
        }
    }
}