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
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void txtScanID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string mathe = txtScanID.Text;
                HienThiKhachHang(mathe);
                txtScanID.Clear();
            }
        }
        public void HienThiKhachHang(string mathe)
        {
            DataTable dt = new DataTable();
            dt = ThongTinKH.ThongTinKhachHang(mathe);
            if (dt.Rows.Count > 0)
            {
                txtmathe.Text = dt.Rows[0]["MaThe"].ToString();
                txtmakh.Text = dt.Rows[0]["MaKH"].ToString();
                txttenkh.Text = dt.Rows[0]["TenKH"].ToString();
                txtgioitinh.Text = dt.Rows[0]["GioiTinh"].ToString();
                txtsdt.Text = dt.Rows[0]["SĐT"].ToString();
                txtcmnd.Text = dt.Rows[0]["CMND"].ToString();
                DateTime ngaysinh = (DateTime)dt.Rows[0]["NgaySinh"];
                txtngaysinh.Text = ngaysinh.ToString("dd/MM/yyyy");
                txtdiachi.Text = dt.Rows[0]["Diachi"].ToString();
                Image im = GetCopyImage(@"picture\" + mathe + ".jpg");
                pictureBoxMain.Image = im;
                //pictureBoxMain.Load(@"picture\" + mathe + ".jpg");
                ThongTinKH.InsertThoiGianQuetThe(txtmathe.Text, txttenkh.Text, DateTime.Now.ToString("dd/MMM/yyyy HH:mm:ss"));
            }
            else
                MessageBox.Show("Thẻ chưa đăng ký!");
        }
        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {

                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

        private void quảnLýThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image != null)
                pictureBoxMain.Image.Dispose();
            Taothe frm = new Taothe();
            frm.Show();
        }

        private void lịchSửQuétThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lichsuquet form = new Lichsuquet();
            form.Show();
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gioithieu frm = new Gioithieu();
            frm.Show();
        }

        private void txtgioitinh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
