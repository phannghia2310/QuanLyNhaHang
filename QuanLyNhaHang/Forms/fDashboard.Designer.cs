namespace QuanLyNhaHang.GUI
{
    partial class fDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart_ThongKeDoanhSo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_ThongKeMatHang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gradientPanel4 = new QuanLyNhaHang.GradientPanel();
            this.txt_DoanhSoNgay = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_DoanhSoThang = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gradientPanel3 = new QuanLyNhaHang.GradientPanel();
            this.txt_MHBanChayNhat = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TongMHThang = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new QuanLyNhaHang.GradientPanel();
            this.txt_TongHoaDonNgay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TongHoaDonThang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanel1 = new QuanLyNhaHang.GradientPanel();
            this.btn_Hide = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ThongKeDoanhSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ThongKeMatHang)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gradientPanel4);
            this.panel1.Controls.Add(this.gradientPanel3);
            this.panel1.Controls.Add(this.gradientPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1449, 200);
            this.panel1.TabIndex = 1;
            // 
            // chart_ThongKeDoanhSo
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_ThongKeDoanhSo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_ThongKeDoanhSo.Legends.Add(legend1);
            this.chart_ThongKeDoanhSo.Location = new System.Drawing.Point(12, 325);
            this.chart_ThongKeDoanhSo.Name = "chart_ThongKeDoanhSo";
            this.chart_ThongKeDoanhSo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh số";
            this.chart_ThongKeDoanhSo.Series.Add(series1);
            this.chart_ThongKeDoanhSo.Size = new System.Drawing.Size(750, 409);
            this.chart_ThongKeDoanhSo.TabIndex = 2;
            this.chart_ThongKeDoanhSo.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Biểu Đồ Thống Kê Doanh Thu Theo Ngày";
            this.chart_ThongKeDoanhSo.Titles.Add(title1);
            // 
            // chart_ThongKeMatHang
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_ThongKeMatHang.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_ThongKeMatHang.Legends.Add(legend2);
            this.chart_ThongKeMatHang.Location = new System.Drawing.Point(815, 325);
            this.chart_ThongKeMatHang.Name = "chart_ThongKeMatHang";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_ThongKeMatHang.Series.Add(series2);
            this.chart_ThongKeMatHang.Size = new System.Drawing.Size(620, 409);
            this.chart_ThongKeMatHang.TabIndex = 3;
            this.chart_ThongKeMatHang.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "Biểu Đồ Thống Kê Mặt Hàng";
            this.chart_ThongKeMatHang.Titles.Add(title2);
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.Angle = 50F;
            this.gradientPanel4.BackColor = System.Drawing.Color.DarkMagenta;
            this.gradientPanel4.BottomColor = System.Drawing.Color.HotPink;
            this.gradientPanel4.Controls.Add(this.txt_DoanhSoNgay);
            this.gradientPanel4.Controls.Add(this.pictureBox3);
            this.gradientPanel4.Controls.Add(this.label11);
            this.gradientPanel4.Controls.Add(this.txt_DoanhSoThang);
            this.gradientPanel4.Controls.Add(this.label13);
            this.gradientPanel4.Location = new System.Drawing.Point(1055, 6);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(370, 184);
            this.gradientPanel4.TabIndex = 2;
            this.gradientPanel4.TopColor = System.Drawing.Color.Empty;
            // 
            // txt_DoanhSoNgay
            // 
            this.txt_DoanhSoNgay.AutoSize = true;
            this.txt_DoanhSoNgay.BackColor = System.Drawing.Color.Transparent;
            this.txt_DoanhSoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DoanhSoNgay.ForeColor = System.Drawing.Color.White;
            this.txt_DoanhSoNgay.Location = new System.Drawing.Point(117, 125);
            this.txt_DoanhSoNgay.Name = "txt_DoanhSoNgay";
            this.txt_DoanhSoNgay.Size = new System.Drawing.Size(41, 29);
            this.txt_DoanhSoNgay.TabIndex = 8;
            this.txt_DoanhSoNgay.Text = "99";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(247, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 121);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(9, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 26);
            this.label11.TabIndex = 7;
            this.label11.Text = "Hôm nay: ";
            // 
            // txt_DoanhSoThang
            // 
            this.txt_DoanhSoThang.AutoSize = true;
            this.txt_DoanhSoThang.BackColor = System.Drawing.Color.Transparent;
            this.txt_DoanhSoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DoanhSoThang.ForeColor = System.Drawing.Color.White;
            this.txt_DoanhSoThang.Location = new System.Drawing.Point(4, 44);
            this.txt_DoanhSoThang.Name = "txt_DoanhSoThang";
            this.txt_DoanhSoThang.Size = new System.Drawing.Size(81, 58);
            this.txt_DoanhSoThang.TabIndex = 6;
            this.txt_DoanhSoThang.Text = "99";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(9, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 29);
            this.label13.TabIndex = 5;
            this.label13.Text = "DOANH SỐ";
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.Angle = 50F;
            this.gradientPanel3.BackColor = System.Drawing.Color.Orange;
            this.gradientPanel3.BottomColor = System.Drawing.Color.Yellow;
            this.gradientPanel3.Controls.Add(this.txt_MHBanChayNhat);
            this.gradientPanel3.Controls.Add(this.pictureBox2);
            this.gradientPanel3.Controls.Add(this.label7);
            this.gradientPanel3.Controls.Add(this.txt_TongMHThang);
            this.gradientPanel3.Controls.Add(this.label9);
            this.gradientPanel3.Location = new System.Drawing.Point(537, 6);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(370, 184);
            this.gradientPanel3.TabIndex = 1;
            this.gradientPanel3.TopColor = System.Drawing.Color.Empty;
            // 
            // txt_MHBanChayNhat
            // 
            this.txt_MHBanChayNhat.AutoSize = true;
            this.txt_MHBanChayNhat.BackColor = System.Drawing.Color.Transparent;
            this.txt_MHBanChayNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MHBanChayNhat.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_MHBanChayNhat.Location = new System.Drawing.Point(47, 141);
            this.txt_MHBanChayNhat.Name = "txt_MHBanChayNhat";
            this.txt_MHBanChayNhat.Size = new System.Drawing.Size(92, 29);
            this.txt_MHBanChayNhat.TabIndex = 8;
            this.txt_MHBanChayNhat.Text = "abcxyz";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(261, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 121);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mặt hàng bán chạy: ";
            // 
            // txt_TongMHThang
            // 
            this.txt_TongMHThang.AutoSize = true;
            this.txt_TongMHThang.BackColor = System.Drawing.Color.Transparent;
            this.txt_TongMHThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongMHThang.ForeColor = System.Drawing.Color.White;
            this.txt_TongMHThang.Location = new System.Drawing.Point(-2, 44);
            this.txt_TongMHThang.Name = "txt_TongMHThang";
            this.txt_TongMHThang.Size = new System.Drawing.Size(81, 58);
            this.txt_TongMHThang.TabIndex = 6;
            this.txt_TongMHThang.Text = "99";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "TỔNG MẶT HÀNG";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 50F;
            this.gradientPanel2.BackColor = System.Drawing.Color.ForestGreen;
            this.gradientPanel2.BottomColor = System.Drawing.Color.Chartreuse;
            this.gradientPanel2.Controls.Add(this.txt_TongHoaDonNgay);
            this.gradientPanel2.Controls.Add(this.label4);
            this.gradientPanel2.Controls.Add(this.txt_TongHoaDonThang);
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Controls.Add(this.pictureBox1);
            this.gradientPanel2.Location = new System.Drawing.Point(26, 6);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(370, 184);
            this.gradientPanel2.TabIndex = 0;
            this.gradientPanel2.TopColor = System.Drawing.Color.Empty;
            // 
            // txt_TongHoaDonNgay
            // 
            this.txt_TongHoaDonNgay.AutoSize = true;
            this.txt_TongHoaDonNgay.BackColor = System.Drawing.Color.Transparent;
            this.txt_TongHoaDonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongHoaDonNgay.ForeColor = System.Drawing.Color.White;
            this.txt_TongHoaDonNgay.Location = new System.Drawing.Point(126, 128);
            this.txt_TongHoaDonNgay.Name = "txt_TongHoaDonNgay";
            this.txt_TongHoaDonNgay.Size = new System.Drawing.Size(41, 29);
            this.txt_TongHoaDonNgay.TabIndex = 4;
            this.txt_TongHoaDonNgay.Text = "99";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hôm nay: ";
            // 
            // txt_TongHoaDonThang
            // 
            this.txt_TongHoaDonThang.AutoSize = true;
            this.txt_TongHoaDonThang.BackColor = System.Drawing.Color.Transparent;
            this.txt_TongHoaDonThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongHoaDonThang.ForeColor = System.Drawing.Color.White;
            this.txt_TongHoaDonThang.Location = new System.Drawing.Point(-2, 44);
            this.txt_TongHoaDonThang.Name = "txt_TongHoaDonThang";
            this.txt_TongHoaDonThang.Size = new System.Drawing.Size(81, 58);
            this.txt_TongHoaDonThang.TabIndex = 2;
            this.txt_TongHoaDonThang.Text = "99";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "TỔNG HÓA ĐƠN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(247, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 121);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.btn_Hide.Location = new System.Drawing.Point(1353, 16);
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
            this.label1.Location = new System.Drawing.Point(665, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "THỐNG KÊ";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Location = new System.Drawing.Point(1395, 17);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 29);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // fDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1449, 776);
            this.Controls.Add(this.chart_ThongKeMatHang);
            this.Controls.Add(this.chart_ThongKeDoanhSo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDashboard";
            this.Load += new System.EventHandler(this.fDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_ThongKeDoanhSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ThongKeMatHang)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            this.gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox btn_Hide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.Panel panel1;
        private GradientPanel gradientPanel4;
        private GradientPanel gradientPanel3;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txt_TongHoaDonNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_TongHoaDonThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_MHBanChayNhat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt_TongMHThang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txt_DoanhSoNgay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txt_DoanhSoThang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ThongKeDoanhSo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ThongKeMatHang;
    }
}