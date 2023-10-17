using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Hoadonnhap
    {
        public string MaHDN { get; set; }
        public string MaNV { get; set; }
        public DateTime Ngaynhap { get; set; }
        public float Thanhtien { get; set; }
        public DTO_Hoadonnhap(string maHDN, string tenNV,  DateTime ngaynhap,float thanhtien)
        {
            this.MaHDN = maHDN;
            this.MaNV = tenNV;
            this.Ngaynhap = ngaynhap;
            this.Thanhtien = thanhtien;
        }
    }
}
