namespace QuanLyNhaHang.Forms
{
    partial class fCashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCashier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_ChucVu = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_TenNhanVien = new System.Windows.Forms.Label();
            this.btn_Personal = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Lock = new Guna.UI2.WinForms.Guna2Button();
            this.btn_PaymentHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Order = new Guna.UI2.WinForms.Guna2Button();
            this.panel_Container = new System.Windows.Forms.Panel();
            this.time_DateTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Personal)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_ChucVu);
            this.panel1.Controls.Add(this.lb_Date);
            this.panel1.Controls.Add(this.lb_Time);
            this.panel1.Controls.Add(this.lb_TenNhanVien);
            this.panel1.Controls.Add(this.btn_Personal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 92);
            this.panel1.TabIndex = 0;
            // 
            // lb_ChucVu
            // 
            this.lb_ChucVu.AutoSize = true;
            this.lb_ChucVu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_ChucVu.Location = new System.Drawing.Point(228, 12);
            this.lb_ChucVu.Name = "lb_ChucVu";
            this.lb_ChucVu.Size = new System.Drawing.Size(73, 25);
            this.lb_ChucVu.TabIndex = 15;
            this.lb_ChucVu.Text = "label12";
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.BackColor = System.Drawing.Color.Transparent;
            this.lb_Date.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.Location = new System.Drawing.Point(1039, 31);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(297, 32);
            this.lb_Date.TabIndex = 14;
            this.lb_Date.Text = "Monday, October 15, 2023";
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.BackColor = System.Drawing.Color.Transparent;
            this.lb_Time.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.Location = new System.Drawing.Point(911, 31);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(102, 32);
            this.lb_Time.TabIndex = 13;
            this.lb_Time.Text = "12:00:00";
            // 
            // lb_TenNhanVien
            // 
            this.lb_TenNhanVien.AutoSize = true;
            this.lb_TenNhanVien.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lb_TenNhanVien.Location = new System.Drawing.Point(227, 41);
            this.lb_TenNhanVien.Name = "lb_TenNhanVien";
            this.lb_TenNhanVien.Size = new System.Drawing.Size(94, 35);
            this.lb_TenNhanVien.TabIndex = 12;
            this.lb_TenNhanVien.Text = "label11";
            // 
            // btn_Personal
            // 
            this.btn_Personal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Personal.FillColor = System.Drawing.Color.Transparent;
            this.btn_Personal.Image = global::QuanLyNhaHang.Properties.Resources.cooking;
            this.btn_Personal.ImageRotate = 0F;
            this.btn_Personal.Location = new System.Drawing.Point(129, 12);
            this.btn_Personal.Name = "btn_Personal";
            this.btn_Personal.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Personal.Size = new System.Drawing.Size(73, 64);
            this.btn_Personal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Personal.TabIndex = 11;
            this.btn_Personal.TabStop = false;
            this.btn_Personal.Click += new System.EventHandler(this.btn_Personal_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Logout);
            this.panel2.Controls.Add(this.btn_Lock);
            this.panel2.Controls.Add(this.btn_PaymentHistory);
            this.panel2.Controls.Add(this.btn_Order);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1467, 69);
            this.panel2.TabIndex = 1;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BorderColor = System.Drawing.Color.Empty;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Logout.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btn_Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Logout.FillColor = System.Drawing.Color.White;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btn_Logout.Location = new System.Drawing.Point(956, 0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(218, 67);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "Đăng Xuất";
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Lock
            // 
            this.btn_Lock.BorderColor = System.Drawing.Color.Empty;
            this.btn_Lock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Lock.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Lock.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btn_Lock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Lock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Lock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Lock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Lock.FillColor = System.Drawing.Color.White;
            this.btn_Lock.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lock.ForeColor = System.Drawing.Color.Black;
            this.btn_Lock.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btn_Lock.Location = new System.Drawing.Point(714, 0);
            this.btn_Lock.Name = "btn_Lock";
            this.btn_Lock.Size = new System.Drawing.Size(218, 67);
            this.btn_Lock.TabIndex = 4;
            this.btn_Lock.Text = "Khóa Màn Hình";
            this.btn_Lock.Click += new System.EventHandler(this.btn_Lock_Click);
            // 
            // btn_PaymentHistory
            // 
            this.btn_PaymentHistory.BorderColor = System.Drawing.Color.Empty;
            this.btn_PaymentHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PaymentHistory.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_PaymentHistory.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btn_PaymentHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_PaymentHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_PaymentHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_PaymentHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_PaymentHistory.FillColor = System.Drawing.Color.White;
            this.btn_PaymentHistory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PaymentHistory.ForeColor = System.Drawing.Color.Black;
            this.btn_PaymentHistory.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btn_PaymentHistory.Location = new System.Drawing.Point(476, 0);
            this.btn_PaymentHistory.Name = "btn_PaymentHistory";
            this.btn_PaymentHistory.Size = new System.Drawing.Size(218, 67);
            this.btn_PaymentHistory.TabIndex = 2;
            this.btn_PaymentHistory.Text = "Lịch Sử Đặt Hàng";
            this.btn_PaymentHistory.Click += new System.EventHandler(this.btn_PaymentHistory_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.BorderColor = System.Drawing.Color.Empty;
            this.btn_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Order.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Order.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btn_Order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Order.FillColor = System.Drawing.Color.White;
            this.btn_Order.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.ForeColor = System.Drawing.Color.Black;
            this.btn_Order.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btn_Order.Location = new System.Drawing.Point(236, 0);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(218, 67);
            this.btn_Order.TabIndex = 1;
            this.btn_Order.Text = "Đặt Bàn - Gọi Món";
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // panel_Container
            // 
            this.panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Container.Location = new System.Drawing.Point(0, 161);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(1467, 730);
            this.panel_Container.TabIndex = 2;
            // 
            // time_DateTime
            // 
            this.time_DateTime.Tick += new System.EventHandler(this.time_DateTime_Tick);
            // 
            // fCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1467, 891);
            this.Controls.Add(this.panel_Container);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCashier";
            this.Load += new System.EventHandler(this.fCashier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Personal)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_ChucVu;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_TenNhanVien;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn_Personal;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_Logout;
        private Guna.UI2.WinForms.Guna2Button btn_Lock;
        private Guna.UI2.WinForms.Guna2Button btn_PaymentHistory;
        private Guna.UI2.WinForms.Guna2Button btn_Order;
        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.Timer time_DateTime;
    }
}