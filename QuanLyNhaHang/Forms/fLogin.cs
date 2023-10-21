using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Xml.Linq;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;

namespace QuanLyNhaHang.GUI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            pn_Login.BackColor = Color.FromArgb(140, 1, 1, 1);
            txt_Password.UseSystemPasswordChar = true;
        }

        private void PB_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowPass.Checked)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
                txt_Password.UseSystemPasswordChar = true;
        }

        private void txt_Username_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            txt_Password.Clear();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain fmain = new fMain();
            fmain.Show();
        }
    }
}
