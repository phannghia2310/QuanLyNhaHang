using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Entities
{
    internal class UserLogin
    {
        private static string _TenDangNhap;
        public static string TenDangNhap { get => _TenDangNhap; set => _TenDangNhap = value; }
        private static string _MatKhau;
        public static string MatKhau { get => _MatKhau; set => _MatKhau = value; }
        private static string _MaNhanVien = "";
        public static string MaNhanVien {  get => _MaNhanVien; set => _MaNhanVien = value; }
        private static string _MaChucVu = "";
        public static string MaChucVu {  get => _MaChucVu; set => _MaChucVu = value; }

    }
}
