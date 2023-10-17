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
    public class BUS_Nhacungcap
    {
        DAL_Nhacungcap dalNhacungcap = new DAL_Nhacungcap();
        public DataTable getDAL_NhaCungCap()
        {
            return dalNhacungcap.getDAL_NhaCungCap();
        }
        public int kiemtramatrung(string ma)
        {
            return dalNhacungcap.kiemtramatrung(ma);
        }
        public bool themNCC(DTO_Nhacungcap ncc)
        {
            return dalNhacungcap.themNCC(ncc);
        }
        public bool suaNCC(DTO_Nhacungcap ncc)
        {
            return dalNhacungcap.suaNCC(ncc);
        }
        public bool xoaNCC(DTO_Nhacungcap ncc)
        {
            return dalNhacungcap.xoaNCC(ncc);
        }
    }
}
