using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaTro.DAL
{
    public class Connection
    {
        SqlConnection con;

        public SqlConnection getConnection()
        {
            string st = ConfigurationManager.ConnectionStrings["QLNT"].ToString();
            con = new SqlConnection(st);
            return con;
        }

        //lấy dữ liệu 
        public DataTable LoadData(string sql)
        {
            getConnection().Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            getConnection().Close();
            return dt;
        }
    }
}
