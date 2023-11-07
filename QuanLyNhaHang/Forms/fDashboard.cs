using QuanLyNhaHang.BusinessLayer;
using QuanLyNhaHang.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis.TtsEngine;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyNhaHang.GUI
{
    public partial class fDashboard : Form
    {
        DataAccess da = new DataAccess();
        HoaDonBLL bllHoaDon = new HoaDonBLL();
        ChiTietHoaDonBLL bllCTHD = new ChiTietHoaDonBLL();
        MonAnBLL bllMonAn = new MonAnBLL();
        SqlConnection cnn = new SqlConnection(DataAccess.strConnection);

        public fDashboard()
        {
            InitializeComponent();
        }

        void ThongKeHoaDon()
        {
            DataTable dtTongHDThang = bllHoaDon.TongHoaDonThang();
            DataTable dtTongHDNgay = bllHoaDon.TongHoaDonNgay();

            txt_TongHoaDonThang.Text = dtTongHDThang.Rows.Count.ToString();
            txt_TongHoaDonNgay.Text = dtTongHDNgay.Rows.Count.ToString();
        }

        void ThongKeMatHang()
        {
            DataTable dtTongMHThang = bllCTHD.TongMatHangThang();
            int TongMH = 0;
            foreach(DataRow row in dtTongMHThang.Rows)
            {
                TongMH += int.Parse(row["SoLuong"].ToString());
            }
            txt_TongMHThang.Text = TongMH.ToString();

            DataTable dtMHBanChay = bllCTHD.MatHangBanChay();
            int max = int.Parse(dtMHBanChay.Rows[0]["SoLuong"].ToString());
            foreach (DataRow row in dtMHBanChay.Rows)
            {
                int temp = int.Parse(row["SoLuong"].ToString());
                if (temp >= max)
                {
                    max = temp;
                    txt_MHBanChayNhat.Text = bllMonAn.GetTenMonAnByMa(row["MaMonAn"].ToString());
                }
            }
        }

        void ThongKeDoanhSo()
        {
            DataTable dtTongDSThang = bllHoaDon.TongDoanhSoThang();
            int TongDSThang = 0, TongDSNgay = 0;
            foreach(DataRow row in dtTongDSThang.Rows)
            {
                TongDSThang += int.Parse(row["TongTien"].ToString());
            }
            txt_DoanhSoThang.Text = String.Format("{0:0,0}", TongDSThang);

            DataTable dtTongDSNgay = bllHoaDon.TongDoanhSoNgay();
            foreach(DataRow row in dtTongDSNgay.Rows)
            {
                TongDSNgay += int.Parse(row["TongTien"].ToString());
            }
            txt_DoanhSoNgay.Text = String.Format("{0:0,0}", TongDSNgay) + "đ";
        }

        void ChartTKDSTheoNgay()
        {
            chart_ThongKeDoanhSo.Series["Doanh số"].XValueType = ChartValueType.Date;
            chart_ThongKeDoanhSo.ChartAreas[0].AxisX.LabelStyle.Format = "MM";
            chart_ThongKeDoanhSo.Series["Doanh số"].YValueType = ChartValueType.Int64;
            DataTable ds = new DataTable();
            if(cnn.State == ConnectionState.Open )
            {
                cnn.Close();
            }
            cnn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select CAST(NgayBan AS DATE) as Ngay, sum(TongTien) AS Tien" +
                                    " from HOADON where Day(NgayBan) = '" + DateTime.Now.ToString("MM") + "' AND TrangThai=N'ĐÃ THANH TOÁN'" +
                                    " group by CAST(NgayBan AS DATE)" +
                                    " ORDER by CAST(NgayBan AS DATE)", cnn);
            sqlDataAdapter.Fill(ds);
            chart_ThongKeDoanhSo.DataSource = ds;
            chart_ThongKeDoanhSo.Series["Doanh số"].XValueMember = "Ngay";
            chart_ThongKeDoanhSo.Series["Doanh số"].YValueMembers = "Tien";
            chart_ThongKeDoanhSo.Series["Doanh số"].IsValueShownAsLabel = true;
            cnn.Close();
            
        }

        void ChartThongKeMatHangNgay()
        {
            DataTable ds = new DataTable();
            if(cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            cnn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ma.TenMonAn as TenMonAn, sum(ct.SoLuong) as SoLuong" +
                                            " FROM ChiTietHoaDon ct JOIN HoaDon hd ON ct.MaHoaDon=hd.MaHoaDon" +
                                            " JOIN MONAN ma ON ct.MaMonAn=ma.MaMonAn" +
                                            " WHERE hd.TrangThai=N'ĐÃ THANH TOÁN'" +
                                            " AND DAY(hd.NgayBan)= " + DateTime.Now.ToString("MM") +
                                            " GROUP BY ma.TenMonAn", cnn);
            sqlDataAdapter.Fill(ds);
            chart_ThongKeMatHang.DataSource = ds;
            chart_ThongKeMatHang.Series["Series1"].XValueMember = "TenMonAn";
            chart_ThongKeMatHang.Series["Series1"].XValueType = ChartValueType.String;
            chart_ThongKeMatHang.Series["Series1"].YValueMembers = "SoLuong";
            chart_ThongKeMatHang.Series["Series1"].YValueType = ChartValueType.Int64;
            chart_ThongKeMatHang.Series["Series1"].IsValueShownAsLabel = true;
            cnn.Close();
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

        private void fDashboard_Load(object sender, EventArgs e)
        {
            ThongKeHoaDon();
            ThongKeMatHang();
            ThongKeDoanhSo();

            ChartTKDSTheoNgay();
            ChartThongKeMatHangNgay();
        }
    }
}
