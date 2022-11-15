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
    public partial class Manager : Form
    {
        RomBUS rom = new RomBUS();
        deviceBUS dev = new deviceBUS();
        AccountBUS Acc = new AccountBUS();
        KhachHangBUS KH = new KhachHangBUS();
        DichVuBUS DV = new DichVuBUS();
        DienNuocBUS DN = new DienNuocBUS();
        ThuePhongBUS TP = new ThuePhongBUS();

        public Manager()
        {
            InitializeComponent();
        }

        //load form
        private void Form3_Load(object sender, EventArgs e)
        {
            LoadRom();
            LoadDevice();
            LoadAccount();
            LoadCustomer();
            LoadDienNuoc();
            LoadThuePhong();
            doimau();
            ComboboxDichVu();
            ComboboxMaPhong();
            comboBox_MaPhong();
        }

        //1.Quan Ly Phong Tro

        //method xoa textbox
        private void XoaText1()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtDienTich.Text = "";
            txtLoaiPhong.Text = "";
            txtGiaPhong.Text = "";
            cbB_TrangThai.SelectedIndex = -1;
        }

        //method hien thi len dataGridView Phong Tro
        private void LoadRom()
        {
            dGVPhongTro.DataSource = rom.LoadDateRom();
        }

        //button them phong tro
        private void bttThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text != "" && txtTenPhong.Text != "" && txtDienTich.Text != "" && txtLoaiPhong.Text != "" && txtGiaPhong.Text != "")
            {
                Rom rm = new Rom(Convert.ToInt32(txtMaPhong.Text), txtTenPhong.Text,Convert.ToSingle(txtDienTich.Text), txtLoaiPhong.Text,Convert.ToSingle(txtGiaPhong.Text), cbB_TrangThai.Text);
                //them tai khoan
                if (rom.themRom(rm))
                {
                    MessageBox.Show("Thêm Thành Công!");
                    LoadRom();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công ");
                }
                XoaText1();
            }
            else
            {
                MessageBox.Show("Cần nhập thông tin đầy đủ trước khi thêm!");
            } 
        }

        //button sua phong tro
        private void bttSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text != "" && txtTenPhong.Text != "" && txtDienTich.Text != "" && txtLoaiPhong.Text != "" && txtGiaPhong.Text != "")
            {
                Rom rm = new Rom(Convert.ToInt32(txtMaPhong.Text), txtTenPhong.Text, Convert.ToSingle(txtDienTich.Text), txtLoaiPhong.Text, Convert.ToSingle(txtGiaPhong.Text),cbB_TrangThai.Text);
                if (rom.suaRom(rm))
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadRom();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!");
                }
                XoaText1();
            }
            else
            {
                MessageBox.Show("Hãy chọn Tài Khoản Muốn sửa!");
            }
        }

        //button xoa phong tro
        private void bttXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Trim() != "")
            {
                Rom rm = new Rom(Convert.ToInt32(txtMaPhong.Text), txtTenPhong.Text, Convert.ToSingle(txtDienTich.Text), txtLoaiPhong.Text, Convert.ToSingle(txtGiaPhong.Text), cbB_TrangThai.Text);
                if (rom.xoaRom(rm))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadRom();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
                XoaText1();
            }

            else
            {
                MessageBox.Show("Hãy chọn phòng muốn xóa");
            }
        }

        //button tim kiem ma phong tro
        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            if(txtMaPhongtk.Text != "")
            {
                dGVPhongTro.DataSource = rom.Timkiem(Convert.ToInt32(txtMaPhongtk.Text));
            }  
            else
            {
                MessageBox.Show("Hãy nhập mã phòng để tìm kiếm!");
            }    
            txtMaPhongtk.Text = "";
        }

        //su kiem cell click 
        private void dGVPhongTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhong.Text = dGVPhongTro.CurrentRow.Cells["MaPhongTro"].Value.ToString();
            txtTenPhong.Text = dGVPhongTro.CurrentRow.Cells["TenPhongTro"].Value.ToString();
            txtDienTich.Text = dGVPhongTro.CurrentRow.Cells["dienTich"].Value.ToString();
            txtLoaiPhong.Text = dGVPhongTro.CurrentRow.Cells["loaiPhong"].Value.ToString();
            txtGiaPhong.Text = dGVPhongTro.CurrentRow.Cells["giaPhong"].Value.ToString();
            cbB_TrangThai.Text = dGVPhongTro.CurrentRow.Cells["trangThai"].Value.ToString();
        }
        
        
        //2.Thiet bi
        //ham xoa textbox 
        private void XoaText2()
        {
            txtMaThietBi.Text = "";
            txtTenThietBi.Text = "";
        }

        //ham hien thi datagridView bang thiet bi
        private void LoadDevice()
        {
            dGVThietBi.DataSource = dev.LoadDevice();
                  
        }

        //button them tt thiet bi
        private void bttThemThietBi_Click(object sender, EventArgs e)
        {
            if (txtMaThietBi.Text != "" && txtTenThietBi.Text != "")
            {
                device de = new device(Convert.ToInt32(txtMaThietBi.Text), txtTenThietBi.Text);
                //them tai khoan
                if (dev.themDevice(de))
                {
                    MessageBox.Show("Thêm Mới Thành Công!");
                    LoadDevice();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công! ");
                }
                XoaText2();
            }
            else
            {
                MessageBox.Show("Cần nhập thông tin đầy đủ trước khi thêm!");
            }
        }

        //button sua  tt thiet bi
        private void bttSuaThietBi_Click(object sender, EventArgs e)
        {
            if (txtMaThietBi.Text != "" && txtTenThietBi.Text != "")
            {
                device de = new device(Convert.ToInt32(txtMaThietBi.Text), txtTenThietBi.Text);
                //them tai khoan
                if (dev.suaDevice(de))
                {
                    MessageBox.Show("Sửa Thành Công!");
                    LoadDevice();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!");
                }
                XoaText2();
            }
            else
            {
                MessageBox.Show("Cần nhập thông tin đầy đủ trước khi sửa!");
            }
        }

        //button xoa tt thiet bi
        private void bttXoaThietBi_Click(object sender, EventArgs e)
        {
            if (txtMaThietBi.Text != "" && txtTenThietBi.Text != "")
            {
                device de = new device(Convert.ToInt32(txtMaThietBi.Text), txtTenThietBi.Text);
                //them tai khoan
                if (dev.xoaDevice(de))
                {
                    MessageBox.Show("Xóa Thành Công!");
                    LoadDevice();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
                XoaText2();
            }
            else
            {
                MessageBox.Show("Hãy chọn thiết bị muốn xóa!");
            }
        }

        //button tim kiem ma thiet bi
        private void bttTimKiemTB_Click(object sender, EventArgs e)
        {
            if (txtMaThietBitt.Text != "")
            {
                dGVPhongTro.DataSource = rom.Timkiem(Convert.ToInt32(txtMaThietBitt.Text));
            }
            else
            {
                MessageBox.Show("Hãy nhập mã thiết bị để tìm kiếm!");
            }
            txtMaThietBitt.Text = "";
        }

        //su kiem cell click
        private void dGVThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaThietBi.Text = dGVThietBi.CurrentRow.Cells["MaThietBi"].Value.ToString();
            txtTenThietBi.Text = dGVThietBi.CurrentRow.Cells["TenThietBi"].Value.ToString();
        }


        //3.TaiKhoan
        //xoa textbox tai khoan
        private void xoaText3()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtSDTTaiKhoan.Text = "";
            txtEmail.Text = "";
        }

        //ham hien thi dataGridView tai khoan 
        private void LoadAccount()
        {
            dGVTaiKhoan.DataSource = Acc.LoadAccount();
            
        }

        //button them thong tin tai khoan
        private void bttThemTaiKhoan_Click(object sender, EventArgs e)
        {
           if(txtTaiKhoan.Text != "" && txtMatKhau.Text !="" && txtSDTTaiKhoan.Text != "" && txtEmail.Text != "")
            {
                Account ac = new Account(txtTaiKhoan.Text, txtMatKhau.Text, txtSDTTaiKhoan.Text, txtEmail.Text);
                if (Acc.themAccount(ac))
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadAccount();
                    xoaText3();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin trước khi thêm!");
            }
        }

        //button suathong tin tai khoan
        private void bttSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "" && txtSDTTaiKhoan.Text != "" && txtEmail.Text != "")
            {
                Account ac = new Account(txtTaiKhoan.Text, txtMatKhau.Text, txtSDTTaiKhoan.Text, txtEmail.Text);
                if (Acc.suaAccount(ac))
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadAccount();
                    xoaText3();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin trước khi sửa!");
            }
        }

        //button xoa tt tai khoan
        private void bttXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "" && txtSDTTaiKhoan.Text != "" && txtEmail.Text != "")
            {
                Account ac = new Account(txtTaiKhoan.Text, txtMatKhau.Text, txtSDTTaiKhoan.Text, txtEmail.Text);
                if (Acc.xoaAccount(ac))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadAccount();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn tài khoản muốn xóa!");
            }
        }

        //button tim kiem theo ten tai khoan
        private void bttTimKiemTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoantk.Text != "")
            {
                dGVTaiKhoan.DataSource = Acc.timKiemAccount(txtTenTaiKhoantk.Text);
            }
            else
            {
                MessageBox.Show("Tìm kiếm không thành công!");
            }
            txtTenTaiKhoantk.Text = "";
        }

        //su kiem cell click
        private void dGVTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTaiKhoan.Text = dGVTaiKhoan.CurrentRow.Cells["TenTaiKhoan"].Value.ToString();
            txtMatKhau.Text = dGVTaiKhoan.CurrentRow.Cells["MatKhau"].Value.ToString();
            txtSDTTaiKhoan.Text = dGVTaiKhoan.CurrentRow.Cells["SDTtk"].Value.ToString();
            txtEmail.Text = dGVTaiKhoan.CurrentRow.Cells["Email"].Value.ToString();

        }

        

        //4.Khách hang
        //xoa textbox khach hang
        private void xoaText4()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            cbbGioiTinh.SelectedIndex = -1;
            dtk_NgaySinh.Text = DateTime.Now.ToString();
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        //ham hien thi len dataGridView thong tin khach hang
        private void LoadCustomer()
        {
            dGVKhachThue.DataSource = KH.LoadCustomer();
        }

        //su kien cell click
        private void dGVKhachThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dGVKhachThue.CurrentRow.Cells["maKH"].Value.ToString();
            txtTenKH.Text = dGVKhachThue.CurrentRow.Cells["TenKH"].Value.ToString();
            cbbGioiTinh.Text = dGVKhachThue.CurrentRow.Cells["GioiTinh"].Value.ToString();
            dtk_NgaySinh.Text = dGVKhachThue.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txtDiaChi.Text = dGVKhachThue.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = dGVKhachThue.CurrentRow.Cells["SDT"].Value.ToString();
        }

        //button them thong tin khach hang
        private void bttThemKH_Click(object sender, EventArgs e)
        {
            if(txtMaKH.Text !="" && txtTenKH.Text != "" && cbbGioiTinh.Text!= "" && dtk_NgaySinh.Text !="" && txtDiaChi.Text!="" && txtSDT.Text !="")
            {
                KhachHang kh = new KhachHang(Convert.ToInt32(txtMaKH.Text), txtTenKH.Text, cbbGioiTinh.Text, Convert.ToDateTime(dtk_NgaySinh.Value.ToString("MM/dd/yyyy")), txtDiaChi.Text, txtSDT.Text);
                if (KH.ThemCustomer(kh))
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadCustomer();
                    xoaText4();

                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }    
            }  
            else
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin trước khi thêm!");
            }    
        }

        //button sua thong tin Khach hang
        private void bttSuaKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" && txtTenKH.Text != "" && cbbGioiTinh.Text != "" && dtk_NgaySinh.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "")
            {
                KhachHang kh = new KhachHang(Convert.ToInt32(txtMaKH.Text), txtTenKH.Text, cbbGioiTinh.Text, Convert.ToDateTime(dtk_NgaySinh.Value.ToString("MM/dd/yyyy")), txtDiaChi.Text, txtSDT.Text);
                if (KH.SuaCustomer(kh))
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadCustomer();
                    xoaText4();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin trước khi sửa!");
            }
        }

        // button xoa tt khach hang
        private void bttXoaKh_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" && txtTenKH.Text != "" && cbbGioiTinh.Text != "" && dtk_NgaySinh.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "")
            {
                KhachHang kh = new KhachHang(Convert.ToInt32(txtMaKH.Text), txtTenKH.Text, cbbGioiTinh.Text, Convert.ToDateTime(dtk_NgaySinh.Value.ToString("MM/dd/yyyy")), txtDiaChi.Text, txtSDT.Text);
                if (KH.xoaCustomer(kh))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadCustomer();

                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng muốn xóa !");
            }
        }

        //butt tim kiem theo ma khach hang
        private void bttTimKiemKhach_Click(object sender, EventArgs e)
        {
           if(txtmaKhachtk.Text != "")
            {
                dGVKhachThue.DataSource = KH.TimKiemCustomer(Convert.ToInt32(txtmaKhachtk.Text));
                MessageBox.Show("Tìm kiếm thành công!");
            }
            else
            {
                MessageBox.Show("Cần nhập mã khách hàng trước khi tìm kiếm!");
            }
            txtmaKhachtk.Text = "";
        }

        //5.DienNuoc
        //ham xoa textBox dien nuoc
        private void xoaText5()
        {
            txtMaDN.Text = "";
            cbBMaPhongDN.Text = "";
            cbB_DichVu.SelectedIndex = -1;
            txtSoCu.Text = "";
            txtSoMoi.Text = "";
            dTK_NgayChotDN.Text = DateTime.Now.ToString();

        }

        //ham hien thi thong tin dich vu nen comboBox
        private void ComboboxDichVu()
        {
            cbB_DichVu.DataSource = DV.LoadDichVu();
            cbB_DichVu.DisplayMember = "TenDV";
            cbB_DichVu.ValueMember = "MaDV";
            cbB_DichVu.SelectedIndex = -1;
        }

        //ham hien thi tt phong tro len comboBox
        private void ComboboxMaPhong()
        {
            cbBMaPhongDN.DataSource = rom.LoadDateRom();
            cbBMaPhongDN.DisplayMember = "TenPhongTro";
            cbBMaPhongDN.ValueMember = "MaPhongTro";
            cbBMaPhongDN.SelectedIndex = -1;
        }

        //ham hien thi len dataGridView bang DienNuoc
        private void LoadDienNuoc()
        {
            dGVDienNuoc.DataSource = DN.LoadDienNuoc();
        }

        //button them tt dien nuoc
        private void bttThemDN_Click(object sender, EventArgs e)
        {
            if (txtMaDN.Text != "" && cbB_DichVu.Text != "" && txtSoCu.Text != "" && txtSoMoi.Text != "" && dTK_NgayChotDN.Text != "" && cbBMaPhongDN.Text != "")
            {
                DienNuoc dn = new DienNuoc(Convert.ToInt32(txtMaDN.Text), Convert.ToInt32(cbB_DichVu.SelectedValue.ToString()), Convert.ToInt32(txtSoCu.Text), Convert.ToInt32(txtSoMoi.Text), Convert.ToDateTime(dTK_NgayChotDN.Value.ToString("MM/dd/yyyy")), Convert.ToInt32(cbBMaPhongDN.SelectedValue.ToString()));
                if (DN.ThemDienNuoc(dn))
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadDienNuoc();
                    xoaText5();

                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin trước khi thêm!");
            }
        }

        //button sua tt dien nuoc
        private void bttSuaDN_Click(object sender, EventArgs e)
        {
            if (txtMaDN.Text != "" && cbB_DichVu.Text != "" && txtSoCu.Text != "" && txtSoMoi.Text != "" && dTK_NgayChotDN.Text != "" && cbBMaPhongDN.Text != "")
            {
                DienNuoc dn = new DienNuoc(Convert.ToInt32(txtMaDN.Text), Convert.ToInt32(cbB_DichVu.SelectedValue.ToString()), Convert.ToInt32(txtSoCu.Text), Convert.ToInt32(txtSoMoi.Text), Convert.ToDateTime(dTK_NgayChotDN.Value.ToString("MM/dd/yyyy")), Convert.ToInt32(cbBMaPhongDN.SelectedValue.ToString()));
                if (DN.SuaDienNuoc(dn))
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadDienNuoc();
                    xoaText5();

                }
                else
                {
                    MessageBox.Show("sửa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin trước khi Sửa!");
            }
        }

        //button xoa tt dien nuoc
        private void bttXoaDN_Click(object sender, EventArgs e)
        {
            if (txtMaDN.Text != "" && cbB_DichVu.Text != "" && txtSoCu.Text != "" && txtSoMoi.Text != "" && dTK_NgayChotDN.Text != "" && cbBMaPhongDN.Text != "")
            {
                DienNuoc dn = new DienNuoc(Convert.ToInt32(txtMaDN.Text), Convert.ToInt32(cbB_DichVu.SelectedValue.ToString()), Convert.ToInt32(txtSoCu.Text), Convert.ToInt32(txtSoMoi.Text), Convert.ToDateTime(dTK_NgayChotDN.Value.ToString("MM/dd/yyyy")), Convert.ToInt32(cbBMaPhongDN.SelectedValue.ToString()));
                if (DN.XoaDienNuoc(dn))
                {
                    MessageBox.Show("xóa thành công!");
                    LoadDienNuoc();
                    xoaText5();

                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn dịch vụ muốn xóa !");
            }
        }

        //button tim kiem theo ma dien nuoc
        private void bttTimKiemDN_Click(object sender, EventArgs e)
        {
            if(txtMaDNtk.Text != "")
            {
                dGVDienNuoc.DataSource = DN.TimKiemDienNuoc(Convert.ToInt32(txtMaDNtk.Text));
                MessageBox.Show("Tìm Kiếm thành công!");
            }
            else
            {
                MessageBox.Show("Hãy nhập Mã điện nước để tìm kiếm !");
            }
            txtMaDNtk.Text = "";
        }

        //su kiem cell click
        private void dGVDienNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDN.Text = dGVDienNuoc.CurrentRow.Cells["MaDN"].Value.ToString();
            cbBMaPhongDN.Text = dGVDienNuoc.CurrentRow.Cells["MaPhongDN"].Value.ToString();
            cbB_DichVu.Text = dGVDienNuoc.CurrentRow.Cells["TenDV"].Value.ToString();
            txtSoCu.Text = dGVDienNuoc.CurrentRow.Cells["SoCuDN"].Value.ToString();
            txtSoMoi.Text = dGVDienNuoc.CurrentRow.Cells["SoMoiDN"].Value.ToString();
            dTK_NgayChotDN.Text = dGVDienNuoc.CurrentRow.Cells["NgayChotDN"].Value.ToString();

        }

        //6.thue Phong
        //ham xoa textbox thue phong
        private void xoaText6()
        {
            txtSoPhieuThue.Text = "";
            txtKhachHang.Clear();
            dtk_ngayTheu.Text = DateTime.Today.ToString();
            cbbMaPhong.SelectedIndex = -1;
            txtGiaPhongThue.Text = "";
            txtTienCoc.Text = "";
            cbbTrangThai.SelectedIndex = -1;
        }

        //ham hien thi thong tin phong tro nen comboBox
        private void comboBox_MaPhong()
        {
            cbbMaPhong.DataSource = rom.LoadDateRom();
            cbbMaPhong.DisplayMember = "MaPhongTro";
            cbbMaPhong.ValueMember = "MaPhongTro";
            cbbMaPhong.SelectedIndex = -1;
        }

        //ham doi mau khi phong tro khong duoc thue nua
        void doimau()
        {
            string st = "Trả Phòng";
            for (int i = 0; i < dGVThuePhong.RowCount; i++)
            {
                if (dGVThuePhong.Rows[i].Cells["TrangThaiTP"].Value.ToString() == st)
                    dGVThuePhong.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        //hien thi thong tin len dataGridView bang ThuePhong 
        private void LoadThuePhong()
        {
            dGVThuePhong.DataSource = TP.LoadThuePhong();
            doimau();
        }

        //button sua thong tin
        private void bttSuaThuePhong_Click(object sender, EventArgs e)
        {
            if (txtSoPhieuThue.Text != "" && txtKhachHang.Text != "" && dtk_ngayTheu.Text != "" && cbbTrangThai.Text != "" && cbbMaPhong.Text != "" && txtGiaPhongThue.Text != "" && txtTienCoc.Text != "")
            {
                ThuePhong tp = new ThuePhong(Convert.ToInt32(txtSoPhieuThue.Text), txtKhachHang.Text, Convert.ToDateTime(dtk_ngayTheu.Value.ToString("MM/dd/yyyy")), cbbTrangThai.Text, Convert.ToInt32(cbbMaPhong.SelectedValue.ToString()), Convert.ToSingle(txtTienCoc.Text), Convert.ToSingle(txtGiaPhongThue.Text));
                if (TP.suaThuePhong(tp))
                {
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!");
                }
                LoadThuePhong();
                doimau();
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin trước khi sửa  thông tin!");
            }
        }

        //button xoa
        private void btt_xoaThuePhong_Click(object sender, EventArgs e)
        {
            if (txtSoPhieuThue.Text != "" && txtKhachHang.Text != "" && dtk_ngayTheu.Text != "" && cbbTrangThai.Text != "" && cbbMaPhong.Text != "" && txtGiaPhongThue.Text != "" && txtTienCoc.Text != "")
            {
                ThuePhong tp = new ThuePhong(Convert.ToInt32(txtSoPhieuThue.Text), txtKhachHang.Text, Convert.ToDateTime(dtk_ngayTheu.Value.ToString("MM/dd/yyyy")), cbbTrangThai.Text, Convert.ToInt32(cbbMaPhong.SelectedValue.ToString()), Convert.ToSingle(txtTienCoc.Text), Convert.ToSingle(txtGiaPhongThue.Text));
                if (TP.xoaThuePhong(tp))
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
                LoadThuePhong();
                doimau();
            }
            else
            {
                MessageBox.Show("Hãy chọn phiếu thuê muốn xóa!");
            }
        }
        
        //sua kiem cell click 
        private void dGVThuePhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoPhieuThue.Text = dGVThuePhong.CurrentRow.Cells["MaSoThue"].Value.ToString();
            txtKhachHang.Text = dGVThuePhong.CurrentRow.Cells["TenKHTP"].Value.ToString();
            dtk_ngayTheu.Text = dGVThuePhong.CurrentRow.Cells["NgayThue"].Value.ToString();
            cbbMaPhong.Text = dGVThuePhong.CurrentRow.Cells["TenPhongTroTp"].Value.ToString(); ;
            txtGiaPhongThue.Text = dGVThuePhong.CurrentRow.Cells["GiaPhongThue"].Value.ToString();
            txtTienCoc.Text = dGVThuePhong.CurrentRow.Cells["TienCoc"].Value.ToString();
            cbbTrangThai.Text = dGVThuePhong.CurrentRow.Cells["TrangThaiTP"].Value.ToString();
        }

        //button tim kiem
        private void bttTimKiemTP_Click(object sender, EventArgs e)
        {
           if(txtMaThuephong.Text != "")
            {
                MessageBox.Show("Tìm Kiếm thành công!");
                dGVThuePhong.DataSource = TP.timKiemThuePhong(Convert.ToInt32(txtMaThuephong.Text));
                doimau();
            }
            else
            {
                MessageBox.Show("Nhập thông tin trước khi tìm kiếm!");
            }
            txtMaThuephong.Text = "";
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }

}
