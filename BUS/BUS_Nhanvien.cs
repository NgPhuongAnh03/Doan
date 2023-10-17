using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_Nhanvien
    {
        DAL_Nhanvien dalNhanvien = new DAL_Nhanvien();
        public DataTable getDAL_Nhanvien()
        {
            return dalNhanvien.getDAL_Nhanvien();
        }
        public int kiemtramatrung(string ma)
        {
            return dalNhanvien.kiemtramatrung(ma);
        }
        public bool themNV(DTO_Nhanvien nv)
        {
            return dalNhanvien.themNV(nv);
        }
        public bool suaNV(DTO_Nhanvien nv)
        {
            return dalNhanvien.suaNV(nv);
        }
        public bool xoaNV(DTO_Nhanvien nv)
        {
            return dalNhanvien.xoaNV(nv);
        }
    }
}
