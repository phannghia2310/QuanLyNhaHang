namespace QuanLyNhaHang.GUI
{
    partial class fLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLocation));
            this.gradientPanel1 = new QuanLyNhaHang.GradientPanel();
            this.btn_Hide = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Table = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Location = new Guna.UI2.WinForms.Guna2Button();
            this.panel_Container = new System.Windows.Forms.Panel();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 90F;
            this.gradientPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.btn_Hide);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.btn_Close);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1467, 100);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Empty;
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackColor = System.Drawing.Color.Transparent;
            this.btn_Hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Hide.BackgroundImage")));
            this.btn_Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hide.Location = new System.Drawing.Point(1368, 19);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(36, 29);
            this.btn_Hide.TabIndex = 5;
            this.btn_Hide.TabStop = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(599, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ KHU VỰC";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Location = new System.Drawing.Point(1410, 20);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 29);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Table);
            this.panel1.Controls.Add(this.btn_Location);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 78);
            this.panel1.TabIndex = 2;
            // 
            // btn_Table
            // 
            this.btn_Table.BorderColor = System.Drawing.Color.Empty;
            this.btn_Table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Table.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Table.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btn_Table.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Table.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Table.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Table.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Table.FillColor = System.Drawing.Color.White;
            this.btn_Table.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table.ForeColor = System.Drawing.Color.Black;
            this.btn_Table.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btn_Table.Location = new System.Drawing.Point(251, 6);
            this.btn_Table.Name = "btn_Table";
            this.btn_Table.Size = new System.Drawing.Size(218, 67);
            this.btn_Table.TabIndex = 1;
            this.btn_Table.Text = "Quản Lý Bàn Ăn";
            this.btn_Table.Click += new System.EventHandler(this.btn_Table_Click);
            // 
            // btn_Location
            // 
            this.btn_Location.BorderColor = System.Drawing.Color.Empty;
            this.btn_Location.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Location.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Location.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btn_Location.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Location.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Location.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Location.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Location.FillColor = System.Drawing.Color.White;
            this.btn_Location.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Location.ForeColor = System.Drawing.Color.Black;
            this.btn_Location.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btn_Location.Location = new System.Drawing.Point(3, 6);
            this.btn_Location.Name = "btn_Location";
            this.btn_Location.Size = new System.Drawing.Size(218, 67);
            this.btn_Location.TabIndex = 0;
            this.btn_Location.Text = "Quản Lý Khu Vực Bàn Ăn";
            this.btn_Location.Click += new System.EventHandler(this.btn_Location_Click);
            // 
            // panel_Container
            // 
            this.panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Container.Location = new System.Drawing.Point(0, 178);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(1467, 645);
            this.panel_Container.TabIndex = 3;
            // 
            // fLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1467, 823);
            this.Controls.Add(this.panel_Container);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLocation";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox btn_Hide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_Table;
        private Guna.UI2.WinForms.Guna2Button btn_Location;
        private System.Windows.Forms.Panel panel_Container;
    }
}