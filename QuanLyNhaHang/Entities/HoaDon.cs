using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Entities
{
    internal class HoaDon
    {
        private string _MaHoaDon;
        public string MaHoaDon {  get => _MaHoaDon;  set => _MaHoaDon = value; }
        private DateTime _NgayBan = DateTime.Now;
        public DateTime NgayBan { get => _NgayBan; set => _NgayBan = value; }
        private TimeSpan _ThoiGian = TimeSpan.Zero;
        public TimeSpan ThoiGian { get => _ThoiGian; set => _ThoiGian = value; }
        private string _KhuyenMai;
        public string KhuyenMai { get => _KhuyenMai; set => _KhuyenMai = value; }
        private int _TongTien;
        public int TongTien { get => _TongTien; set => _TongTien = value; }
        private string _TrangThai;
        public string TrangThai { get => _TrangThai; set => _TrangThai = value; }
        private string _GhiChu;
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
        private string _MaNhanVien;
        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        private string _MaKhuVuc;
        public string MaKhuVuc { get => _MaKhuVuc; set => _MaKhuVuc = value; }
        private string _MaBan;
        public string MaBan { get => _MaBan; set => _MaBan = value; }
        private List<ChiTietHoaDon> _ListChiTietHoaDon;
        public List<ChiTietHoaDon> ListChiTienHoaDon { get => _ListChiTietHoaDon; set => _ListChiTietHoaDon = value; }

        public HoaDon() { }
    }
}
