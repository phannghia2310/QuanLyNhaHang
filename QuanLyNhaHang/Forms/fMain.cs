using QuanLyNhaHang.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.GUI
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            lb_ChucVu.Text = fLogin.tenchucvu;
            lb_TenNhanVien.Text = fLogin.tennhanvien;
            time_DateTime.Start();
        }


        private void btn_Personal_Click(object sender, EventArgs e)
        {
            this.Hide();
            fPersonal fPersonal = new fPersonal();
            fPersonal.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin flogin = new fLogin();
            flogin.Show();
        }

        private void btn_Lock_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLock flock = new fLock();
            flock.Show();
        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
            this.Hide();
            fContact fcontact = new fContact();
            fcontact.Show();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            fEmployee femp = new fEmployee();
            femp.Show();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAccount faccount = new fAccount();
            faccount.Show();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMenu fmenu = new fMenu();
            fmenu.Show();
        }

        private void btn_Location_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLocation flocation = new fLocation();
            flocation.Show();
        }

        private void btn_Bill_Click(object sender, EventArgs e)
        {
            this.Hide();
            fPaymentHistory fpayment = new fPaymentHistory();
            fpayment.Show();
        }

        private void btn_Statistical_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDashboard fdashboard = new fDashboard();
            fdashboard.Show();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            this.Hide();
            fOrder forder = new fOrder();
            forder.Show();
        }

        private void time_DateTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lb_Time.Text = dateTime.ToString("HH:mm:ss");
            this.lb_Date.Text = dateTime.ToString("D");
        }
    }
}
