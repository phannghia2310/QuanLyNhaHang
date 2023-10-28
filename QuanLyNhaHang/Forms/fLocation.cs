using QuanLyNhaHang.Forms.User_Controls;
using QuanLyNhaHang.GUI.User_Controls;
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
    public partial class fLocation : Form
    {
        public fLocation()
        {
            InitializeComponent();
            UC_Location ul = new UC_Location();
            addUserControl(ul);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(userControl);
            userControl.BringToFront();
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

        private void btn_Location_Click(object sender, EventArgs e)
        {
            UC_Location ul = new UC_Location();
            addUserControl(ul);
        }

        private void btn_Table_Click(object sender, EventArgs e)
        {
            UC_Table ut = new UC_Table();
            addUserControl(ut);
        }
    }
}
