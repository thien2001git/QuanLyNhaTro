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
   public  class DienNuocBUS
    {
        DienNuocDAL dn = new DienNuocDAL();
        public DataTable LoadDienNuoc()
        {
            return dn.LoadDienNuoc();
        }

        public bool ThemDienNuoc(DienNuoc DN)
        {
            return dn.themDienNuoc(DN);
        }

        public bool SuaDienNuoc(DienNuoc DN)
        {
            return dn.suaDienNuoc(DN);
        }

        public bool XoaDienNuoc(DienNuoc DN)
        {
            return dn.xoaDienNuoc(DN);
        }

        public DataTable TimKiemDienNuoc(int madn)
        {
            return dn.TimKiemDienNuoc(madn);
        }

        public float getSoDien(int madn)
        {
            return dn.getSodien(madn);
        }

        public float getTienDien(int madn)
        {
            return dn.getTienDien(madn);
        }

        public float getSoNuoc(int madn)
        {
            return dn.getSoNuoc(madn);
        }

        public float getTienNuoc(int madn)
        {
            return dn.getTienNuoc(madn);
        }

    }
}
