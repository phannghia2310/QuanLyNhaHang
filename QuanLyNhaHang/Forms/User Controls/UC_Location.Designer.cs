namespace QuanLyNhaHang.Forms.User_Controls
{
    partial class UC_Location
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Location));
            this.dgv_KhuVuc = new System.Windows.Forms.DataGridView();
            this.MaKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_TenKhuVuc = new System.Windows.Forms.RadioButton();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btb_XoaBot = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ChinhSua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThemMoi = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ChapNhan = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TenKhuVuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaKhuVuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhuVuc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_KhuVuc
            // 
            this.dgv_KhuVuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhuVuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_KhuVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhuVuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhuVuc,
            this.TenKhuVuc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KhuVuc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_KhuVuc.Location = new System.Drawing.Point(32, 302);
            this.dgv_KhuVuc.Name = "dgv_KhuVuc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhuVuc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_KhuVuc.RowHeadersWidth = 62;
            this.dgv_KhuVuc.RowTemplate.Height = 24;
            this.dgv_KhuVuc.Size = new System.Drawing.Size(1403, 323);
            this.dgv_KhuVuc.TabIndex = 8;
            this.dgv_KhuVuc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhuVuc_RowEnter);
            // 
            // MaKhuVuc
            // 
            this.MaKhuVuc.DataPropertyName = "MaKhuVuc";
            this.MaKhuVuc.HeaderText = "Mã khu vực";
            this.MaKhuVuc.MinimumWidth = 6;
            this.MaKhuVuc.Name = "MaKhuVuc";
            // 
            // TenKhuVuc
            // 
            this.TenKhuVuc.DataPropertyName = "TenKhuVuc";
            this.TenKhuVuc.HeaderText = "Tên khu vực";
            this.TenKhuVuc.MinimumWidth = 6;
            this.TenKhuVuc.Name = "TenKhuVuc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_TenKhuVuc);
            this.groupBox2.Controls.Add(this.txt_TimKiem);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btb_XoaBot);
            this.groupBox2.Controls.Add(this.btn_ChinhSua);
            this.groupBox2.Controls.Add(this.btn_ThemMoi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(786, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 245);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // rb_TenKhuVuc
            // 
            this.rb_TenKhuVuc.AutoSize = true;
            this.rb_TenKhuVuc.Location = new System.Drawing.Point(83, 184);
            this.rb_TenKhuVuc.Name = "rb_TenKhuVuc";
            this.rb_TenKhuVuc.Size = new System.Drawing.Size(120, 24);
            this.rb_TenKhuVuc.TabIndex = 15;
            this.rb_TenKhuVuc.TabStop = true;
            this.rb_TenKhuVuc.Text = "Tên khu vực";
            this.rb_TenKhuVuc.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiem.Location = new System.Drawing.Point(132, 119);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(487, 27);
            this.txt_TimKiem.TabIndex = 14;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tìm kiếm:";
            // 
            // btb_XoaBot
            // 
            this.btb_XoaBot.BorderRadius = 10;
            this.btb_XoaBot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btb_XoaBot.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btb_XoaBot.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btb_XoaBot.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btb_XoaBot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btb_XoaBot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btb_XoaBot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btb_XoaBot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btb_XoaBot.FillColor = System.Drawing.Color.Red;
            this.btb_XoaBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_XoaBot.ForeColor = System.Drawing.Color.White;
            this.btb_XoaBot.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btb_XoaBot.Location = new System.Drawing.Point(447, 32);
            this.btb_XoaBot.Name = "btb_XoaBot";
            this.btb_XoaBot.Size = new System.Drawing.Size(172, 51);
            this.btb_XoaBot.TabIndex = 12;
            this.btb_XoaBot.Text = "Xóa bớt";
            this.btb_XoaBot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btb_XoaBot.Click += new System.EventHandler(this.btb_XoaBot_Click);
            // 
            // btn_ChinhSua
            // 
            this.btn_ChinhSua.BorderRadius = 10;
            this.btn_ChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChinhSua.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btn_ChinhSua.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ChinhSua.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_ChinhSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChinhSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChinhSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ChinhSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ChinhSua.FillColor = System.Drawing.Color.Goldenrod;
            this.btn_ChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChinhSua.ForeColor = System.Drawing.Color.White;
            this.btn_ChinhSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ChinhSua.Location = new System.Drawing.Point(241, 32);
            this.btn_ChinhSua.Name = "btn_ChinhSua";
            this.btn_ChinhSua.Size = new System.Drawing.Size(172, 51);
            this.btn_ChinhSua.TabIndex = 11;
            this.btn_ChinhSua.Text = "Chỉnh sửa";
            this.btn_ChinhSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_ChinhSua.Click += new System.EventHandler(this.btn_ChinhSua_Click);
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.BorderRadius = 10;
            this.btn_ThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemMoi.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btn_ThemMoi.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ThemMoi.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_ThemMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThemMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThemMoi.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemMoi.ForeColor = System.Drawing.Color.White;
            this.btn_ThemMoi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ThemMoi.Location = new System.Drawing.Point(31, 32);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(172, 51);
            this.btn_ThemMoi.TabIndex = 10;
            this.btn_ThemMoi.Text = "Thêm mới";
            this.btn_ThemMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_LamMoi);
            this.groupBox1.Controls.Add(this.btn_ChapNhan);
            this.groupBox1.Controls.Add(this.txt_TenKhuVuc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_MaKhuVuc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 245);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khu vực";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BorderRadius = 10;
            this.btn_LamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LamMoi.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btn_LamMoi.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_LamMoi.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_LamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_LamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_LamMoi.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_LamMoi.Location = new System.Drawing.Point(478, 142);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(172, 51);
            this.btn_LamMoi.TabIndex = 9;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_ChapNhan
            // 
            this.btn_ChapNhan.BorderRadius = 10;
            this.btn_ChapNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChapNhan.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btn_ChapNhan.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ChapNhan.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_ChapNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChapNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChapNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ChapNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ChapNhan.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_ChapNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChapNhan.ForeColor = System.Drawing.Color.White;
            this.btn_ChapNhan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ChapNhan.Location = new System.Drawing.Point(478, 63);
            this.btn_ChapNhan.Name = "btn_ChapNhan";
            this.btn_ChapNhan.Size = new System.Drawing.Size(172, 51);
            this.btn_ChapNhan.TabIndex = 8;
            this.btn_ChapNhan.Text = "Chấp nhận";
            this.btn_ChapNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_ChapNhan.Click += new System.EventHandler(this.btn_ChapNhan_Click);
            // 
            // txt_TenKhuVuc
            // 
            this.txt_TenKhuVuc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenKhuVuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenKhuVuc.Location = new System.Drawing.Point(250, 118);
            this.txt_TenKhuVuc.Name = "txt_TenKhuVuc";
            this.txt_TenKhuVuc.Size = new System.Drawing.Size(161, 27);
            this.txt_TenKhuVuc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khu vực";
            // 
            // txt_MaKhuVuc
            // 
            this.txt_MaKhuVuc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MaKhuVuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaKhuVuc.Location = new System.Drawing.Point(42, 118);
            this.txt_MaKhuVuc.Name = "txt_MaKhuVuc";
            this.txt_MaKhuVuc.Size = new System.Drawing.Size(161, 27);
            this.txt_MaKhuVuc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khu vực";
            // 
            // UC_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgv_KhuVuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Location";
            this.Size = new System.Drawing.Size(1467, 645);
            this.Load += new System.EventHandler(this.UC_Location_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhuVuc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_KhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuVuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_TenKhuVuc;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btb_XoaBot;
        private Guna.UI2.WinForms.Guna2Button btn_ChinhSua;
        private Guna.UI2.WinForms.Guna2Button btn_ThemMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
        private Guna.UI2.WinForms.Guna2Button btn_ChapNhan;
        private System.Windows.Forms.TextBox txt_TenKhuVuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaKhuVuc;
        private System.Windows.Forms.Label label2;
    }
}
