using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhaTro.DAL;
using NhaTro.DAO;

namespace NhaTro.DAL
{
   public class ThuePhongDAL
    {
        Connection con = new Connection();
        SqlConnection cn;

        public DataTable LoadThuePhong()
        {
            return con.LoadData("Select * from ThuePhong");
        }

        //them phong
        public bool themThuePhong(ThuePhong tp)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string str = "Insert into ThuePhong values(@masothue, @khachhang, @ngayThue, @trangThai, @maPhong, @tienCoc, @giaPhong)";
                SqlCommand cmd = new SqlCommand(str, cn);
                cmd.Parameters.AddWithValue("@masothue", tp.MaSoThue);
                cmd.Parameters.AddWithValue("@khachhang", tp.KhachHang);
                cmd.Parameters.AddWithValue("@ngayThue", tp.NgayThue);
                cmd.Parameters.AddWithValue("@trangThai", tp.TrangThai);
                cmd.Parameters.AddWithValue("@maPhong", tp.MaPhong);
                cmd.Parameters.AddWithValue("@tienCoc", tp.TienCoc);
                cmd.Parameters.AddWithValue("@giaPhong", tp.GiaPhong);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception)
            {

            }
            finally
            {
                cn.Close();
            }
            return false;
        }
        //sua phong
        public bool suaThuePhong(ThuePhong tp)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string str = "Update ThuePhong set  KhachHang=@khachhang, NgayThue=@ngayThue, trangThai=@trangThai, MaPhongTro=@maPhong, TienCoc=@tienCoc, GiaPhong=@giaPhong where MaSoThue=@masothue";
                SqlCommand cmd = new SqlCommand(str, cn);
                cmd.Parameters.AddWithValue("@masothue", tp.MaSoThue);
                cmd.Parameters.AddWithValue("@khachhang", tp.KhachHang);
                cmd.Parameters.AddWithValue("@ngayThue", tp.NgayThue);
                cmd.Parameters.AddWithValue("@trangThai", tp.TrangThai);
                cmd.Parameters.AddWithValue("@maPhong", tp.MaPhong);
                cmd.Parameters.AddWithValue("@tienCoc", tp.TienCoc);
                cmd.Parameters.AddWithValue("@giaPhong", tp.GiaPhong);
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
        //xoa phong 
        public bool xoaThuePhong(ThuePhong tp)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string str = "Delete ThuePhong where MaSoThue=@masothue";
                SqlCommand cmd = new SqlCommand(str, cn);
                cmd.Parameters.AddWithValue("@masothue", tp.MaSoThue);
                cmd.Parameters.AddWithValue("@khachhang", tp.KhachHang);
                cmd.Parameters.AddWithValue("@ngayThue", tp.NgayThue);
                cmd.Parameters.AddWithValue("@trangThai", tp.TrangThai);
                cmd.Parameters.AddWithValue("@maPhong", tp.MaPhong);
                cmd.Parameters.AddWithValue("@tienCoc", tp.TienCoc);
                cmd.Parameters.AddWithValue("@giaPhong", tp.GiaPhong);
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
        //tim kiếm
        public DataTable timKiemThuePhong(int MaThue)
        {
            return con.LoadData("Select * from ThuePhong where MaSoThue = "+ MaThue +"");
        }
    }
}
