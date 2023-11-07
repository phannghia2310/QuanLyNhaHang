namespace QuanLyNhaHang.Forms.User_Controls
{
    partial class UC_Order
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Order));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_MaHoaDon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_KhuyenMai = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_ThanhTien = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_TongCong = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_TrangThai = new System.Windows.Forms.Label();
            this.txt_ThoiGian = new System.Windows.Forms.Label();
            this.txt_Ban = new System.Windows.Forms.Label();
            this.txt_KhuVuc = new System.Windows.Forms.Label();
            this.txt_NgayBan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.panel_MonAn = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_DanhMuc = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grb_Ban = new System.Windows.Forms.GroupBox();
            this.panel_Table = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_KhuVuc = new System.Windows.Forms.ComboBox();
            this.time_Order = new System.Windows.Forms.Timer(this.components);
            this.cms_Trong = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.im_GoiMon = new System.Windows.Forms.ToolStripMenuItem();
            this.im_DatBan = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_DatTruoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.im_GoiMonDT = new System.Windows.Forms.ToolStripMenuItem();
            this.im_HuyDatBan = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_CoNguoi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.im_ThemTraMon = new System.Windows.Forms.ToolStripMenuItem();
            this.im_ChuyenBan = new System.Windows.Forms.ToolStripMenuItem();
            this.im_GopBan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.im_XacNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.print_Document = new System.Drawing.Printing.PrintDocument();
            this.print_PreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.panel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grb_Ban.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cms_Trong.SuspendLayout();
            this.cms_DatTruoc.SuspendLayout();
            this.cms_CoNguoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_LamMoi);
            this.panel3.Controls.Add(this.btn_ThanhToan);
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(434, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 711);
            this.panel3.TabIndex = 6;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BorderRadius = 10;
            this.btn_LamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LamMoi.CustomImages.Image = global::QuanLyNhaHang.Properties.Resources.refresh;
            this.btn_LamMoi.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_LamMoi.CustomImages.ImageSize = new System.Drawing.Size(37, 37);
            this.btn_LamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_LamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_LamMoi.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_LamMoi.Location = new System.Drawing.Point(325, 618);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(199, 72);
            this.btn_LamMoi.TabIndex = 1;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BorderRadius = 10;
            this.btn_ThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThanhToan.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_ThanhToan.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ThanhToan.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_ThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThanhToan.FillColor = System.Drawing.Color.ForestGreen;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_ThanhToan.Location = new System.Drawing.Point(34, 618);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(203, 72);
            this.btn_ThanhToan.TabIndex = 0;
            this.btn_ThanhToan.Text = " Thanh toán";
            this.btn_ThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_GhiChu);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.dgv_HoaDon);
            this.groupBox5.Controls.Add(this.txt_MaHoaDon);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txt_KhuyenMai);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txt_ThanhTien);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txt_TongCong);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txt_TrangThai);
            this.groupBox5.Controls.Add(this.txt_ThoiGian);
            this.groupBox5.Controls.Add(this.txt_Ban);
            this.groupBox5.Controls.Add(this.txt_KhuVuc);
            this.groupBox5.Controls.Add(this.txt_NgayBan);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(0, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(555, 580);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin bàn đang phục vụ";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GhiChu.Location = new System.Drawing.Point(126, 430);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_GhiChu.Size = new System.Drawing.Size(398, 26);
            this.txt_GhiChu.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ghi chú:";
            // 
            // dgv_HoaDon
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMonAn,
            this.DonGia,
            this.SoLuong});
            this.dgv_HoaDon.Location = new System.Drawing.Point(0, 152);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.Size = new System.Drawing.Size(555, 264);
            this.dgv_HoaDon.TabIndex = 24;
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.HeaderText = "Tên món ăn";
            this.TenMonAn.MinimumWidth = 6;
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.Width = 220;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // txt_MaHoaDon
            // 
            this.txt_MaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaHoaDon.Location = new System.Drawing.Point(126, 42);
            this.txt_MaHoaDon.Name = "txt_MaHoaDon";
            this.txt_MaHoaDon.Size = new System.Drawing.Size(124, 22);
            this.txt_MaHoaDon.TabIndex = 23;
            this.txt_MaHoaDon.Text = "    ";
            this.txt_MaHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Hóa đơn:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(410, 538);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 20);
            this.label19.TabIndex = 21;
            this.label19.Text = "VNĐ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(410, 468);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "VNĐ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(345, 503);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "%";
            // 
            // txt_KhuyenMai
            // 
            this.txt_KhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_KhuyenMai.Location = new System.Drawing.Point(288, 500);
            this.txt_KhuyenMai.Name = "txt_KhuyenMai";
            this.txt_KhuyenMai.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KhuyenMai.Size = new System.Drawing.Size(44, 26);
            this.txt_KhuyenMai.TabIndex = 18;
            this.txt_KhuyenMai.TextChanged += new System.EventHandler(this.txt_KhuyenMai_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(161, 503);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Khuyến mãi:";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_ThanhTien.Location = new System.Drawing.Point(288, 538);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(111, 22);
            this.txt_ThanhTien.TabIndex = 16;
            this.txt_ThanhTien.Text = "0";
            this.txt_ThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(171, 538);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "Thành tiền:";
            // 
            // txt_TongCong
            // 
            this.txt_TongCong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongCong.ForeColor = System.Drawing.Color.Red;
            this.txt_TongCong.Location = new System.Drawing.Point(288, 466);
            this.txt_TongCong.Name = "txt_TongCong";
            this.txt_TongCong.Size = new System.Drawing.Size(111, 22);
            this.txt_TongCong.TabIndex = 14;
            this.txt_TongCong.Text = "0";
            this.txt_TongCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(171, 468);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Tổng cộng:";
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TrangThai.Location = new System.Drawing.Point(393, 109);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.Size = new System.Drawing.Size(131, 22);
            this.txt_TrangThai.TabIndex = 11;
            this.txt_TrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ThoiGian
            // 
            this.txt_ThoiGian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ThoiGian.Location = new System.Drawing.Point(393, 74);
            this.txt_ThoiGian.Name = "txt_ThoiGian";
            this.txt_ThoiGian.Size = new System.Drawing.Size(131, 22);
            this.txt_ThoiGian.TabIndex = 10;
            this.txt_ThoiGian.Text = "12:00:00";
            this.txt_ThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Ban
            // 
            this.txt_Ban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ban.ForeColor = System.Drawing.Color.Red;
            this.txt_Ban.Location = new System.Drawing.Point(126, 108);
            this.txt_Ban.Name = "txt_Ban";
            this.txt_Ban.Size = new System.Drawing.Size(124, 22);
            this.txt_Ban.TabIndex = 3;
            this.txt_Ban.Text = "            ";
            this.txt_Ban.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_KhuVuc
            // 
            this.txt_KhuVuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_KhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KhuVuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_KhuVuc.Location = new System.Drawing.Point(126, 74);
            this.txt_KhuVuc.Name = "txt_KhuVuc";
            this.txt_KhuVuc.Size = new System.Drawing.Size(124, 22);
            this.txt_KhuVuc.TabIndex = 3;
            this.txt_KhuVuc.Text = "    ";
            this.txt_KhuVuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_NgayBan
            // 
            this.txt_NgayBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NgayBan.Location = new System.Drawing.Point(391, 42);
            this.txt_NgayBan.Name = "txt_NgayBan";
            this.txt_NgayBan.Size = new System.Drawing.Size(133, 22);
            this.txt_NgayBan.TabIndex = 7;
            this.txt_NgayBan.Text = "10/10/2023";
            this.txt_NgayBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Trạng thái:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thời gian:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bàn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khu vực:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 44);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(989, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 711);
            this.panel2.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txt_TimKiem);
            this.groupBox4.Controls.Add(this.panel_MonAn);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(30, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(429, 541);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách món ăn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tìm kiếm:";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiem.Location = new System.Drawing.Point(124, 35);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(283, 26);
            this.txt_TimKiem.TabIndex = 0;
            this.txt_TimKiem.Click += new System.EventHandler(this.txt_TimKiem_Click);
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // panel_MonAn
            // 
            this.panel_MonAn.AutoScroll = true;
            this.panel_MonAn.BackColor = System.Drawing.Color.White;
            this.panel_MonAn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_MonAn.Location = new System.Drawing.Point(3, 69);
            this.panel_MonAn.Name = "panel_MonAn";
            this.panel_MonAn.Size = new System.Drawing.Size(423, 469);
            this.panel_MonAn.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_DanhMuc);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(30, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh mục món ăn";
            // 
            // cmb_DanhMuc
            // 
            this.cmb_DanhMuc.FormattingEnabled = true;
            this.cmb_DanhMuc.Location = new System.Drawing.Point(34, 45);
            this.cmb_DanhMuc.Name = "cmb_DanhMuc";
            this.cmb_DanhMuc.Size = new System.Drawing.Size(178, 28);
            this.cmb_DanhMuc.TabIndex = 0;
            this.cmb_DanhMuc.SelectedIndexChanged += new System.EventHandler(this.cmb_DanhMuc_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grb_Ban);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 711);
            this.panel1.TabIndex = 4;
            // 
            // grb_Ban
            // 
            this.grb_Ban.Controls.Add(this.panel_Table);
            this.grb_Ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Ban.Location = new System.Drawing.Point(25, 149);
            this.grb_Ban.Name = "grb_Ban";
            this.grb_Ban.Size = new System.Drawing.Size(390, 541);
            this.grb_Ban.TabIndex = 1;
            this.grb_Ban.TabStop = false;
            this.grb_Ban.Text = "Danh sách bàn";
            // 
            // panel_Table
            // 
            this.panel_Table.AutoScroll = true;
            this.panel_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Table.Location = new System.Drawing.Point(3, 22);
            this.panel_Table.Name = "panel_Table";
            this.panel_Table.Size = new System.Drawing.Size(384, 516);
            this.panel_Table.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_KhuVuc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khu vực";
            // 
            // cmb_KhuVuc
            // 
            this.cmb_KhuVuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_KhuVuc.FormattingEnabled = true;
            this.cmb_KhuVuc.Items.AddRange(new object[] {
            "Tất cả"});
            this.cmb_KhuVuc.Location = new System.Drawing.Point(43, 42);
            this.cmb_KhuVuc.Name = "cmb_KhuVuc";
            this.cmb_KhuVuc.Size = new System.Drawing.Size(180, 28);
            this.cmb_KhuVuc.TabIndex = 0;
            this.cmb_KhuVuc.SelectedIndexChanged += new System.EventHandler(this.cmb_KhuVuc_SelectedIndexChanged);
            // 
            // time_Order
            // 
            this.time_Order.Tick += new System.EventHandler(this.time_Order_Tick);
            // 
            // cms_Trong
            // 
            this.cms_Trong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cms_Trong.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_Trong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.im_GoiMon,
            this.im_DatBan});
            this.cms_Trong.Name = "cms_Trong";
            this.cms_Trong.Size = new System.Drawing.Size(142, 52);
            // 
            // im_GoiMon
            // 
            this.im_GoiMon.Name = "im_GoiMon";
            this.im_GoiMon.Size = new System.Drawing.Size(141, 24);
            this.im_GoiMon.Text = "Gọi món";
            this.im_GoiMon.Click += new System.EventHandler(this.im_GoiMon_Click);
            // 
            // im_DatBan
            // 
            this.im_DatBan.Name = "im_DatBan";
            this.im_DatBan.Size = new System.Drawing.Size(141, 24);
            this.im_DatBan.Text = "Đặt bàn";
            this.im_DatBan.Click += new System.EventHandler(this.im_DatBan_Click);
            // 
            // cms_DatTruoc
            // 
            this.cms_DatTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cms_DatTruoc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_DatTruoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.im_GoiMonDT,
            this.im_HuyDatBan});
            this.cms_DatTruoc.Name = "cms_DatTruoc";
            this.cms_DatTruoc.Size = new System.Drawing.Size(169, 52);
            // 
            // im_GoiMonDT
            // 
            this.im_GoiMonDT.Name = "im_GoiMonDT";
            this.im_GoiMonDT.Size = new System.Drawing.Size(168, 24);
            this.im_GoiMonDT.Text = "Gọi món";
            this.im_GoiMonDT.Click += new System.EventHandler(this.im_GoiMonDT_Click);
            // 
            // im_HuyDatBan
            // 
            this.im_HuyDatBan.Name = "im_HuyDatBan";
            this.im_HuyDatBan.Size = new System.Drawing.Size(168, 24);
            this.im_HuyDatBan.Text = "Hủy đặt bàn";
            this.im_HuyDatBan.Click += new System.EventHandler(this.im_HuyDatBan_Click);
            // 
            // cms_CoNguoi
            // 
            this.cms_CoNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cms_CoNguoi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_CoNguoi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.im_ThemTraMon,
            this.im_ChuyenBan,
            this.im_GopBan,
            this.toolStripMenuItem2,
            this.im_XacNhan});
            this.cms_CoNguoi.Name = "cms_CoNguoi";
            this.cms_CoNguoi.Size = new System.Drawing.Size(213, 124);
            // 
            // im_ThemTraMon
            // 
            this.im_ThemTraMon.Name = "im_ThemTraMon";
            this.im_ThemTraMon.Size = new System.Drawing.Size(212, 24);
            this.im_ThemTraMon.Text = "Thêm/Trả món";
            this.im_ThemTraMon.Click += new System.EventHandler(this.im_ThemTraMon_Click);
            // 
            // im_ChuyenBan
            // 
            this.im_ChuyenBan.Name = "im_ChuyenBan";
            this.im_ChuyenBan.Size = new System.Drawing.Size(212, 24);
            this.im_ChuyenBan.Text = "Chuyển bàn";
            this.im_ChuyenBan.Click += new System.EventHandler(this.im_ChuyenBan_Click);
            // 
            // im_GopBan
            // 
            this.im_GopBan.Name = "im_GopBan";
            this.im_GopBan.Size = new System.Drawing.Size(212, 24);
            this.im_GopBan.Text = "Gộp bàn";
            this.im_GopBan.Click += new System.EventHandler(this.im_GopBan_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(212, 24);
            this.toolStripMenuItem2.Text = "----------------------";
            // 
            // im_XacNhan
            // 
            this.im_XacNhan.Name = "im_XacNhan";
            this.im_XacNhan.Size = new System.Drawing.Size(212, 24);
            this.im_XacNhan.Text = "Xác nhận gọi món";
            this.im_XacNhan.Click += new System.EventHandler(this.im_XacNhan_Click);
            // 
            // print_Document
            // 
            this.print_Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.print_Document_PrintPage);
            // 
            // print_PreviewDialog
            // 
            this.print_PreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.print_PreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.print_PreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.print_PreviewDialog.Enabled = true;
            this.print_PreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("print_PreviewDialog.Icon")));
            this.print_PreviewDialog.Name = "print_PreviewDialog";
            this.print_PreviewDialog.Visible = false;
            // 
            // UC_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Order";
            this.Size = new System.Drawing.Size(1467, 711);
            this.Load += new System.EventHandler(this.UC_Order_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grb_Ban.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.cms_Trong.ResumeLayout(false);
            this.cms_DatTruoc.ResumeLayout(false);
            this.cms_CoNguoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
        private Guna.UI2.WinForms.Guna2Button btn_ThanhToan;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Label txt_MaHoaDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_KhuyenMai;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label txt_ThanhTien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txt_TongCong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txt_TrangThai;
        private System.Windows.Forms.Label txt_ThoiGian;
        private System.Windows.Forms.Label txt_Ban;
        private System.Windows.Forms.Label txt_KhuVuc;
        private System.Windows.Forms.Label txt_NgayBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Panel panel_MonAn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_DanhMuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grb_Ban;
        private System.Windows.Forms.Panel panel_Table;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_KhuVuc;
        private System.Windows.Forms.Timer time_Order;
        private System.Windows.Forms.ContextMenuStrip cms_Trong;
        private System.Windows.Forms.ToolStripMenuItem im_GoiMon;
        private System.Windows.Forms.ToolStripMenuItem im_DatBan;
        private System.Windows.Forms.ContextMenuStrip cms_DatTruoc;
        private System.Windows.Forms.ToolStripMenuItem im_GoiMonDT;
        private System.Windows.Forms.ToolStripMenuItem im_HuyDatBan;
        private System.Windows.Forms.ContextMenuStrip cms_CoNguoi;
        private System.Windows.Forms.ToolStripMenuItem im_ThemTraMon;
        private System.Windows.Forms.ToolStripMenuItem im_ChuyenBan;
        private System.Windows.Forms.ToolStripMenuItem im_GopBan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem im_XacNhan;
        private System.Drawing.Printing.PrintDocument print_Document;
        private System.Windows.Forms.PrintPreviewDialog print_PreviewDialog;
    }
}
