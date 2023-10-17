using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Hoadonnhap
    {
        DAL_Hoadonnhap dalHoadonnhap = new DAL_Hoadonnhap();
        public DataTable getHoadonnhap()
        {
            return dalHoadonnhap.getHoadonnhap();
        }
        public int kiemtramatrung(string ma)
        {
            return dalHoadonnhap.kiemtramatrung(ma);
        }
        public bool themHDN(DTO_Hoadonnhap hdn)
        {
            return dalHoadonnhap.themHDN(hdn);
        }
        public bool suaHDN(DTO_Hoadonnhap hdn)
        {
            return dalHoadonnhap.suaHDN(hdn);
        }
        public bool xoaHDN(DTO_Hoadonnhap hdn)
        {
            return dalHoadonnhap.xoaHDN(hdn);
        }
    }
}
