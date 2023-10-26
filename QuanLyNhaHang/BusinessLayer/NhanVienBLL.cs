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
            string select = "SELECT * FROM NhanVien";
            return da.GetDataTable(select);
        }

        public void Insert(NhanVien nv)
        {
            string query = "INSERT INTO NhanVien VALUES ('" + nv.MaNhanVien + "', N'" + nv.TenNhanVien  +"', N'" + nv.GioiTinh + "', '" + nv.NgaySinh + "', N'" + nv.DiaChi + "', '" + nv.SDT + "', '" + nv.MaChucVu + "'";
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
    }
}
