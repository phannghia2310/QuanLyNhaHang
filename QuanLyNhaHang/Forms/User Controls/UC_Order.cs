using Bunifu.UI.WinForms.Extensions;
using Guna.UI2.WinForms;
using QuanLyNhaHang.BusinessLayer;
using QuanLyNhaHang.DataLayer;
using QuanLyNhaHang.Entities;
using QuanLyNhaHang.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.Forms.User_Controls
{
    public partial class UC_Order : UserControl
    {
        DataAccess da = new DataAccess();
        HoaDon hd;
        ChiTietHoaDon ct;
        HoaDonBLL bllHoaDon = new HoaDonBLL();
        ChiTietHoaDonBLL bllCTHD = new ChiTietHoaDonBLL();
        KhuVucBLL bllKhuVuc = new KhuVucBLL();
        BanBLL bllBan = new BanBLL();
        DanhMucBLL bllDanhMuc = new DanhMucBLL();
        MonAnBLL bllMonAn = new MonAnBLL();
        NhanVienBLL bllNhanVien = new NhanVienBLL();
        string MaBan;
        float khuyenmai = 0, tongcong = 0, thanhtien = 0;
        int height = 0;

        public UC_Order()
        {
            InitializeComponent();
        }

        void GetDataHoaDon()
        {
            hd = new HoaDon();
            hd.MaHoaDon = txt_MaHoaDon.Text;
            hd.NgayBan = Convert.ToDateTime(txt_NgayBan.Text);
            hd.ThoiGian = TimeSpan.Parse(txt_ThoiGian.Text);
            hd.KhuyenMai = txt_KhuyenMai.Text + "%";
            hd.TongTien = Convert.ToInt32(txt_ThanhTien.Text);
            hd.TrangThai = "CHƯA THANH TOÁN";
            hd.GhiChu = txt_GhiChu.Text;
            hd.MaNhanVien = UserLogin.MaNhanVien;
            hd.MaKhuVuc = bllKhuVuc.GetMaKhuVucByTenKhuVuc(txt_KhuVuc.Text);
            hd.MaBan = bllBan.GetMaBanByTenBan(txt_Ban.Text);
        }

        void AutoID()
        {
            string lastID = bllHoaDon.GetMaHoaDon();
            int number;

            if (string.IsNullOrEmpty(lastID))
            {
                string newID = "HD00001";
                txt_MaHoaDon.Text = newID;
            }
            else if (int.TryParse(lastID.Substring(2), out number))
            {
                int newNumber = number + 1;
                string newID = "HD" + newNumber.ToString("D5");
                txt_MaHoaDon.Text = newID;
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        void GetBan()
        {
            panel_Table.Controls.Clear();
            string MaKhuVuc = cmb_KhuVuc.SelectedValue.ToString();
            int index = cmb_KhuVuc.SelectedIndex;

            System.Data.DataTable dt = new System.Data.DataTable();
            if (index == 0)
            {
                dt = bllBan.GetDSBan();
            }
            else
            {
                dt = bllBan.GetBanByMaKhuVuc(MaKhuVuc);
            }

            int x = 10, y = 10;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Guna2Button btn = new Guna2Button()
                {
                    Name = "btn_Table" + i,
                    Text = dt.Rows[i]["TenBan"].ToString(),
                    TextAlign = HorizontalAlignment.Right,
                    TextOffset = new System.Drawing.Point(-8, 20),
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 9),
                    ForeColor = Color.Black,
                    Image = Properties.Resources.table,
                    ImageSize = new Size(50, 50),
                    ImageAlign = HorizontalAlignment.Center,
                    ImageOffset = new System.Drawing.Point(0, -10),
                    Width = 100,
                    Height = 70,
                    Location = new System.Drawing.Point(x + 25, y + 20),
                    BorderRadius = 5,
                    BorderColor = Color.Gray,
                    BorderThickness = 1,
                    FillColor = Color.White,
                    Cursor = Cursors.Hand,
                };

                if (x < panel_Table.Width - 220)
                {
                    x += 110;
                }
                else
                {
                    x = 10;
                    y += 80;
                }

                if (dt.Rows[i]["TrangThai"].ToString() == "TRỐNG")
                {
                    btn.FillColor = Color.White;
                    btn.ContextMenuStrip = cms_Trong;
                }
                if (dt.Rows[i]["TrangThai"].ToString() == "ĐẶT TRƯỚC")
                {
                    btn.FillColor = Color.Yellow;
                    btn.ContextMenuStrip = cms_DatTruoc;
                }
                if (dt.Rows[i]["TrangThai"].ToString() == "CÓ NGƯỜI")
                {
                    btn.FillColor = Color.Green;
                    btn.ContextMenuStrip = cms_CoNguoi;
                }

                btn.Click += btn_Click;
                panel_Table.Controls.Add(btn);
            }
        }

        void GetMonAn(System.Data.DataTable selectedItems)
        {
            panel_MonAn.Controls.Clear();
            string MaDanhMuc = cmb_DanhMuc.SelectedValue.ToString();
            int index = cmb_DanhMuc.SelectedIndex;

            System.Data.DataTable dt = new System.Data.DataTable();
            if (txt_TimKiem.Text == "")
            {
                if (index == 0)
                {
                    dt = bllMonAn.GetDsMonAn();
                }
                else
                {
                    dt = bllMonAn.GetMonAnByMaDanhMuc(MaDanhMuc);
                }
            }
            else
            {
                dt = bllMonAn.SearchByTenMonAn(txt_TimKiem.Text);
            }

            int x = 10, y = 10;

            if (selectedItems.Rows.Count == 0)
            {
                selectedItems = new System.Data.DataTable();
                selectedItems.Columns.Add("TenMonAn");
                selectedItems.Columns.Add("DonGia", typeof(decimal));
                selectedItems.Columns.Add("SoLuong", typeof(int));
                selectedItems.Columns.Add("ThanhTien", typeof(decimal));
            }
            dgv_HoaDon.DataSource = selectedItems;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Panel pn = new Panel()
                {
                    Name = "pn_MonAn" + i,
                    Width = 140,
                    Height = 130,
                    Location = new System.Drawing.Point(x, y),
                    BorderStyle = BorderStyle.FixedSingle,
                };

                Panel sub_pn = new Panel()
                {
                    Dock = DockStyle.Bottom,
                    Width = 140,
                    Height = 25,
                };
                pn.Controls.Add(sub_pn);

                Guna2Button btn_Add = new Guna2Button()
                {
                    Text = "+",
                    TextAlign = HorizontalAlignment.Center,
                    Font = new Font("Microsoft Sans Serif", 10),
                    ForeColor = Color.White,
                    Dock = DockStyle.Right,
                    Width = 70,
                    Cursor = Cursors.Hand,
                    BorderThickness = 1,
                    BorderColor = Color.Gray,
                };
                sub_pn.Controls.Add(btn_Add);

                Guna2Button btn_Sub = new Guna2Button()
                {
                    Text = "-",
                    TextAlign = HorizontalAlignment.Center,
                    Font = new Font("Microsoft Sans Serif", 10),
                    ForeColor = Color.White,
                    Dock = DockStyle.Left,
                    Width = 70,
                    Cursor = Cursors.Hand,
                    BorderColor = Color.Gray,
                    BorderThickness = 1,
                };
                sub_pn.Controls.Add(btn_Sub);

                Label lb_cost = new Label()
                {
                    Text = dt.Rows[i]["DonGia"].ToString() + " VNĐ",
                    TextAlign = ContentAlignment.MiddleRight,
                    Dock = DockStyle.Top,
                };
                pn.Controls.Add(lb_cost);

                Label lb_name = new Label()
                {
                    Text = dt.Rows[i]["TenMonAn"].ToString(),
                    Dock = DockStyle.Top,
                };
                pn.Controls.Add(lb_name);

                string fileAnh = dt.Rows[i]["Anh"].ToString();
                PictureBox pb = new PictureBox()
                {
                    Dock = DockStyle.Top,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Height = 60,
                };
                if (fileAnh == "Chưa có ảnh" || !File.Exists(@"C:\Users\phank\OneDrive\Documents\CODEWORK\VS-Code\PTTKHDT\QuanLyNhaHang\QuanLyNhaHang\Resources\" + fileAnh))
                {
                    pb.BackgroundImage = null;
                }
                else
                {
                    pb.BackgroundImage = Image.FromFile(@"C:\Users\phank\OneDrive\Documents\CODEWORK\VS-Code\PTTKHDT\QuanLyNhaHang\QuanLyNhaHang\Resources\" + fileAnh);
                }
                pn.Controls.Add(pb);

                if (x < panel_MonAn.Width - 220)
                {
                    x += 150;
                }
                else
                {
                    x = 10;
                    y += 140;
                }

                panel_MonAn.Controls.Add(pn);

                int itemIndex = i;

                btn_Add.Click += (sender, e) =>
                {
                    if (itemIndex >= 0 && itemIndex < dt.Rows.Count)
                    {
                        string itemName = dt.Rows[itemIndex]["TenMonAn"].ToString();
                        decimal itemDonGia = decimal.Parse(dt.Rows[itemIndex]["DonGia"].ToString());

                        DataRow existingItem = selectedItems.AsEnumerable().FirstOrDefault(row => row.Field<string>("TenMonAn") == itemName);

                        if (existingItem != null)
                        {
                            existingItem["SoLuong"] = (int)existingItem["SoLuong"] + 1;
                            existingItem["ThanhTien"] = (int)existingItem["SoLuong"] * itemDonGia;
                        }
                        else
                        {
                            DataRow newItemRow = selectedItems.NewRow();
                            newItemRow["TenMonAn"] = itemName;
                            newItemRow["DonGia"] = itemDonGia;
                            newItemRow["SoLuong"] = 1;
                            newItemRow["ThanhTien"] = itemDonGia;
                            selectedItems.Rows.Add(newItemRow);
                        }

                        tongcong = 0;
                        foreach (DataRow row in selectedItems.Rows)
                        {
                            tongcong += int.Parse(row["ThanhTien"].ToString());
                        }
                        txt_TongCong.Text = tongcong.ToString();
                        txt_ThanhTien.Text = tongcong.ToString();

                        dgv_HoaDon.Refresh();
                    }
                };

                btn_Sub.Click += (sender, e) =>
                {
                    if (itemIndex >= 0 && itemIndex < dt.Rows.Count)
                    {
                        string itemName = dt.Rows[itemIndex]["TenMonAn"].ToString();

                        DataRow existingItem = selectedItems.AsEnumerable().FirstOrDefault(row => row.Field<string>("TenMonAn") == itemName);

                        if (existingItem != null)
                        {
                            int currentSoLuong = (int)existingItem["SoLuong"];
                            currentSoLuong--;

                            if (currentSoLuong > 0)
                            {
                                existingItem["SoLuong"] = currentSoLuong;
                                existingItem["ThanhTien"] = currentSoLuong * (int)existingItem["DonGia"];
                            }
                            else
                            {
                                selectedItems.Rows.Remove(existingItem);
                            }

                            tongcong = 0;
                            foreach (DataRow row in selectedItems.Rows)
                            {
                                tongcong += int.Parse(row["ThanhTien"].ToString());
                            }
                            txt_TongCong.Text = tongcong.ToString();
                            txt_ThanhTien.Text = tongcong.ToString();

                            dgv_HoaDon.Refresh();
                        }
                    }
                };
            }
        }

        private void UC_Order_Load(object sender, EventArgs e)
        {
            time_Order.Start();
            AutoID();

            cmb_KhuVuc.DataSource = bllKhuVuc.GetDSKhuVuc();
            cmb_KhuVuc.DisplayMember = "TenKhuVuc";
            cmb_KhuVuc.ValueMember = "MaKhuVuc";
            GetBan();

            cmb_DanhMuc.DataSource = bllDanhMuc.GetDSDanhMuc();
            cmb_DanhMuc.DisplayMember = "TenDanhMuc";
            cmb_DanhMuc.ValueMember = "MaDanhMuc";

            DataTable selectedItems;
            if (dgv_HoaDon.DataSource != null)
            {
                selectedItems = (DataTable)dgv_HoaDon.DataSource;
            }
            else
            {
                selectedItems = new DataTable();
            }
            GetMonAn(selectedItems);

            txt_KhuVuc.Text = "";
            txt_Ban.Text = "";
            txt_TrangThai.Text = "";
            txt_KhuyenMai.Text = "0";
            txt_TongCong.Text = "0";
            txt_ThanhTien.Text = "0";
            txt_GhiChu.Text = "";

            panel_MonAn.Enabled = false;
            dgv_HoaDon.ReadOnly = true;
            ((DataTable)dgv_HoaDon.DataSource).Clear();
        }

        private void time_Order_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            txt_NgayBan.Text = dateTime.ToString("yyyy-dd-MM");
            txt_ThoiGian.Text = dateTime.ToString("HH:mm:ss");
        }

        private void cmb_KhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetBan();
        }

        private void cmb_DanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable selectedItems;
            if (dgv_HoaDon.DataSource != null)
            {
                selectedItems = (DataTable)dgv_HoaDon.DataSource;
            }
            else
            {
                selectedItems = new DataTable();
            }
            GetMonAn(selectedItems);
        }

        bool CheckThanhToan()
        {
            if (txt_KhuVuc.Text == "" && txt_Ban.Text == "" && txt_TrangThai.Text == "")
            {
                MessageBox.Show("Bạn chưa lựa chọn bàn để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txt_TrangThai.Text == "TRỐNG" || txt_TrangThai.Text == "ĐẶT TRƯỚC")
            {
                MessageBox.Show("Bàn hiện tại trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (CheckThanhToan())
            {
                height = 400 + (dgv_HoaDon.Rows.Count - 1) * 30;
                hd = bllHoaDon.GetHoaDonByMa(txt_MaHoaDon.Text);
                bllHoaDon.CapNhatTrangThaiHoaDon("ĐÃ THANH TOÁN", hd.MaHoaDon);

                bllBan.CapNhatTrangThaiBan("TRỐNG", txt_Ban.Text);
                GetBan();

                MessageBox.Show("Thanh toán thành công!!", "Thông báo");

                print_PreviewDialog.Document = print_Document;
                print_Document.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Suit Detail", 800, height + 200);
                print_PreviewDialog.ShowDialog();

                UC_Order_Load(sender, e);

            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_KhuyenMai.Text = "0";
            txt_TongCong.Text = "0";
            txt_ThanhTien.Text = "0";
            txt_GhiChu.Text = "";
            ((DataTable)dgv_HoaDon.DataSource).Clear();
        }

        private void txt_KhuyenMai_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_KhuyenMai.Text))
            {
                khuyenmai = 0;
                thanhtien = tongcong - tongcong * (khuyenmai / 100);
                txt_ThanhTien.Text = thanhtien.ToString();
            }
            else
            {
                khuyenmai = int.Parse(txt_KhuyenMai.Text);
                thanhtien = tongcong - tongcong * (khuyenmai / 100);
                txt_ThanhTien.Text = thanhtien.ToString();
            }
        }

        private void txt_TimKiem_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Clear();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable selectedItems;
            if (dgv_HoaDon.DataSource != null)
            {
                selectedItems = (DataTable)dgv_HoaDon.DataSource;
            }
            else
            {
                selectedItems = new DataTable();
            }
            GetMonAn(selectedItems);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            loadChuot(sender, e);
        }

        private void im_GoiMon_Click(object sender, EventArgs e)
        {
            panel_MonAn.Enabled = true;
            txt_TrangThai.Text = "CÓ NGƯỜI";
            txt_TrangThai.ForeColor = Color.Green;
            bllBan.CapNhatTrangThaiBan(txt_TrangThai.Text, txt_Ban.Text);
            GetBan();
        }

        private void im_DatBan_Click(object sender, EventArgs e)
        {
            bllBan.CapNhatTrangThaiBan("ĐẶT TRƯỚC", txt_Ban.Text);
            GetBan();
        }

        private void im_GoiMonDT_Click(object sender, EventArgs e)
        {
            panel_MonAn.Enabled = true;
            txt_TrangThai.Text = "CÓ NGƯỜI";
            txt_TrangThai.ForeColor = Color.Green;
            bllBan.CapNhatTrangThaiBan(txt_TrangThai.Text, txt_Ban.Text);
            GetBan();
        }

        private void im_HuyDatBan_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bàn hiện đang được đặt trước, bạn muốn hủy bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllBan.CapNhatTrangThaiBan("TRỐNG", txt_Ban.Text);
                GetBan();
            }
        }

        private void im_ThemTraMon_Click(object sender, EventArgs e)
        {
            panel_MonAn.Enabled = true;
        }

        private void im_ChuyenBan_Click(object sender, EventArgs e)
        {
            fSwitchTable fSwitchTable = new fSwitchTable(MaBan, txt_Ban.Text);
            fSwitchTable.ShowDialog();
            UC_Order_Load(sender, e);
        }

        bool CheckGoiMon()
        {
            if(string.IsNullOrWhiteSpace(txt_KhuVuc.Text) || string.IsNullOrWhiteSpace(txt_Ban.Text) || string.IsNullOrWhiteSpace(txt_TrangThai.Text))
            {
                MessageBox.Show("Vui lòng chọn bàn phục vụ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(txt_TrangThai.Text == "TRỐNG")
            {
                MessageBox.Show("Bàn hiện đang trống!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void im_XacNhan_Click(object sender, EventArgs e)
        {
            if (CheckGoiMon())
            {
                if (CheckGoiMon())
                {
                    if (dgv_HoaDon.Rows.Count == 1)
                    {
                        if (MessageBox.Show("Bàn hiện chưa đặt món, bạn muốn hủy bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            GetDataHoaDon();
                            List<ChiTietHoaDon> list = bllCTHD.GetListCTHDByMaHoaDon(hd.MaHoaDon);
                            foreach(ChiTietHoaDon ct in list)
                            {
                                bllCTHD.Delete(ct);
                            }
                            bllHoaDon.Delete(hd);
                            bllBan.CapNhatTrangThaiBan("TRỐNG", txt_Ban.Text);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Xác nhận gọi món", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            hd = bllHoaDon.GetHoaDonByMa(txt_MaHoaDon.Text);

                            if (hd != null)
                            {
                                GetDataHoaDon();
                                bllHoaDon.Update(hd);
                            }
                            else
                            {
                                GetDataHoaDon();
                                bllHoaDon.Insert(hd);
                            }

                            ct = new ChiTietHoaDon();
                            List<ChiTietHoaDon> list = bllCTHD.GetListCTHDByMaHoaDon(txt_MaHoaDon.Text);

                            foreach (DataGridViewRow row in dgv_HoaDon.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    string MaMonAn = bllMonAn.GetMaMonAnByTen(row.Cells["TenMonAn"].Value.ToString());

                                    // Check if the ChiTietHoaDon item exists in the list
                                    var existingCT = list.FirstOrDefault(ct => ct.MaMonAn == MaMonAn && ct.MaHoaDon == txt_MaHoaDon.Text);

                                    if (existingCT != null)
                                    {
                                        // Update the existing ChiTietHoaDon item
                                        ct.MaHoaDon = hd.MaHoaDon;
                                        ct.MaMonAn = MaMonAn;
                                        ct.DonGia = Convert.ToInt32(row.Cells["DonGia"].Value);
                                        ct.SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                                        ct.ThanhTien = Convert.ToInt32(row.Cells["ThanhTien"].Value);

                                        bllCTHD.Update(ct);
                                    }
                                    else
                                    {
                                        // Insert a new ChiTietHoaDon item
                                        ct.MaHoaDon = hd.MaHoaDon;
                                        ct.MaMonAn = MaMonAn;
                                        ct.DonGia = Convert.ToInt32(row.Cells["DonGia"].Value);
                                        ct.SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                                        ct.ThanhTien = Convert.ToInt32(row.Cells["ThanhTien"].Value);

                                        bllCTHD.Insert(ct);
                                    }
                                }
                            }

                            // Now, remove any ChiTietHoaDon items that are no longer present in the DataGridView
                            foreach (ChiTietHoaDon ctToRemove in list)
                            {
                                bool found = false;

                                foreach (DataGridViewRow row in dgv_HoaDon.Rows)
                                {
                                    if (!row.IsNewRow)
                                    {
                                        string MaMonAn = bllMonAn.GetMaMonAnByTen(row.Cells["TenMonAn"].Value.ToString());

                                        if (ctToRemove.MaMonAn == MaMonAn && ctToRemove.MaHoaDon == txt_MaHoaDon.Text)
                                        {
                                            found = true;
                                            break;
                                        }
                                    }
                                }

                                if (!found)
                                {
                                    bllCTHD.Delete(ctToRemove);
                                }
                            }
                        }
                    }
                }
                UC_Order_Load(sender, e);
            }
        }

        private void im_GopBan_Click(object sender, EventArgs e)
        {
            fMergeTable fMergeTable = new fMergeTable(MaBan, txt_Ban.Text);
            fMergeTable.ShowDialog();
            UC_Order_Load(sender, e);
        }

        private void print_Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("QUẢN LÝ NHÀ HÀNG", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, 260, 50);
            e.Graphics.DrawString("Địa chỉ: 450-451 Lê Văn Việt, Tăng Nhơn Phú A, Quận 9, TP. Thủ Đức", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, 110, 80);
            e.Graphics.DrawString("SDT: 0966045284 - 0374404395", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, 260, 110);
            e.Graphics.DrawLine(new Pen(Brushes.Black), 270, 150, 500, 150);

            e.Graphics.DrawString("HÓA ĐƠN THANH TOÁN", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 260, 170);
            e.Graphics.DrawString("Số hóa đơn: " + txt_MaHoaDon.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 290, 200);

            e.Graphics.DrawString("Khu vực: " + txt_KhuVuc.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 110, 240);
            e.Graphics.DrawString("Bàn: " + txt_Ban.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 110, 270);
            e.Graphics.DrawString("Thu ngân: " + bllNhanVien.GetTenNhanVienByMaNhanVien(UserLogin.MaNhanVien) , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 110, 300);
            e.Graphics.DrawString("Ngày: " + txt_NgayBan.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 500, 240);
            e.Graphics.DrawString("Thời gian: " + txt_ThoiGian.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 500, 270);

            e.Graphics.DrawString("Tên món ăn", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 110, 350);
            e.Graphics.DrawString("Đơn giá", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 290, 350);
            e.Graphics.DrawString("Số lượng", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 440, 350);
            e.Graphics.DrawString("Thành tiền", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 590, 350);
            Pen dashedPen = new Pen(Brushes.Black)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dash,
            };
            e.Graphics.DrawLine(dashedPen, 110, 380, 690, 380);

            // Draw the items on the invoice.


            for (int i = 0; i < dgv_HoaDon.Rows.Count - 1; i++)
            {
                e.Graphics.DrawString(dgv_HoaDon.Rows[i].Cells["TenMonAn"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 110, 400 + i * 30);
                e.Graphics.DrawString(dgv_HoaDon.Rows[i].Cells["DonGia"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 290, 400 + i * 30);
                e.Graphics.DrawString(dgv_HoaDon.Rows[i].Cells["SoLuong"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 470, 400 + i * 30);
                e.Graphics.DrawString(dgv_HoaDon.Rows[i].Cells["ThanhTien"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 610, 400 + i * 30);
            }

            height = 400 + (dgv_HoaDon.Rows.Count - 1) * 30;

            // Draw the total amount on the invoice.
            e.Graphics.DrawString("Tổng cộng: " + txt_TongCong.Text + " VNĐ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 490, height + 30);
            e.Graphics.DrawString("Khuyến mãi: " + txt_KhuyenMai.Text + " %", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 490, height + 70);
            e.Graphics.DrawString("Thành tiền: " + txt_ThanhTien.Text + " VNĐ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 490, height + 110);

            e.Graphics.DrawString("Xin chân thành cảm ơn quý khách! Hẹn gặp lại!", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, 220, height + 150);
        }

        void loadChuot(object sender, EventArgs e)
        {
            txt_Ban.Text = ((Guna2Button)sender).Text;
            MaBan = bllBan.GetMaBanByTenBan(txt_Ban.Text);
            panel_MonAn.Enabled = false;
            if (((Guna2Button)sender).FillColor == Color.White)
            {
                txt_TrangThai.Text = "TRỐNG";
                txt_TrangThai.ForeColor = Color.Black;
            }
            else if (((Guna2Button)sender).FillColor == Color.Green)
            {
                txt_TrangThai.Text = "CÓ NGƯỜI";
                txt_TrangThai.ForeColor = Color.Green;
            }
            else if (((Guna2Button)sender).FillColor == Color.Yellow)
            {
                txt_TrangThai.Text = "ĐẶT TRƯỚC";
                txt_TrangThai.ForeColor = Color.Gold;
            }

            txt_KhuVuc.Text = bllKhuVuc.GetTenKhuVucByTenBan(txt_Ban.Text);
            txt_MaHoaDon.Text = bllHoaDon.GetMaHoaDonByMaBan(MaBan);
            if (txt_MaHoaDon.Text == "")
            {
                AutoID();
            }

            DataTable listCTHD = bllCTHD.GetChiTietHoaDonByMaBan(MaBan);
            GetMonAn(listCTHD);
            hd = bllHoaDon.GetHoaDonByMa(txt_MaHoaDon.Text);

            if(hd != null)
            {
                txt_KhuyenMai.Text = hd.KhuyenMai.Remove(hd.KhuyenMai.Length - 1, 1);
                txt_GhiChu.Text = hd.GhiChu;
                txt_ThanhTien.Text = hd.TongTien.ToString();

                thanhtien = int.Parse(txt_ThanhTien.Text);
                khuyenmai = int.Parse(txt_KhuyenMai.Text);
                tongcong = thanhtien / (1 - (khuyenmai / 100));

                txt_TongCong.Text = tongcong.ToString();
            }
        }
    }
}
