using QuanLyNhaHang.DataLayer;
using QuanLyNhaHang.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.BusinessLayer
{
    internal class HoaDonBLL
    {
        DataAccess da = new DataAccess();

        public DataTable GetDSHoaDon()
        {
            string select = "SELECT hd.MaHoaDon, hd.NgayBan, hd.ThoiGian, hd.TongTien, hd.TrangThai, nv.TenNhanVien, kv.TenKhuVuc, b.TenBan" +
                            " FROM HoaDon hd, NhanVien nv, KhuVuc kv, Ban b" +
                            " WHERE hd.MaNhanVien = nv.MaNhanVien AND hd.MaKhuVuc = kv.MaKhuVuc AND hd.MaBan = b.MaBan AND hd.TrangThai=N'ĐÃ THANH TOÁN'";
            return da.GetDataTable(select);
        }

        public HoaDon GetHoaDonByMa(string MaHoaDon)
        {
            HoaDon hd = new HoaDon();

            string select = "SELECT * FROM HoaDon WHERE MaHoaDon='" + MaHoaDon + "'";
            DataTable dt = da.GetDataTable(select);
            if(dt.Rows.Count > 0)
            {
                hd.MaHoaDon = dt.Rows[0]["MaHoaDon"].ToString();
                hd.NgayBan = DateTime.Parse(dt.Rows[0]["NgayBan"].ToString());
                hd.ThoiGian = TimeSpan.Parse(dt.Rows[0]["ThoiGian"].ToString());
                hd.KhuyenMai = dt.Rows[0]["KhuyenMai"].ToString();
                hd.TongTien = int.Parse(dt.Rows[0]["TongTien"].ToString());
                hd.TrangThai = dt.Rows[0]["TrangThai"].ToString();
                hd.GhiChu = dt.Rows[0]["GhiChu"].ToString();
                hd.MaNhanVien = dt.Rows[0]["MaNhanVien"].ToString();
                hd.MaKhuVuc = dt.Rows[0]["MaKhuVuc"].ToString();
                hd.MaBan = dt.Rows[0]["MaBan"].ToString();

                return hd;
            }

            return null;
        }

        public string GetMaHoaDonByMaBan(string MaBan)
        {
            string select = "SELECT DISTINCT MaHoaDon FROM HoaDon WHERE MaBan='" + MaBan + "' AND TrangThai= N'CHƯA THANH TOÁN'";
            return da.GetValue(select, "MaHoaDon");
        }

        public string GetMaHoaDon()
        {
            string select = "SELECT TOP 1 MaHoaDon FROM HoaDon ORDER BY MaHoaDon DESC";
            return da.GetLastID(select);
        }

        public DataTable TongHoaDonThang()
        {
            string select = "SELECT * FROM HoaDon WHERE TrangThai=N'ĐÃ THANH TOÁN' AND DAY(NgayBan) = " + DateTime.Now.ToString("MM");
            return da.GetDataTable(select);
        }

        public DataTable TongHoaDonNgay()
        {
            string select = "SELECT * FROM HoaDon WHERE TrangThai=N'ĐÃ THANH TOÁN' AND MONTH(NgayBan) = " + DateTime.Now.ToString("dd");
            return da.GetDataTable(select);
        }

        public DataTable TongDoanhSoThang()
        {
            string select = "SELECT TongTIen FROM HoaDon WHERE TrangThai=N'ĐÃ THANH TOÁN' AND DAY(NgayBan)=" + DateTime.Now.ToString("MM");
            return da.GetDataTable(select);
        }

        public DataTable TongDoanhSoNgay()
        {
            string select = "SELECT TongTIen FROM HoaDon WHERE TrangThai=N'ĐÃ THANH TOÁN' AND MONTH(NgayBan)=" + DateTime.Now.ToString("dd");
            return da.GetDataTable(select);
        }

        public void Insert(HoaDon hd)
        {
            string query = "INSERT INTO HoaDon VALUES ('" + hd.MaHoaDon + "', '" + hd.NgayBan + "', '" + hd.ThoiGian + "', '" + hd.KhuyenMai + "', " + hd.TongTien + ", N'" + 
                                        hd.TrangThai + "', N'" + hd.GhiChu + "', '" + hd.MaNhanVien + "', '" + hd.MaKhuVuc + "', '" + hd.MaBan + "')";
            da.ExecuteNonQuery(query);
        }

        public void Update(HoaDon hd)
        {
            string query = "UPDATE HoaDon SET NgayBan='" + hd.NgayBan + "', ThoiGian='" + hd.ThoiGian + "', KhuyenMai='" + hd.KhuyenMai + "', TongTien=" + hd.TongTien + ", TrangThai=N'" + hd.TrangThai + 
                                        "', GhiChu=N'" + hd.GhiChu + "', MaNhanVien='" + hd.MaNhanVien + "', MaKhuVuc='" + hd.MaKhuVuc + "', MaBan='" + hd.MaBan + "' WHERE MaHoaDon='" + hd.MaHoaDon + "'";
            da.ExecuteNonQuery(query);
        }

        public void Delete(HoaDon hd)
        {
            string query = "DELETE FROM HoaDon WHERE MaHoaDon='" + hd.MaHoaDon + "'";
            da.ExecuteNonQuery(query);
        }

        public void CapNhatTrangThaiHoaDon(string TrangThai, string MaHoaDon)
        {
            string query = "UPDATE HoaDon SET TrangThai=N'" + TrangThai + "' WHERE MaHoaDon='" + MaHoaDon + "'";
            da.ExecuteNonQuery(query);
        }

        public DataTable ThongKeTheoNgay(string Ngay)
        {
            string select = "SELECT hd.MaHoaDon, hd.NgayBan, hd.ThoiGian, hd.TongTien, hd.TrangThai, nv.TenNhanVien, kv.TenKhuVuc, b.TenBan" +
                            " FROM HoaDon hd, NhanVien nv, KhuVuc kv, Ban b" +
                            " WHERE hd.MaNhanVien = nv.MaNhanVien AND hd.MaKhuVuc = kv.MaKhuVuc" +
                            " AND hd.MaBan = b.MaBan AND hd.TrangThai=N'ĐÃ THANH TOÁN' AND hd.NgayBan LIKE '" + Ngay + "'";
            return da.GetDataTable (select);
        }

        public DataTable ThongKeTheoThang(string Thang, string Nam)
        {
            string select = "SELECT hd.MaHoaDon, hd.NgayBan, hd.ThoiGian, hd.TongTien, hd.TrangThai, nv.TenNhanVien, kv.TenKhuVuc, b.TenBan" +
                            " FROM HoaDon hd, NhanVien nv, KhuVuc kv, Ban b" +
                            " WHERE hd.MaNhanVien = nv.MaNhanVien AND hd.MaKhuVuc = kv.MaKhuVuc" +
                            " AND hd.MaBan = b.MaBan AND hd.TrangThai=N'ĐÃ THANH TOÁN' AND DAY(hd.NgayBan) = '" + Thang + "' AND YEAR(hd.NgayBan) = '" + Nam + "'";
            return da.GetDataTable (select);
        }

        public DataTable ThongKeTheoKhoang(string TuNgay, string DenNgay)
        {
            string select = "SELECT hd.MaHoaDon, hd.NgayBan, hd.ThoiGian, hd.TongTien, hd.TrangThai, nv.TenNhanVien, kv.TenKhuVuc, b.TenBan" +
                            " FROM HoaDon hd, NhanVien nv, KhuVuc kv, Ban b" +
                            " WHERE hd.MaNhanVien = nv.MaNhanVien AND hd.MaKhuVuc = kv.MaKhuVuc" +
                            " AND hd.MaBan = b.MaBan AND hd.TrangThai=N'ĐÃ THANH TOÁN' AND hd.NgayBan >= '" + TuNgay + "' AND hd.NgayBan <= '" + DenNgay + "'";
            return da.GetDataTable(select);
        }
    }
}
