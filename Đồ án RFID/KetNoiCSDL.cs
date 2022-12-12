using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Đồ_án_RFID
{
    class KetNoiCSDL
    {
        private static SqlConnection cnn = new SqlConnection();
        public static void MoKetNoi()
        {
            try
            {
                string sqlcon = @"Data Source = DESKTOP-S4EE5LP\DUY; Initial Catalog = GymRFID; Integrated Security = True";
                cnn.ConnectionString = sqlcon;
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
            }
            catch (Exception)
            {

            }
        }
        public static void DongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public static DataTable ExcuteQuery(string sql)
        {
            MoKetNoi();
            SqlCommand cd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DongKetNoi();
            return dt;
        }
        public static void ExcuteNonQuery(string sql)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}

