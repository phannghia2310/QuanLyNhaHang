﻿using Guna.UI2.WinForms;
using QuanLyNhaHang.BusinessLayer;
using QuanLyNhaHang.DataLayer;
using QuanLyNhaHang.Entities;
using QuanLyNhaHang.Forms;
using QuanLyNhaHang.Forms.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.GUI
{
    public partial class fOrder : Form
    {
        public fOrder()
        {
            InitializeComponent();
            UC_Order uo = new UC_Order();
            addUserControl(uo);
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
    }
}
