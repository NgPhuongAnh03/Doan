using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_Thongke_Baocao:DAL_Connect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public int SumHDB_theongay(DTO_Hoadonban hd1, DTO_Hoadonban hd2)
        {
            string ngay1 = string.Format("{1}-{2}-{0}", hd1.Ngayban.Day, hd1.Ngayban.Year, hd1.Ngayban.Month);
            string ngay2 = string.Format("{1}-{2}-{0}", hd2.Ngayban.Day, hd2.Ngayban.Year, hd2.Ngayban.Month);

            _con.Open();
            dt = new DataTable();
            string select = string.Format("SELECT SUM(TongTien) FROM tbl_HoaDonBan WHERE tbl_HoaDonBan.NgayBan between '{0}' and '{1}'", ngay1, ngay2);
            da = new SqlDataAdapter(select, _con);
            da.Fill(dt);
            int sum = 0;

            if (dt.Rows.Count > 0)
            {
                sum = int.Parse(dt.Rows[0][0].ToString());
            }
            _con.Close();
            return sum;
        }

        public int SumHDN_theongay(DTO_Hoadonnhap hd1, DTO_Hoadonnhap hd2)
        {
            string ngay1 = string.Format("{1}-{2}-{0}", hd1.Ngaynhap.Day, hd1.Ngaynhap.Year, hd1.Ngaynhap.Month);
            string ngay2 = string.Format("{1}-{2}-{0}", hd2.Ngaynhap.Day, hd2.Ngaynhap.Year, hd2.Ngaynhap.Month);

            _con.Open();
            dt = new DataTable();
            string select = string.Format("SELECT SUM(TongTien) FROM tbl_HoaDonNhap WHERE tbl_HoaDonNhap.NgayNhap between '{0}' and '{1}'", ngay1, ngay2);
            da = new SqlDataAdapter(select, _con);
            da.Fill(dt);
            int sum = 0;

            if (dt.Rows.Count > 0)
            {
                sum = int.Parse(dt.Rows[0][0].ToString());
            }
            _con.Close();
            return sum;
        }

        public DataTable LoadHoaDonBan(DTO_Hoadonban hd1, DTO_Hoadonban hd2)
        {
            string ngay1 = string.Format("{1}-{2}-{0}", hd1.Ngayban.Day, hd1.Ngayban.Year, hd1.Ngayban.Month);
            string ngay2 = string.Format("{1}-{2}-{0}", hd2.Ngayban.Day, hd2.Ngayban.Year, hd2.Ngayban.Month);

            _con.Open();
            dt = new DataTable();
            string select = string.Format("SELECT A.MaHDB, A.Ngayban, A.MaNV, B.MaSP, A.Thanhtien FROM Hoadonban A INNER JOIN ChitietHDB B ON A.MaHDB = B.MaHDB WHERE NgayBan between '{0}' and '{1}'", ngay1, ngay2);
            da = new SqlDataAdapter(select, _con);
            da.Fill(dt);
            _con.Close();
            return dt;
        }

        public DataTable LoadHoaDonNhap(DTO_Hoadonnhap hd1, DTO_Hoadonnhap hd2)
        {
            string ngay1 = string.Format("{1}-{2}-{0}", hd1.Ngaynhap.Day, hd1.Ngaynhap.Year, hd1.Ngaynhap.Month);
            string ngay2 = string.Format("{1}-{2}-{0}", hd2.Ngaynhap.Day, hd2.Ngaynhap.Year, hd2.Ngaynhap.Month);

            _con.Open();
            dt = new DataTable();
            string select = string.Format("SELECT A.MaHDN, A.MaNV, B.MaSP, A.Thanhtien FROM Hoadonnhap A INNER JOIN tbl_ChiTietHoaDonNhap B ON A.MaHDN = B.MaHDN WHERE Ngaynhap between '{0}' and '{1}'", ngay1, ngay2);
            da = new SqlDataAdapter(select, _con);
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}
