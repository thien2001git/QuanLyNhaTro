using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using NhaTro.BUS;
using System.Diagnostics.CodeAnalysis;

namespace NhaTro
{
    public partial class statistical : Form
    {
        public statistical()
        {
            InitializeComponent();
        }
        DanhThuBUS DT = new DanhThuBUS();

        //thoat
        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //button thong ke 
        private void bttThongKe_Click(object sender, EventArgs e)
        {
            if (dTPFromDate.Value != dTPNgayDen.Value)
            {
                DVThongKe.DataSource = DT.LoadDoanhThu(Convert.ToDateTime(dTPFromDate.Value.ToString("MM/dd/yyyy")), Convert.ToDateTime(dTPNgayDen.Value.ToString("MM/dd/yyyy")));
                txtTongTien.Text = Convert.ToString(DT.TongTien(Convert.ToDateTime(dTPFromDate.Value.ToString("MM/dd/yyyy")), Convert.ToDateTime(dTPNgayDen.Value.ToString("MM/dd/yyyy"))));
                MessageBox.Show("Thống kê thành công!");
            }
            else
            {
                MessageBox.Show("Thống kê thất bại!");
            }

        }

        private void statistical_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn quay lại ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
