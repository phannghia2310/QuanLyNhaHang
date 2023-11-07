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
            string select = "SELECT ma.MaMonAn, ma.TenMonAn, ma.DonGia, ma.DVT, ma.Anh, dm.TenDanhMuc" +
                            " FROM MonAn ma, DanhMuc dm" +
                            " WHERE ma.MaDanhMuc = dm.MaDanhMuc";
            return da.GetDataTable(select);
        }

        public string GetMaMonAnByTen(string Ten)
        {
            string select = "SELECT MaMonAn FROM MonAN WHERE TenMonAn=N'" + Ten + "'";
            return da.GetValue(select, "MaMonAn");
        }

        public string GetTenMonAnByMa(string Ma)
        {
            string select = "SELECT TenMonAn FROM MonAn WHERE MaMonAn='" + Ma + "'";
            return da.GetValue(select, "TenMonAn");
        }

        public DataTable GetMonAnByMaDanhMuc(string MaDanhMuc)
        {
            string select = "SELECT * FROM MonAn WHERE MaDanhMuc='" + MaDanhMuc + "'";
            return da.GetDataTable(select);
        }

        public string GetMaMonAn()
        {
            string select = "SELECT TOP 1 MaMonAn FROM MonAn ORDER BY MaMonAn DESC";
            return da.GetLastID(select);
        }

        public void Insert(MonAn ma)
        {
            string query = "INSERT INTO MonAn VALUES ('" + ma.MaMonAn + "', N'" + ma.TenMonAn + "', " + ma.DonGia + ", N'" + ma.DVT + "', N'" + ma.Anh + "', '" + ma.MaDanhMuc + "')";
            da.ExecuteNonQuery(query);
        }

        public void Update(MonAn ma)
        {
            string query = "UPDATE MonAn SET TenMonAn=N'" + ma.TenMonAn + "', DonGia=" + ma.DonGia + ", DVT=N'" + ma.DVT + "', Anh=N'" + ma.Anh + "', MaDanhMuc='" + ma.MaDanhMuc + "' WHERE MaMonAn='" + ma.MaMonAn + "'";
            da.ExecuteNonQuery(query);
        }

        public void Delete(MonAn ma)
        {
            string query = "DELETE FROM MonAn WHERE MaMonAn='" + ma.MaMonAn + "'";
            da.ExecuteNonQuery(query);
        }

        public DataTable SearchByTenMonAn(string TenMonAn)
        {
            string select = "SELECT ma.MaMonAn, ma.TenMonAn, ma.DonGia, ma.DVT, ma.Anh, dm.TenDanhMuc" +
                            " FROM MonAn ma, DanhMuc dm" +
                            " WHERE ma.MaDanhMuc = dm.MaDanhMuc AND ma.TenMonAn LIKE N'%" + TenMonAn + "%'";
            return da.GetDataTable(select);
        }

        public DataTable SearchByTenDanhMuc(string TenDanhMuc)
        {
            string select = "SELECT ma.MaMonAn, ma.TenMonAn, ma.DonGia, ma.DVT, ma.Anh dm.TenDanhMuc" +
                            " FROM MonAn ma, DanhMuc dm" +
                            " WHERE ma.MaDanhMuc = dm.MaDanhMuc AND dm.TenDanhMuc LIKE N'%" + TenDanhMuc + "%'";
            return da.GetDataTable(select);
        }
    }
}
