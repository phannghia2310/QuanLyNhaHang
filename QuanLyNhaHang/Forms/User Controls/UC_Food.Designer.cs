namespace QuanLyNhaHang.GUI.User_Controls
{
    partial class UC_Food
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Food));
            this.dgv_MonAn = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_XuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.rb_TenDanhMuc = new System.Windows.Forms.RadioButton();
            this.rb_TenMonAn = new System.Windows.Forms.RadioButton();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btb_XoaBot = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ChinhSua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThemMoi = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_MaDanhMuc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DVT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ChapNhan = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TenMonAn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaMonAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_AnhMonAn = new System.Windows.Forms.PictureBox();
            this.btn_LoadImage = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.lb_FileAnh = new System.Windows.Forms.Label();
            this.MaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonAn)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MonAn
            // 
            this.dgv_MonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_MonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonAn,
            this.TenMonAn,
            this.DonGia,
            this.DVT,
            this.Anh,
            this.TenDanhMuc});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_MonAn.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_MonAn.Location = new System.Drawing.Point(32, 302);
            this.dgv_MonAn.Name = "dgv_MonAn";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MonAn.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_MonAn.RowHeadersWidth = 62;
            this.dgv_MonAn.RowTemplate.Height = 24;
            this.dgv_MonAn.Size = new System.Drawing.Size(1403, 323);
            this.dgv_MonAn.TabIndex = 8;
            this.dgv_MonAn.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MonAn_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_XuatExcel);
            this.groupBox2.Controls.Add(this.rb_TenDanhMuc);
            this.groupBox2.Controls.Add(this.rb_TenMonAn);
            this.groupBox2.Controls.Add(this.txt_TimKiem);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btb_XoaBot);
            this.groupBox2.Controls.Add(this.btn_ChinhSua);
            this.groupBox2.Controls.Add(this.btn_ThemMoi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(786, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 259);
            this.groupBox2.TabIndex = 7;
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
            this.btn_XuatExcel.Location = new System.Drawing.Point(445, 189);
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(172, 51);
            this.btn_XuatExcel.TabIndex = 17;
            this.btn_XuatExcel.Text = "Xuất Excel";
            this.btn_XuatExcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_XuatExcel.Click += new System.EventHandler(this.btn_XuatExcel_Click);
            // 
            // rb_TenDanhMuc
            // 
            this.rb_TenDanhMuc.AutoSize = true;
            this.rb_TenDanhMuc.Location = new System.Drawing.Point(239, 203);
            this.rb_TenDanhMuc.Name = "rb_TenDanhMuc";
            this.rb_TenDanhMuc.Size = new System.Drawing.Size(136, 24);
            this.rb_TenDanhMuc.TabIndex = 16;
            this.rb_TenDanhMuc.TabStop = true;
            this.rb_TenDanhMuc.Text = "Tên danh mục";
            this.rb_TenDanhMuc.UseVisualStyleBackColor = true;
            // 
            // rb_TenMonAn
            // 
            this.rb_TenMonAn.AutoSize = true;
            this.rb_TenMonAn.Location = new System.Drawing.Point(59, 203);
            this.rb_TenMonAn.Name = "rb_TenMonAn";
            this.rb_TenMonAn.Size = new System.Drawing.Size(118, 24);
            this.rb_TenMonAn.TabIndex = 15;
            this.rb_TenMonAn.TabStop = true;
            this.rb_TenMonAn.Text = "Tên món ăn";
            this.rb_TenMonAn.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiem.Location = new System.Drawing.Point(130, 126);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(487, 27);
            this.txt_TimKiem.TabIndex = 14;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tìm kiếm:";
            // 
            // btb_XoaBot
            // 
            this.btb_XoaBot.BorderRadius = 10;
            this.btb_XoaBot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btb_XoaBot.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
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
            this.btn_ThemMoi.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
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
            this.groupBox1.Controls.Add(this.lb_FileAnh);
            this.groupBox1.Controls.Add(this.btn_LoadImage);
            this.groupBox1.Controls.Add(this.pb_AnhMonAn);
            this.groupBox1.Controls.Add(this.cmb_MaDanhMuc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_DVT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_DonGia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_LamMoi);
            this.groupBox1.Controls.Add(this.btn_ChapNhan);
            this.groupBox1.Controls.Add(this.txt_TenMonAn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_MaMonAn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 259);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn";
            // 
            // cmb_MaDanhMuc
            // 
            this.cmb_MaDanhMuc.FormattingEnabled = true;
            this.cmb_MaDanhMuc.Location = new System.Drawing.Point(181, 202);
            this.cmb_MaDanhMuc.Name = "cmb_MaDanhMuc";
            this.cmb_MaDanhMuc.Size = new System.Drawing.Size(125, 28);
            this.cmb_MaDanhMuc.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Danh mục";
            // 
            // txt_DVT
            // 
            this.txt_DVT.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DVT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DVT.Location = new System.Drawing.Point(179, 55);
            this.txt_DVT.Name = "txt_DVT";
            this.txt_DVT.Size = new System.Drawing.Size(127, 27);
            this.txt_DVT.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Đơn vị tính";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DonGia.Location = new System.Drawing.Point(31, 203);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(121, 27);
            this.txt_DonGia.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Đơn giá";
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
            this.btn_LamMoi.Location = new System.Drawing.Point(532, 145);
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
            this.btn_ChapNhan.Location = new System.Drawing.Point(532, 66);
            this.btn_ChapNhan.Name = "btn_ChapNhan";
            this.btn_ChapNhan.Size = new System.Drawing.Size(172, 51);
            this.btn_ChapNhan.TabIndex = 8;
            this.btn_ChapNhan.Text = "Chấp nhận";
            this.btn_ChapNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_ChapNhan.Click += new System.EventHandler(this.btn_ChapNhan_Click);
            // 
            // txt_TenMonAn
            // 
            this.txt_TenMonAn.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenMonAn.Location = new System.Drawing.Point(31, 128);
            this.txt_TenMonAn.Name = "txt_TenMonAn";
            this.txt_TenMonAn.Size = new System.Drawing.Size(275, 27);
            this.txt_TenMonAn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên món ăn";
            // 
            // txt_MaMonAn
            // 
            this.txt_MaMonAn.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MaMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaMonAn.Location = new System.Drawing.Point(31, 56);
            this.txt_MaMonAn.Name = "txt_MaMonAn";
            this.txt_MaMonAn.Size = new System.Drawing.Size(121, 27);
            this.txt_MaMonAn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã món ăn";
            // 
            // pb_AnhMonAn
            // 
            this.pb_AnhMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_AnhMonAn.Location = new System.Drawing.Point(332, 38);
            this.pb_AnhMonAn.Name = "pb_AnhMonAn";
            this.pb_AnhMonAn.Size = new System.Drawing.Size(177, 115);
            this.pb_AnhMonAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_AnhMonAn.TabIndex = 17;
            this.pb_AnhMonAn.TabStop = false;
            // 
            // btn_LoadImage
            // 
            this.btn_LoadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadImage.Location = new System.Drawing.Point(359, 195);
            this.btn_LoadImage.Name = "btn_LoadImage";
            this.btn_LoadImage.Size = new System.Drawing.Size(121, 40);
            this.btn_LoadImage.TabIndex = 18;
            this.btn_LoadImage.Text = "Thêm ảnh";
            this.btn_LoadImage.UseVisualStyleBackColor = true;
            this.btn_LoadImage.Click += new System.EventHandler(this.btn_LoadImage_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // lb_FileAnh
            // 
            this.lb_FileAnh.AutoSize = true;
            this.lb_FileAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FileAnh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_FileAnh.Location = new System.Drawing.Point(328, 156);
            this.lb_FileAnh.Name = "lb_FileAnh";
            this.lb_FileAnh.Size = new System.Drawing.Size(95, 17);
            this.lb_FileAnh.TabIndex = 19;
            this.lb_FileAnh.Text = "File ảnh (.jpg)";
            // 
            // MaMonAn
            // 
            this.MaMonAn.DataPropertyName = "MaMonAn";
            this.MaMonAn.HeaderText = "Mã món ăn";
            this.MaMonAn.MinimumWidth = 6;
            this.MaMonAn.Name = "MaMonAn";
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.HeaderText = "Tên món ăn";
            this.TenMonAn.MinimumWidth = 6;
            this.TenMonAn.Name = "TenMonAn";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            // 
            // Anh
            // 
            this.Anh.DataPropertyName = "Anh";
            this.Anh.HeaderText = "Ảnh";
            this.Anh.MinimumWidth = 6;
            this.Anh.Name = "Anh";
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.DataPropertyName = "TenDanhMuc";
            this.TenDanhMuc.HeaderText = "Tên danh mục";
            this.TenDanhMuc.MinimumWidth = 6;
            this.TenDanhMuc.Name = "TenDanhMuc";
            // 
            // UC_Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_MonAn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Food";
            this.Size = new System.Drawing.Size(1467, 645);
            this.Load += new System.EventHandler(this.UC_Food_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonAn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MonAn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_TenMonAn;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btb_XoaBot;
        private Guna.UI2.WinForms.Guna2Button btn_ChinhSua;
        private Guna.UI2.WinForms.Guna2Button btn_ThemMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
        private Guna.UI2.WinForms.Guna2Button btn_ChapNhan;
        private System.Windows.Forms.TextBox txt_TenMonAn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaMonAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_MaDanhMuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DVT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_TenDanhMuc;
        private Guna.UI2.WinForms.Guna2Button btn_XuatExcel;
        private System.Windows.Forms.PictureBox pb_AnhMonAn;
        private System.Windows.Forms.Button btn_LoadImage;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label lb_FileAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDanhMuc;
    }
}
