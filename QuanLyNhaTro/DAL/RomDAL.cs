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
    class RomDAL
    {
        Connection con = new Connection();
        SqlConnection cn;

        //Lấy dữ liệu phòng trọ 
        public DataTable LoadDataRom()
        {
            return con.LoadData("Select * from PHONGTRO");

        }
        //thêm mới phòng trọ
        public bool themRom(Rom rom)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string SQL = string.Format("insert into PhongTro values(@MaPhongTro, @TenPhongTro, @DienTich, @LoaiPhong, @GiaPhong, @TrangThai)");
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.Parameters.AddWithValue("@MaPhongTro", rom.MaPhongTro);
                cmd.Parameters.AddWithValue("@TenPhongTro", rom.TenPhongTro);
                cmd.Parameters.AddWithValue("@DienTich", rom.DienTich);
                cmd.Parameters.AddWithValue("@LoaiPhong", rom.LoaiPhong);
                cmd.Parameters.AddWithValue("@GiaPhong", rom.GiaPhong);
                cmd.Parameters.AddWithValue("@TrangThai", rom.TrangThai);
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

        //sửa phòng trọ 
        public bool SuaRom(Rom rom)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string SQL = string.Format("UPDATE PhongTro SET TenPhongTro =@TenPhongTro,DienTich = @DienTich, LoaiPhong = @LoaiPhong, GiaPhong = @GiaPhong ,trangThai = @TrangThai where MaPhongTro =@MaPhongTro ");
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.Parameters.AddWithValue("@MaPhongTro", rom.MaPhongTro);
                cmd.Parameters.AddWithValue("@TenPhongTro", rom.TenPhongTro);
                cmd.Parameters.AddWithValue("@DienTich", rom.DienTich);
                cmd.Parameters.AddWithValue("@LoaiPhong", rom.LoaiPhong);
                cmd.Parameters.AddWithValue("@GiaPhong", rom.GiaPhong);
                cmd.Parameters.AddWithValue("@TrangThai", rom.TrangThai);
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
        //Xoa du Lieu
        public bool XoaRom(Rom rom)
        {
            cn = con.getConnection();
            try
            {
                cn.Open();
                string SQL = string.Format("DELETE FROM PhongTro where MaPhongTro =@MaPhongTro ");
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.Parameters.AddWithValue("@MaPhongTro", rom.MaPhongTro);
                cmd.Parameters.AddWithValue("@TenPhongTro", rom.TenPhongTro);
                cmd.Parameters.AddWithValue("@DienTich", rom.DienTich);
                cmd.Parameters.AddWithValue("@LoaiPhong", rom.LoaiPhong);
                cmd.Parameters.AddWithValue("@GiaPhong", rom.GiaPhong);
                cmd.Parameters.AddWithValue("@TrangThai", rom.TrangThai);
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

         public DataTable TimKiemRom(int Maphong)
        {
            return con.LoadData("Select * from PHONGTRO where MaPhongTro ='"+ Maphong +"' ");
        }

        public float getGiaPhong(string MaPhong)
        {
            float price = 0;
            cn = con.getConnection();
            try
            {
                cn.Open();
                string SQL = string.Format("select *  from PhongTro where MaPhongTro='" + MaPhong + "'");
                SqlCommand cmd = new SqlCommand(SQL, cn );
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        price = Convert.ToSingle(dr["GiaPhong"].ToString());
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
