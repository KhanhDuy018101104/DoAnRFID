using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_RFID
{
    public partial class Lichsuquet : Form
    {
        public Lichsuquet()
        {
            InitializeComponent();
            Loadcbbtenkh();
        }
        public void Loadcbbtenkh()
        {
            DataTable dt = new DataTable();
            dt = ThongTinKH.GetTenKH();
            /*
            cbbtenkh.Items.Add("Tất cả");
            foreach (DataRow dr in dt.Rows)
            {
                cbbtenkh.Items.Add(dr[0].ToString());
            }
             */
            DataRow dr = dt.NewRow();
            dr["TenKH"] = "Tất cả";
            dr["MaThe"] = "999999999";
            dt.Rows.InsertAt(dr, 0);
            cbtenkh.DataSource = dt;
            cbtenkh.DisplayMember = "TenKH";
            cbtenkh.ValueMember = "MaThe";
        }
        private void Lichsuquet_Load(object sender, EventArgs e)
        {

        }

        private void btxemlichsuquet_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ThongTinKH.LichSuQuetThe(cbtenkh.SelectedValue.ToString());
            dataGridView_LichSuQuet.DataSource = dt;
        }
    }
}
