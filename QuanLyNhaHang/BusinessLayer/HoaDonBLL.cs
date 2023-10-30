using QuanLyNhaHang.DataLayer;
using QuanLyNhaHang.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.BusinessLayer
{
    internal class HoaDonBLL
    {
        DataAccess da = new DataAccess();

        public DataTable GetDSHoaDon()
        {
            string select = "SELECT hd.MaHoaDon, hd.NgayBan, hd.TongTien, hd.TrangThai, nv.TenNhanVien" +
                            " FROM HoaDon hd, NhanVien nv" +
                            " WHERE hd.MaNhanVien = nv.MaNhanVien";
            return da.GetDataTable(select);
        }
        
        public string GetMaHoaDon()
        {
            string select = "SELECT TOP 1 MaHoaDon FROM HoaDon ORDER BY MaHoaDon DESC";
            return da.GetLastID(select);
        }

        public void Insert(HoaDon hd)
        {
            string query = "INSERT INTO HoaDon VALUES ('" + hd.MaHoaDon + "', '" + hd.NgayBan + "', " + hd.TongTien + ", N'" + hd.TrangThai + "', '" + hd.MaNhanVien + "')";
            da.ExecuteNonQuery(query);
        }

        public void Update(HoaDon hd)
        {
            string query = "UPDATE HoaDon SET NgayBan='" + hd.NgayBan + "', TongTien=" + hd.TongTien + ", TrangThai=N'" + hd.TrangThai + "', MaNhanVien='" + hd.MaNhanVien + "' WHERE MaHoaDon='" + hd.MaHoaDon + "'";
            da.ExecuteNonQuery(query);
        }

        public void Delete(HoaDon hd)
        {
            string query = "DELETE FROM HoaDon WHERE MaHoaDon='" + hd.MaHoaDon + "'";
            da.ExecuteNonQuery(query);
        }

        public DataTable ThongKeTheoNgay(string Ngay)
        {
            string select = "SELECT DISTINCT hd.MaHoaDon, hd.NgayBan, hd.TongTien, hd.TrangThai, nv.TenNhanVien" +
                            " FROM HoaDon hd, NhanVien nv" +
                            " WHERE hd.MaNhanVien = nv.MaNhanVien AND hd.NgayBan LIKE '" + Ngay + "'";
            return da.GetDataTable (select);
        }

        public DataTable ThongKeTheoThang(string Thang, string Nam)
        {
            string select = "SELECT DISTINCT hd.MaHoaDon, hd.NgayBan, hd.TongTien, hd.TrangThai, nv.TenNhanVien" +
                            " FROM HoaDon hd, NhanVien nv" +
                            " WHERE hd.MaNhanVien = nv.MaNhanVien AND MONTH(hd.NgayBan) = " + Thang + " AND YEAR(hd.NgayBan) = " + Nam;
            return da.GetDataTable (select);
        }

        public DataTable ThongKeTheoKhoang(string TuNgay, string DenNgay)
        {
            string select = "SELECT DISTINCT hd.MaHoaDon, hd.NgayBan, hd.TongTien, hd.TrangThai, nv.TenNhanVien" +
                            " FROM HoaDon hd, NhanVien nv" +
                            " WHERE hd.MaNhanVien = nv.MaNhanVien AND hd.NgayBan >= '" + TuNgay + "' AND hd.NgayBan <= '" + DenNgay + "'";
            return da.GetDataTable(select);
        }
    }
}
