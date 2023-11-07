using QuanLyNhaHang.DataLayer;
using QuanLyNhaHang.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuanLyNhaHang.BusinessLayer
{
    internal class BanBLL
    {
        DataAccess da = new DataAccess();

        public DataTable GetDSBan()
        {
            string select = "SELECT b.MaBan, b.TenBan, b.TrangThai, kv.TenKhuVuc" +
                            " FROM Ban b, KhuVuc kv" +
                            " WHERE b.MaKhuVuc = kv.MaKhuVuc";
            return da.GetDataTable(select);
        }

        public DataTable GetBanByMaKhuVuc(string id)
        {
            string select = "SELECT * FROM Ban WHERE MaKhuVuc='" + id + "'";
            return da.GetDataTable(select);
        }

        public string GetTenBanByMaBan(string MaBan)
        {
            string select = "SELECT DISTINCT TenBan FROM Ban WHERE MaBan='" + MaBan + "'";
            return da.GetValue(select, "TenBan");
        }

        public DataTable GetBanByTrangThai(string TrangThai, string TenBan)
        {
            string select = "SELECT DISTINCT * FROM Ban WHERE TrangThai=N'" + TrangThai +  "' AND TenBan != '" + TenBan + "'";
            return da.GetDataTable(select);
        }
        
        public string GetMaBan()
        {
            string select = "SELECT TOP 1 MaBan FROM Ban ORDER BY MaBan DESC";
            return da.GetLastID(select);
        }

        public string GetMaBanByTenBan(string TenBan)
        {
            string select = "SELECT DISTINCT MaBan FROM Ban WHERE TenBan=N'" + TenBan + "'";
            return da.GetValue(select, "MaBan");
        }

        public string GetMaKhuVucByTenBan(string TenBan)
        {
            string select = "SELECT DISTINCT MaKhuVuc FROM Ban WHERE TenBan=N'" + TenBan + "'";
            return da.GetValue(select, "MaKhuVuc");
        }

        public void Insert(Ban b)
        {
            string query = "INSERT INTO Ban VALUES ('" + b.MaBan + "', N'" + b.TenBan + "', N'" + b.TrangThai + "', '" + b.MaKhuVuc + "')";
            da.ExecuteNonQuery(query);
        }

        public void Update(Ban b)
        {
            string query = "UPDATE Ban SET TenBan=N'" + b.TenBan + "', TrangThai=N'" + b.TrangThai + "', MaKhuVuc='" + b.MaKhuVuc + "'";
            da.ExecuteNonQuery(query);
        }

        public void CapNhatTrangThaiBan(string TrangThai, string TenBan)
        {
            string query = "UPDATE Ban SET TrangThai=N'" + TrangThai + "' WHERE TenBan=N'" + TenBan + "'";
            da.ExecuteNonQuery(query);
        }

        public void Delete(Ban b)
        {
            string query = "DELETE FROM Ban WHERE MaBan='" + b.MaBan + "'";
            da.ExecuteNonQuery(query);
        }

        public DataTable SearchByTenBan(string TenBan)
        {
            string select = "SELECT b.MaBan, b.TenBan, b.TrangThai, kv.TenKhuVuc" +
                            " FROM Ban b, KhuVuc kv" +
                            " WHERE b.MaKhuVuc = kv.MaKhuVuc AND b.TenBan LIKE N'%" + TenBan + "%'";
            return da.GetDataTable(select);
        }

        public DataTable SearchByTenKhuVuc(string TenKhuVuc)
        {
            string select = "SELECT b.MaBan, b.TenBan, b.TrangThai, kv.TenKhuVuc" +
                            " FROM Ban b, KhuVuc kv" +
                            " WHERE b.MaKhuVuc = kv.MaKhuVuc AND kv.TenKhuVuc LIKE N'%" + TenKhuVuc + "%'";
            return da.GetDataTable(select);
        }

        public DataTable SearchByTrangThai(string TrangThai)
        {
            string select = "SELECT b.MaBan, b.TenBan, b.TrangThai, kv.TenKhuVuc" +
                            " FROM Ban b, KhuVuc kv" +
                            " WHERE b.MaKhuVuc = kv.MaKhuVuc AND b.TrangThai LIKE N'%" + TrangThai + "%'";
            return da.GetDataTable(select);
        }
    }
}
