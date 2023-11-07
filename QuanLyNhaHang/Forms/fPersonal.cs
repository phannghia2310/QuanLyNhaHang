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
    public partial class fPersonal : Form
    {
        public fPersonal()
        {
            InitializeComponent();
            UC_Personal up = new UC_Personal();
            addUserControl(up);
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
            if(fLogin.tenchucvu == "Quản lý")
            {
                this.Close();
                fMain fMain = new fMain();
                fMain.Show();
            }
            else
            {
                this.Close();
                fCashier fCashier = new fCashier();
                fCashier.Show();
            }
        }

        private void btn_Information_Click(object sender, EventArgs e)
        {
            UC_Personal up = new UC_Personal();
            addUserControl(up);
        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            UC_ChangPass uc = new UC_ChangPass();
            addUserControl(uc);
        }
    }
}
