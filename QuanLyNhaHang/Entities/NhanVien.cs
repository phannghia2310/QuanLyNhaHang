using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Entities
{
    internal class NhanVien
    {
        private string _MaNhanVien;
        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        private string _TenNhanVien;
        public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
        private string _GioiTinh;
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        private DateTime _NgaySinh = DateTime.Parse("01-01-1999");
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        private string _DiaChi;
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        private string _SDT;
        public string SDT { get => _SDT; set => _SDT = value; }
        private string _MaChucVu;
        public string MaChucVu { get => _MaChucVu; set => _MaChucVu = value; }

        public NhanVien() { }
    }
}
