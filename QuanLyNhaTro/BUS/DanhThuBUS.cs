using NhaTro.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaTro.BUS
{
    public class DanhThuBUS
    {
        DoanhThuDAL dt = new DoanhThuDAL();

        public DataTable LoadDoanhThu(DateTime toDate, DateTime formDate)
        {
            return dt.LoadThongKe(toDate, formDate);
        }

        public long TongTien(DateTime toDate, DateTime formDate)
        {
            return dt.TongTien(toDate, formDate);
        }
    }
}
