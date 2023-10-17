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
    public class DAL_Hoadonban:DAL_Connect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getHoadonban()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from Hoadonban", _con);
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
            string sql = "Select count(*) from Hoadonban where MaHDB='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themHDB(DTO_Hoadonban hdb)
        {
            string sql = "Insert into Hoadonban values('" + hdb.MaHDB + "',N'" + hdb.MaNV + "',N'" + hdb.Ngayban + "','" + hdb.Thanhtien + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaHDB(DTO_Hoadonban hdb)
        {
            string sql = "Update Hoadonban set MaNV='" + hdb.MaNV + "', Ngayban='" + hdb.Ngayban + "', Thanhtien='" + hdb.Thanhtien + "' where MaHDN='" + hdb.MaHDB + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaHDB(DTO_Hoadonban hdb)
        {
            string sql = "delete from Hoadonban where MaNCC='" + hdb.MaHDB + "' ";
            thucthisql(sql);
            return true;
        }
    }
}
