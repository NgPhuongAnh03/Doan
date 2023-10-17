using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Nhanvien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string Gioitinh { get; set; }
        public string SDT { get; set; }
        public string Diachi { get; set; }
        public DTO_Nhanvien(string maNV, string tenNV, string gioitinh, string sdt, string diachi)
        {
            MaNV = maNV;
            TenNV = tenNV;
            Gioitinh = gioitinh;
            SDT = sdt;
            Diachi = diachi;
        }
    }
}
