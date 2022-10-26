using NhaTro.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaTro.DAL
{
    public class HoaDonDAL
    {
        Connection con = new Connection();
        SqlConnection cn;

        public DataTable LoadBill()
        {
            return con.LoadData("getHoaDon_info");
        }

        //thêm hóa đơn
        public bool themHoaDon(HoaDon hd)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string str = "Insert into HoaDon values(@SoHD, @KhachHang, @NgayLap, @TrangThai, @MaPhongTro, @GiaPhong, @SoDienSuDung, @TienDien, @SoNuocSuDung, @TienNuoc)";
                SqlCommand cmd = new SqlCommand(str, cn);
                cmd.Parameters.AddWithValue("@SoHD", hd.SoHD);
                cmd.Parameters.AddWithValue("@KhachHang", hd.KhachHang);
                cmd.Parameters.AddWithValue("@NgayLap", hd.NgayLap);
                cmd.Parameters.AddWithValue("@TrangThai", hd.TrangThai);
                cmd.Parameters.AddWithValue("@MaPhongTro", hd.MaPhong);
                cmd.Parameters.AddWithValue("@GiaPhong", hd.GiaPhong);
                cmd.Parameters.AddWithValue("@SoDienSuDung", hd.SoDienSuDung);
                cmd.Parameters.AddWithValue("@TienDien", hd.TienDien);
                cmd.Parameters.AddWithValue("@SoNuocSuDung", hd.SoNuocSuDung);
                cmd.Parameters.AddWithValue("@TienNuoc", hd.TienNuoc);

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
        //Sửa hóa đơn
        public bool suaHoaDon(HoaDon hd)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string str = "Update HoaDon set KhachHang=@KhachHang, NgayLap=@NgayLap, TrangThai=@TrangThai, MaPhongTro=@MaPhongTro, GiaPhong=@GiaPhong, SoDienSuDung=@SoDienSuDung, TienDien=@TienDien, SoNuocSuDung=@SoNuocSuDung, TienNuoc=@TienNuoc where SoHD=@SoHD";
                SqlCommand cmd = new SqlCommand(str, cn);
                cmd.Parameters.AddWithValue("@SoHD", hd.SoHD);
                cmd.Parameters.AddWithValue("@KhachHang", hd.KhachHang);
                cmd.Parameters.AddWithValue("@NgayLap", hd.NgayLap);
                cmd.Parameters.AddWithValue("@TrangThai", hd.TrangThai);
                cmd.Parameters.AddWithValue("@MaPhongTro", hd.MaPhong);
                cmd.Parameters.AddWithValue("@GiaPhong", hd.GiaPhong);
                cmd.Parameters.AddWithValue("@SoDienSuDung", hd.SoDienSuDung);
                cmd.Parameters.AddWithValue("@TienDien", hd.TienDien);
                cmd.Parameters.AddWithValue("@SoNuocSuDung", hd.SoNuocSuDung);
                cmd.Parameters.AddWithValue("@TienNuoc", hd.TienNuoc);

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
        //Xóa hóa đơn
        public bool xoaHoaDon(HoaDon hd)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string str = "Delete HoaDon where SoHD=@SoHD";
                SqlCommand cmd = new SqlCommand(str, cn);
                cmd.Parameters.AddWithValue("@SoHD", hd.SoHD);
                cmd.Parameters.AddWithValue("@KhachHang", hd.KhachHang);
                cmd.Parameters.AddWithValue("@NgayLap", hd.NgayLap);
                cmd.Parameters.AddWithValue("@TrangThai", hd.TrangThai);
                cmd.Parameters.AddWithValue("@MaPhongTro", hd.MaPhong);
                cmd.Parameters.AddWithValue("@GiaPhong", hd.GiaPhong);
                cmd.Parameters.AddWithValue("@SoDienSuDung", hd.SoDienSuDung);
                cmd.Parameters.AddWithValue("@TienDien", hd.TienDien);
                cmd.Parameters.AddWithValue("@SoNuocSuDung", hd.SoNuocSuDung);
                cmd.Parameters.AddWithValue("@TienNuoc", hd.TienNuoc);

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

        public DataTable TimKiemHoaDon(int MaHD)
        {
            return con.LoadData("select hd.SoHD,KhachHang, hd.NgayLap, pt.MaPhongTro , pt.GiaPhong, hd.SoDienSuDung ,hd.TienDien, hd.SoNuocSuDung, hd.TienNuoc, (pt.GiaPhong + hd.TienDien + hd.TienNuoc) As 'ThanhTien', hd.TrangThai from HOADON hd inner join PHONGTRO pt on pt.MaPhongTro = hd.MaPhongTro where SoHD='"+MaHD+"'");
        }

    }
}
