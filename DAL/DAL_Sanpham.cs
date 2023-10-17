using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Sanpham:DAL_Connect
    {
        DAL_Connect dbcon = new DAL_Connect();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getDAL_Sanpham()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from Sanpham", _con);
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
            string sql = "Select count (*) from Sanpham where MaSP='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            int i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themSP(DTO_Sanpham sp)
        {
            string sql = "insert into Sanpham values('" + sp.MaSP + "',N'" + sp.TenSP + "','" + sp.Size + "','" + sp.Soluong + "','" + sp.Giaban + "','" + sp.MaNCC + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaSP(DTO_Sanpham sp)
        {
            string sql = "update Sanpham set TenSP=N'" + sp.TenSP + "',Size='" + sp.Size + "',Soluong='" + sp.Soluong + "',Giaban='" + sp.Giaban + "' where MaSP='" + sp.MaSP + "' ";
            thucthisql(sql);
            return true;
        }
        public bool xoaSP(DTO_Sanpham sp)
        {
            string sql = "delete from Sanpham where MaSP='" + sp.MaSP + "' ";
            thucthisql(sql);
            return true;
        }
    }
}
