using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlHandler
    {
        public void ExecuteNonQuery(string query, List<KeyValuePair<string, object>> param)
        {
            using (SqlConnection con = DBConnection.Connection())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var spParam in param)
                    {
                        cmd.Parameters.Add(new SqlParameter()
                        {
                            ParameterName = spParam.Key,
                            Value = spParam.Value
                        });
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<object> ExecuteAsList(string query, KeyValuePair<string, object>[] param)
        {
            List<object> dataList = new List<object>();
            using (SqlConnection con = DBConnection.Connection())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var spParam in param)
                    {
                        cmd.Parameters.Add(new SqlParameter()
                        {
                            ParameterName = spParam.Key,
                            Value = spParam.Value
                        });
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataList.Add(reader);
                        }
                    }
                }
            }
            return dataList;
        }
    }
}
