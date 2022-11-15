namespace NhaTro
{
    partial class rent
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
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtk_ngayTheu = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbMaPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoPhieuThue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bttThoat = new System.Windows.Forms.Button();
            this.btt_xoa = new System.Windows.Forms.Button();
            this.btt_Them = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Thuê Phòng",
            "Trả Phòng"});
            this.cbbTrangThai.Location = new System.Drawing.Point(213, 355);
            this.cbbTrangThai.Margin = new System.Windows.Forms.Padding(5);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(198, 26);
            this.cbbTrangThai.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(30, 355);
            this.label7.Margin = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng Thái: ";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTienCoc.Location = new System.Drawing.Point(213, 305);
            this.txtTienCoc.Margin = new System.Windows.Forms.Padding(5);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(198, 26);
            this.txtTienCoc.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(30, 305);
            this.label6.Margin = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tiền Cọc: ";
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGiaPhong.Location = new System.Drawing.Point(213, 255);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(5);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(198, 26);
            this.txtGiaPhong.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(30, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá Phòng: ";
            // 
            // dtk_ngayTheu
            // 
            this.dtk_ngayTheu.CustomFormat = "dd/MM/yyyy";
            this.dtk_ngayTheu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtk_ngayTheu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtk_ngayTheu.Location = new System.Drawing.Point(213, 155);
            this.dtk_ngayTheu.Margin = new System.Windows.Forms.Padding(5);
            this.dtk_ngayTheu.Name = "dtk_ngayTheu";
            this.dtk_ngayTheu.Size = new System.Drawing.Size(198, 26);
            this.dtk_ngayTheu.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Location = new System.Drawing.Point(30, 155);
            this.label13.Margin = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ngày Thuê: ";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtKhachHang.Location = new System.Drawing.Point(213, 105);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(5);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(198, 26);
            this.txtKhachHang.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(30, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Khách: ";
            // 
            // cbbMaPhong
            // 
            this.cbbMaPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbMaPhong.FormattingEnabled = true;
            this.cbbMaPhong.Location = new System.Drawing.Point(213, 205);
            this.cbbMaPhong.Margin = new System.Windows.Forms.Padding(5);
            this.cbbMaPhong.Name = "cbbMaPhong";
            this.cbbMaPhong.Size = new System.Drawing.Size(198, 26);
            this.cbbMaPhong.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(30, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Phòng: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu Thuê Phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoPhieuThue
            // 
            this.txtSoPhieuThue.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSoPhieuThue.Location = new System.Drawing.Point(213, 55);
            this.txtSoPhieuThue.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoPhieuThue.Name = "txtSoPhieuThue";
            this.txtSoPhieuThue.Size = new System.Drawing.Size(198, 26);
            this.txtSoPhieuThue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phiếu: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbbTrangThai, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.bttThoat, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtTienCoc, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btt_xoa, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtGiaPhong, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btt_Them, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbbMaPhong, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtk_ngayTheu, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtKhachHang, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSoPhieuThue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 614);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // bttThoat
            // 
            this.bttThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.tableLayoutPanel1.SetColumnSpan(this.bttThoat, 2);
            this.bttThoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttThoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.ForeColor = System.Drawing.Color.White;
            this.bttThoat.Image = global::NhaTro.Properties.Resources._3643769_building_home_house_main_menu_start_113416;
            this.bttThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttThoat.Location = new System.Drawing.Point(30, 536);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(30, 4, 4, 4);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(382, 45);
            this.bttThoat.TabIndex = 9;
            this.bttThoat.Text = "      Quay lại";
            this.bttThoat.UseVisualStyleBackColor = false;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // btt_xoa
            // 
            this.btt_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.tableLayoutPanel1.SetColumnSpan(this.btt_xoa, 2);
            this.btt_xoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btt_xoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_xoa.ForeColor = System.Drawing.Color.White;
            this.btt_xoa.Image = global::NhaTro.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btt_xoa.Location = new System.Drawing.Point(30, 483);
            this.btt_xoa.Margin = new System.Windows.Forms.Padding(30, 4, 4, 4);
            this.btt_xoa.Name = "btt_xoa";
            this.btt_xoa.Size = new System.Drawing.Size(382, 45);
            this.btt_xoa.TabIndex = 8;
            this.btt_xoa.Text = "      Xóa";
            this.btt_xoa.UseVisualStyleBackColor = false;
            this.btt_xoa.Click += new System.EventHandler(this.btt_xoa_Click);
            // 
            // btt_Them
            // 
            this.btt_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.tableLayoutPanel1.SetColumnSpan(this.btt_Them, 2);
            this.btt_Them.Dock = System.Windows.Forms.DockStyle.Top;
            this.btt_Them.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Them.ForeColor = System.Drawing.Color.White;
            this.btt_Them.Image = global::NhaTro.Properties.Resources.add_circle_create_expand_new_plus_icon_123218;
            this.btt_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btt_Them.Location = new System.Drawing.Point(30, 430);
            this.btt_Them.Margin = new System.Windows.Forms.Padding(30, 30, 4, 4);
            this.btt_Them.Name = "btt_Them";
            this.btt_Them.Size = new System.Drawing.Size(382, 45);
            this.btt_Them.TabIndex = 7;
            this.btt_Them.Text = "       Thêm";
            this.btt_Them.UseVisualStyleBackColor = false;
            this.btt_Them.Click += new System.EventHandler(this.btt_Them_Click);
            // 
            // rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 614);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "rent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuê Phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rent_FormClosing_1);
            this.Load += new System.EventHandler(this.Form6_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btt_xoa;
        private System.Windows.Forms.Button btt_Them;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtk_ngayTheu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbMaPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoPhieuThue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}