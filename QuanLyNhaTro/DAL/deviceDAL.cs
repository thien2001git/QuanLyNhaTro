using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhaTro.DAO;

namespace NhaTro.DAL
{
    public class deviceDAL
    {
        Connection con = new Connection();
        SqlConnection cn;

        public DataTable LoadDevice()
        {
            return con.LoadData("Select * from Thietbi");
        }

        //Thêm thiết bị
        public bool ThemDevice(device dev)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string strSQL = "Insert into ThietBi values(@mathietbi, @tenthietbi)";
                SqlCommand cmd = new SqlCommand(strSQL, cn);
                cmd.Parameters.AddWithValue("@mathietbi", dev.MaThietBi);
                cmd.Parameters.AddWithValue("@tenthietbi", dev.TenThietBi);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                cn.Close();
            }
            return false;
        }

        //Sửa thiết bị 
        public bool suaDevice(device dev)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string strUpdate = "Update Thietbi set tenThietbi = @tenthietbi where mathietbi = @mathietbi";
                SqlCommand cmd = new SqlCommand(strUpdate, cn);
                cmd.Parameters.AddWithValue("@tenthietbi", dev.TenThietBi);
                cmd.Parameters.AddWithValue("@mathietbi", dev.MaThietBi);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                cn.Close();
            }
            return false;
        }
        //xoa thiet bi
        public bool xoaDevice(device dev)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string strUpdate = "delete Thietbi  where mathietbi = @mathietbi";
                SqlCommand cmd = new SqlCommand(strUpdate, cn);
                cmd.Parameters.AddWithValue("@tenthietbi", dev.TenThietBi);
                cmd.Parameters.AddWithValue("@mathietbi", dev.MaThietBi);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                cn.Close();
            }
            return false;
        }
        //tìm kiếm
        public DataTable TimekiemDevice(int mathietBi)
        {
            return con.LoadData("Select * from Thietbi where mathietbi = '"+ mathietBi +"'");
        }
    }
}
