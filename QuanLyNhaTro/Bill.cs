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
using NhaTro.DAO;
using NhaTro.BUS;

namespace NhaTro
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        RomBUS rom = new RomBUS();
        HoaDonBUS HD = new HoaDonBUS();
        DienNuocBUS DN = new DienNuocBUS();


        //load form
        private void Form4_Load(object sender, EventArgs e)
        {
            LoadBill();
            comboBox_MaPhong();
            doimau();
        }
        
        //method hien thi hoa don
        private void LoadBill()
        {
            dGVHoaDon.DataSource = HD.LoadBill();
        }

        //xoa textbox
        private void XoaText()
        {
            txtSoHoaDon.Text = "";
            txtKhachHang.Clear();
            dtk_ngayLap.Text = DateTime.Now.ToString();
            cbbTrangThai.Text = "";
            cbbMaPhong.SelectedIndex = -1;
            txtGiaPhong.Text = "";
            txtSoDien.Clear();
            txtTienDien.Text = "";
            txtSoNuoc.Text = "";
            txtTienNuoc.Text = "";
        }


        //ham hien thi thong tin phong tro nen comboBox
        private void comboBox_MaPhong()
        {

            cbbMaPhong.DataSource = rom.LoadDateRom() ;
            cbbMaPhong.DisplayMember = "MaPhongTro";
            cbbMaPhong.ValueMember = "MaPhongTro";
            cbbMaPhong.SelectedIndex = -1;
        }

        //ham doi mau hoa don chua thanh toan
        void doimau()
        {
            string st = "Chưa Thanh Toán ";
            for (int i = 0; i < dGVHoaDon.RowCount; i++)
            {
                if (dGVHoaDon.Rows[i].Cells["TrangThai"].Value.ToString() == st)
                    dGVHoaDon.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        //su kien cell click 
        private void dGVHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoHoaDon.Text = dGVHoaDon.CurrentRow.Cells["SoHD"].Value.ToString();
            txtKhachHang.Text = dGVHoaDon.CurrentRow.Cells["TenKH"].Value.ToString();
            dtk_ngayLap.Text = dGVHoaDon.CurrentRow.Cells["NgayLap"].Value.ToString();
            cbbTrangThai.Text = dGVHoaDon.CurrentRow.Cells["TrangThai"].Value.ToString();
            cbbMaPhong.Text = dGVHoaDon.CurrentRow.Cells["MaPhongTro"].Value.ToString();
            txtGiaPhong.Text = dGVHoaDon.CurrentRow.Cells["GiaPhong"].Value.ToString();
            txtSoDien.Text = dGVHoaDon.CurrentRow.Cells["SoDienSuDung"].Value.ToString();
            txtTienDien.Text = dGVHoaDon.CurrentRow.Cells["TienDien"].Value.ToString();
            txtSoNuoc.Text = dGVHoaDon.CurrentRow.Cells["SoNuocSuDung"].Value.ToString();
            txtTienNuoc.Text = dGVHoaDon.CurrentRow.Cells["TienNuoc"].Value.ToString();
        }

        //button them
        private void btt_Them_Click(object sender, EventArgs e)
        {
            if (txtSoHoaDon.Text != "" && txtKhachHang.Text != "" && dtk_ngayLap.Text != "" && cbbTrangThai.Text != "" && cbbMaPhong.Text != "" && txtGiaPhong.Text != "" && txtMaDien.Text != "" && txtMaNuoc.Text != "" && txtSoDien.Text != "" && txtTienDien.Text != "" && txtSoNuoc.Text != "" && txtTienNuoc.Text != "")
            {
                HoaDon hd = new HoaDon(Convert.ToInt32(txtSoHoaDon.Text), txtKhachHang.Text, Convert.ToDateTime(dtk_ngayLap.Value.ToString("MM/dd/yyyy")), cbbTrangThai.Text,Convert.ToInt32(cbbMaPhong.SelectedValue.ToString()), Convert.ToSingle(txtGiaPhong.Text), Convert.ToInt32(txtSoDien.Text), Convert.ToSingle(txtTienDien.Text), Convert.ToInt32(txtSoNuoc.Text), Convert.ToSingle(txtTienNuoc.Text));
                if (HD.themBill(hd))
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadBill();
                    doimau();
                    XoaText();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                } 
            }
            else
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin cần thêm mới!");
            }
        }

        //button sua
        private void btt_Sua_Click(object sender, EventArgs e)
        {
            if (txtSoHoaDon.Text != "" && txtKhachHang.Text != "" && dtk_ngayLap.Text != "" && cbbTrangThai.Text != "" && cbbMaPhong.Text != "" && txtGiaPhong.Text != "" && txtSoDien.Text != "" && txtTienDien.Text != "" && txtSoNuoc.Text != "" && txtTienNuoc.Text != "")
            {
                HoaDon hd = new HoaDon(Convert.ToInt32(txtSoHoaDon.Text), txtKhachHang.Text, Convert.ToDateTime(dtk_ngayLap.Value.ToString("MM/dd/yyyy")), cbbTrangThai.Text, Convert.ToInt32(cbbMaPhong.SelectedValue.ToString()), Convert.ToSingle(txtGiaPhong.Text), Convert.ToInt32(txtSoDien.Text), Convert.ToSingle(txtTienDien.Text), Convert.ToInt32(txtSoNuoc.Text), Convert.ToSingle(txtTienNuoc.Text));
                if (HD.suaBill(hd))
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadBill();
                    doimau();
                    XoaText();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin cần sửa!");
            }
        }

        //button xoa
        private void btt_xoa_Click(object sender, EventArgs e)
        {
            if (txtSoHoaDon.Text != "" )
            {
                HoaDon hd = new HoaDon(Convert.ToInt32(txtSoHoaDon.Text), txtKhachHang.Text, Convert.ToDateTime(dtk_ngayLap.Value.ToString("MM/dd/yyyy")), cbbTrangThai.Text, Convert.ToInt32(cbbMaPhong.SelectedValue.ToString()), Convert.ToSingle(txtGiaPhong.Text), Convert.ToInt32(txtSoDien.Text), Convert.ToSingle(txtTienDien.Text), Convert.ToInt32(txtSoNuoc.Text), Convert.ToSingle(txtTienNuoc.Text));
                if (HD.xoaBill(hd))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadBill();
                    doimau();
                    XoaText();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn hóa đơn cần xóa!");
            }
        }

        //button tim kiem
        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            if(txtSoHD.Text != "")
            {
                dGVHoaDon.DataSource = HD.TimKiemBill(Convert.ToInt32(txtSoHD.Text));
                doimau();
            }
            else
            {
                MessageBox.Show("Cần nhập thông tin trước tìm kiếm!");
            }
            txtSoHD.Text = "";
        }

        private void Bill_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaPhong.Text != "")
            {
                txtGiaPhong.Text = Convert.ToString(rom.getGiaPhong(cbbMaPhong.SelectedValue.ToString()));
            }
            else
            {
                txtGiaPhong.Clear();
            }
        }

        private void txtMaDien_TextChanged(object sender, EventArgs e)
        {
            if (txtMaDien.Text != "")
            {
                txtSoDien.Text = Convert.ToString(DN.getSoDien(Convert.ToInt32(txtMaDien.Text)));
                txtTienDien.Text = Convert.ToString(DN.getTienDien(Convert.ToInt32(txtMaDien.Text)));
            }
            else
            {
                txtSoDien.Clear();
                txtTienDien.Clear();
            }
        }

        private void txtMaNuoc_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNuoc.Text != "")
            {
                txtSoNuoc.Text = Convert.ToString(DN.getSoNuoc(Convert.ToInt32(txtMaNuoc.Text)));
                txtTienNuoc.Text = Convert.ToString(DN.getTienNuoc(Convert.ToInt32(txtMaNuoc.Text)));
            }
            else
            {
                txtSoNuoc.Clear();
                txtTienNuoc.Clear();
            }
        }
    }
}
