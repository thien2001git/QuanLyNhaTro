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
    public class ThuePhongBUS
    {
        ThuePhongDAL TP = new ThuePhongDAL();

        public DataTable LoadThuePhong()
        {
            return TP.LoadThuePhong();
        }

        public bool ThemThuePhong(ThuePhong tp)
        {
            return TP.themThuePhong(tp);
        }

        public bool suaThuePhong(ThuePhong tp)
        {
            return TP.suaThuePhong(tp);
        }

        public bool xoaThuePhong(ThuePhong tp)
        {
            return TP.xoaThuePhong(tp);
        }

        public DataTable timKiemThuePhong(int mathue)
        {
            return TP.timKiemThuePhong(mathue);
        }
    }
}
