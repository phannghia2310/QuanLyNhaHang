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
    public partial class UC_Personal : UserControl
    {
        DataAccess da = new DataAccess();
        NhanVien nv;
        NhanVienBLL bllNhanVien = new NhanVienBLL();
        ChucVuBLL bllChucVu = new ChucVuBLL();

        public UC_Personal()
        {
            InitializeComponent();
        }

        void GetDataNhanVien()
        {
            nv = new NhanVien();
            nv.MaNhanVien = lb_MaNhanVien.Text;
            nv.TenNhanVien = txt_TenNhanVien.Text;
            nv.NgaySinh = Convert.ToDateTime(dt_NgaySinh.Text);
            if (rb_Nam.Checked) 
                nv.GioiTinh = rb_Nam.Text;
            else 
                nv.GioiTinh = rb_Nu.Text;
            nv.SDT = txt_SDT.Text;
            nv.DiaChi = txt_DiaChi.Text;
            nv.MaChucVu = bllChucVu.GetMaChucVuByTen(lb_ChucVu.Text);
        }

        bool CheckNhap()
        {
            if (string.IsNullOrWhiteSpace(txt_TenNhanVien.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenNhanVien.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_DiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DiaChi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_SDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SDT.Focus();
                return false;
            }
            return true;
        }

        private void UC_Personal_Load(object sender, EventArgs e)
        {
            nv = bllNhanVien.GetNhanVienByMaNhanVien(UserLogin.MaNhanVien);
            lb_MaNhanVien.Text = nv.MaNhanVien;
            lb_ChucVu.Text = bllChucVu.GetTenChucVuByMa(nv.MaChucVu);
            txt_TenNhanVien.Text = nv.TenNhanVien;
            dt_NgaySinh.Text = nv.NgaySinh.ToString();
            if (nv.GioiTinh == "Nam")
                rb_Nam.Checked = true;
            else
                rb_Nu.Checked = true;
            txt_SDT.Text = nv.SDT;
            txt_DiaChi.Text = nv.DiaChi;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if(CheckNhap())
            {
                GetDataNhanVien();
                bllNhanVien.Update(nv);
                MessageBox.Show("Cập nhật thông tin thành công!!", "Thành công");
            }
            UC_Personal_Load(sender, e);
        }
    }
}
