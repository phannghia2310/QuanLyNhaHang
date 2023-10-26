using Bunifu.UI.WinForms.Helpers.Transitions;
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

namespace QuanLyNhaHang.GUI
{
    public partial class fAccount : Form
    {
        DataAccess da = new DataAccess();
        TaiKhoan tk;
        TaiKhoanBLL bllTaiKhoan = new TaiKhoanBLL();
        NhanVienBLL bllNhanVien = new NhanVienBLL();
        ChucVuBLL bllChucVu = new ChucVuBLL();
        
        string flag = "";

        public fAccount()
        {
            InitializeComponent();
        }

        void GetDataTaiKhoan()
        {
            tk = new TaiKhoan();
            tk.TenDangNhap = txt_TenDangNhap.Text;
            tk.MatKhau = txt_MatKhau.Text;
            tk.MaNhanVien = cmb_MaNhanVien.Text;
            tk.MaChucVu = cmb_MaChucVu.Text;
        }

        void LockControl()
        {
            txt_TenDangNhap.ReadOnly = true;
            txt_MatKhau.ReadOnly = true;
            cmb_MaNhanVien.Enabled = false;
            cmb_MaChucVu.Enabled = false;
        }

        void UnlockControl()
        {
            txt_TenDangNhap.ReadOnly = false;
            txt_MatKhau.ReadOnly = false;
            cmb_MaNhanVien.Enabled = true;
            cmb_MaChucVu.Enabled = true;
        }

        void ClearText()
        {
            txt_TenDangNhap.Text = "";
            txt_MatKhau.Text = "";
            cmb_MaNhanVien.Text = "";
            cmb_MaChucVu.Text = "";
        }

        bool CheckNhap()
        {
            if (string.IsNullOrWhiteSpace(txt_TenDangNhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenDangNhap.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_MatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MatKhau.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmb_MaNhanVien.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã nhân viên!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_MaNhanVien.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmb_MaChucVu.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã chức vụ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_MaChucVu.Focus();
                return false;
            }
            if (bllTaiKhoan.ExistUser(txt_TenDangNhap.Text))
            {
                MessageBox.Show("Tài khoản: " + txt_TenDangNhap.Text + " đã được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenDangNhap.Focus();
                return false;
            }
            if (da.CheckKey("SELECT MaNhanVien FROM TaiKhoan WHERE MaNhanVien='" + cmb_MaNhanVien.Text + "'"))
            {
                MessageBox.Show("Nhân viên " + cmb_MaNhanVien.Text + " đã có tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_MaNhanVien.Focus();
                return false;
            }
            return true;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            fMain fMain = new fMain();
            fMain.Show();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void fAccount_Load(object sender, EventArgs e)
        {
            dgv_TaiKhoan.DataSource = bllTaiKhoan.GetDSTaiKhoan();

            cmb_MaNhanVien.DataSource = bllNhanVien.GetDSNhanVien();
            cmb_MaNhanVien.DisplayMember = "MaNhanVien";
            cmb_MaNhanVien.ValueMember = "MaNhanVien";

            cmb_MaChucVu.DataSource = bllChucVu.GetDSChucVu();
            cmb_MaChucVu.DisplayMember = "MaChucVu";
            cmb_MaChucVu.ValueMember = "MaChucVu";

            rb_TenDangNhap.Checked = true;
            LockControl();
        }

        private void dgv_TaiKhoan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txt_TenDangNhap.Text = dgv_TaiKhoan.Rows[row].Cells["TenDangNhap"].Value.ToString();
            txt_MatKhau.Text = dgv_TaiKhoan.Rows[row].Cells["MatKhau"].Value.ToString();
            cmb_MaNhanVien.Text = dgv_TaiKhoan.Rows[row].Cells["MaNhanVien"].Value.ToString();
            cmb_MaChucVu.Text = dgv_TaiKhoan.Rows[row].Cells["MaChucVu"].Value.ToString();

            LockControl();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            UnlockControl();
            ClearText();
            txt_TenDangNhap.Focus();
            flag = "Add";
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            txt_TenDangNhap.Focus();
            flag = "Edit";
        }

        private void btb_XoaBot_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn xóa tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                bllTaiKhoan.Delete(tk);

                fAccount_Load(sender, e);
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if(rb_TenDangNhap.Checked == true)
            {
                dgv_TaiKhoan.DataSource = bllTaiKhoan.SearchByTenDangNhap(txt_TimKiem.Text);
            }
            if(rb_MaNhanVien.Checked == true)
            {
                dgv_TaiKhoan.DataSource = bllTaiKhoan.SearchByMaNhanVien(txt_TimKiem.Text);
            }
            if(rb_MaChucVu.Checked == true)
            {
                dgv_TaiKhoan.DataSource = bllTaiKhoan.SearchByMaChucVu(txt_TimKiem.Text);
            }
        }

        private void btn_ChapNhan_Click(object sender, EventArgs e)
        {
            if(CheckNhap())
            {
                if(flag == "Add")
                {
                    GetDataTaiKhoan();
                    bllTaiKhoan.Insert(tk);
                    MessageBox.Show("Thêm tài khoản thành công!!", "Thông báo");
                    dgv_TaiKhoan.DataSource = bllTaiKhoan.GetDSTaiKhoan();
                }
                if(flag == "Edit")
                {
                    GetDataTaiKhoan();
                    bllTaiKhoan.Update(tk);
                    MessageBox.Show("Cập nhật tài khoản thành công!!", "Thông báo");
                    dgv_TaiKhoan.DataSource = bllTaiKhoan.GetDSTaiKhoan();
                }
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            ClearText();
            UnlockControl();
        }
    }
}
