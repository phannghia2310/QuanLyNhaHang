using Guna.UI2.WinForms;
using QuanLyNhaHang.BusinessLayer;
using QuanLyNhaHang.DataLayer;
using QuanLyNhaHang.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
        HoaDonBLL bllHoaDon = new HoaDonBLL();
        ChiTietHoaDonBLL bllCTHD = new ChiTietHoaDonBLL();
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

        void AutoID()
        {
            string lastID = bllHoaDon.GetMaHoaDon();
            int number;

            if(string.IsNullOrEmpty(lastID))
            {
                string newID = "HD00001";
                txt_MaHoaDon.Text = newID;
            }
            else if(int.TryParse(lastID.Substring(2), out number))
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

            DataTable dt = new DataTable();
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
                    TextOffset = new Point(-8, 20),
                    Font = new Font("Microsoft Sans Serif", 9),
                    ForeColor = Color.Black,
                    Image = Properties.Resources.table,
                    ImageSize = new Size(50, 50),
                    ImageAlign = HorizontalAlignment.Center,
                    ImageOffset = new Point(0, -10),
                    Width = 100,
                    Height = 70,
                    Location = new Point(x + 25, y + 20),
                    BorderRadius = 5,
                    BorderColor = Color.Gray,
                    BorderThickness = 1,
                    FillColor = Color.White,
                    Cursor = Cursors.Hand,
                };
                
                if(x < panel_Table.Width - 220)
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
                    btn.ContextMenuStrip= cms_CoNguoi;
                }

                panel_Table.Controls.Add(btn);
            }
        }
        
        void GetMonAn()
        {
            panel_MonAn.Controls.Clear();
            string MaDanhMuc = cmb_DanhMuc.SelectedValue.ToString();
            int index = cmb_DanhMuc.SelectedIndex;

            DataTable dt = new DataTable();
            if (index == 0)
            {
                dt = bllMonAn.GetDsMonAn();
            }
            else
            {
                dt = bllMonAn.GetMonAnByMaDanhMuc(MaDanhMuc);
            }

            int x = 10, y = 10;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Panel pn = new Panel()
                {
                    Name = "pn_MonAn" + i,
                    Width = 140,
                    Height = 110,
                    Location = new Point(x, y),
                    BorderStyle = BorderStyle.FixedSingle,
                };

                Label lb = new Label()
                {
                    Text = dt.Rows[i]["TenMonAn"].ToString(),
                    Dock = DockStyle.Top,
                };
                pn.Controls.Add(lb);

                PictureBox pb = new PictureBox()
                {
                    Dock = DockStyle.Top,
                    BackColor = Color.Red,
                    BackgroundImage = Image.FromFile("C:\\Users\\phank\\OneDrive\\Documents\\CODEWORK\\VS-Code\\PTTKHDT\\QuanLyNhaHang\\QuanLyNhaHang\\Resources\\month.png"),
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Height = 60,
                };
                pn.Controls.Add(pb);

                Panel sub_pn = new Panel()
                {
                    Dock = DockStyle.Bottom,
                    BackColor = Color.Green,
                };
                pn.Controls.Add(sub_pn);

                Button btn_Add = new Button()
                {

                };

                if (x < panel_MonAn.Width - 220)
                {
                    x += 150;
                }
                else
                {
                    x = 10;
                    y += 130;
                }

                panel_MonAn.Controls.Add(pn);
            }
        }

        private void fOrder_Load(object sender, EventArgs e)
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
            GetMonAn();

            txt_KhuyenMai.Text = "";
            //panel_MonAn.Enabled = false;
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

        private void cmb_KhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetBan();
        }

        private void cmb_DanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetMonAn();
        }
    }
}
