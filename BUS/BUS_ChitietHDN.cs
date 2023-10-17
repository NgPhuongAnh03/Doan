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
    public class BUS_ChitietHDN
    {
        DAL_ChitietHDN dalChitietHDN = new DAL_ChitietHDN();
        public DataTable getChitietHDN()
        {
            return dalChitietHDN.getChitietHDN();
        }
        public int kiemtramatrung(string ma)
        {
            return dalChitietHDN.kiemtramatrung(ma);
        }
        public bool themChitietHDN(DTO_ChitietHDN hdn)
        {
            return dalChitietHDN.themChitietHDN(hdn);
        }
        public bool suaChitietHDN(DTO_ChitietHDN hdn)
        {
            return dalChitietHDN.suaChitietHDN(hdn);
        }
        public bool xoaChitietHDN(DTO_ChitietHDN hdn)
        {
            return dalChitietHDN.xoaChitietHDN(hdn);
        }
    }
}
