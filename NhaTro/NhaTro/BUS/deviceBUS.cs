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
   public  class deviceBUS
    {
        deviceDAL dev = new deviceDAL();

        public DataTable LoadDevice()
        {
            return dev.LoadDevice();
        }

        public bool themDevice(device devi)
        {
            return dev.ThemDevice(devi);
        }

        public bool suaDevice(device devi)
        {
            return dev.suaDevice(devi);
        }

        public bool xoaDevice(device devi)
        {
            return dev.xoaDevice(devi);
        }

        public DataTable TimKiemDevice(int mathietbi)
        {
            return dev.TimekiemDevice(mathietbi);
        }
    }
}
