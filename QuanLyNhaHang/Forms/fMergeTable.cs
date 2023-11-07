using QuanLyNhaHang.BusinessLayer;
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

namespace QuanLyNhaHang.Forms
{
    public partial class fMergeTable : Form
    {
        string MaBan, TenBan;
        BanBLL bllBan = new BanBLL();
        KhuVucBLL bllKhuVuc = new KhuVucBLL();
        MonAnBLL bllMonAn = new MonAnBLL();
        HoaDonBLL bllHoaDon = new HoaDonBLL();
        ChiTietHoaDonBLL bllCTHD = new ChiTietHoaDonBLL();

        public fMergeTable(string maBan, string tenBan)
        {
            InitializeComponent();
            this.MaBan = maBan;
            this.TenBan = tenBan;
        }

        private void fMergeTable_Load(object sender, EventArgs e)
        {
            cmb_Ban.DataSource = bllBan.GetBanByTrangThai("CÓ NGƯỜI", TenBan);
            cmb_Ban.DisplayMember = "TenBan";
            cmb_Ban.ValueMember = "MaBan";
            txt_Ban.Text = TenBan;

            dgv_HoaDon.DataSource = bllCTHD.GetChiTietHoaDonByMaBan(MaBan);
            dgv_HoaDonGop.DataSource = bllCTHD.GetChiTietHoaDonByMaBan(bllBan.GetMaBanByTenBan(cmb_Ban.Text));
        }

        private void cmb_Ban_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_HoaDonGop.DataSource = bllCTHD.GetChiTietHoaDonByMaBan(bllBan.GetMaBanByTenBan(cmb_Ban.Text));
        }

        private void btn_GopBan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn gộp hóa đơn '" + txt_Ban.Text + "' với hóa đơn '" + cmb_Ban.Text + "'?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //Add value from dgv_HoaDon to dgv_HoaDonGop
                DataTable dt = dgv_HoaDon.DataSource as DataTable;
                foreach(DataRow row in dt.Rows)
                {
                    bool rowExists = false;
                    DataTable dtGop = dgv_HoaDonGop.DataSource as DataTable;
                    foreach(DataRow rowGop in dtGop.Rows)
                    {
                        if (row["TenMonAn"].Equals(rowGop["TenMonAn"]))
                        {
                            rowGop["SoLuong"] = int.Parse(rowGop["SoLuong"].ToString()) + int.Parse(row["SoLuong"].ToString());
                            rowExists = true;
                            break;
                        }
                    }

                    if(!rowExists)
                    {
                        DataRow dr = dtGop.NewRow();
                        dr["TenMonAn"] = row["TenMonAn"];
                        dr["DonGia"] = row["DonGia"];
                        dr["SoLuong"] = row["SoLuong"];
                        dr["ThanhTien"] = row["ThanhTien"];
                        dtGop.Rows.Add(dr);
                    }
                }

                //delete HoaDon and ChiTietHoaDon of dgv_HoaDon
                string MaHoaDon = bllHoaDon.GetMaHoaDonByMaBan(MaBan);
                HoaDon hd = bllHoaDon.GetHoaDonByMa(MaHoaDon);
                List<ChiTietHoaDon> list = bllCTHD.GetListCTHDByMaHoaDon(MaHoaDon);
                foreach(ChiTietHoaDon cthd in list)
                {
                    bllCTHD.Delete(cthd);
                }
                bllHoaDon.Delete(hd);

                //delete HoaDonGop and ChiTietHoaDonGop of dgv_HoaDonGop
                string MaBanGop = bllBan.GetMaBanByTenBan(cmb_Ban.Text);
                string MaHoaDonGop = bllHoaDon.GetMaHoaDonByMaBan(MaBanGop);
                HoaDon hdGop = bllHoaDon.GetHoaDonByMa(MaHoaDonGop);
                List<ChiTietHoaDon> listGop = bllCTHD.GetListCTHDByMaHoaDon(MaHoaDonGop);
                foreach(ChiTietHoaDon cthd in listGop)
                {
                    bllCTHD.Delete(cthd);
                }
                bllHoaDon.Delete(hdGop);


                //create new HoaDon
                HoaDon newHoaDon = new HoaDon();
                string lastID = bllHoaDon.GetMaHoaDon();
                int number;

                if (string.IsNullOrEmpty(lastID))
                {
                    string newID = "HD00001";
                    newHoaDon.MaHoaDon = newID;
                }
                else if (int.TryParse(lastID.Substring(2), out number))
                {
                    int newNumber = number + 1;
                    string newID = "HD" + newNumber.ToString("D5");
                    newHoaDon.MaHoaDon = newID;
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
                newHoaDon.NgayBan = DateTime.Parse(DateTime.Now.ToString("yyyy-dd-MM"));
                newHoaDon.ThoiGian = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
                newHoaDon.KhuyenMai = "0%";
                newHoaDon.TongTien = hd.TongTien + hdGop.TongTien;
                newHoaDon.TrangThai = "CHƯA THANH TOÁN";
                newHoaDon.GhiChu = txt_GhiChu.Text;
                newHoaDon.MaNhanVien = UserLogin.MaNhanVien;
                newHoaDon.MaKhuVuc = bllBan.GetMaKhuVucByTenBan(cmb_Ban.Text);
                newHoaDon.MaBan = bllBan.GetMaBanByTenBan(cmb_Ban.Text);
                bllHoaDon.Insert(newHoaDon);

                //create new ChiTietHoaDon for newHoaDon
                ChiTietHoaDon ct = new ChiTietHoaDon();
                foreach (DataGridViewRow row in dgv_HoaDonGop.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string MaMonAn = bllMonAn.GetMaMonAnByTen(row.Cells["TenMonAn1"].Value.ToString());

                        ct.MaHoaDon = newHoaDon.MaHoaDon;
                        ct.MaMonAn = MaMonAn;
                        ct.DonGia = int.Parse(row.Cells["DonGia1"].Value.ToString());
                        ct.SoLuong = int.Parse(row.Cells["SoLuong1"].Value.ToString());
                        ct.ThanhTien = int.Parse(row.Cells["ThanhTien1"].Value.ToString());

                        bllCTHD.Insert(ct);
                    }
                }

                //dgv_HoaDon.DataSource = null;
                //dgv_HoaDonGop.Refresh();
                bllBan.CapNhatTrangThaiBan("TRỐNG", TenBan);
                MessageBox.Show("Gộp bàn thành công!!", "Thành công");
                this.Close();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
