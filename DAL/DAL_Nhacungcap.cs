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
    public class DAL_Nhacungcap:DAL_Connect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getDAL_NhaCungCap()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from Nhacungcap", _con);
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
            string sql = "Select count (*) from Nhacungcap where MaNCC='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            int i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }

        public bool themNCC(DTO_Nhacungcap ncc)
        {
            string sql = "insert into Nhacungcap values('" + ncc.MaNCC + "',N'" + ncc.TenNCC + "','" + ncc.SDT + "',N'" + ncc.Diachi +"')";
            thucthisql(sql);
            return true;
        }
        public bool suaNCC(DTO_Nhacungcap ncc)
        {
            string sql = "update Nhacungcap set TenNCC=N'" + ncc.TenNCC + "',SDT='" + ncc.SDT + "',DiaChi=N'" + ncc.Diachi + "' where MaNCC='" + ncc.MaNCC + "' ";
            thucthisql(sql);
            return true;
        }
        public bool xoaNCC(DTO_Nhacungcap ncc)
        {
            string sql = "delete from Nhacungcap where MaNCC='" + ncc.MaNCC + "' ";
            thucthisql(sql);
            return true;
        }
    }
}
