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
    internal class ChucVuBLL
    {
        DataAccess da = new DataAccess();

        public DataTable GetDSChucVu()
        {
            string select = "SELECT * FROM ChucVu";
            return da.GetDataTable(select);
        }

        public void Insert(ChucVu cv)
        {
            string query = "INSERT INTO ChucVu VALUES ('" + cv.MaChucVu + "', N'" + cv.TenChucVu + "')";
            da.ExecuteNonQuery(query);
        } 

        public void Update(ChucVu cv)
        {
            string query = "UPDATE ChucVu SET TenChucVu=N'" + cv.TenChucVu + "' WHERE MaChucVu='" + cv.MaChucVu + "'";
            da.ExecuteNonQuery(query);
        }

        public void Delete(ChucVu cv)
        {
            string query = "DELETE FROM ChucVu WHERE MaChucVu='" + cv.MaChucVu + "'";
            da.ExecuteNonQuery(query);
        }
    }
}
