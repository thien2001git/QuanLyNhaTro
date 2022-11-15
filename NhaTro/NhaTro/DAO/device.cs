using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaTro.DAO
{
   public class device
    {
        private int maThietBi;
        public int MaThietBi
        {
            get { return maThietBi; }
            set { maThietBi = value; }
        }

        private string tenThietBi;
        public string TenThietBi
        {
            get { return tenThietBi; }
            set { tenThietBi = value; }
        }

        //methods constructor
        public device() { }
        public device(int maThietBi, string tenThietBi)
        {
            this.MaThietBi = maThietBi;
            this.TenThietBi = tenThietBi;
        }
    }
}
