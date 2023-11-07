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
    public partial class fCashier : Form
    {
        public fCashier()
        {
            InitializeComponent();
            UC_Order uo = new UC_Order();
            addUserControl(uo);
        }

        private void fCashier_Load(object sender, EventArgs e)
        {
            lb_ChucVu.Text = fLogin.tenchucvu;
            lb_TenNhanVien.Text = fLogin.tennhanvien;
            time_DateTime.Start();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            UC_Order uo = new UC_Order();
            addUserControl(uo);
        }

        private void btn_PaymentHistory_Click(object sender, EventArgs e)
        {
            UC_PaymentHistory up = new UC_PaymentHistory();
            addUserControl(up);
        }

        private void btn_Lock_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLock fLock = new fLock();
            fLock.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin flogin = new fLogin();
            flogin.Show();
        }

        private void time_DateTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lb_Time.Text = dateTime.ToString("HH:mm:ss");
            this.lb_Date.Text = dateTime.ToString("D");
        }

        private void btn_Personal_Click(object sender, EventArgs e)
        {
            this.Hide();
            fPersonal fPersonal = new fPersonal();
            fPersonal.Show();
        }
    }
}
