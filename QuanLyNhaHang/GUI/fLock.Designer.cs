namespace QuanLyNhaHang.GUI
{
    partial class fLock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLock));
            this.pn_Lock = new System.Windows.Forms.Panel();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_Lock.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Lock
            // 
            this.pn_Lock.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pn_Lock.Controls.Add(this.txt_PassWord);
            this.pn_Lock.Controls.Add(this.label2);
            this.pn_Lock.Controls.Add(this.label1);
            this.pn_Lock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pn_Lock.Location = new System.Drawing.Point(179, 277);
            this.pn_Lock.Name = "pn_Lock";
            this.pn_Lock.Size = new System.Drawing.Size(540, 287);
            this.pn_Lock.TabIndex = 0;
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PassWord.Location = new System.Drawing.Point(240, 156);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(239, 25);
            this.txt_PassWord.TabIndex = 2;
            this.txt_PassWord.UseSystemPasswordChar = true;
            this.txt_PassWord.TextChanged += new System.EventHandler(this.txt_PassWord_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÓA MÀN HÌNH";
            // 
            // fLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1319, 798);
            this.Controls.Add(this.pn_Lock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLock";
            this.Load += new System.EventHandler(this.fLock_Load);
            this.pn_Lock.ResumeLayout(false);
            this.pn_Lock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Lock;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}