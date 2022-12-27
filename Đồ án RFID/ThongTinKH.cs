using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Đồ_án_RFID
{
    class ThongTinKH
    {
        public static DataTable ThongTinKhachHang(string mathe)
        {
            string sql = "SELECT * FROM KHACHHANG WHERE MaThe = " + mathe;
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static void InsertThoiGianQuetThe(string mathe, string tenkh, string thoigian)
        {
            string sql = "INSERT INTO LICHSUQUET (MaThe, TenKH, ThoiGian) VALUES('" + mathe + "', N'" + tenkh + "','" + thoigian + "')";
            KetNoiCSDL.ExcuteNonQuery(sql);
        }

        public static DataTable LichSuQuetThe(string mathe)
        {
            string sql = "";
            if (mathe == "999999999")
                sql = "SELECT * FROM LICHSUQUET";
            else sql = "SELECT * FROM LICHSUQUET WHERE MaThe = " + mathe + " ORDER BY ThoiGian DESC";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable GetTenKH()
        {
            string sql = "SELECT DISTINCT TenKH, MaThe FROM KHACHHANG ORDER BY TenKH";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static void DangKyTheMoi(string mathe, string makh, string tenkh, string gioitinh, string sdt, string cmnd, string diachi, string ngaysinh)
        {
            string sql = "INSERT INTO KHACHHANG (MaThe, MaKH, TenKH, GioiTinh, SĐT, CMND, Diachi, NgaySinh) VALUES ('" + mathe + "','" + makh + "', N'" + tenkh + "','" + gioitinh + "','" + sdt + "','" + cmnd + "', N'" + diachi + "','" + ngaysinh + "')";
            KetNoiCSDL.ExcuteNonQuery(sql);
        }

        public static void CapNhatThe(string mathe, string makh, string tenkh, string gioitinh, string sdt, string cmnd, string diachi, string ngaysinh)
        {
            string sql = "UPDATE KHACHHANG SET MaKH = '" + makh + "', TenKH = N'" + tenkh +
                "', GioiTinh = '" + gioitinh + "', SĐT = '" + sdt + "', CMND = '" + cmnd + "', Diachi = N'" + diachi + "', NgaySinh = '" + ngaysinh + "' WHERE MaThe = '" + mathe + "'";
            KetNoiCSDL.ExcuteNonQuery(sql);
        }

        public static void XoaThe(string mathe)
        {
            string sql = "DELETE FROM KHACHHANG WHERE MaThe = '" + mathe + "'";
            KetNoiCSDL.ExcuteNonQuery(sql);
        }

        public static DataTable GetAllKH()
        {
            string sql = "SELECT * FROM KHACHHANG";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.ExcuteQuery(sql);
            return dt;
        }
    }
}

   

