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
            string select = "SELECT * FROM HoaDon";
            return da.GetDataTable(select);
        }

        public void Insert(HoaDon hd)
        {
            string query = "INSERT INTO HoaDon VALUES ('" + hd.MaHoaDon + "', '" + hd.NgayBan + "', " + hd.TongTien + ", N'" + hd.TrangThai + "', '" + hd.MaNhanVien + "'";
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
    }
}
