using NhaTro.DAL;
using NhaTro.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaTro.BUS
{
    class HoaDonBUS
    {
        HoaDonDAL HD = new HoaDonDAL();
        public DataTable LoadBill()
        {
            return HD.LoadBill();
        }

        public bool themBill(HoaDon hd)
        {
            return HD.themHoaDon(hd);
        }

        public bool suaBill(HoaDon hd)
        {
            return HD.suaHoaDon(hd);
        }

        public bool xoaBill(HoaDon hd)
        {
            return HD.xoaHoaDon(hd);
        }

        public DataTable TimKiemBill(int ma)
        {
            return HD.TimKiemHoaDon(ma);
        }
    }
}
