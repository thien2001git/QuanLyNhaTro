using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using NhaTro.BUS;
using NhaTro.DAO;

namespace NhaTro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        AccountBUS acc = new AccountBUS();

        //Đăng nhập
        private void bttLogin_Click(object sender, EventArgs e)
        {
            Main fmain = new Main();

            if (txtTenDN.Text == "")
            {
                MessageBox.Show("Hãy nhập vào tên đăng nhập! ");
            }
            else
            {
                if (txtPass.Text == "")
                    MessageBox.Show("Hãy nhập vào mật khẩu! ");
                else
                {
                    Account Ac = new Account(txtTenDN.Text, txtPass.Text);
                    if (acc.getAccount1(Ac))
                    {
                        MessageBox.Show("Đăng nhập thành công !");
                        txtTenDN.Clear();
                        txtPass.Clear();
                        fmain.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
                    }
                }
            }
        }

        // thoat ung dung
        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

      
    }
}
