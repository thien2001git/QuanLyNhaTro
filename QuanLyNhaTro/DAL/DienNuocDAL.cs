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
    public class DienNuocDAL
    {
        Connection con = new Connection();
        SqlConnection cn;

        public DataTable LoadDienNuoc()
        {
            return con.LoadData("getDienNuoc_info");
        }

        //thêm khách hàng
        public bool themDienNuoc(DienNuoc dn)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string strInsert = "Insert into DienNuoc values(@MaDN, @MaDV, @SoCu, @SoMoi, @NgayChot, @maPhong)";
                SqlCommand cmd = new SqlCommand(strInsert, cn);
                cmd.Parameters.AddWithValue("@MaDN", dn.MaDienNuoc);
                cmd.Parameters.AddWithValue("@MaDV", dn.MaDichVu);
                cmd.Parameters.AddWithValue("@SoCu", dn.SoCu);
                cmd.Parameters.AddWithValue("@SoMoi", dn.SoMoi);
                cmd.Parameters.AddWithValue("@NgayChot", dn.NgayChot);
                cmd.Parameters.AddWithValue("@maPhong", dn.MaPhongTro);
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
        public bool suaDienNuoc(DienNuoc dn)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string strInsert = "Update DienNuoc set  MADV=@MaDV, soCu=@SoCu, soMoi=@SoMoi, ngayChot=@NgayChot, MaPhongTro=@maPhong where MaDN=@MaDN ";
                SqlCommand cmd = new SqlCommand(strInsert, cn);
                cmd.Parameters.AddWithValue("@MaDN", dn.MaDienNuoc);
                cmd.Parameters.AddWithValue("@MaDV", dn.MaDichVu);
                cmd.Parameters.AddWithValue("@SoCu", dn.SoCu);
                cmd.Parameters.AddWithValue("@SoMoi", dn.SoMoi);
                cmd.Parameters.AddWithValue("@NgayChot", dn.NgayChot);
                cmd.Parameters.AddWithValue("@maPhong", dn.MaPhongTro);
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
        public bool xoaDienNuoc(DienNuoc dn)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string strInsert = "delete DienNuoc where MaDN=@MaDN ";
                SqlCommand cmd = new SqlCommand(strInsert, cn);
                cmd.Parameters.AddWithValue("@MaDN", dn.MaDienNuoc);
                cmd.Parameters.AddWithValue("@MaDV", dn.MaDichVu);
                cmd.Parameters.AddWithValue("@SoCu", dn.SoCu);
                cmd.Parameters.AddWithValue("@SoMoi", dn.SoMoi);
                cmd.Parameters.AddWithValue("@NgayChot", dn.NgayChot);
                cmd.Parameters.AddWithValue("@maPhong", dn.MaPhongTro);
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
        public DataTable TimKiemDienNuoc(int MaDN)
        {
            return con.LoadData("select * from DienNuoc where MaDN='" + MaDN + "'");
        }

        //Lấy số điện 
        public float getSodien(int MaDienNuoc)
        {
            float price = 0;
            cn = con.getConnection();
            try
            {
                cn.Open();
                string SQL = string.Format("select MaDN, (SoMoi - SoCu ) AS 'SodienSudung' from DienNuoc where MaDN='" + MaDienNuoc + "'");
                SqlCommand cmd = new SqlCommand(SQL, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        price = Convert.ToSingle(dr["SodienSudung"].ToString());
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

        //Lấy tiền  điện 
        public float getTienDien(int MaDienNuoc)
        {
            float price = 0;
            cn = con.getConnection();
            try
            {
                cn.Open();
                string SQL = string.Format("select maDN, (SoMoi - SoCu )*dv.Gia AS 'tienDien' from DienNuoc dn inner join DichVu dv on dv.MaDV = dn.MaDV where maDN = '"+ MaDienNuoc + "'");
                SqlCommand cmd = new SqlCommand(SQL, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        price = Convert.ToSingle(dr["tienDien"].ToString());
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

        //Lấy số nước 
        public float getSoNuoc(int MaDienNuoc)
        {
            float price = 0;
            cn = con.getConnection();
            try
            {
                cn.Open();
                string SQL = string.Format("select MaDN, (SoMoi - SoCu ) AS 'SoNuocSudung' from DienNuoc where MaDN='" + MaDienNuoc + "'");
                SqlCommand cmd = new SqlCommand(SQL, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        price = Convert.ToSingle(dr["SoNuocSudung"].ToString());
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

        //Lấy tiền nước 
        public float getTienNuoc(int MaDienNuoc)
        {
            float price = 0;
            cn = con.getConnection();
            try
            {
                cn.Open();
                string SQL = string.Format("select maDN, (SoMoi - SoCu )*dv.Gia AS 'tienNuoc' from DienNuoc dn inner join DichVu dv on dv.MaDV = dn.MaDV where maDN = '" + MaDienNuoc + "'");
                SqlCommand cmd = new SqlCommand(SQL, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        price = Convert.ToSingle(dr["tienNuoc"].ToString());
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
