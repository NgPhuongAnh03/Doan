using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_Thongke_Baocao
    {
        DAL_Thongke_Baocao dalThongke_Baocao = new DAL_Thongke_Baocao();
        public int SumHDB_theongay(DTO_Hoadonban hd1, DTO_Hoadonban hd2)
        {
            return dalThongke_Baocao.SumHDB_theongay(hd1, hd2);
        }

        public int SumHDN_theongay(DTO_Hoadonnhap hd1, DTO_Hoadonnhap hd2)
        {
            return dalThongke_Baocao.SumHDN_theongay(hd1, hd2);
        }

        public DataTable LoadHoaDonBan(DTO_Hoadonban hd1, DTO_Hoadonban hd2)
        {
            return dalThongke_Baocao.LoadHoaDonBan(hd1, hd2);
        }
        public DataTable LoadHoaDonNhap(DTO_Hoadonnhap hd1, DTO_Hoadonnhap hd2)
        {
            return dalThongke_Baocao.LoadHoaDonNhap(hd1, hd2);
        }
    }
}
