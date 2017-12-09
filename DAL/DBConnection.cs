using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
    public static class DBConnection
    {
        public static SqlConnection Connection()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            return con;
        }
    }
}
