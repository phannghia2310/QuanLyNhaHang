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
            string select = "SELECT ma.TenMonAn, ct.DonGia, ct.SoLuong, ct.ThanhTien" +
                            " FROM ChiTietHoaDon ct, MonAn ma" +
                            " WHERE ct.MaMonAn = ma.MaMonAn";
            return da.GetDataTable(select);
        }

        public List<ChiTietHoaDon> GetListCTHDByMaHoaDon(string MaHoaDon)
        {
            List<ChiTietHoaDon> list = new List<ChiTietHoaDon>();
            string select = "SELECT *" +
                            " FROM ChiTietHoaDon ct" +
                            " WHERE ct.MaHoaDon='" + MaHoaDon + "'";
            DataTable dt = da.GetDataTable(select);
            if(dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    ChiTietHoaDon ct = new ChiTietHoaDon();
                    ct.MaHoaDon = row["MaHoaDon"].ToString();
                    ct.MaMonAn = row["MaMonAn"].ToString();
                    ct.DonGia = int.Parse(row["DonGia"].ToString());
                    ct.SoLuong = int.Parse(row["SoLuong"].ToString());
                    ct.ThanhTien = int.Parse(row["ThanhTien"].ToString());
                    list.Add(ct);
                }
            }
            return list;
        }

        public DataTable GetCTHDByMaHoaDon(string MaHoaDon)
        {
            string select = "SELECT ma.TenMonAn, ct.DonGia, ct.SoLuong, ct.ThanhTien" +
                            " FROM ChiTietHoaDon ct, MonAn ma" +
                            " WHERE ct.MaMonAn=ma.MaMonAn AND ct.MaHoaDon='" + MaHoaDon + "'";
            return da.GetDataTable (select);
        }

        public DataTable GetChiTietHoaDonByMaBan(string MaBan)
        {
            string select = "SELECT ma.TenMonAn, ct.DonGia, ct.SoLuong, ct.ThanhTien" +
                            " FROM ChiTietHoaDon ct, HoaDon hd, MonAn ma" +
                            " WHERE ct.MaHoaDon=hd.MaHoaDon AND ct.MaMonAn=ma.MaMonAn AND hd.TrangThai = N'CHƯA THANH TOÁN' AND hd.MaBan='" + MaBan + "'";
            return da.GetDataTable(select);
        }

        public DataTable TongMatHangThang()
        {
            string select = "SELECT ct.SoLuong" +
                            " FROM ChiTietHoaDon ct, HoaDon hd" +
                            " WHERE ct.MaHoaDon=hd.MaHoaDon AND hd.TrangThai=N'ĐÃ THANH TOÁN' AND DAY(hd.NgayBan) = " + DateTime.Now.ToString("MM");
            return da.GetDataTable(select);
        }

        public DataTable MatHangBanChay()
        {
            string select = "SELECT ct.MaMonAn, count(ct.MaMonAn) as SoLuong" +
                            " FROM ChiTietHoaDon ct, HoaDon hd" +
                            " WHERE ct.MaHoaDon=hd.MaHoaDon AND hd.TrangThai=N'ĐÃ THANH TOÁN' AND DAY(hd.NgayBan)=" + DateTime.Now.ToString("MM") +
                            " GROUP BY ct.MaMonAn";
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
