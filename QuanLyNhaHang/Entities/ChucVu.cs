using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Entities
{
    internal class ChucVu
    {
        private string _MaChucVu;
        public string MaChucVu { get => _MaChucVu; set => _MaChucVu = value; }
        private string _TenChucVu;
        public string TenChucVu { get => _TenChucVu; set => _TenChucVu = value; }
        
        public ChucVu() { }
        public ChucVu(string MaChucVu, string TenChucVu)
        {
            this.MaChucVu = MaChucVu;
            this.TenChucVu = TenChucVu;
        }
    }
}
