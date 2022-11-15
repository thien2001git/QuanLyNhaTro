using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaTro.DAO
{
   public  class DienNuoc
    {
		private int maDienNuoc;
		public int MaDienNuoc
        {
            get { return maDienNuoc; }
            set { maDienNuoc = value; }
        }

		private int maDichVu;
		public int MaDichVu
        {
			get { return maDichVu; }
			set { maDichVu = value; }
		}

		private int soCu;
		public int SoCu
        {
			get { return soCu; }
			set { soCu = value; }
		}

		private int soMoi;
		public int SoMoi
		{
			get { return soMoi; }
			set { soMoi = value; }
		}

		private DateTime ngayChot;
		public DateTime NgayChot
		{
			get { return ngayChot; }
			set { ngayChot = value; }
		}


		private int maPhongTro;
		public int MaPhongTro
		{
			get { return maPhongTro; }
			set { maPhongTro = value; }
		}

		//method constructor
		public DienNuoc() { }

		public DienNuoc(int madiennuoc, int madichvu, int socu, int somoi, DateTime ngaychot, int maphongtro)
        {
			this.maDienNuoc = madiennuoc;
			this.maDichVu = madichvu;
			this.soCu = socu;
			this.soMoi = somoi;
			this.ngayChot = ngaychot;
			this.maPhongTro = maphongtro;
        }
	}
}
