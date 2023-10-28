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
    internal class NhanVienBLL
    {
        DataAccess da = new DataAccess();
        
        public DataTable GetDSNhanVien()
        {
            string select = "SELECT nv.MaNhanVien, nv.TenNhanVien, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SDT, cv.TenChucVu" +
                            " FROM NhanVien nv, ChucVu cv" +
                            " WHERE nv.MaChucVu = cv.MaChucVu";
            return da.GetDataTable(select);
        }

        public string GetMaNhanVien()
        {
            string select = "SELECT TOP 1 MaNhanVien FROM NhanVien ORDER BY MaNhanVien DESC";
            return da.GetLastID(select);
        }

        public void Insert(NhanVien nv)
        {
            string query = "INSERT INTO NhanVien VALUES ('" + nv.MaNhanVien + "', N'" + nv.TenNhanVien  +"', N'" + nv.GioiTinh + "', '" + nv.NgaySinh + "', N'" + nv.DiaChi + "', '" + nv.SDT + "', '" + nv.MaChucVu + "')";
            da.ExecuteNonQuery(query);
        }

        public void Update(NhanVien nv)
        {
            string query = "UPDATE NhanVien SET TenNhanVien=N'" + nv.TenNhanVien + "', GioiTinh=N'" + nv.GioiTinh + "', NgaySinh='" + nv.NgaySinh + "', DiaChi=N'" + nv.DiaChi + "', SDT='" + nv.SDT + "', MaChucVu='" + nv.MaChucVu + "' WHERE MaNhanVien='" + nv.MaNhanVien + "'";
            da.ExecuteNonQuery(query);
        }

        public void Delete(NhanVien nv)
        {
            string query = "DELETE FROM NhanVien WHERE MaNhanVien='" + nv.MaNhanVien + "'";
            da.ExecuteNonQuery(query);
        }

        public DataTable SearchByTenNhanVien(string TenNhanVien)
        {
            string select = "SELECT nv.MaNhanVien, nv.TenNhanVien, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SDT, cv.TenChucVu" +
                            " FROM NhanVien nv, ChucVu cv" +
                            " WHERE nv.MaChucVu = cv.MaChucVu AND nv.TenNhanVien LIKE N'%" + TenNhanVien + "%'";
            return da.GetDataTable(select);
        }

        public DataTable SearchByTenChucVu(string TenChucVu)
        {
            string select = "SELECT nv.MaNhanVien, nv.TenNhanVien, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SDT, cv.TenChucVu" +
                            " FROM NhanVien nv, ChucVu cv" +
                            " WHERE nv.MaChucVu = cv.MaChucVu AND cv.TenChucVu LIKE N'%" + TenChucVu + "%'";
            return da.GetDataTable(select);
        }
    }
}
