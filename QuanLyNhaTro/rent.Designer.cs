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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btt_xoa = new System.Windows.Forms.Button();
            this.btt_Them = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dtk_ngayTheu = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbMaPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSoPhieuThue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttThoat = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.bttThoat);
            this.panel2.Controls.Add(this.btt_xoa);
            this.panel2.Controls.Add(this.btt_Them);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(2, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 562);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbTrangThai);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(26, 421);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 43);
            this.panel1.TabIndex = 6;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Thuê Phòng",
            "Trả Phòng"});
            this.cbbTrangThai.Location = new System.Drawing.Point(122, 12);
            this.cbbTrangThai.Margin = new System.Windows.Forms.Padding(5);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(199, 24);
            this.cbbTrangThai.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng Thái: ";
            // 
            // btt_xoa
            // 
            this.btt_xoa.BackColor = System.Drawing.Color.White;
            this.btt_xoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_xoa.Image = global::NhaTro.Properties.Resources.iconfinder_multimedia_26_2849810;
            this.btt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btt_xoa.Location = new System.Drawing.Point(148, 474);
            this.btt_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btt_xoa.Name = "btt_xoa";
            this.btt_xoa.Size = new System.Drawing.Size(97, 52);
            this.btt_xoa.TabIndex = 8;
            this.btt_xoa.Text = "      Xóa";
            this.btt_xoa.UseVisualStyleBackColor = false;
            this.btt_xoa.Click += new System.EventHandler(this.btt_xoa_Click);
            // 
            // btt_Them
            // 
            this.btt_Them.BackColor = System.Drawing.Color.White;
            this.btt_Them.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Them.Image = global::NhaTro.Properties.Resources.Them;
            this.btt_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btt_Them.Location = new System.Drawing.Point(25, 474);
            this.btt_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btt_Them.Name = "btt_Them";
            this.btt_Them.Size = new System.Drawing.Size(98, 52);
            this.btt_Them.TabIndex = 7;
            this.btt_Them.Text = "       Thêm";
            this.btt_Them.UseVisualStyleBackColor = false;
            this.btt_Them.Click += new System.EventHandler(this.btt_Them_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtTienCoc);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(26, 368);
            this.panel7.Margin = new System.Windows.Forms.Padding(5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(348, 43);
            this.panel7.TabIndex = 5;
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(122, 10);
            this.txtTienCoc.Margin = new System.Windows.Forms.Padding(5);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(199, 22);
            this.txtTienCoc.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tiền Cọc: ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtGiaPhong);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(26, 314);
            this.panel6.Margin = new System.Windows.Forms.Padding(5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(348, 44);
            this.panel6.TabIndex = 4;
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(122, 10);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(5);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(199, 22);
            this.txtGiaPhong.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá Phòng: ";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.dtk_ngayTheu);
            this.panel13.Controls.Add(this.label13);
            this.panel13.Location = new System.Drawing.Point(26, 197);
            this.panel13.Margin = new System.Windows.Forms.Padding(5);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(345, 43);
            this.panel13.TabIndex = 2;
            // 
            // dtk_ngayTheu
            // 
            this.dtk_ngayTheu.CustomFormat = "dd/MM/yyyy";
            this.dtk_ngayTheu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtk_ngayTheu.Location = new System.Drawing.Point(122, 10);
            this.dtk_ngayTheu.Margin = new System.Windows.Forms.Padding(5);
            this.dtk_ngayTheu.Name = "dtk_ngayTheu";
            this.dtk_ngayTheu.Size = new System.Drawing.Size(195, 22);
            this.dtk_ngayTheu.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ngày Thuê: ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtKhachHang);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(26, 140);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(345, 47);
            this.panel5.TabIndex = 1;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(122, 12);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(5);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(195, 22);
            this.txtKhachHang.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Khách: ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbbMaPhong);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(26, 250);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(348, 54);
            this.panel4.TabIndex = 3;
            // 
            // cbbMaPhong
            // 
            this.cbbMaPhong.FormattingEnabled = true;
            this.cbbMaPhong.Location = new System.Drawing.Point(122, 10);
            this.cbbMaPhong.Margin = new System.Windows.Forms.Padding(5);
            this.cbbMaPhong.Name = "cbbMaPhong";
            this.cbbMaPhong.Size = new System.Drawing.Size(199, 24);
            this.cbbMaPhong.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Phòng: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu Thuê Phòng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSoPhieuThue);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(26, 76);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 54);
            this.panel3.TabIndex = 0;
            // 
            // txtSoPhieuThue
            // 
            this.txtSoPhieuThue.Location = new System.Drawing.Point(122, 10);
            this.txtSoPhieuThue.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoPhieuThue.Name = "txtSoPhieuThue";
            this.txtSoPhieuThue.Size = new System.Drawing.Size(195, 22);
            this.txtSoPhieuThue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phiếu: ";
            // 
            // bttThoat
            // 
            this.bttThoat.BackColor = System.Drawing.Color.White;
            this.bttThoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Image = global::NhaTro.Properties.Resources.iconfinder_multimedia_17_2849819;
            this.bttThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttThoat.Location = new System.Drawing.Point(277, 474);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(97, 52);
            this.bttThoat.TabIndex = 9;
            this.bttThoat.Text = "      Quay lại";
            this.bttThoat.UseVisualStyleBackColor = false;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(416, 578);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "rent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuê Phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rent_FormClosing_1);
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btt_xoa;
        private System.Windows.Forms.Button btt_Them;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.DateTimePicker dtk_ngayTheu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbbMaPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSoPhieuThue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Button bttThoat;
    }
}