using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhaTro.DAO;

namespace NhaTro.DAL
{
    public class AccountDAL
    {
        Connection con = new Connection();
        SqlConnection cn;
        public bool getAccount(Account acc)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string SQL = string.Format("SELECT * FROM TaiKhoan WHERE TenTaiKhoan =@TenTaiKhoan and MatKhau= @MatKhau");
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.Parameters.AddWithValue("@TenTaiKhoan", acc.TenTaiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", acc.MatKhau);
                SqlDataReader ad = cmd.ExecuteReader();
                if (ad.Read() != false)
                    return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối!xin vui lòng kiểm tra lại");
            }
            finally
            {
                cn.Close();
            }
            return false;
        }
        public DataTable LoadAccount()
        {
            return con.LoadData("Select * from TaiKhoan");
        }
        //them tai khoan
        public bool ThemAccount(Account acc)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string strSQL = "Insert into TaiKhoan values(@TenTaiKhoan, @MatKhau, @sdt, @email )";
                SqlCommand cmd = new SqlCommand(strSQL, cn);
                cmd.Parameters.AddWithValue("@TenTaiKhoan", acc.TenTaiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", acc.MatKhau);
                cmd.Parameters.AddWithValue("@sdt", acc.SDT);
                cmd.Parameters.AddWithValue("@email", acc.Email);
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
        public bool suaAccount(Account acc)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string strUpdate = "Update TaiKhoan set matKhau = @matKhau, sdt = @sdt, email = @email where tenTaiKhoan = @tenTaiKhoan";
                SqlCommand cmd = new SqlCommand(strUpdate, cn);
                cmd.Parameters.AddWithValue("@TenTaiKhoan", acc.TenTaiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", acc.MatKhau);
                cmd.Parameters.AddWithValue("@sdt", acc.SDT);
                cmd.Parameters.AddWithValue("@email", acc.Email);
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
        public bool xoaAccount(Account acc)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string strUpdate = "delete TaiKhoan where tenTaiKhoan = @tenTaiKhoan";
                SqlCommand cmd = new SqlCommand(strUpdate, cn);
                cmd.Parameters.AddWithValue("@TenTaiKhoan", acc.TenTaiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", acc.MatKhau);
                cmd.Parameters.AddWithValue("@sdt", acc.SDT);
                cmd.Parameters.AddWithValue("@email", acc.Email);
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
        public DataTable TimekiemAccount(string TenTaiKhoan)
        {
            return con.LoadData("Select * from TaiKhoan where TenTaiKhoan = '" + TenTaiKhoan + "'");
        }

    }
}
