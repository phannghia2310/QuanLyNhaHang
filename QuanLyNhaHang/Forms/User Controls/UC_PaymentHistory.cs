using QuanLyNhaHang.BusinessLayer;
using QuanLyNhaHang.DataLayer;
using QuanLyNhaHang.Entities;
using QuanLyNhaHang.GUI;
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
    public partial class UC_PaymentHistory : UserControl
    {
        DataAccess da = new DataAccess();
        HoaDon hd;
        HoaDonBLL bllHoaDon = new HoaDonBLL();

        public UC_PaymentHistory()
        {
            InitializeComponent();
        }

        private void UC_PaymentHistory_Load(object sender, EventArgs e)
        {
            dgv_HoaDon.DataSource = bllHoaDon.GetDSHoaDon();
            dgv_HoaDon.ReadOnly = true;
            cmb_ChonThang.Text = "01";
            dt_ChonNgay.Text = DateTime.Now.ToString();
            dt_ChonNam.Text = DateTime.Now.ToString();
            dt_TuNgay.Text = DateTime.Now.ToString();
            dt_DenNgay.Text = DateTime.Now.ToString();
        }

        private void dgv_HoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txt_MaHoaDon.Text = dgv_HoaDon.Rows[row].Cells["MaHoaDon"].Value.ToString();
            txt_NgayBan.Text = dgv_HoaDon.Rows[row].Cells["NgayBan"].Value.ToString();
            txt_ThoiGian.Text = dgv_HoaDon.Rows[row].Cells["ThoiGian"].Value.ToString();
            txt_TongTien.Text = dgv_HoaDon.Rows[row].Cells["TongTien"].Value.ToString();
            txt_TrangThai.Text = dgv_HoaDon.Rows[row].Cells["TrangThai"].Value.ToString();
            txt_TenNhanVien.Text = dgv_HoaDon.Rows[row].Cells["TenNhanVien"].Value.ToString();
            txt_KhuVuc.Text = dgv_HoaDon.Rows[row].Cells["TenKhuVuc"].Value.ToString();
            txt_Ban.Text = dgv_HoaDon.Rows[row].Cells["TenBan"].Value.ToString();
        }

        private void btn_XemCTHD_Click(object sender, EventArgs e)
        {
            fDetails fDetails = new fDetails(txt_MaHoaDon.Text);
            fDetails.Show();
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
            UC_PaymentHistory_Load(sender, e);
        }

    }
}
