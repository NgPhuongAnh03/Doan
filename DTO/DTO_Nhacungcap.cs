using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Nhacungcap
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string SDT { get; set; }
        public string Diachi { get; set; }
        public DTO_Nhacungcap(string maNCC, string tenNCC, string SDT, string diachi)
        {
            this.MaNCC = maNCC;
            this.TenNCC = tenNCC;
            this.SDT = SDT;
            this.Diachi = diachi;
        }
    }
}
