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
    internal class KhuVucBLL
    {
        DataAccess da = new DataAccess();

        public DataTable GetDSKhuVuc()
        {
            string select = "SELECT * FROM KhuVuc";
            return da.GetDataTable(select);
        }

        public string GetMaKhuVuc()
        {
            string select = "SELECT TOP 1 MaKhuVuc FROM KhuVuc ORDER BY MaKhuVuc DESC";
            return da.GetLastID(select);
        }

        public void Insert(KhuVuc kv)
        {
            string query = "INSERT INTO KhuVuc VALUES ('" + kv.MaKhuVuc + "', N'" + kv.TenKhuVuc + "')";
            da.ExecuteNonQuery(query);
        }

        public void Update(KhuVuc kv)
        {
            string query = "UPDATE KhuVuc SET TenKhuVuc=N'" + kv.TenKhuVuc + "' WHERE MaKhuVuc='" + kv.MaKhuVuc + "'";
            da.ExecuteNonQuery(query);
        }

        public void Delete(KhuVuc kv)
        {
            string query = "DELETE FROM KhuVuc WHERE MaKhuVuc='" + kv.MaKhuVuc + "'";
            da.ExecuteNonQuery(query);
        }

        public DataTable SearchByTenKhuVuc(string TenKhuVuc)
        {
            string select = "SELECT * FROM KhuVuc WHERE TenKhuVuc LIKE N'%" + TenKhuVuc + "%'";
            return da.GetDataTable(select);
        }
    }
}
