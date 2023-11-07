namespace QuanLyNhaHang.Forms
{
    partial class fMergeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMergeTable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gradientPanel1 = new QuanLyNhaHang.GradientPanel();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_Ban = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Ban = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_HoaDonGop = new System.Windows.Forms.DataGridView();
            this.TenMonAn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_GopBan = new Guna.UI2.WinForms.Guna2Button();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDonGop)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 90F;
            this.gradientPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.btn_Close);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1181, 100);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Empty;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Location = new System.Drawing.Point(1133, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 29);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(530, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "GỘP BÀN";
            // 
            // dgv_HoaDon
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMonAn,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_HoaDon.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_HoaDon.Location = new System.Drawing.Point(12, 180);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.Size = new System.Drawing.Size(545, 266);
            this.dgv_HoaDon.TabIndex = 13;
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.HeaderText = "Tên món ăn";
            this.TenMonAn.MinimumWidth = 6;
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.Width = 200;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 123;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 123;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 123;
            // 
            // cmb_Ban
            // 
            this.cmb_Ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Ban.FormattingEnabled = true;
            this.cmb_Ban.Location = new System.Drawing.Point(895, 129);
            this.cmb_Ban.Name = "cmb_Ban";
            this.cmb_Ban.Size = new System.Drawing.Size(108, 28);
            this.cmb_Ban.TabIndex = 12;
            this.cmb_Ban.SelectedIndexChanged += new System.EventHandler(this.cmb_Ban_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(830, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bàn:";
            // 
            // txt_Ban
            // 
            this.txt_Ban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_Ban.Location = new System.Drawing.Point(269, 130);
            this.txt_Ban.Name = "txt_Ban";
            this.txt_Ban.Size = new System.Drawing.Size(100, 25);
            this.txt_Ban.TabIndex = 10;
            this.txt_Ban.Text = "    ";
            this.txt_Ban.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bàn:";
            // 
            // dgv_HoaDonGop
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HoaDonGop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_HoaDonGop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDonGop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMonAn1,
            this.DonGia1,
            this.SoLuong1,
            this.ThanhTien1});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_HoaDonGop.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_HoaDonGop.Location = new System.Drawing.Point(624, 180);
            this.dgv_HoaDonGop.Name = "dgv_HoaDonGop";
            this.dgv_HoaDonGop.RowHeadersWidth = 51;
            this.dgv_HoaDonGop.RowTemplate.Height = 24;
            this.dgv_HoaDonGop.Size = new System.Drawing.Size(545, 266);
            this.dgv_HoaDonGop.TabIndex = 15;
            // 
            // TenMonAn1
            // 
            this.TenMonAn1.DataPropertyName = "TenMonAn";
            this.TenMonAn1.HeaderText = "Tên món ăn";
            this.TenMonAn1.MinimumWidth = 6;
            this.TenMonAn1.Name = "TenMonAn1";
            this.TenMonAn1.Width = 200;
            // 
            // DonGia1
            // 
            this.DonGia1.DataPropertyName = "DonGia";
            this.DonGia1.HeaderText = "Đơn giá";
            this.DonGia1.MinimumWidth = 6;
            this.DonGia1.Name = "DonGia1";
            this.DonGia1.Width = 123;
            // 
            // SoLuong1
            // 
            this.SoLuong1.DataPropertyName = "SoLuong";
            this.SoLuong1.HeaderText = "Số lượng";
            this.SoLuong1.MinimumWidth = 6;
            this.SoLuong1.Name = "SoLuong1";
            this.SoLuong1.Width = 123;
            // 
            // ThanhTien1
            // 
            this.ThanhTien1.DataPropertyName = "ThanhTien";
            this.ThanhTien1.HeaderText = "Thành tiền";
            this.ThanhTien1.MinimumWidth = 6;
            this.ThanhTien1.Name = "ThanhTien1";
            this.ThanhTien1.Width = 123;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(579, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 333);
            this.label4.TabIndex = 16;
            this.label4.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // btn_GopBan
            // 
            this.btn_GopBan.BorderRadius = 10;
            this.btn_GopBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GopBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_GopBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_GopBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_GopBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_GopBan.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_GopBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_GopBan.ForeColor = System.Drawing.Color.White;
            this.btn_GopBan.Image = global::QuanLyNhaHang.Properties.Resources.merge_call;
            this.btn_GopBan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_GopBan.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_GopBan.Location = new System.Drawing.Point(501, 526);
            this.btn_GopBan.Name = "btn_GopBan";
            this.btn_GopBan.Size = new System.Drawing.Size(180, 45);
            this.btn_GopBan.TabIndex = 14;
            this.btn_GopBan.Text = "Gộp bàn";
            this.btn_GopBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_GopBan.Click += new System.EventHandler(this.btn_GopBan_Click);
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GhiChu.Location = new System.Drawing.Point(427, 474);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_GhiChu.Size = new System.Drawing.Size(398, 22);
            this.txt_GhiChu.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(331, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ghi chú:";
            // 
            // fMergeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1181, 608);
            this.Controls.Add(this.txt_GhiChu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_HoaDonGop);
            this.Controls.Add(this.btn_GopBan);
            this.Controls.Add(this.dgv_HoaDon);
            this.Controls.Add(this.cmb_Ban);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Ban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMergeTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMergeTable";
            this.Load += new System.EventHandler(this.fMergeTable_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDonGop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_Close;
        private Guna.UI2.WinForms.Guna2Button btn_GopBan;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.ComboBox cmb_Ban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_Ban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_HoaDonGop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien1;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Label label9;
    }
}