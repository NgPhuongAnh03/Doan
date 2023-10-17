using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_Hoadonban
    {
        DAL_Hoadonban dalHoadonban = new DAL_Hoadonban();
        public DataTable getHoadonban()
        {
            return dalHoadonban.getHoadonban();
        }
        public int kiemtramatrung(string ma)
        {
            return dalHoadonban.kiemtramatrung(ma);
        }
        public bool themHDB(DTO_Hoadonban hdb)
        {
            return dalHoadonban.themHDB(hdb);
        }
        public bool suaHDB(DTO_Hoadonban hdb)
        {
            return dalHoadonban.suaHDB(hdb);
        }
        public bool xoaHDB(DTO_Hoadonban hdb)
        {
            return dalHoadonban.xoaHDB(hdb);
        }
    }
}
