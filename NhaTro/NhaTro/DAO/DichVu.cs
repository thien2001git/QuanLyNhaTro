using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaTro.DAO
{
   public class DichVu
    {
        private int maDichVu;
        public int MaDichVu
        {
            get { return maDichVu; }
            set { maDichVu = value; }
        }

        private string tenDV;
        public string TenDV
        {
            get { return tenDV; }
            set { tenDV = value; }
        }

        private float gia;
        public float Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        //method constructor
        public DichVu() { }

        public DichVu(int madv, string tendv, float gia)
        {
            this.maDichVu = madv;
            this.tenDV = tendv;
            this.gia = gia;
        }
    }
}
