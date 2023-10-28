namespace QuanLyNhaHang.GUI
{
    partial class fEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEmployee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_XuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.rb_MaChucVu = new System.Windows.Forms.RadioButton();
            this.btn_ThemMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ChinhSua = new Guna.UI2.WinForms.Guna2Button();
            this.rb_TenNhanVien = new System.Windows.Forms.RadioButton();
            this.btb_XoaBot = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_MaChucVu = new System.Windows.Forms.ComboBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_Nu = new System.Windows.Forms.RadioButton();
            this.rb_Nam = new System.Windows.Forms.RadioButton();
            this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ChapNhan = new Guna.UI2.WinForms.Guna2Button();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TenNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new QuanLyNhaHang.GradientPanel();
            this.btn_Hide = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_NhanVien);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 718);
            this.panel1.TabIndex = 1;
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi,
            this.SDT,
            this.TenChucVu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_NhanVien.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_NhanVien.Location = new System.Drawing.Point(32, 308);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.Size = new System.Drawing.Size(1405, 387);
            this.dgv_NhanVien.TabIndex = 2;
            this.dgv_NhanVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_RowEnter);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // TenChucVu
            // 
            this.TenChucVu.DataPropertyName = "TenChucVu";
            this.TenChucVu.HeaderText = "Chức vụ";
            this.TenChucVu.MinimumWidth = 6;
            this.TenChucVu.Name = "TenChucVu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_XuatExcel);
            this.groupBox2.Controls.Add(this.rb_MaChucVu);
            this.groupBox2.Controls.Add(this.btn_ThemMoi);
            this.groupBox2.Controls.Add(this.btn_ChinhSua);
            this.groupBox2.Controls.Add(this.rb_TenNhanVien);
            this.groupBox2.Controls.Add(this.btb_XoaBot);
            this.groupBox2.Controls.Add(this.txt_TimKiem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(791, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.BorderRadius = 10;
            this.btn_XuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XuatExcel.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_XuatExcel.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_XuatExcel.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_XuatExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XuatExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XuatExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XuatExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XuatExcel.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btn_XuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatExcel.ForeColor = System.Drawing.Color.White;
            this.btn_XuatExcel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_XuatExcel.Location = new System.Drawing.Point(443, 172);
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(172, 51);
            this.btn_XuatExcel.TabIndex = 35;
            this.btn_XuatExcel.Text = "Xuất Excel";
            this.btn_XuatExcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_XuatExcel.Click += new System.EventHandler(this.btn_XuatExcel_Click);
            // 
            // rb_MaChucVu
            // 
            this.rb_MaChucVu.AutoSize = true;
            this.rb_MaChucVu.Location = new System.Drawing.Point(267, 190);
            this.rb_MaChucVu.Name = "rb_MaChucVu";
            this.rb_MaChucVu.Size = new System.Drawing.Size(91, 24);
            this.rb_MaChucVu.TabIndex = 42;
            this.rb_MaChucVu.TabStop = true;
            this.rb_MaChucVu.Text = "Chức vụ";
            this.rb_MaChucVu.UseVisualStyleBackColor = true;
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.BorderRadius = 10;
            this.btn_ThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemMoi.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
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
            this.btn_ThemMoi.Location = new System.Drawing.Point(27, 35);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(172, 51);
            this.btn_ThemMoi.TabIndex = 35;
            this.btn_ThemMoi.Text = "Thêm mới";
            this.btn_ThemMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // btn_ChinhSua
            // 
            this.btn_ChinhSua.BorderRadius = 10;
            this.btn_ChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChinhSua.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
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
            this.btn_ChinhSua.Location = new System.Drawing.Point(237, 35);
            this.btn_ChinhSua.Name = "btn_ChinhSua";
            this.btn_ChinhSua.Size = new System.Drawing.Size(172, 51);
            this.btn_ChinhSua.TabIndex = 36;
            this.btn_ChinhSua.Text = "Chỉnh sửa";
            this.btn_ChinhSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_ChinhSua.Click += new System.EventHandler(this.btn_ChinhSua_Click);
            // 
            // rb_TenNhanVien
            // 
            this.rb_TenNhanVien.AutoSize = true;
            this.rb_TenNhanVien.Location = new System.Drawing.Point(83, 190);
            this.rb_TenNhanVien.Name = "rb_TenNhanVien";
            this.rb_TenNhanVien.Size = new System.Drawing.Size(134, 24);
            this.rb_TenNhanVien.TabIndex = 40;
            this.rb_TenNhanVien.TabStop = true;
            this.rb_TenNhanVien.Text = "Tên nhân viên";
            this.rb_TenNhanVien.UseVisualStyleBackColor = true;
            // 
            // btb_XoaBot
            // 
            this.btb_XoaBot.BorderRadius = 10;
            this.btb_XoaBot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btb_XoaBot.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
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
            this.btb_XoaBot.Location = new System.Drawing.Point(443, 35);
            this.btb_XoaBot.Name = "btb_XoaBot";
            this.btb_XoaBot.Size = new System.Drawing.Size(172, 51);
            this.btb_XoaBot.TabIndex = 37;
            this.btb_XoaBot.Text = "Xóa bớt";
            this.btb_XoaBot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btb_XoaBot.Click += new System.EventHandler(this.btb_XoaBot_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiem.Location = new System.Drawing.Point(128, 125);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(487, 26);
            this.txt_TimKiem.TabIndex = 39;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tìm kiếm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_MaChucVu);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dt_NgaySinh);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btn_LamMoi);
            this.groupBox1.Controls.Add(this.btn_ChapNhan);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_TenNhanVien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_MaNhanVien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // cmb_MaChucVu
            // 
            this.cmb_MaChucVu.FormattingEnabled = true;
            this.cmb_MaChucVu.Location = new System.Drawing.Point(220, 59);
            this.cmb_MaChucVu.Name = "cmb_MaChucVu";
            this.cmb_MaChucVu.Size = new System.Drawing.Size(168, 28);
            this.cmb_MaChucVu.TabIndex = 34;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Location = new System.Drawing.Point(351, 196);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(133, 26);
            this.txt_SDT.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày sinh";
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NgaySinh.Location = new System.Drawing.Point(328, 127);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(140, 26);
            this.dt_NgaySinh.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_Nu);
            this.groupBox3.Controls.Add(this.rb_Nam);
            this.groupBox3.Location = new System.Drawing.Point(439, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 61);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giới tính";
            // 
            // rb_Nu
            // 
            this.rb_Nu.AutoSize = true;
            this.rb_Nu.Location = new System.Drawing.Point(109, 26);
            this.rb_Nu.Name = "rb_Nu";
            this.rb_Nu.Size = new System.Drawing.Size(51, 24);
            this.rb_Nu.TabIndex = 1;
            this.rb_Nu.TabStop = true;
            this.rb_Nu.Text = "Nữ";
            this.rb_Nu.UseVisualStyleBackColor = true;
            // 
            // rb_Nam
            // 
            this.rb_Nam.AutoSize = true;
            this.rb_Nam.Location = new System.Drawing.Point(16, 26);
            this.rb_Nam.Name = "rb_Nam";
            this.rb_Nam.Size = new System.Drawing.Size(65, 24);
            this.rb_Nam.TabIndex = 0;
            this.rb_Nam.TabStop = true;
            this.rb_Nam.Text = "Nam";
            this.rb_Nam.UseVisualStyleBackColor = true;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BorderRadius = 10;
            this.btn_LamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LamMoi.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
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
            this.btn_LamMoi.Location = new System.Drawing.Point(525, 183);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(172, 51);
            this.btn_LamMoi.TabIndex = 31;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_ChapNhan
            // 
            this.btn_ChapNhan.BorderRadius = 10;
            this.btn_ChapNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChapNhan.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
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
            this.btn_ChapNhan.Location = new System.Drawing.Point(525, 113);
            this.btn_ChapNhan.Name = "btn_ChapNhan";
            this.btn_ChapNhan.Size = new System.Drawing.Size(172, 51);
            this.btn_ChapNhan.TabIndex = 30;
            this.btn_ChapNhan.Text = "Chấp nhận";
            this.btn_ChapNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_ChapNhan.Click += new System.EventHandler(this.btn_ChapNhan_Click);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiaChi.Location = new System.Drawing.Point(34, 195);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(277, 26);
            this.txt_DiaChi.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Chức vụ";
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenNhanVien.Location = new System.Drawing.Point(34, 127);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Size = new System.Drawing.Size(226, 26);
            this.txt_TenNhanVien.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên nhân viên";
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaNhanVien.Location = new System.Drawing.Point(34, 60);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(134, 26);
            this.txt_MaNhanVien.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(580, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 90F;
            this.gradientPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.btn_Hide);
            this.gradientPanel1.Controls.Add(this.btn_Close);
            this.gradientPanel1.Controls.Add(this.label9);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1467, 105);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Empty;
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackColor = System.Drawing.Color.Transparent;
            this.btn_Hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Hide.BackgroundImage")));
            this.btn_Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hide.Location = new System.Drawing.Point(1377, 11);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(36, 29);
            this.btn_Hide.TabIndex = 5;
            this.btn_Hide.TabStop = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Location = new System.Drawing.Point(1419, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 29);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(614, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 35);
            this.label9.TabIndex = 3;
            this.label9.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // fEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1467, 823);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEmployee";
            this.Load += new System.EventHandler(this.fEmployee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
        private Guna.UI2.WinForms.Guna2Button btn_ChapNhan;
        private System.Windows.Forms.DateTimePicker dt_NgaySinh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_Nu;
        private System.Windows.Forms.RadioButton rb_Nam;
        private System.Windows.Forms.ComboBox cmb_MaChucVu;
        private System.Windows.Forms.RadioButton rb_MaChucVu;
        private Guna.UI2.WinForms.Guna2Button btn_ThemMoi;
        private Guna.UI2.WinForms.Guna2Button btn_ChinhSua;
        private System.Windows.Forms.RadioButton rb_TenNhanVien;
        private Guna.UI2.WinForms.Guna2Button btb_XoaBot;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btn_XuatExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucVu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.PictureBox btn_Hide;
        private GradientPanel gradientPanel1;
    }
}