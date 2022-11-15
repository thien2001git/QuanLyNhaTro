using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaTro.DAO
{
   public class KhachHang
    {
		private int maKH;
		public int MAKH
        {
			get { return maKH; }
            set { maKH = value; }
        }

		private string tenKH;
		public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

		private string gioiTinh;
		public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        private DateTime ngaySinh;
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        private string sdt;
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        //method constructor
        public KhachHang() { }

        public KhachHang(int makh, string tenkh, string gioitinh, DateTime ngaysinh, string diachi, string sdt)
        {
            this.maKH = makh;
            this.tenKH = tenkh;
            this.gioiTinh = gioitinh;
            this.ngaySinh = ngaysinh;
            this.diaChi = diachi;
            this.sdt = sdt;
        }
   
    }
}
