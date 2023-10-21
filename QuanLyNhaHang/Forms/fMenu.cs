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
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
            UC_Category uc = new UC_Category();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_Container.Controls.Clear();
            panel_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void fMenu_Load(object sender, EventArgs e)
        {

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

        private void btn_Category_Click(object sender, EventArgs e)
        {
            UC_Category uc = new UC_Category();
            addUserControl(uc);
        }

        private void btn_Food_Click(object sender, EventArgs e)
        {
            UC_Food uf = new UC_Food();
            addUserControl(uf);
        }
    }
}
