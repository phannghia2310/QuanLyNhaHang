using QuanLyNhaHang.BusinessLayer;
using QuanLyNhaHang.DataLayer;
using QuanLyNhaHang.Entities;
using QuanLyNhaHang.Forms.User_Controls;
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

namespace QuanLyNhaHang.Forms
{
    public partial class fSwitchTable : Form
    {
        string MaBan, TenBan;
        BanBLL bllBan = new BanBLL();
        HoaDonBLL bllHoaDon = new HoaDonBLL();
        ChiTietHoaDonBLL bllCTHD = new ChiTietHoaDonBLL();

        public fSwitchTable(string maBan, string tenBan)
        {
            InitializeComponent();
            this.MaBan = maBan;
            this.TenBan = tenBan;
        }

        private void fSwitchTable_Load(object sender, EventArgs e)
        {
            cmb_Ban.DataSource = bllBan.GetBanByTrangThai("TRỐNG", TenBan);
            cmb_Ban.DisplayMember = "TenBan";
            cmb_Ban.ValueMember = "MaBan";
            txt_Ban.Text = TenBan;

            dgv_HoaDon.DataSource = bllCTHD.GetChiTietHoaDonByMaBan(MaBan);
        }

        bool CheckSelect()
        {
            if (txt_Ban.Text == cmb_Ban.Text)
            {
                MessageBox.Show("Lựa chọn bàn không hợp lệ!\nVui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        bool CheckTrangThai()
        {
            DataTable dt = bllBan.GetDSBan();
            string TrangThai = "";
            foreach(DataRow row in dt.Rows)
            {
                if (cmb_Ban.Text == row["TenBan"].ToString())
                {
                    TrangThai = row["TrangThai"].ToString();
                }
            }
            if(TrangThai == "CÓ NGƯỜI")
            {
                MessageBox.Show("Bàn này đã có người, không thể chuyển!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (TrangThai == "ĐẶT TRƯỚC")
            {
                MessageBox.Show("Bàn này đã có người đặt, không thể chuyển!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btn_ChuyenBan_Click(object sender, EventArgs e)
        {
            if(CheckSelect())
            {
                if(CheckTrangThai())
                {
                    if(MessageBox.Show("Bạn có chắc chắn muốn chuyển từ '" + txt_Ban.Text + "' đến '" + cmb_Ban.Text + "'", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string MaHoaDon = bllHoaDon.GetMaHoaDonByMaBan(MaBan);
                        HoaDon hd = new HoaDon();
                        hd = bllHoaDon.GetHoaDonByMa(MaHoaDon);
                        if(hd != null)
                        {
                            hd.MaKhuVuc = bllBan.GetMaKhuVucByTenBan(cmb_Ban.Text);
                            hd.MaBan = bllBan.GetMaBanByTenBan(cmb_Ban.Text);
                            bllHoaDon.Update(hd);
                        }
                        bllBan.CapNhatTrangThaiBan("TRỐNG", txt_Ban.Text);
                        bllBan.CapNhatTrangThaiBan("CÓ NGƯỜI", cmb_Ban.Text);
                        MessageBox.Show("Chuyển bàn thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Chuyển bàn thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
