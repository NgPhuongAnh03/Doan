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
    public class BUS_Sanpham
    {
        DAL_Sanpham dalSanpham = new DAL_Sanpham();
        public DataTable getDAL_Sanpham()
        {
            return dalSanpham.getDAL_Sanpham();
        }
        public int kiemtramatrung(string ma)
        {
            return dalSanpham.kiemtramatrung(ma);
        }
        public bool themSP(DTO_Sanpham sp)
        {
            return dalSanpham.themSP(sp);
        }
        public bool suaSP(DTO_Sanpham sp)
        {
            return dalSanpham.suaSP(sp);
        }
        public bool xoaSP(DTO_Sanpham ma)
        {
            return dalSanpham.xoaSP(ma);
        }
    }
}
