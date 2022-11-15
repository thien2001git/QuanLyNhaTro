using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaTro.DAO
{
    public class Account
    {
        private string tenTaiKhoan ; 
        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }
        private string matKhau;
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        private string sdt;
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Account() { }

        public Account(string tenTaiKhoan, string matKhau, string sdt, string email)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.sdt = sdt;
            this.email = email;
        }
        public Account(string tenTaiKhoan, string matKhau)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
        }
    }
}
