using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaTro.DAL
{
    public class DoanhThuDAL
    {
        Connection con = new Connection();
        SqlConnection cn;

        public DataTable LoadThongKe(DateTime ToDate, DateTime FormDate)
        {
            string str = "select SoHD, MaPhongTro, NgayLap, (GiaPhong + TienDien + TienNuoc) As 'ThanhTien' from HOADON where NgayLap between '" + ToDate + "' and '" + FormDate + "'";
            return con.LoadData(str);
        }

        public long TongTien(DateTime ToDate, DateTime FormDate)
        {
            long price = 0;
            cn = con.getConnection();
            try
            {
                cn.Open();
                string SQL = string.Format("select SUM(GiaPhong + TienDien + TienNuoc) As 'SoLuong' from HOADON  where NgayLap between '" + ToDate + "' and '" + FormDate + "'");
                SqlCommand cmd = new SqlCommand(SQL, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        price = Convert.ToInt64(dr["SoLuong"].ToString());
                    }
                }
                
            }
            catch (Exception)
            {
                //
            }
            finally
            {
                cn.Close();
            }
            return price;
        }
    }
}
