using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Entities
{
    internal class TaiKhoan
    {
        private string _TenDangNhap;
        public string TenDangNhap { get => _TenDangNhap; set => _TenDangNhap = value; }
        private string _MatKhau;
        public string MatKhau { get => _MatKhau; set => _MatKhau = value; }
        private string _MaNhanVien;
        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        private string _MaChucVu;
        public string MaChucVu { get => _MaChucVu; set => _MaChucVu = value; }

        public TaiKhoan() { }
    }
}
