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
    public class AccountBUS
    {
        AccountDAL acc = new AccountDAL();
        public bool getAccount1(Account ac)
        {
            return acc.getAccount(ac);
        }
        public DataTable LoadAccount()
        {
            return acc.LoadAccount();
        }
        public bool themAccount(Account ac)
        {
            return acc.ThemAccount(ac);
        }
        public bool suaAccount(Account ac)
        {
            return acc.suaAccount(ac);
        }
        public bool xoaAccount(Account ac)
        {
            return acc.xoaAccount(ac);
        }
        public DataTable timKiemAccount(string TenTaiKhoan)
        {
            return acc.TimekiemAccount(TenTaiKhoan);
        }

    }
}
