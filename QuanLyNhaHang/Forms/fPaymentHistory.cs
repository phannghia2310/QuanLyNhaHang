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
    public partial class fPaymentHistory : Form
    {
        DataAccess da = new DataAccess();
        HoaDon hd;
        HoaDonBLL bllHoaDon = new HoaDonBLL();
        NhanVienBLL bllNhanVien = new NhanVienBLL();

        public fPaymentHistory()
        {
            InitializeComponent();
        }

        void GetDataHoaDon()
        {
            hd = new HoaDon();
            hd.MaHoaDon = txt_MaHoaDon.Text;
            hd.NgayBan = dt_NgayBan.Value;
            hd.TongTien = Convert.ToInt32(txt_TongTien.Text);
            hd.TrangThai = txt_TrangThai.Text;
            hd.MaNhanVien = cmb_MaNhanVien.SelectedValue.ToString();
        }

        void LockControl()
        {
            txt_MaHoaDon.Enabled = false;
            dt_NgayBan.Enabled = false;
            txt_TongTien.Enabled = false;
            txt_TrangThai.Enabled = false;
            cmb_MaNhanVien.Enabled = false;
        }

        private void fPayment_Load(object sender, EventArgs e)
        {
            dgv_HoaDon.DataSource = bllHoaDon.GetDSHoaDon();
            dgv_HoaDon.ReadOnly = true;

            cmb_MaNhanVien.DataSource = bllNhanVien.GetDSNhanVien();
            cmb_MaNhanVien.DisplayMember = "TenNhanVien";
            cmb_MaNhanVien.ValueMember = "MaNhanVien";

            LockControl();
        }

        private void dgv_HoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txt_MaHoaDon.Text = dgv_HoaDon.Rows[row].Cells["MaHoaDon"].Value.ToString();
            dt_NgayBan.Text = dgv_HoaDon.Rows[row].Cells["NgayBan"].Value.ToString();
            txt_TongTien.Text = dgv_HoaDon.Rows[row].Cells["TongTien"].Value.ToString();
            txt_TrangThai.Text = dgv_HoaDon.Rows[row].Cells["TrangThai"].Value.ToString();
            cmb_MaNhanVien.Text = dgv_HoaDon.Rows[row].Cells["TenNhanVien"].Value.ToString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            fMain fmain = new fMain();
            fmain.Show();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_XemCTHD_Click(object sender, EventArgs e)
        {

        }

        private void btn_TheoNgay_Click(object sender, EventArgs e)
        {
            dgv_HoaDon.DataSource = bllHoaDon.ThongKeTheoNgay(dt_ChonNgay.Text);
        }

        private void btn_TheoThang_Click(object sender, EventArgs e)
        {
            dgv_HoaDon.DataSource = bllHoaDon.ThongKeTheoThang(cmb_ChonThang.Text, dt_ChonNam.Text);
        }

        private void btn_TheoKhoang_Click(object sender, EventArgs e)
        {
            dgv_HoaDon.DataSource = bllHoaDon.ThongKeTheoKhoang(dt_TuNgay.Text, dt_DenNgay.Text);
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            fPayment_Load(sender, e);
        }

    }
}
