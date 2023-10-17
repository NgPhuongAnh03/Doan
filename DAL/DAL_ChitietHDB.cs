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
    public class DAL_ChitietHDB:DAL_Connect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getChitietHDB()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from ChitietHDB", _con);
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
            string sql = "Select count(*) from ChitietHDB where MaCTHDB='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themChitietHDB(DTO_ChitietHDB hdb)
        {
            string sql = "Insert into ChitietHDB values('" + hdb.MaCTHDB + "',N'" + hdb.MaSP + "',N'" + hdb.Soluong + "',N'" + hdb.Dongia + "','" + hdb.Thanhtien + "',N'" + hdb.Ngayban + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaChitietHDB(DTO_ChitietHDB hdb)
        {
            string sql = "Insert into ChitietHDB values MaSP=N'" + hdb.MaSP + "', Soluong='" + hdb.Soluong + "', Soluong='" + hdb.Soluong + "', Thanhtien='" + hdb.Thanhtien + "', Ngayban='" + hdb.Ngayban + "' where MaCTHDB='" + hdb.MaCTHDB + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaChitietHDB(DTO_ChitietHDB hdb)
        {
            string sql = "delete from ChitietHDB where MaCTHDB='" + hdb.MaCTHDB + "' ";
            thucthisql(sql);
            return true;
        }
    }
}
