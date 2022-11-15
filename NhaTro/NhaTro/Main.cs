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
using System.IO;
using NhaTro.DAL;

namespace NhaTro
{
    public partial class Main : Form
    {
        List<Phong> lstRoom = new List<Phong>();

        public Main()
        {
            InitializeComponent();
        }
        SqlConnection con;
        DirectoryInfo dr;

        private void Form2_Load(object sender, EventArgs e)
        {

            Connection mycon = new Connection() ;
            con = mycon.getConnection();
            HienThiAnhPhong();

        }
        
        private void ThietLapTextBox()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtDienTich.Text = "";
            txtLoaiPhong.Text = "";
            txtGiaPhong.Text = "";
            txtTrangThai.Text = "";
        }

        //lay dach sach phong
        private  List<Phong> LayDanhSachPhong()
        {
            List<Phong> tableList = new List<Phong>();
            con.Open();
            string stt = "select * from PHONGTRO";
            SqlCommand cmd = new SqlCommand(stt, con);
            SqlDataReader ad = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(ad);
            con.Close();
            foreach(DataRow item in tb.Rows)
            {
                Phong table = new Phong(item);
                tableList.Add(table);
            }
            return tableList;
        }

        //hiển thị hình ảnh lên ListView
        private void HienThiAnhPhong()
        {
            lstRoom = LayDanhSachPhong();

            for (int i = 0; i < lstRoom.Count;i ++)
            {
                dr = new DirectoryInfo("image");
            }
            for(int i = 0; i < lstRoom.Count; i++)
            {
                foreach (FileInfo file in dr.GetFiles())
                {
                    try
                    {
                        this.imageListRoom.Images.Add(Image.FromFile(file.FullName));
                    }
                    catch
                    {
                        MessageBox.Show("Không tìm thấy đường dẫn");
                    }
                }
            }
            // Cấu hình cho hình ảnh
            this.listViewRoom.View = View.LargeIcon;
            this.imageListRoom.ImageSize = new Size(65, 60);
            this.listViewRoom.LargeImageList = this.imageListRoom;

            for (int j = 0; j < imageListRoom.Images.Count; j++)
            {
                ListViewItem lst = new ListViewItem();
                lst.ImageIndex = j;
                string a = Convert.ToString(j);
                lst.Text = a;
                this.listViewRoom.Items.Add(lst);
            }
        }

        private void LapHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill f4 = new Bill();
            this.Hide();
            f4.ShowDialog();
            this.Show();
        }

        private void QuanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager f = new Manager();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thongKeDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statistical f5 = new statistical();
            this.Hide();
            f5.ShowDialog();
            this.Show();
        }

        //click vào listView hiển thị thông tin phong nên textBox
        private void listViewRoom_Click(object sender, EventArgs e)
        {
            //Lấy thông tin tương ứng hiện lên textBo
            int stritem = int.Parse(listViewRoom.SelectedItems[0].SubItems[0].Text);
            if (stritem.ToString() != "")
            {
                txtMaPhong.Text = Convert.ToString(lstRoom[stritem].MaPhong);
                txtTenPhong.Text = lstRoom[stritem].TenPhong;
                txtDienTich.Text = Convert.ToString(lstRoom[stritem].DienTich);
                txtLoaiPhong.Text = lstRoom[stritem].LoaiPhong;
                txtGiaPhong.Text = Convert.ToString(lstRoom[stritem].GiaPhong);
                txtTrangThai.Text = lstRoom[stritem].TrangThai;
                if (txtTrangThai.Text == "Đang Thuê")
                {
                    bttDatPhong.Enabled = false;
                }
                else
                {
                    bttDatPhong.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phòng!");
            }

        }

        private void bttLamMoi_Click(object sender, EventArgs e)
        {
            listViewRoom.Items.Clear();
            imageListRoom.Images.Clear();
            HienThiAnhPhong();
            listViewRoom.Enabled = true;
            ThietLapTextBox();
            bttDatPhong.Enabled = true;
        }

        private void bttDatPhong_Click(object sender, EventArgs e)
        {
                rent f = new rent();
                f.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            Login flg = new Login();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
