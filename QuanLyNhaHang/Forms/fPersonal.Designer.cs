namespace QuanLyNhaHang.Forms
{
    partial class fPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPersonal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Information = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ChangePass = new Guna.UI2.WinForms.Guna2Button();
            this.panel_Container = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new QuanLyNhaHang.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ChangePass);
            this.panel1.Controls.Add(this.btn_Information);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 71);
            this.panel1.TabIndex = 1;
            // 
            // btn_Information
            // 
            this.btn_Information.BorderColor = System.Drawing.Color.Empty;
            this.btn_Information.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Information.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Information.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btn_Information.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Information.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Information.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Information.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Information.FillColor = System.Drawing.Color.White;
            this.btn_Information.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Information.ForeColor = System.Drawing.Color.Black;
            this.btn_Information.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btn_Information.Location = new System.Drawing.Point(55, 1);
            this.btn_Information.Name = "btn_Information";
            this.btn_Information.Size = new System.Drawing.Size(218, 67);
            this.btn_Information.TabIndex = 1;
            this.btn_Information.Text = "Thông Tin Cá Nhân";
            this.btn_Information.Click += new System.EventHandler(this.btn_Information_Click);
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.BorderColor = System.Drawing.Color.Empty;
            this.btn_ChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangePass.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ChangePass.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btn_ChangePass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChangePass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChangePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ChangePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ChangePass.FillColor = System.Drawing.Color.White;
            this.btn_ChangePass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePass.ForeColor = System.Drawing.Color.Black;
            this.btn_ChangePass.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btn_ChangePass.Location = new System.Drawing.Point(294, 1);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(218, 67);
            this.btn_ChangePass.TabIndex = 2;
            this.btn_ChangePass.Text = "Đổi Mật Khẩu";
            this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
            // 
            // panel_Container
            // 
            this.panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Container.Location = new System.Drawing.Point(0, 171);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(572, 537);
            this.panel_Container.TabIndex = 2;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 90F;
            this.gradientPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.btn_Close);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(572, 100);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Empty;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(138, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Location = new System.Drawing.Point(524, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 29);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // fPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(572, 708);
            this.Controls.Add(this.panel_Container);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPersonal";
            this.panel1.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_ChangePass;
        private Guna.UI2.WinForms.Guna2Button btn_Information;
        private System.Windows.Forms.Panel panel_Container;
    }
}