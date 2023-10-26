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
    internal class DanhMucBLL
    {
        DataAccess da = new DataAccess();

        public DataTable GetDSDanhMuc()
        {
            string select = "SELECT * FROM DanhMuc";
            return da.GetDataTable(select);
        }

        public void Insert(DanhMuc dm)
        {
            string query = "INSERT INTO DanhMuc VALUES ('" + dm.MaDanhMuc + "', N'" + dm.TenDanhMuc + "')";
            da.ExecuteNonQuery(query);
        }

        public void Update(DanhMuc dm)
        {
            string query = "UPDATE DanhMuc SET TenDanhMuc=N'" + dm.TenDanhMuc + "' WHERE MaDanhMuc='" + dm.MaDanhMuc + "'";
            da.ExecuteNonQuery(query);
        }

        public void Delete(DanhMuc dm)
        {
            string query = "DELETE FROM DanhMuc WHERE MaDanhMuc='" + dm.MaDanhMuc + "'";
            da.ExecuteNonQuery(query);
        }
    }
}
