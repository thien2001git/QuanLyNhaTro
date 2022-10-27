namespace NhaTro
{
    partial class statistical
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.bttThongKe = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dTPNgayDen = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dTPFromDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DVThongKe = new System.Windows.Forms.DataGridView();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhongTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttThoat = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bttThongKe);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(22, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 135);
            this.panel3.TabIndex = 5;
            // 
            // bttThongKe
            // 
            this.bttThongKe.BackColor = System.Drawing.Color.White;
            this.bttThongKe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThongKe.Image = global::NhaTro.Properties.Resources.iconfinder_business_finance_money_31_2784264;
            this.bttThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttThongKe.Location = new System.Drawing.Point(379, 46);
            this.bttThongKe.Name = "bttThongKe";
            this.bttThongKe.Size = new System.Drawing.Size(119, 49);
            this.bttThongKe.TabIndex = 3;
            this.bttThongKe.Text = "      Thống Kê";
            this.bttThongKe.UseVisualStyleBackColor = false;
            this.bttThongKe.Click += new System.EventHandler(this.bttThongKe_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dTPNgayDen);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(33, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 38);
            this.panel4.TabIndex = 2;
            // 
            // dTPNgayDen
            // 
            this.dTPNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNgayDen.Location = new System.Drawing.Point(104, 6);
            this.dTPNgayDen.Name = "dTPNgayDen";
            this.dTPNgayDen.Size = new System.Drawing.Size(158, 24);
            this.dTPNgayDen.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đến Ngày: ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dTPFromDate);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(33, 35);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(285, 38);
            this.panel8.TabIndex = 1;
            // 
            // dTPFromDate
            // 
            this.dTPFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPFromDate.Location = new System.Drawing.Point(105, 6);
            this.dTPFromDate.Name = "dTPFromDate";
            this.dTPFromDate.Size = new System.Drawing.Size(157, 24);
            this.dTPFromDate.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Từ Ngày: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(174, -3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thống kê doanh thu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DVThongKe);
            this.panel1.Controls.Add(this.bttThoat);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(22, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 421);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(164, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 59);
            this.panel2.TabIndex = 3;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(182, 9);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(226, 44);
            this.txtTongTien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng Doanh Thu: ";
            // 
            // DVThongKe
            // 
            this.DVThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHD,
            this.MaPhongTro,
            this.NgayLap,
            this.ThanhTien});
            this.DVThongKe.Location = new System.Drawing.Point(50, 78);
            this.DVThongKe.Name = "DVThongKe";
            this.DVThongKe.Size = new System.Drawing.Size(525, 284);
            this.DVThongKe.TabIndex = 4;
            // 
            // SoHD
            // 
            this.SoHD.DataPropertyName = "SoHD";
            this.SoHD.HeaderText = "Số Hóa Đơn";
            this.SoHD.Name = "SoHD";
            this.SoHD.Width = 120;
            // 
            // MaPhongTro
            // 
            this.MaPhongTro.DataPropertyName = "MaPhongTro";
            this.MaPhongTro.HeaderText = "Mã Phòng Trọ";
            this.MaPhongTro.Name = "MaPhongTro";
            this.MaPhongTro.Width = 120;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 120;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 120;
            // 
            // bttThoat
            // 
            this.bttThoat.BackColor = System.Drawing.Color.White;
            this.bttThoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Image = global::NhaTro.Properties.Resources.iconfinder_multimedia_17_2849819;
            this.bttThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttThoat.Location = new System.Drawing.Point(456, 372);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(119, 40);
            this.bttThoat.TabIndex = 5;
            this.bttThoat.Text = "      Quay lại";
            this.bttThoat.UseVisualStyleBackColor = false;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(667, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "statistical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Doanh Thu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.statistical_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bttThongKe;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DVThongKe;
        private System.Windows.Forms.DateTimePicker dTPNgayDen;
        private System.Windows.Forms.DateTimePicker dTPFromDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}