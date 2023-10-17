using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Sanpham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string Size { get; set; }
        public int Soluong { get; set; }
        public float Giaban { get; set; }
        public string MaNCC { get; set; }
        public DTO_Sanpham(string maSP, string tenSP, string size, int soluong, float giaban, string maNCC)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.Size = size;
            this.Soluong = soluong;
            this.Giaban = giaban;
            this.MaNCC = maNCC;
        }
    }
}
