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
using System.Runtime.InteropServices;
using NhaTro.DAO;

namespace NhaTro
{
    public partial class rent : Form
    {
        public rent()
        {
            InitializeComponent();
        }
        RomBUS rom = new RomBUS();
        ThuePhongBUS TP = new ThuePhongBUS();

        //load form
        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox_MaPhong();
        }

        //xoa textbox
        private void ThietLapText()
        {
            txtSoPhieuThue.Text = "";
            txtKhachHang.Clear();
            dtk_ngayTheu.Text = DateTime.Today.ToString();
            cbbMaPhong.SelectedIndex = -1;
            txtGiaPhong.Text = "";
            txtTienCoc.Text = "";
            cbbTrangThai.SelectedIndex = -1;
        }

        //lay thong tin phong nen comboBox
        private void comboBox_MaPhong()
        {
            cbbMaPhong.DataSource = rom.LoadDateRom();
            cbbMaPhong.DisplayMember = "TenPhongTro";
            cbbMaPhong.ValueMember = "MaPhongTro";
            cbbMaPhong.SelectedIndex = -1;
        }

        //button them 
        private void btt_Them_Click(object sender, EventArgs e)
        {
            if (txtSoPhieuThue.Text != "" && txtKhachHang.Text != "" && dtk_ngayTheu.Text != "" && cbbTrangThai.Text != "" && cbbMaPhong.Text != "" && txtGiaPhong.Text != "" && txtTienCoc.Text != "")
            {
                ThuePhong tp = new ThuePhong(Convert.ToInt32(txtSoPhieuThue.Text), txtKhachHang.Text, Convert.ToDateTime(dtk_ngayTheu.Value.ToString("MM/dd/yyyy")), cbbTrangThai.Text, Convert.ToInt32(cbbMaPhong.SelectedValue.ToString()), Convert.ToSingle(txtTienCoc.Text), Convert.ToSingle(txtGiaPhong.Text));
                if (TP.ThemThuePhong(tp))
                {
                    MessageBox.Show("Thêm thành công!");
                    ThietLapText();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin trước khi thuê phòng!");
            }

        }

        //button xoa text
        private void btt_xoa_Click(object sender, EventArgs e)
        {
            ThietLapText();
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rent_FormClosing_1(object sender, FormClosingEventArgs e)
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
