namespace QuanLyNhaHang.Forms.User_Controls
{
    partial class UC_Table
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Table));
            this.dgv_Ban = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_TenKhuVuc = new System.Windows.Forms.RadioButton();
            this.rb_TenBan = new System.Windows.Forms.RadioButton();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btb_XoaBot = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ChinhSua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThemMoi = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_MaKhuVuc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ChapNhan = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TenBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_TrangThai = new System.Windows.Forms.ComboBox();
            this.rb_TrangThai = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ban)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Ban
            // 
            this.dgv_Ban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Ban.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Ban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBan,
            this.TenBan,
            this.TrangThai,
            this.TenKhuVuc});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Ban.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Ban.Location = new System.Drawing.Point(32, 302);
            this.dgv_Ban.Name = "dgv_Ban";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Ban.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Ban.RowHeadersWidth = 62;
            this.dgv_Ban.RowTemplate.Height = 24;
            this.dgv_Ban.Size = new System.Drawing.Size(1403, 323);
            this.dgv_Ban.TabIndex = 11;
            this.dgv_Ban.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ban_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_TrangThai);
            this.groupBox2.Controls.Add(this.rb_TenKhuVuc);
            this.groupBox2.Controls.Add(this.rb_TenBan);
            this.groupBox2.Controls.Add(this.txt_TimKiem);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btb_XoaBot);
            this.groupBox2.Controls.Add(this.btn_ChinhSua);
            this.groupBox2.Controls.Add(this.btn_ThemMoi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(786, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 245);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // rb_TenKhuVuc
            // 
            this.rb_TenKhuVuc.AutoSize = true;
            this.rb_TenKhuVuc.Location = new System.Drawing.Point(239, 183);
            this.rb_TenKhuVuc.Name = "rb_TenKhuVuc";
            this.rb_TenKhuVuc.Size = new System.Drawing.Size(120, 24);
            this.rb_TenKhuVuc.TabIndex = 16;
            this.rb_TenKhuVuc.TabStop = true;
            this.rb_TenKhuVuc.Text = "Tên khu vực";
            this.rb_TenKhuVuc.UseVisualStyleBackColor = true;
            // 
            // rb_TenBan
            // 
            this.rb_TenBan.AutoSize = true;
            this.rb_TenBan.Location = new System.Drawing.Point(59, 183);
            this.rb_TenBan.Name = "rb_TenBan";
            this.rb_TenBan.Size = new System.Drawing.Size(90, 24);
            this.rb_TenBan.TabIndex = 15;
            this.rb_TenBan.TabStop = true;
            this.rb_TenBan.Text = "Tên bàn";
            this.rb_TenBan.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiem.Location = new System.Drawing.Point(130, 119);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(487, 27);
            this.txt_TimKiem.TabIndex = 14;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 121);
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
            this.btb_XoaBot.Location = new System.Drawing.Point(445, 32);
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
            this.btn_ChinhSua.Location = new System.Drawing.Point(239, 32);
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
            this.btn_ThemMoi.Location = new System.Drawing.Point(29, 32);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(172, 51);
            this.btn_ThemMoi.TabIndex = 10;
            this.btn_ThemMoi.Text = "Thêm mới";
            this.btn_ThemMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_TrangThai);
            this.groupBox1.Controls.Add(this.cmb_MaKhuVuc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_LamMoi);
            this.groupBox1.Controls.Add(this.btn_ChapNhan);
            this.groupBox1.Controls.Add(this.txt_TenBan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_MaBan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 245);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bàn";
            // 
            // cmb_MaKhuVuc
            // 
            this.cmb_MaKhuVuc.FormattingEnabled = true;
            this.cmb_MaKhuVuc.Location = new System.Drawing.Point(252, 152);
            this.cmb_MaKhuVuc.Name = "cmb_MaKhuVuc";
            this.cmb_MaKhuVuc.Size = new System.Drawing.Size(161, 28);
            this.cmb_MaKhuVuc.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Khu vực";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Trạng thái";
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
            // txt_TenBan
            // 
            this.txt_TenBan.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenBan.Location = new System.Drawing.Point(30, 152);
            this.txt_TenBan.Name = "txt_TenBan";
            this.txt_TenBan.Size = new System.Drawing.Size(161, 27);
            this.txt_TenBan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên bàn";
            // 
            // txt_MaBan
            // 
            this.txt_MaBan.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MaBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaBan.Location = new System.Drawing.Point(30, 87);
            this.txt_MaBan.Name = "txt_MaBan";
            this.txt_MaBan.Size = new System.Drawing.Size(161, 27);
            this.txt_MaBan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã bàn";
            // 
            // MaBan
            // 
            this.MaBan.DataPropertyName = "MaBan";
            this.MaBan.HeaderText = "Mã bàn";
            this.MaBan.MinimumWidth = 6;
            this.MaBan.Name = "MaBan";
            // 
            // TenBan
            // 
            this.TenBan.DataPropertyName = "TenBan";
            this.TenBan.HeaderText = "Tên bàn";
            this.TenBan.MinimumWidth = 6;
            this.TenBan.Name = "TenBan";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // TenKhuVuc
            // 
            this.TenKhuVuc.DataPropertyName = "TenKhuVuc";
            this.TenKhuVuc.HeaderText = "Tên khu vực";
            this.TenKhuVuc.MinimumWidth = 6;
            this.TenKhuVuc.Name = "TenKhuVuc";
            // 
            // cmb_TrangThai
            // 
            this.cmb_TrangThai.FormattingEnabled = true;
            this.cmb_TrangThai.Items.AddRange(new object[] {
            "TRỐNG",
            "CÓ NGƯỜI",
            "ĐẶT TRƯỚC"});
            this.cmb_TrangThai.Location = new System.Drawing.Point(252, 87);
            this.cmb_TrangThai.Name = "cmb_TrangThai";
            this.cmb_TrangThai.Size = new System.Drawing.Size(161, 28);
            this.cmb_TrangThai.TabIndex = 17;
            // 
            // rb_TrangThai
            // 
            this.rb_TrangThai.AutoSize = true;
            this.rb_TrangThai.Location = new System.Drawing.Point(458, 183);
            this.rb_TrangThai.Name = "rb_TrangThai";
            this.rb_TrangThai.Size = new System.Drawing.Size(105, 24);
            this.rb_TrangThai.TabIndex = 17;
            this.rb_TrangThai.TabStop = true;
            this.rb_TrangThai.Text = "Trạng thái";
            this.rb_TrangThai.UseVisualStyleBackColor = true;
            // 
            // UC_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgv_Ban);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Table";
            this.Size = new System.Drawing.Size(1467, 645);
            this.Load += new System.EventHandler(this.UC_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ban)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Ban;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_TenKhuVuc;
        private System.Windows.Forms.RadioButton rb_TenBan;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btb_XoaBot;
        private Guna.UI2.WinForms.Guna2Button btn_ChinhSua;
        private Guna.UI2.WinForms.Guna2Button btn_ThemMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_MaKhuVuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
        private Guna.UI2.WinForms.Guna2Button btn_ChapNhan;
        private System.Windows.Forms.TextBox txt_TenBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuVuc;
        private System.Windows.Forms.ComboBox cmb_TrangThai;
        private System.Windows.Forms.RadioButton rb_TrangThai;
    }
}
