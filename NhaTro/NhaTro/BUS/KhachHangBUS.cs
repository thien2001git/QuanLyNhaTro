using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhaTro.DAL;
using NhaTro.DAO;

namespace NhaTro.BUS
{
    class KhachHangBUS
    {
        KhachHangDAL KH = new KhachHangDAL();
        public DataTable LoadCustomer()
        {
            return KH.LoadCustomer();
        }
        public bool ThemCustomer(KhachHang kh)
        {
            return KH.themCustomer(kh);
        }

        public bool SuaCustomer(KhachHang kh)
        {
            return KH.suaCustomer(kh);
        }

        public bool xoaCustomer(KhachHang kh)
        {
            return KH.xoaCustomer(kh);
        }

        public DataTable TimKiemCustomer(int MaKH)
        {
            return KH.TimKiemCustomer(MaKH);
        }
    }
}
