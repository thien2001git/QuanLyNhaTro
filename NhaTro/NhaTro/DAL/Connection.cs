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
        static SqlConnection con;
        public static string CON_STR = "Data Source=DESKTOP-FSBNR5D;Initial Catalog=QLPhongTro;Integrated Security=True"; 
        public SqlConnection getConnection()
        {
            
            con = new SqlConnection(CON_STR);
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
