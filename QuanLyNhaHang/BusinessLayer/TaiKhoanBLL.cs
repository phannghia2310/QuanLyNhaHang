using QuanLyNhaHang.DataLayer;
using QuanLyNhaHang.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.BusinessLayer
{
    internal class TaiKhoanBLL
    {
        DataAccess da = new DataAccess();

        public bool ExistUser(TaiKhoan us)
        {
            string sql = "SELECT * FROM TAIKHOAN WHERE TenDangNhap=N'" + us.TenDangNhap + "' and MatKhau=N'" + us.MatKhau + "'";
            if (da.GetDataTable(sql).Rows.Count > 0)
            {
                UserLogin.TenDangNhap = da.GetDataTable(sql).Rows[0]["TenDangNhap"].ToString();
                UserLogin.MaChucVu = da.GetDataTable(sql).Rows[0]["MaChucVu"].ToString();
                UserLogin.MaNhanVien = da.GetDataTable(sql).Rows[0]["MaNhanVien"].ToString();
                UserLogin.MatKhau = da.GetDataTable(sql).Rows[0]["MatKhau"].ToString();
                SqlHelper.MaChucVu = UserLogin.MaChucVu;
                return true;
            }
            else return false;
        }

        public bool ExistUser(string TenDangNhap)
        {
            string sql = "SELECT * FROM TaiKhoan WHERE TenDangNhap=N'" + TenDangNhap + "'";
            if (da.GetDataTable(sql).Rows.Count != 0)
            {
                return true;
            }
            else
                return false;
        }

        public DataTable GetDSTaiKhoan()
        {
            string select = "SELECT * FROM TaiKhoan";
            return da.GetDataTable(select);
        }

        public TaiKhoan GetTaiKhoan(string TenDangNhap)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.TenDangNhap = TenDangNhap;

            string select = "SELECT * FROM TaiKhoan WHERE TenDangNhap=N'" + TenDangNhap + "'";
            DataTable dt = da.GetDataTable(select);
            if(dt.Rows.Count > 0)
            {
                tk.MatKhau = dt.Rows[0]["MatKhau"].ToString();
                tk.MaChucVu = dt.Rows[0]["MaChucVu"].ToString();
                tk.MaNhanVien = dt.Rows[0]["MaNhanVien"].ToString();
            }
            return tk;
        }

        public string GetTenChucVu(string MaChucVu)
        {
            string selest = "SELECT TenChucVu FROM ChucVu cv, TaiKhoan tk WHERE cv.MaChucVu=tk.MaChucVu AND tk.MaChucVu='" + MaChucVu + "'";
            return da.GetValue(selest, "TenChucVu");
        }

        public string GetTenNhanVien(string MaNhanVien)
        {
            string selest = "SELECT TenNhanVien FROM NhanVien nv, TaiKhoan tk WHERE nv.MaNhanVien=tk.MaNhanVien AND nv.MaNhanVien='" + MaNhanVien + "'";
            return da.GetValue(selest, "TenNhanVien");
        }

        public void Insert(TaiKhoan us)
        {
            string query = "INSERT INTO TaiKhoan VALUES (N'" + us.TenDangNhap + "', '" + us.MatKhau + "', '" + us.MaNhanVien + "', '" + us.MaChucVu + "'";
            da.ExecuteNonQuery(query);
        }

        public void Update(TaiKhoan us)
        {
            string query = "UPDATE TaiKhoan SET MatKhau=N'" + us.MatKhau + "', MaNhanVien='" + us.MaNhanVien + "', MaChucVu='" + us.MaChucVu + "' WHERE TenDangNhap=N'" + us.TenDangNhap +"'";
            da.ExecuteNonQuery(query);
        }

        public void Delete(TaiKhoan us)
        {
            string query = "DELETE FROM TaiKhoan WHERE TenDangNhap=N'" + us.TenDangNhap + "'";
            da.ExecuteNonQuery(query);
        }

        public void ChangePassword(string NewPass)
        {
            string query = "UPDATE TaiKhoan SET MatKhau=N'" + NewPass + "' WHERE TenDangNhap=N'" + UserLogin.TenDangNhap + "'";
            UserLogin.MatKhau = NewPass;
            da.ExecuteNonQuery(query);
        }

        public DataTable SearchByTenDangNhap(string TenDangNhap)
        {
            string select = "SELECT * FROM TaiKhoan WHERE TenDangNhap LIKE N'%" + TenDangNhap + "%'";
            return da.GetDataTable(select);
        }

        public DataTable SearchByMaNhanVien(string MaNhanVien)
        {
            string select = "SELECT * FROM TaiKhoan WHERE MaNhanVien LIKE '%" + MaNhanVien + "%'";
            return da.GetDataTable(select);
        }

        public DataTable SearchByMaChucVu(string MaChucVu)
        {
            string select = "SELECT * FROM TaiKhoan WHERE MaChucVu LIKE '%" + MaChucVu + "%'";
            return da.GetDataTable(select);
        }
    }
}
