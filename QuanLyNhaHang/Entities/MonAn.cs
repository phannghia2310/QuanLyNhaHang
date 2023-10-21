using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Entities
{
    internal class MonAn
    {
        private string _MaMonAn;
        public string MaMonAn { get => _MaMonAn; set => _MaMonAn = value; }
        private string _TenMonAn;
        public string TenMonAn { get => _TenMonAn; set => _TenMonAn = value; }
        private int _DonGia;
        public int DonGia { get => _DonGia; set => _DonGia = value; }
        private string _DVT;
        public string DVT { get => _DVT; set => _DVT = value; }
        private string _MaDanhMuc;
        public string MaDanhMuc { get => _MaDanhMuc; set => _MaDanhMuc = value; }

        public MonAn() { }
    }
}
