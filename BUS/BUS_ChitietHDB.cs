using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_ChitietHDB
    {
        DAL_ChitietHDB dalChitietHDB = new DAL_ChitietHDB();
        public DataTable getChitietHDB()
        {
            return dalChitietHDB.getChitietHDB();
        }
        public int kiemtramatrung(string ma)
        {
            return dalChitietHDB.kiemtramatrung(ma);
        }
        public bool themChitietHDB(DTO_ChitietHDB hdb)
        {
            return dalChitietHDB.themChitietHDB(hdb);
        }
        public bool suaChitietHDB(DTO_ChitietHDB hdb)
        {
            return dalChitietHDB.suaChitietHDB(hdb);
        }
        public bool xoaChitietHDB(DTO_ChitietHDB hdb)
        {
            return dalChitietHDB.xoaChitietHDB(hdb);
        }
    }
}
