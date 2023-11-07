using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Xml.Linq;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using QuanLyNhaHang.BusinessLayer;
using QuanLyNhaHang.DataLayer;
using QuanLyNhaHang.Entities;
using QuanLyNhaHang.Forms;

namespace QuanLyNhaHang.GUI
{
    public partial class fLogin : Form
    {
        public static string username = "";
        public static string password = "";
        public static string tenchucvu = "";
        public static string tennhanvien = "";

        TaiKhoanBLL bllTaiKhoan = new TaiKhoanBLL();

        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            pn_Login.BackColor = Color.FromArgb(140, 1, 1, 1);
            txt_Password.UseSystemPasswordChar = true;
        }

        private void PB_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowPass.Checked)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
                txt_Password.UseSystemPasswordChar = true;
        }

        private void txt_Username_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            txt_Password.Clear();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            username = txt_Username.Text;
            password = txt_Password.Text;
            TaiKhoan us = new TaiKhoan();
            us.TenDangNhap = txt_Username.Text;
            us.MatKhau = txt_Password.Text;

            if (bllTaiKhoan.ExistUser(us) == true)
            {
                tenchucvu = bllTaiKhoan.GetTenChucVu(UserLogin.MaChucVu);
                tennhanvien = bllTaiKhoan.GetTenNhanVien(UserLogin.MaNhanVien);

                if(tenchucvu == "Quản lý")
                {
                    this.Hide();
                    fMain fmain = new fMain();
                    fmain.Show();
                }
                else
                {
                    this.Hide();
                    fCashier fCashier = new fCashier();
                    fCashier.Show();
                }
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
