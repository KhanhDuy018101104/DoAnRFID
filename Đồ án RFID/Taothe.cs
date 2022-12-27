using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Đồ_án_RFID
{
    public partial class Taothe : Form
    {
        public Taothe()
        {
            InitializeComponent();
            ReloadDanhsach();
        }

        string sourcefile = "";
        string destfile = Directory.GetCurrentDirectory() + @"\picture\";

        private void btsave_Click(object sender, EventArgs e)
        {
            string mathe = txtmathe.Text.Trim();
            string masv = txtmakh.Text.Trim();
            string tensv = txttenkh.Text.Trim();
            string gioitinh = txtgioitinh.Text.Trim();
            string sodienthoai = txtsdt.Text.Trim();
            string CMND = txtcmnd.Text.Trim();
            string diachi = txtdiachi.Text.Trim();
            string ngaysinh = txtngaysinh.Text.Trim();
            ThongTinKH.DangKyTheMoi(mathe, masv, tensv, gioitinh, sodienthoai, CMND, diachi, ngaysinh);
            File.Copy(sourcefile, destfile + mathe + ".jpg", true);
            ReloadDanhsach();
            MessageBox.Show("Đăng ký thành công");
        }

        

        private void btloadhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                sourcefile = open.FileName;
                pictureBox1.Load(sourcefile);
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            string mathe = txtmathe.Text.Trim();
            string makh = txtmakh.Text.Trim();
            string tenkh = txttenkh.Text.Trim();
            string gioitinh = txtgioitinh.Text.Trim();
            string sdt = txtsdt.Text.Trim();
            string CMND = txtcmnd.Text.Trim();
            string diachi = txtdiachi.Text.Trim();
            string ngaysinh = txtngaysinh.Text.Trim();
            ThongTinKH.CapNhatThe(mathe, makh, tenkh, gioitinh, sdt, CMND, diachi, ngaysinh);
            ReloadDanhsach();
            MessageBox.Show("Cập nhật thành công");
        }

        private void ReloadDanhsach()
        {
            DataTable dt = new DataTable();
            dt = ThongTinKH.GetAllKH();
            dataGridView1.DataSource = dt;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtmathe.Text = row.Cells["MaThe"].Value.ToString();
                txtmakh.Text = row.Cells["MaKH"].Value.ToString();
                txttenkh.Text = row.Cells["TenKH"].Value.ToString();
                txtgioitinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtsdt.Text = row.Cells["SĐT"].Value.ToString();
                txtcmnd.Text = row.Cells["CMND"].Value.ToString();
                txtngaysinh.Text = row.Cells["NgaySinh"].Value.ToString();
                txtdiachi.Text = row.Cells["Diachi"].Value.ToString();
                Image im = GetCopyImage(@"picture\" + txtmathe.Text + ".jpg");
                pictureBox1.Image = im;
                //pictureBox1.Load(@"picture\" + txtmathe.Text + ".jpg");
            }
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            string mathe = txtmathe.Text.Trim();
            string message = "Bạn có muốn xóa thẻ đã chọn?";
            string title = "Xác nhận xóa";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                ThongTinKH.XoaThe(mathe);
                pictureBox1.Image = null;
                File.Delete(destfile + mathe + ".jpg");
                ReloadDanhsach();
                MessageBox.Show("Xóa thẻ thành công");
            }
            else
            {
                this.Close();
            }
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            txtmathe.Text = "";
            txtmakh.Text = "";
            txttenkh.Text = "";
            txtgioitinh.Text = "";
            txtsdt.Text = "";
            txtcmnd.Text = "";
            txtdiachi.Text = "";
            txtngaysinh.Text = "";
            pictureBox1.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txttenkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void Taothe_Load(object sender, EventArgs e)
        {

        }
    }
 }

