using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Entities
{
    internal class KhuVuc
    {
        private string _MaKhuVuc;
        public string MaKhuVuc { get => _MaKhuVuc; set => _MaKhuVuc = value; }
        private string _TenKhuVuc;
        public string TenKhuVuc { get => _TenKhuVuc; set => _TenKhuVuc = value; }

        public KhuVuc() { }
        public KhuVuc(string MaKhuVuc, string TenKhuVuc)
        {
            this.MaKhuVuc = MaKhuVuc;
            this.TenKhuVuc = TenKhuVuc;
        }
    }
}
