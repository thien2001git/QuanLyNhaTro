using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace NhaTro
{
   public  class Phong
    {
        private int? maphong;
        public int? MaPhong
        {
            get { return maphong; }
            set {maphong = value; }
        }

        private string tenphong;
        public string TenPhong 
        {
            get{ return tenphong; }
            set { tenphong = value; }
        }

        private float dientich;
        public float DienTich 
        {
            get { return dientich; }
            set{ dientich = value; }
        }

        private string loaiphong;
        public string LoaiPhong
        {
            get {return loaiphong ; }
            set {loaiphong = value; }
        }

        private float giaphong;
        public float GiaPhong
        {
            get { return giaphong; }
            set { giaphong = value; }
        }
        private string trangThai;
        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        //method constructor
        public Phong(int MaPhong, string TenPhong, float DienTich, string LoaiPhong, float GiaPhong, string trangThai)
        {
            this.MaPhong = MaPhong;
            this.TenPhong = TenPhong;
            this.DienTich = DienTich;
            this.LoaiPhong = LoaiPhong;
            this.GiaPhong = GiaPhong;
            this.trangThai = trangThai;
        }
        public Phong(DataRow row)
        {
            this.MaPhong = (int)row["MaPhongTro"];
            this.TenPhong = row["TenPhongTro"].ToString();
            this.DienTich = float.Parse(row["DienTich"].ToString());
            this.LoaiPhong = row["LoaiPhong"].ToString();
            this.GiaPhong = float.Parse(row["GiaPhong"].ToString());
            this.TrangThai = row["TrangThai"].ToString();
        }
    }
}
