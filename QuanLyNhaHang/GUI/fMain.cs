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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            time_DateTime.Start();
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

        private void time_DateTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lb_Time.Text = dateTime.ToString("HH:mm:ss");
            this.lb_Date.Text = dateTime.ToString("D");
        }
    }
}
