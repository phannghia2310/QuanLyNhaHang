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

        public NhanVien GetNhanVienByMaNhanVien(string MaNhanVien)
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = MaNhanVien;
            
            string select = "SELECT * FROM NhanVien WHERE MaNhanVien='" + MaNhanVien + "'";
            DataTable dt = da.GetDataTable(select);

            if(dt.Rows.Count > 0)
            {
                nv.TenNhanVien = dt.Rows[0]["TenNhanVien"].ToString();
                nv.NgaySinh = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString());
                nv.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
                nv.SDT = dt.Rows[0]["SDT"].ToString();
                nv.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                nv.MaChucVu = dt.Rows[0]["MaChucVu"].ToString();
            }

            return nv;
        }

        public string GetMaNhanVien()
        {
            string select = "SELECT TOP 1 MaNhanVien FROM NhanVien ORDER BY MaNhanVien DESC";
            return da.GetLastID(select);
        }

        public string GetTenNhanVienByMaNhanVien(string MaNhanVien)
        {
            string select = "SELECT DISTINCT TenNhanVien FROM NhanVien WHERE MaNhanVien='" + MaNhanVien + "'";
            return da.GetValue(select, "TenNhanVien");
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
