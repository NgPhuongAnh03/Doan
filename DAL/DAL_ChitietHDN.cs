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
    public class DAL_ChitietHDN:DAL_Connect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getChitietHDN()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from ChitietHDN", _con);
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
            string sql = "Select count(*) from ChitietHDN where MaCTHDN='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themChitietHDN(DTO_ChitietHDN hdn)
        {
            string sql = "Insert into ChitietHDN values('" + hdn.MaCTHDN + "',N'" + hdn.MaHDN + "',N'" + hdn.MaNV + "',N'" + hdn.MaSP + "',N'" + hdn.Soluong + "',N'" + hdn.Dongia + "','" + hdn.Thanhtien + "',N'" + hdn.Ngaynhap + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaChitietHDN(DTO_ChitietHDN hdn)
        {
            string sql = "Update ChitietHDN set MaHDN='" + hdn.MaHDN + "',N'" + hdn.MaNV + "',N'" + hdn.MaSP + "', Soluong='" + hdn.Soluong + "', Dongia='" + hdn.Dongia + "', Thanhtien='" + hdn.Thanhtien + "', Ngaynhap='" + hdn.Ngaynhap + "' where MaCTHDN='" + hdn.MaCTHDN + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaChitietHDN(DTO_ChitietHDN hdn)
        {
            string sql = "delete from ChitietHDN where MaCTHDN='" + hdn.MaCTHDN + "' ";
            thucthisql(sql);
            return true;
        }
    }
}
