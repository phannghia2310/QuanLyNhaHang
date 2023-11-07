using QuanLyNhaHang.BusinessLayer;
using QuanLyNhaHang.DataLayer;
using QuanLyNhaHang.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.Forms.User_Controls
{
    public partial class UC_ChangPass : UserControl
    {
        DataAccess da = new DataAccess();
        TaiKhoan tk;
        TaiKhoanBLL bllTaiKhoan = new TaiKhoanBLL();
        ChucVuBLL bllChucVu = new ChucVuBLL();

        public UC_ChangPass()
        {
            InitializeComponent();
        }

        void GetDataTaiKhoan()
        {
            tk = new TaiKhoan();
            tk.TenDangNhap = txt_TenDangNhap.Text;
            tk.MatKhau = txt_MatKhauMoi.Text;
            tk.MaNhanVien = lb_MaNhanVien.Text;
            tk.MaChucVu = bllChucVu.GetMaChucVuByTen(lb_ChucVu.Text);
        }

        bool CheckNhap()
        {
            if(string.IsNullOrWhiteSpace(txt_TenDangNhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenDangNhap.Focus();
                return false;
            }
            if(txt_TenDangNhap.Text != UserLogin.TenDangNhap)
            {
                MessageBox.Show("Tên đăng nhập không đúng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenDangNhap.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txt_MatKhauCu.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MatKhauCu.Focus();
                return false;
            }
            if(txt_MatKhauCu.Text != UserLogin.MatKhau)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MatKhauCu.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txt_MatKhauMoi.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MatKhauMoi.Focus();
                return false;
            }
            if(txt_MatKhauMoi.Text == txt_MatKhauCu.Text)
            {
                MessageBox.Show("Mật khẩu mới không hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MatKhauMoi.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txt_NhapLai.Text))
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_NhapLai.Focus();
                return false;
            }
            if(txt_NhapLai.Text != txt_MatKhauMoi.Text)
            {
                MessageBox.Show("Nhập lại không khớp!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_NhapLai.Focus();
                return false;
            }
            return true;
        }

        private void UC_ChangPass_Load(object sender, EventArgs e)
        {
            tk = bllTaiKhoan.GetTaiKhoan(UserLogin.TenDangNhap);
            lb_MaNhanVien.Text = tk.MaNhanVien;
            lb_ChucVu.Text = bllChucVu.GetTenChucVuByMa(tk.MaChucVu);

            txt_MatKhauCu.UseSystemPasswordChar = true;
            txt_MatKhauMoi.UseSystemPasswordChar = true;
            txt_NhapLai.UseSystemPasswordChar = true;
        }

        private void cb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowPass.Checked)
            {
                txt_MatKhauCu.UseSystemPasswordChar = false;
                txt_MatKhauMoi.UseSystemPasswordChar = false;
                txt_NhapLai.UseSystemPasswordChar = false;
            }
            else
            {
                txt_MatKhauCu.UseSystemPasswordChar = true;
                txt_MatKhauMoi.UseSystemPasswordChar = true;
                txt_NhapLai.UseSystemPasswordChar = true;
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if(CheckNhap())
            {
                bllTaiKhoan.ChangePassword(txt_MatKhauMoi.Text);
                MessageBox.Show("Bạn đã đổi mật khẩu thành công!!", "Thành công");
            }
        }
    }
}
