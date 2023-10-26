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
    internal class ChiTietHoaDonBLL
    {
        DataAccess da = new DataAccess();

        public DataTable GetDSChiTietHoaDon()
        {
            string select = "SELECT * FROM ChiTietHoaDon";
            return da.GetDataTable(select);
        }

        public void Insert(ChiTietHoaDon ct)
        {
            string query = "INSERT INTO ChiTietHoaDon VALUES ('" + ct.MaHoaDon + "', '" + ct.MaMonAn + "', " + ct.DonGia + ", " + ct.SoLuong + ", " + ct.ThanhTien + ")";
            da.ExecuteNonQuery(query);
        }

        public void Update(ChiTietHoaDon ct)
        {
            string query = "UPDATE ChiTietHoaDon SET DonGia=" + ct.DonGia + ", SoLuong=" + ct.SoLuong + ", ThanhTien=" + ct.ThanhTien + " WHERE MaHoaDon='" + ct.MaHoaDon + "' AND MaMonAn='" + ct.MaMonAn + "'";
            da.ExecuteNonQuery(query);
        }

        public void Delete(ChiTietHoaDon ct)
        {
            string query = "DELETE FROM ChiTietHoaDon WHERE MaHoaDon='" + ct.MaHoaDon + "' AND MaMonAn='" + ct.MaMonAn + "'";
            da.ExecuteNonQuery(query);
        }
    }
}
