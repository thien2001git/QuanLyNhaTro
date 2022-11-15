using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaTro.DAO
{
   public class ThuePhong
    {
		private int maSoThue;
		public int MaSoThue
        {
            get { return maSoThue; }
            set { maSoThue = value; }
        }

		private string khachHang;
		public string KhachHang
		{
			get { return khachHang; }
			set { khachHang = value; }
		}

		private DateTime ngayThue;
		public DateTime NgayThue
		{
			get { return ngayThue; }
			set { ngayThue = value; }
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

		private float tienCoc;
		public float TienCoc
        {
			get { return tienCoc; }
			set { tienCoc = value; }
		}

		private float giaPhong;
		public float GiaPhong
		{
			get { return giaPhong; }
			set { giaPhong = value; }
		}

		//method constructor
		public ThuePhong() { }

		public ThuePhong(int masothue, string khachhang, DateTime ngayThue, string trangThai, int maPhong, float tienCoc, float giaPhong)
        {
			this.maSoThue = masothue;
			this.khachHang = khachhang;
			this.ngayThue = ngayThue;
			this.trangThai = trangThai;
			this.maPhong = maPhong;
			this.tienCoc = tienCoc;
			this.giaPhong = giaPhong;
        }

	}
}
