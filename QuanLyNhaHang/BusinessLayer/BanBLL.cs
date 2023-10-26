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
    internal class BanBLL
    {
        DataAccess da = new DataAccess();

        public DataTable GetDSBan()
        {
            string select = "SELECT * FROM Ban";
            return da.GetDataTable(select);
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

        public void Delete(Ban b)
        {
            string query = "DELETE FROM Ban WHERE MaBan='" + b.MaBan + "'";
            da.ExecuteNonQuery(query);
        }
    }
}
