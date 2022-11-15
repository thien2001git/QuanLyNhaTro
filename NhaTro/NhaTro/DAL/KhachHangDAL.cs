using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using NhaTro.DAO;
namespace NhaTro.DAL
{
  public  class KhachHangDAL
    {
        Connection con = new Connection();
        SqlConnection cn;

        public DataTable LoadCustomer()
        {
            return con.LoadData("select * from KhachHang");
        }

        //thêm khách hàng
        public bool themCustomer(KhachHang kh)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string strInsert = "Insert into KhachHang values(@MaKh, @TenKH, @gioitinh, @ngaySinh, @diachi, @sdt)";
                SqlCommand cmd = new SqlCommand(strInsert, cn);
                cmd.Parameters.AddWithValue("@Makh", kh.MAKH);
                cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                cmd.Parameters.AddWithValue("@gioitinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@ngaySinh", kh.NgaySinh);
                cmd.Parameters.AddWithValue("@diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", kh.SDT);
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

        //sua thong tin khach hang
        public bool suaCustomer(KhachHang kh)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string strInsert = "Update KhachHang set TenKH=@TenKH, GioiTinh=@gioitinh, NgaySinh=@ngaySinh, DiaChi=@diachi, SDT=@sdt where maKH=@MaKh ";
                SqlCommand cmd = new SqlCommand(strInsert, cn);
                cmd.Parameters.AddWithValue("@Makh", kh.MAKH);
                cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                cmd.Parameters.AddWithValue("@gioitinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@ngaySinh", kh.NgaySinh);
                cmd.Parameters.AddWithValue("@diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", kh.SDT);
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
        //xoa khach hang

        public bool xoaCustomer(KhachHang kh)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string strInsert = "delete KhachHang where makh=@MaKh";
                SqlCommand cmd = new SqlCommand(strInsert, cn);
                cmd.Parameters.AddWithValue("@Makh", kh.MAKH);
                cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                cmd.Parameters.AddWithValue("@gioitinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@gaySinh", kh.NgaySinh);
                cmd.Parameters.AddWithValue("@daichi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", kh.SDT);
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
        //Tim kiem khach hang
        public DataTable TimKiemCustomer(int maKh)
        {
            return con.LoadData("select * from Khachhang where makh='" + maKh + "'");
        }
    }
}
