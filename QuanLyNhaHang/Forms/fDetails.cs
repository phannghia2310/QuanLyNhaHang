using QuanLyNhaHang.BusinessLayer;
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

namespace QuanLyNhaHang.Forms
{
    public partial class fDetails : Form
    {
        string MaHoaDon;
        HoaDon hd;
        ChiTietHoaDon ct;
        HoaDonBLL bllHoaDon = new HoaDonBLL();
        ChiTietHoaDonBLL bllCTHD = new ChiTietHoaDonBLL();
        KhuVucBLL bllKhuVuc = new KhuVucBLL();
        BanBLL bllBan = new BanBLL();
        NhanVienBLL bllNhanVien = new NhanVienBLL();

        public fDetails(string maHoaDon)
        {
            InitializeComponent();
            this.MaHoaDon = maHoaDon;
        }

        private void fDetails_Load(object sender, EventArgs e)
        {
            hd = bllHoaDon.GetHoaDonByMa(MaHoaDon);
            dgv_CTHD.DataSource = bllCTHD.GetCTHDByMaHoaDon(MaHoaDon);

            txt_MaHoaDon.Text = hd.MaHoaDon;
            txt_KhuVuc.Text = bllKhuVuc.GetTenKhuVucByMaKhuVuc(hd.MaKhuVuc);
            txt_Ban.Text = bllBan.GetTenBanByMaBan(hd.MaBan);
            txt_TenNhanVien.Text = bllNhanVien.GetTenNhanVienByMaNhanVien(hd.MaNhanVien);
            txt_NgayBan.Text = hd.NgayBan.ToString();
            txt_ThoiGian.Text = hd.ThoiGian.ToString();
            txt_TrangThai.Text = hd.TrangThai;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
