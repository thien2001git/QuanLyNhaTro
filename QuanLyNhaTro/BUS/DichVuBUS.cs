using NhaTro.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaTro.BUS
{
   public  class DichVuBUS
    {
        DichVuDAL dv = new DichVuDAL();
        public DataTable LoadDichVu()
        {
            return dv.LoadDichVu();
        }
    }
}
