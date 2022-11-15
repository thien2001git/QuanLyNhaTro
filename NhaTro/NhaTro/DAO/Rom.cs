using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaTro.DAO
{
   public class Rom
    {
		private int maPhongTro;
		public int MaPhongTro
        {
            get { return maPhongTro; }
            set { maPhongTro = value; }
        }

		private string tenPhongTro;
		public string TenPhongTro
        {
            get { return tenPhongTro; }
            set { tenPhongTro = value; }
        }

        private float dienTich;
        public float DienTich
        {
            get { return dienTich; }
            set { dienTich = value; }
        }

        private string loaiPhong;
        public string LoaiPhong
        {
            get { return loaiPhong; }
            set { loaiPhong = value; }
        }

        private float giaPhong;
        public float GiaPhong
        {
            get { return giaPhong; }
            set { giaPhong = value; }
        }

        private string trangThai;
        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        //methods constructor 
        public Rom() { }

        public Rom(int maPhong, string tenPhongTro, float dienTich, string loaiPhong, float giaPhong, string trangThai)
        {
            this.MaPhongTro = maPhong;
            this.TenPhongTro = tenPhongTro;
            this.DienTich = dienTich;
            this.LoaiPhong = loaiPhong;
            this.GiaPhong = giaPhong;
            this.trangThai = trangThai;
        }

        public Rom(string tenPhongTro, float dienTich, string loaiPhong, float giaPhong)
        {
            this.TenPhongTro = tenPhongTro;
            this.DienTich = dienTich;
            this.LoaiPhong = loaiPhong;
            this.GiaPhong = giaPhong;
        }

        public Rom(DataRow row)
        {
            this.MaPhongTro = (int)row["MaPhongTro"];
            this.TenPhongTro = row["TenPhongTro"].ToString();
            this.DienTich = float.Parse(row["DienTich"].ToString());
            this.LoaiPhong = row["LoaiPhong"].ToString();
            this.GiaPhong = float.Parse(row["GiaPhong"].ToString());
            this.TrangThai = row["TrangThai"].ToString();
        }

    }
}
