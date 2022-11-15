using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaTro.DAL
{
    public class DichVuDAL
    {
        Connection con = new Connection();

        public DataTable LoadDichVu()
        {
            return con.LoadData("Select * from DichVu");
        }

    }
}
