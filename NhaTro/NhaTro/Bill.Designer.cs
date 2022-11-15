namespace NhaTro
{
    partial class Bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMaNuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTienDien = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSoDien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btt_xoa = new System.Windows.Forms.Button();
            this.btt_Sua = new System.Windows.Forms.Button();
            this.btt_Them = new System.Windows.Forms.Button();
            this.bttTimKiem = new System.Windows.Forms.Button();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaDien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTienNuoc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtk_ngayLap = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSoNuoc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbMaPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoHoaDon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dGVHoaDon = new System.Windows.Forms.DataGridView();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhongTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNuocSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHoaDon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaNuoc
            // 
            this.txtMaNuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaNuoc.Location = new System.Drawing.Point(466, 114);
            this.txtMaNuoc.Name = "txtMaNuoc";
            this.txtMaNuoc.Size = new System.Drawing.Size(225, 25);
            this.txtMaNuoc.TabIndex = 1;
            this.txtMaNuoc.TextChanged += new System.EventHandler(this.txtMaNuoc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(352, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nước: ";
            // 
            // txtTienDien
            // 
            this.txtTienDien.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTienDien.Location = new System.Drawing.Point(813, 41);
            this.txtTienDien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienDien.Name = "txtTienDien";
            this.txtTienDien.Size = new System.Drawing.Size(228, 25);
            this.txtTienDien.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(698, 41);
            this.label16.Margin = new System.Windows.Forms.Padding(4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Tiền Điện: ";
            // 
            // txtSoDien
            // 
            this.txtSoDien.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSoDien.Location = new System.Drawing.Point(813, 4);
            this.txtSoDien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDien.Name = "txtSoDien";
            this.txtSoDien.Size = new System.Drawing.Size(228, 25);
            this.txtSoDien.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(698, 4);
            this.label15.Margin = new System.Windows.Forms.Padding(4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Số Điện: ";
            // 
            // btt_xoa
            // 
            this.btt_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btt_xoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btt_xoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_xoa.ForeColor = System.Drawing.Color.White;
            this.btt_xoa.Image = global::NhaTro.Properties.Resources.iconfinder_multimedia_26_2849810;
            this.btt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btt_xoa.Location = new System.Drawing.Point(351, 3);
            this.btt_xoa.Name = "btt_xoa";
            this.btt_xoa.Size = new System.Drawing.Size(168, 42);
            this.btt_xoa.TabIndex = 12;
            this.btt_xoa.Text = "      Xóa";
            this.btt_xoa.UseVisualStyleBackColor = false;
            this.btt_xoa.Click += new System.EventHandler(this.btt_xoa_Click);
            // 
            // btt_Sua
            // 
            this.btt_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btt_Sua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btt_Sua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Sua.ForeColor = System.Drawing.Color.White;
            this.btt_Sua.Image = global::NhaTro.Properties.Resources.sua;
            this.btt_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btt_Sua.Location = new System.Drawing.Point(177, 3);
            this.btt_Sua.Name = "btt_Sua";
            this.btt_Sua.Size = new System.Drawing.Size(168, 42);
            this.btt_Sua.TabIndex = 11;
            this.btt_Sua.Text = "       Sửa";
            this.btt_Sua.UseVisualStyleBackColor = false;
            this.btt_Sua.Click += new System.EventHandler(this.btt_Sua_Click);
            // 
            // btt_Them
            // 
            this.btt_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btt_Them.Dock = System.Windows.Forms.DockStyle.Top;
            this.btt_Them.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Them.ForeColor = System.Drawing.Color.White;
            this.btt_Them.Image = global::NhaTro.Properties.Resources.Them;
            this.btt_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btt_Them.Location = new System.Drawing.Point(3, 3);
            this.btt_Them.Name = "btt_Them";
            this.btt_Them.Size = new System.Drawing.Size(168, 42);
            this.btt_Them.TabIndex = 10;
            this.btt_Them.Text = "       Thêm";
            this.btt_Them.UseVisualStyleBackColor = false;
            this.btt_Them.Click += new System.EventHandler(this.btt_Them_Click);
            // 
            // bttTimKiem
            // 
            this.bttTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.bttTimKiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.bttTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttTimKiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTimKiem.ForeColor = System.Drawing.Color.White;
            this.bttTimKiem.Image = global::NhaTro.Properties.Resources.iconfinder_00_ELASTOFONT_STORE_READY_search_2703065;
            this.bttTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttTimKiem.Location = new System.Drawing.Point(874, 4);
            this.bttTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.bttTimKiem.Name = "bttTimKiem";
            this.bttTimKiem.Size = new System.Drawing.Size(167, 42);
            this.bttTimKiem.TabIndex = 2;
            this.bttTimKiem.Text = "       Tìm Kiếm";
            this.bttTimKiem.UseVisualStyleBackColor = false;
            this.bttTimKiem.Click += new System.EventHandler(this.bttTimKiem_Click);
            // 
            // txtSoHD
            // 
            this.txtSoHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSoHD.Location = new System.Drawing.Point(700, 4);
            this.txtSoHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(166, 25);
            this.txtSoHD.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(600, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số hóa đơn: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1043, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Thông Tin Hóa Đơn";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaDien
            // 
            this.txtMaDien.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaDien.Location = new System.Drawing.Point(467, 78);
            this.txtMaDien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDien.Name = "txtMaDien";
            this.txtMaDien.Size = new System.Drawing.Size(223, 25);
            this.txtMaDien.TabIndex = 1;
            this.txtMaDien.TextChanged += new System.EventHandler(this.txtMaDien_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Điện: ";
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGiaPhong.Location = new System.Drawing.Point(467, 41);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(223, 25);
            this.txtGiaPhong.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá Phòng: ";
            // 
            // txtTienNuoc
            // 
            this.txtTienNuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTienNuoc.Location = new System.Drawing.Point(813, 115);
            this.txtTienNuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienNuoc.Name = "txtTienNuoc";
            this.txtTienNuoc.Size = new System.Drawing.Size(228, 25);
            this.txtTienNuoc.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(698, 115);
            this.label12.Margin = new System.Windows.Forms.Padding(4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tiền Nước: ";
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Đã Thanh Toán",
            "Chưa Thanh Toán "});
            this.cbbTrangThai.Location = new System.Drawing.Point(121, 115);
            this.cbbTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(223, 25);
            this.cbbTrangThai.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 115);
            this.label14.Margin = new System.Windows.Forms.Padding(4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Trạng Thái";
            // 
            // dtk_ngayLap
            // 
            this.dtk_ngayLap.CustomFormat = "dd/MM/yyyy";
            this.dtk_ngayLap.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtk_ngayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtk_ngayLap.Location = new System.Drawing.Point(121, 78);
            this.dtk_ngayLap.Margin = new System.Windows.Forms.Padding(4);
            this.dtk_ngayLap.Name = "dtk_ngayLap";
            this.dtk_ngayLap.Size = new System.Drawing.Size(223, 25);
            this.dtk_ngayLap.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 78);
            this.label13.Margin = new System.Windows.Forms.Padding(4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ngày Lập: ";
            // 
            // txtSoNuoc
            // 
            this.txtSoNuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSoNuoc.Location = new System.Drawing.Point(813, 78);
            this.txtSoNuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoNuoc.Name = "txtSoNuoc";
            this.txtSoNuoc.Size = new System.Drawing.Size(228, 25);
            this.txtSoNuoc.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(698, 78);
            this.label11.Margin = new System.Windows.Forms.Padding(4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số Nước: ";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtKhachHang.Location = new System.Drawing.Point(121, 41);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(223, 25);
            this.txtKhachHang.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(4, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khách Hàng: ";
            // 
            // cbbMaPhong
            // 
            this.cbbMaPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbMaPhong.FormattingEnabled = true;
            this.cbbMaPhong.Location = new System.Drawing.Point(467, 4);
            this.cbbMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaPhong.Name = "cbbMaPhong";
            this.cbbMaPhong.Size = new System.Drawing.Size(223, 25);
            this.cbbMaPhong.TabIndex = 1;
            this.cbbMaPhong.SelectedIndexChanged += new System.EventHandler(this.cbbMaPhong_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(352, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Phòng: ";
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSoHoaDon.Location = new System.Drawing.Point(121, 4);
            this.txtSoHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(223, 25);
            this.txtSoHoaDon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn: ";
            // 
            // dGVHoaDon
            // 
            this.dGVHoaDon.AllowUserToAddRows = false;
            this.dGVHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHD,
            this.TenKH,
            this.NgayLap,
            this.MaPhongTro,
            this.GiaPhong,
            this.SoDienSuDung,
            this.TienDien,
            this.SoNuocSuDung,
            this.TienNuoc,
            this.ThanhTien,
            this.TrangThai});
            this.dGVHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVHoaDon.Location = new System.Drawing.Point(4, 293);
            this.dGVHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dGVHoaDon.Name = "dGVHoaDon";
            this.dGVHoaDon.RowHeadersWidth = 51;
            this.dGVHoaDon.Size = new System.Drawing.Size(1043, 309);
            this.dGVHoaDon.TabIndex = 14;
            this.dGVHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVHoaDon_CellClick);
            // 
            // SoHD
            // 
            this.SoHD.DataPropertyName = "SoHD";
            this.SoHD.HeaderText = "Số hóa đơn";
            this.SoHD.MinimumWidth = 6;
            this.SoHD.Name = "SoHD";
            this.SoHD.Width = 80;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "KhachHang";
            this.TenKH.HeaderText = "Khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 120;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 80;
            // 
            // MaPhongTro
            // 
            this.MaPhongTro.DataPropertyName = "MaPhongTro";
            this.MaPhongTro.HeaderText = "Phòng trọ";
            this.MaPhongTro.MinimumWidth = 6;
            this.MaPhongTro.Name = "MaPhongTro";
            this.MaPhongTro.ReadOnly = true;
            this.MaPhongTro.Width = 125;
            // 
            // GiaPhong
            // 
            this.GiaPhong.DataPropertyName = "GiaPhong";
            this.GiaPhong.HeaderText = "Giá phòng";
            this.GiaPhong.MinimumWidth = 6;
            this.GiaPhong.Name = "GiaPhong";
            this.GiaPhong.Width = 125;
            // 
            // SoDienSuDung
            // 
            this.SoDienSuDung.DataPropertyName = "SoDienSuDung";
            this.SoDienSuDung.HeaderText = "Số điện";
            this.SoDienSuDung.MinimumWidth = 6;
            this.SoDienSuDung.Name = "SoDienSuDung";
            this.SoDienSuDung.Width = 80;
            // 
            // TienDien
            // 
            this.TienDien.DataPropertyName = "TienDien";
            this.TienDien.HeaderText = "Tiền điện";
            this.TienDien.MinimumWidth = 6;
            this.TienDien.Name = "TienDien";
            this.TienDien.Width = 125;
            // 
            // SoNuocSuDung
            // 
            this.SoNuocSuDung.DataPropertyName = "SoNuocSuDung";
            this.SoNuocSuDung.HeaderText = "Số nước";
            this.SoNuocSuDung.MinimumWidth = 6;
            this.SoNuocSuDung.Name = "SoNuocSuDung";
            this.SoNuocSuDung.Width = 80;
            // 
            // TienNuoc
            // 
            this.TienNuoc.DataPropertyName = "TienNuoc";
            this.TienNuoc.HeaderText = "Tiền nước";
            this.TienNuoc.MinimumWidth = 6;
            this.TienNuoc.Name = "TienNuoc";
            this.TienNuoc.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 125;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = false;
            this.TrangThai.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.label9.Location = new System.Drawing.Point(4, 256);
            this.label9.Margin = new System.Windows.Forms.Padding(4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1043, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "Hiển Thị Danh Sách";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dGVHoaDon, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 606);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25012F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.18747F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.09373F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.18747F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.09373F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.18747F));
            this.tableLayoutPanel2.Controls.Add(this.label11, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.label16, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTienNuoc, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtSoNuoc, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtTienDien, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label15, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSoDien, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMaDien, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtGiaPhong, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbbMaPhong, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbbTrangThai, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtk_ngayLap, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtKhachHang, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSoHoaDon, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtMaNuoc, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1045, 150);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Controls.Add(this.bttTimKiem, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btt_xoa, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSoHD, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btt_Them, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btt_Sua, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 199);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1045, 50);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 606);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bill_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVHoaDon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVHoaDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTienDien;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSoDien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSoNuoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btt_xoa;
        private System.Windows.Forms.Button btt_Sua;
        private System.Windows.Forms.Button btt_Them;
        private System.Windows.Forms.Button bttTimKiem;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTienNuoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtk_ngayLap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbMaPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNuocSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}