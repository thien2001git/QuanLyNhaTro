using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaTro.DAO
{
    public class HoaDon
    {
		private int soHD;
		public int SoHD
		{
			get { return soHD; }
			set { soHD = value; }
		}

		private string khachHang;
		public string KhachHang
		{
			get { return khachHang; }
			set { khachHang = value; }
		}

		private DateTime ngayLap;
		public DateTime NgayLap
		{
			get { return ngayLap; }
			set { ngayLap = value; }
		}

		private string trangThai;
		public string TrangThai
		{
			get { return trangThai; }
			set { trangThai = value; }
		}

		private int maPhong;
		public int MaPhong
		{
			get { return maPhong; }
			set { maPhong = value; }
		}

        private float giaPhong;
        public float GiaPhong
        {
            get { return giaPhong; }
            set { giaPhong = value; }
        }

		private int soDienSuDung;
		public int SoDienSuDung
		{
			get { return soDienSuDung; }
			set { soDienSuDung = value; }
		}

		private float tienDien;
		public float TienDien
		{
			get { return tienDien; }
			set { tienDien = value; }
		}

		private int soNuocSuDung;
		public int SoNuocSuDung
		{
			get { return soNuocSuDung; }
			set { soNuocSuDung = value; }
		}

		private float tienNuoc;
		public float TienNuoc
		{
			get { return tienNuoc; }
			set { tienNuoc = value; }
		}

		//method constructor
		public HoaDon() { }

		public HoaDon(int soHD, string khachhang, DateTime ngayLap, string trangThai, int maPhong, float giaPhong, int sodiensd, float tiendien, int sonuocsd, float tiennuoc)
		{
			this.soHD = soHD;
			this.khachHang = khachhang;
			this.ngayLap = ngayLap;
			this.trangThai = trangThai;
			this.maPhong = maPhong;
			this.giaPhong = giaPhong;
			this.soDienSuDung = sodiensd;
			this.tienDien = tiendien;
			this.soNuocSuDung = sonuocsd;
			this.tienNuoc = tiennuoc;
		}
	
	}
}
