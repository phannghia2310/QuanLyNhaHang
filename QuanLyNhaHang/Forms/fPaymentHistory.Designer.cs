namespace QuanLyNhaHang.GUI
{
    partial class fPaymentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPaymentHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gradientPanel1 = new QuanLyNhaHang.GradientPanel();
            this.btn_Hide = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_MaNhanVien = new System.Windows.Forms.ComboBox();
            this.dt_NgayBan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_XemCTHD = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaHoaDon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dt_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dt_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.btn_TheoKhoang = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_ChonThang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dt_ChonNam = new System.Windows.Forms.DateTimePicker();
            this.btn_TheoThang = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dt_ChonNgay = new System.Windows.Forms.DateTimePicker();
            this.btn_TheoNgay = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
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
            this.gradientPanel1.Size = new System.Drawing.Size(1449, 100);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Empty;
            // 
            // btn_Hide
            // 
            this.btn_Hide.BackColor = System.Drawing.Color.Transparent;
            this.btn_Hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Hide.BackgroundImage")));
            this.btn_Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hide.Location = new System.Drawing.Point(1354, 14);
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
            this.label1.Location = new System.Drawing.Point(586, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "LỊCH SỬ ĐẶT HÀNG";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Location = new System.Drawing.Point(1396, 15);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 29);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_MaNhanVien);
            this.groupBox1.Controls.Add(this.dt_NgayBan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_LamMoi);
            this.groupBox1.Controls.Add(this.btn_XemCTHD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_TrangThai);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_TongTien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_MaHoaDon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 282);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // cmb_MaNhanVien
            // 
            this.cmb_MaNhanVien.FormattingEnabled = true;
            this.cmb_MaNhanVien.Location = new System.Drawing.Point(29, 230);
            this.cmb_MaNhanVien.Name = "cmb_MaNhanVien";
            this.cmb_MaNhanVien.Size = new System.Drawing.Size(217, 28);
            this.cmb_MaNhanVien.TabIndex = 36;
            // 
            // dt_NgayBan
            // 
            this.dt_NgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NgayBan.Location = new System.Drawing.Point(222, 62);
            this.dt_NgayBan.Name = "dt_NgayBan";
            this.dt_NgayBan.Size = new System.Drawing.Size(134, 26);
            this.dt_NgayBan.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "(VNĐ)";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BorderRadius = 10;
            this.btn_LamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LamMoi.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
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
            this.btn_LamMoi.Location = new System.Drawing.Point(399, 163);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(172, 51);
            this.btn_LamMoi.TabIndex = 33;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_XemCTHD
            // 
            this.btn_XemCTHD.BorderRadius = 10;
            this.btn_XemCTHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XemCTHD.CustomImages.Image = global::QuanLyNhaHang.Properties.Resources.detail;
            this.btn_XemCTHD.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_XemCTHD.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_XemCTHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XemCTHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XemCTHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XemCTHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XemCTHD.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_XemCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemCTHD.ForeColor = System.Drawing.Color.White;
            this.btn_XemCTHD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_XemCTHD.Location = new System.Drawing.Point(399, 93);
            this.btn_XemCTHD.Name = "btn_XemCTHD";
            this.btn_XemCTHD.Size = new System.Drawing.Size(172, 51);
            this.btn_XemCTHD.TabIndex = 32;
            this.btn_XemCTHD.Text = "Xem CTHD";
            this.btn_XemCTHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_XemCTHD.Click += new System.EventHandler(this.btn_XemCTHD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nhân viên";
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TrangThai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TrangThai.Location = new System.Drawing.Point(222, 148);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.Size = new System.Drawing.Size(134, 26);
            this.txt_TrangThai.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Trạng thái";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TongTien.Location = new System.Drawing.Point(29, 148);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(104, 26);
            this.txt_TongTien.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ngày bán";
            // 
            // txt_MaHoaDon
            // 
            this.txt_MaHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaHoaDon.Location = new System.Drawing.Point(29, 62);
            this.txt_MaHoaDon.Name = "txt_MaHoaDon";
            this.txt_MaHoaDon.Size = new System.Drawing.Size(134, 26);
            this.txt_MaHoaDon.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(629, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 282);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dt_DenNgay);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.dt_TuNgay);
            this.panel3.Controls.Add(this.btn_TheoKhoang);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(541, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 206);
            this.panel3.TabIndex = 4;
            // 
            // dt_DenNgay
            // 
            this.dt_DenNgay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_DenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DenNgay.Location = new System.Drawing.Point(56, 103);
            this.dt_DenNgay.Name = "dt_DenNgay";
            this.dt_DenNgay.Size = new System.Drawing.Size(150, 30);
            this.dt_DenNgay.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(24, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Đến ngày:";
            // 
            // dt_TuNgay
            // 
            this.dt_TuNgay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_TuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_TuNgay.Location = new System.Drawing.Point(56, 40);
            this.dt_TuNgay.Name = "dt_TuNgay";
            this.dt_TuNgay.Size = new System.Drawing.Size(150, 30);
            this.dt_TuNgay.TabIndex = 2;
            // 
            // btn_TheoKhoang
            // 
            this.btn_TheoKhoang.BorderColor = System.Drawing.Color.White;
            this.btn_TheoKhoang.BorderRadius = 5;
            this.btn_TheoKhoang.BorderThickness = 3;
            this.btn_TheoKhoang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TheoKhoang.CustomImages.Image = global::QuanLyNhaHang.Properties.Resources.schedule;
            this.btn_TheoKhoang.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_TheoKhoang.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_TheoKhoang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TheoKhoang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TheoKhoang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TheoKhoang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TheoKhoang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_TheoKhoang.FillColor = System.Drawing.Color.IndianRed;
            this.btn_TheoKhoang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_TheoKhoang.ForeColor = System.Drawing.Color.White;
            this.btn_TheoKhoang.Location = new System.Drawing.Point(0, 141);
            this.btn_TheoKhoang.Name = "btn_TheoKhoang";
            this.btn_TheoKhoang.Size = new System.Drawing.Size(238, 63);
            this.btn_TheoKhoang.TabIndex = 1;
            this.btn_TheoKhoang.Text = "TK theo khoảng";
            this.btn_TheoKhoang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_TheoKhoang.Click += new System.EventHandler(this.btn_TheoKhoang_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(24, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Từ ngày:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmb_ChonThang);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dt_ChonNam);
            this.panel2.Controls.Add(this.btn_TheoThang);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(281, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 207);
            this.panel2.TabIndex = 3;
            // 
            // cmb_ChonThang
            // 
            this.cmb_ChonThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ChonThang.FormattingEnabled = true;
            this.cmb_ChonThang.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmb_ChonThang.Location = new System.Drawing.Point(99, 40);
            this.cmb_ChonThang.Name = "cmb_ChonThang";
            this.cmb_ChonThang.Size = new System.Drawing.Size(91, 33);
            this.cmb_ChonThang.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(26, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Chọn tháng:";
            // 
            // dt_ChonNam
            // 
            this.dt_ChonNam.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ChonNam.CustomFormat = "yyyy";
            this.dt_ChonNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ChonNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ChonNam.Location = new System.Drawing.Point(99, 103);
            this.dt_ChonNam.Name = "dt_ChonNam";
            this.dt_ChonNam.Size = new System.Drawing.Size(91, 30);
            this.dt_ChonNam.TabIndex = 2;
            // 
            // btn_TheoThang
            // 
            this.btn_TheoThang.BorderColor = System.Drawing.Color.White;
            this.btn_TheoThang.BorderRadius = 5;
            this.btn_TheoThang.BorderThickness = 3;
            this.btn_TheoThang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TheoThang.CustomImages.Image = global::QuanLyNhaHang.Properties.Resources.month;
            this.btn_TheoThang.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_TheoThang.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_TheoThang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TheoThang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TheoThang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TheoThang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TheoThang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_TheoThang.FillColor = System.Drawing.Color.IndianRed;
            this.btn_TheoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_TheoThang.ForeColor = System.Drawing.Color.White;
            this.btn_TheoThang.Location = new System.Drawing.Point(0, 142);
            this.btn_TheoThang.Name = "btn_TheoThang";
            this.btn_TheoThang.Size = new System.Drawing.Size(238, 63);
            this.btn_TheoThang.TabIndex = 1;
            this.btn_TheoThang.Text = "TK theo tháng";
            this.btn_TheoThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_TheoThang.Click += new System.EventHandler(this.btn_TheoThang_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Chọn năm:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dt_ChonNgay);
            this.panel1.Controls.Add(this.btn_TheoNgay);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(22, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 208);
            this.panel1.TabIndex = 0;
            // 
            // dt_ChonNgay
            // 
            this.dt_ChonNgay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ChonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ChonNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ChonNgay.Location = new System.Drawing.Point(52, 70);
            this.dt_ChonNgay.Name = "dt_ChonNgay";
            this.dt_ChonNgay.Size = new System.Drawing.Size(150, 30);
            this.dt_ChonNgay.TabIndex = 2;
            // 
            // btn_TheoNgay
            // 
            this.btn_TheoNgay.BorderColor = System.Drawing.Color.White;
            this.btn_TheoNgay.BorderRadius = 5;
            this.btn_TheoNgay.BorderThickness = 3;
            this.btn_TheoNgay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TheoNgay.CustomImages.Image = global::QuanLyNhaHang.Properties.Resources.day;
            this.btn_TheoNgay.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_TheoNgay.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_TheoNgay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TheoNgay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TheoNgay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TheoNgay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TheoNgay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_TheoNgay.FillColor = System.Drawing.Color.IndianRed;
            this.btn_TheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_TheoNgay.ForeColor = System.Drawing.Color.White;
            this.btn_TheoNgay.Location = new System.Drawing.Point(0, 143);
            this.btn_TheoNgay.Name = "btn_TheoNgay";
            this.btn_TheoNgay.Size = new System.Drawing.Size(238, 63);
            this.btn_TheoNgay.TabIndex = 1;
            this.btn_TheoNgay.Text = "TK theo ngày";
            this.btn_TheoNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_TheoNgay.Click += new System.EventHandler(this.btn_TheoNgay_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Chọn ngày:";
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.NgayBan,
            this.TongTien,
            this.TrangThai,
            this.TenNhanVien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_HoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_HoaDon.Location = new System.Drawing.Point(13, 421);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.Size = new System.Drawing.Size(1419, 343);
            this.dgv_HoaDon.TabIndex = 3;
            this.dgv_HoaDon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_RowEnter);
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHoaDon";
            this.MaHoaDon.HeaderText = "Mã hóa đơn";
            this.MaHoaDon.MinimumWidth = 6;
            this.MaHoaDon.Name = "MaHoaDon";
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày bán";
            this.NgayBan.MinimumWidth = 6;
            this.NgayBan.Name = "NgayBan";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Nhân viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // fPaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1449, 776);
            this.Controls.Add(this.dgv_HoaDon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPaymentHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPayment";
            this.Load += new System.EventHandler(this.fPayment_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox btn_Hide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaHoaDon;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
        private Guna.UI2.WinForms.Guna2Button btn_XemCTHD;
        private System.Windows.Forms.DateTimePicker dt_NgayBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_MaNhanVien;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_TheoNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_ChonNgay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dt_TuNgay;
        private Guna.UI2.WinForms.Guna2Button btn_TheoKhoang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dt_ChonNam;
        private Guna.UI2.WinForms.Guna2Button btn_TheoThang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_ChonThang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dt_DenNgay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
    }
}