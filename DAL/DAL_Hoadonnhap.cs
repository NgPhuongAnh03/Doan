using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Hoadonnhap:DAL_Connect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getHoadonnhap()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from Hoadonnhap", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void thucthisql(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public int kiemtramatrung(string ma)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from Hoadonnhap where MaHDN='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themHDN(DTO_Hoadonnhap hdn)
        {
            string sql = "Insert into Hoadonnhap values('" + hdn.MaHDN + "',N'" + hdn.MaNV + "',N'" + hdn.Ngaynhap + "','" + hdn.Thanhtien + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaHDN(DTO_Hoadonnhap hdn)
        {
            string sql = "Update Hoadonnhap set MaNV='" + hdn.MaNV + "', Ngaynhap='" + hdn.Ngaynhap + "', Thanhtien='" + hdn.Thanhtien + "' where MaHDN='" + hdn.MaHDN + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaHDN(DTO_Hoadonnhap hdn)
        {
            string sql = "delete from tbl_NhaCungCap where MaNCC='" + hdn.MaHDN + "' ";
            thucthisql(sql);
            return true;
        }
    }
}
