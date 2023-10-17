using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChitietHDN
    {
        public string MaCTHDN { get; set; }
        public string MaHDN { get; set; }
        public string MaNV { get; set; }
        public string MaSP { get; set; }
        public float Dongia { get; set; }
        public int Soluong { get; set; }
        public float Thanhtien { get; set; }
        public DateTime Ngaynhap { get; set; }

        public DTO_ChitietHDN(string maCTHDN, string maHDN,string maNV, string maSP, int soluong, float dongia, float thanhtien, DateTime ngaynhap)
        {
            this.MaCTHDN = maCTHDN;
            this.MaHDN = maHDN;
            this.MaNV = maNV;
            this.MaSP = maSP;
            this.Soluong = soluong;
            this.Dongia = dongia;
            this.Thanhtien = thanhtien;
            this.Ngaynhap = ngaynhap;
        }
    }
}
