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
    public class DAL_Nhanvien:DAL_Connect
    {
        DAL_Connect dbcon = new DAL_Connect();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getDAL_Nhanvien()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from Nhanvien", _con);
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
            string sql = "Select count (*) from Nhanvien where MaNV='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            int i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themNV(DTO_Nhanvien nv)
        {
            string sql = "insert into Nhanvien values('" + nv.MaNV + "',N'" + nv.TenNV + "','" + nv.Gioitinh + "','" + nv.SDT + "','" + nv.Diachi + "')";
            thucthisql(sql);
            return true;
        }
        public bool suaNV(DTO_Nhanvien nv)
        {
            string sql = "update Nhanvien set TenNV=N'" + nv.TenNV + "', Gioitinh='" + nv.Gioitinh + "', SDT='" + nv.SDT + "', Diachi=N'" + nv.Diachi + "'where MaNV='" + nv.MaNV + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaNV(DTO_Nhanvien nv)
        {
            string sql = "delete from Nhanvien where MaNV='" + nv.MaNV + "' ";
            thucthisql(sql);
            return true;
        }
    }
}
