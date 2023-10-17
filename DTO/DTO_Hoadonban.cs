using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Hoadonban
    {
        public string MaHDB { get; set; }
        public string MaNV { get; set; }
        public DateTime Ngayban { get; set; }
        public float Thanhtien { get; set; }
        public DTO_Hoadonban(string maHDB, string tenNV, DateTime ngayban, float thanhtien)
        {
            this.MaHDB = maHDB;
            this.MaNV = tenNV;
            this.Ngayban = ngayban;
            this.Thanhtien = thanhtien;
        }
    }
}
