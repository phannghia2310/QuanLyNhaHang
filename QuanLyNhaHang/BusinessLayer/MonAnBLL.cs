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
    internal class MonAnBLL
    {
        DataAccess da = new DataAccess();

        public DataTable GetDsMonAn()
        {
            string select = "SELECT * FROM MonAn";
            return da.GetDataTable(select);
        }

        public void Insert(MonAn ma)
        {
            string query = "INSERT INTO MonAn VALUES ('" + ma.MaMonAn + "', N'" + ma.TenMonAn + "', " + ma.DonGia + ", N'" + ma.DVT + "', '" + ma.MaDanhMuc + "'";
            da.ExecuteNonQuery(query);
        }

        public void Update(MonAn ma)
        {
            string query = "UPDATE MonAn SET TenMonAn=N'" + ma.TenMonAn + "', DonGia=" + ma.DonGia + ", DVT=N'" + ma.DVT + "', MaDanhMuc='" + ma.MaDanhMuc + "' WHERE MaMonAn='" + ma.MaMonAn + "'";
            da.ExecuteNonQuery(query);
        }

        public void Delete(MonAn ma)
        {
            string query = "DELETE FROM MonAn WHERE MaMonAn='" + ma.MaMonAn + "'";
            da.ExecuteNonQuery(query);
        }
    }
}
