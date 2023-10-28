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
    public partial class fOrder : Form
    {
        DataAccess da = new DataAccess();
        HoaDon hd;
        ChiTietHoaDon ct;
        KhuVucBLL bllKhuVuc = new KhuVucBLL();
        BanBLL bllBan = new BanBLL();
        DanhMucBLL bllDanhMuc = new DanhMucBLL();
        MonAnBLL bllMonAn = new MonAnBLL();

        public fOrder()
        {
            InitializeComponent();
        }

        void GetDataHoaDon()
        {
            hd = new HoaDon();
            hd.MaHoaDon = txt_MaHoaDon.Text;
            hd.NgayBan = Convert.ToDateTime(txt_NgayBan.Text);
            hd.TongTien = Convert.ToInt32(txt_ThanhTien.Text);
            hd.TrangThai = txt_TrangThai.Text;
            hd.MaNhanVien = UserLogin.MaNhanVien;
        }

        private void fOrder_Load(object sender, EventArgs e)
        {
            time_Order.Start();
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

        private void time_Order_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            txt_NgayBan.Text = dateTime.ToString("dd/MM/yyyy");
            txt_ThoiGian.Text = dateTime.ToString("HH:mm:ss");
        }
    }
}
