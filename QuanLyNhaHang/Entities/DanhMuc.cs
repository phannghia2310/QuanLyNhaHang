using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Entities
{
    internal class DanhMuc
    {
        private string _MaDanhMuc;
        public string MaDanhMuc { get => _MaDanhMuc; set => _MaDanhMuc = value; }
        private string _TenDanhMuc;
        public string TenDanhMuc { get => _TenDanhMuc; set => _TenDanhMuc = value; }

        public DanhMuc() { }
        public DanhMuc(string MaDanhMuc, string TenDanhMuc)
        {
            this.MaDanhMuc = MaDanhMuc;
            this.TenDanhMuc = TenDanhMuc;
        }
    }
}
