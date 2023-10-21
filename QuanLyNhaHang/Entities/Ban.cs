using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Entities
{
    internal class Ban
    {
        private string _MaBan;
        public string MaBan { get => _MaBan; set => _MaBan = value; }
        private string _TenBan;
        public string TenBan { get => _TenBan; set => _TenBan = value; }
        private string _TrangThai;
        public string TrangThai { get => _TrangThai; set => _TrangThai = value; }
        private string _MaKhuVuc;
        public string MaKhuVuc {  get => _MaKhuVuc; set => _MaKhuVuc = value; }

        public Ban() { }
    }
}
