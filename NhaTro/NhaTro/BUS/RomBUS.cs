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
    class RomBUS
    {
        RomDAL rom = new RomDAL();

        public DataTable LoadDateRom()
        {
            return rom.LoadDataRom();
        }
        public bool themRom(Rom rm)
        {
            return rom.themRom(rm);
        }

        public bool suaRom(Rom rm)
        {
            return rom.SuaRom(rm);
        }
        public bool xoaRom(Rom rm)
        {
            return rom.XoaRom(rm);
        }
        public DataTable Timkiem(int Maphong)
        {
            return rom.TimKiemRom(Maphong);
        }
        public float getGiaPhong(string st)
        {
            return rom.getGiaPhong(st);
        }
    }
}
