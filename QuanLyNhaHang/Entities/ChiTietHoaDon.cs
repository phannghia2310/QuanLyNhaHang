using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Entities
{
    internal class ChiTietHoaDon
    {
        private string _MaHoaDon;
        public string MaHoaDon { get => _MaHoaDon; set => _MaHoaDon = value; }
        private string _MaMonAn;
        public string MaMonAn { get => _MaMonAn; set => _MaMonAn = value; }
        private int _DonGia;
        public int DonGia { get => _DonGia; set => _DonGia = value; }
        private int _SoLuong;
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        private int _ThanhTien;
        public int ThanhTien {  get => _ThanhTien;  set => _ThanhTien = value; }

        public ChiTietHoaDon() { }
    }
}
