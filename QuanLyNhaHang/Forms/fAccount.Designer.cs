namespace QuanLyNhaHang.GUI
{
    partial class fAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAccount));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_MaChucVu = new System.Windows.Forms.RadioButton();
            this.rb_MaNhanVien = new System.Windows.Forms.RadioButton();
            this.rb_TenDangNhap = new System.Windows.Forms.RadioButton();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btb_XoaBot = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ChinhSua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThemMoi = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_MaNhanVien = new System.Windows.Forms.ComboBox();
            this.cmb_MaChucVu = new System.Windows.Forms.ComboBox();
            this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ChapNhan = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new QuanLyNhaHang.GradientPanel();
            this.btn_Hide = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_TaiKhoan);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1467, 736);
            this.panel2.TabIndex = 2;
            // 
            // dgv_TaiKhoan
            // 
            this.dgv_TaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDangNhap,
            this.MatKhau,
            this.MaNhanVien,
            this.MaChucVu});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TaiKhoan.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_TaiKhoan.Location = new System.Drawing.Point(33, 310);
            this.dgv_TaiKhoan.Name = "dgv_TaiKhoan";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_TaiKhoan.RowHeadersWidth = 62;
            this.dgv_TaiKhoan.RowTemplate.Height = 24;
            this.dgv_TaiKhoan.Size = new System.Drawing.Size(1403, 389);
            this.dgv_TaiKhoan.TabIndex = 2;
            this.dgv_TaiKhoan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TaiKhoan_RowEnter);
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.HeaderText = "Mã chức vụ";
            this.MaChucVu.MinimumWidth = 6;
            this.MaChucVu.Name = "MaChucVu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_MaChucVu);
            this.groupBox2.Controls.Add(this.rb_MaNhanVien);
            this.groupBox2.Controls.Add(this.rb_TenDangNhap);
            this.groupBox2.Controls.Add(this.txt_TimKiem);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btb_XoaBot);
            this.groupBox2.Controls.Add(this.btn_ChinhSua);
            this.groupBox2.Controls.Add(this.btn_ThemMoi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(787, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 245);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // rb_MaChucVu
            // 
            this.rb_MaChucVu.AutoSize = true;
            this.rb_MaChucVu.Location = new System.Drawing.Point(424, 185);
            this.rb_MaChucVu.Name = "rb_MaChucVu";
            this.rb_MaChucVu.Size = new System.Drawing.Size(116, 24);
            this.rb_MaChucVu.TabIndex = 17;
            this.rb_MaChucVu.TabStop = true;
            this.rb_MaChucVu.Text = "Mã chức vụ";
            this.rb_MaChucVu.UseVisualStyleBackColor = true;
            // 
            // rb_MaNhanVien
            // 
            this.rb_MaNhanVien.AutoSize = true;
            this.rb_MaNhanVien.Location = new System.Drawing.Point(256, 185);
            this.rb_MaNhanVien.Name = "rb_MaNhanVien";
            this.rb_MaNhanVien.Size = new System.Drawing.Size(129, 24);
            this.rb_MaNhanVien.TabIndex = 16;
            this.rb_MaNhanVien.TabStop = true;
            this.rb_MaNhanVien.Text = "Mã nhân viên";
            this.rb_MaNhanVien.UseVisualStyleBackColor = true;
            // 
            // rb_TenDangNhap
            // 
            this.rb_TenDangNhap.AutoSize = true;
            this.rb_TenDangNhap.Location = new System.Drawing.Point(84, 185);
            this.rb_TenDangNhap.Name = "rb_TenDangNhap";
            this.rb_TenDangNhap.Size = new System.Drawing.Size(140, 24);
            this.rb_TenDangNhap.TabIndex = 15;
            this.rb_TenDangNhap.TabStop = true;
            this.rb_TenDangNhap.Text = "Tên đăng nhập";
            this.rb_TenDangNhap.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.cmb_MaNhanVien);
            this.groupBox1.Controls.Add(this.cmb_MaChucVu);
            this.groupBox1.Controls.Add(this.btn_LamMoi);
            this.groupBox1.Controls.Add(this.btn_ChapNhan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_MatKhau);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_TenDangNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // cmb_MaNhanVien
            // 
            this.cmb_MaNhanVien.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_MaNhanVien.FormattingEnabled = true;
            this.cmb_MaNhanVien.Location = new System.Drawing.Point(255, 166);
            this.cmb_MaNhanVien.Name = "cmb_MaNhanVien";
            this.cmb_MaNhanVien.Size = new System.Drawing.Size(142, 28);
            this.cmb_MaNhanVien.TabIndex = 11;
            // 
            // cmb_MaChucVu
            // 
            this.cmb_MaChucVu.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_MaChucVu.FormattingEnabled = true;
            this.cmb_MaChucVu.Location = new System.Drawing.Point(252, 89);
            this.cmb_MaChucVu.Name = "cmb_MaChucVu";
            this.cmb_MaChucVu.Size = new System.Drawing.Size(145, 28);
            this.cmb_MaChucVu.TabIndex = 10;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã chức vụ";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MatKhau.Location = new System.Drawing.Point(41, 166);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(161, 27);
            this.txt_MatKhau.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenDangNhap.Location = new System.Drawing.Point(41, 87);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(161, 27);
            this.txt_TenDangNhap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 90F;
            this.gradientPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.btn_Hide);
            this.gradientPanel1.Controls.Add(this.btn_Close);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1467, 87);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Empty;
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackColor = System.Drawing.Color.Transparent;
            this.btn_Hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Hide.BackgroundImage")));
            this.btn_Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hide.Location = new System.Drawing.Point(1372, 12);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(36, 29);
            this.btn_Hide.TabIndex = 2;
            this.btn_Hide.TabStop = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Location = new System.Drawing.Point(1414, 13);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 29);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(603, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // fAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1467, 823);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAccount";
            this.Load += new System.EventHandler(this.fAccount_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox btn_Hide;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_TaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_ChapNhan;
        private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
        private Guna.UI2.WinForms.Guna2Button btb_XoaBot;
        private Guna.UI2.WinForms.Guna2Button btn_ChinhSua;
        private Guna.UI2.WinForms.Guna2Button btn_ThemMoi;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_MaChucVu;
        private System.Windows.Forms.RadioButton rb_MaNhanVien;
        private System.Windows.Forms.RadioButton rb_TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.ComboBox cmb_MaNhanVien;
        private System.Windows.Forms.ComboBox cmb_MaChucVu;
    }
}