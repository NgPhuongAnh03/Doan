using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChitietHDB
    {
        public string MaCTHDB { get; set; }
        public string MaHDB { get; set; }
        public string MaNV { get; set; }
        public string MaSP { get; set; }
        public int Soluong { get; set; }
        public float Dongia { get; set; }
        public float Thanhtien { get; set; }
        public DateTime Ngayban { get; set; }

        public DTO_ChitietHDB(string maCTHDB, string maHDB, string maNV, string maSP, int soluong, float dongia, float thanhtien, DateTime ngayban)
        {
            this.MaCTHDB = maCTHDB;
            this.MaHDB = maHDB;
            this.MaNV = maNV;
            this.MaSP = maSP;
            this.Soluong = soluong;
            this.Dongia = dongia;
            this.Thanhtien = thanhtien;
            this.Ngayban = ngayban;
        }
    }
}
