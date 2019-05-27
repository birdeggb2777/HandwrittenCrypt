namespace HandwrittenCrypt_解密檔_
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.載入圖片AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.載入圖片BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.輸出圖片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.載入圖片AToolStripMenuItem,
            this.載入圖片BToolStripMenuItem,
            this.解密ToolStripMenuItem,
            this.輸出圖片ToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1614, 28);
            this.MenuStrip1.TabIndex = 11;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // 載入圖片AToolStripMenuItem
            // 
            this.載入圖片AToolStripMenuItem.Name = "載入圖片AToolStripMenuItem";
            this.載入圖片AToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.載入圖片AToolStripMenuItem.Text = "載入圖片A";
            this.載入圖片AToolStripMenuItem.Click += new System.EventHandler(this.載入圖片AToolStripMenuItem_Click);
            // 
            // 載入圖片BToolStripMenuItem
            // 
            this.載入圖片BToolStripMenuItem.Name = "載入圖片BToolStripMenuItem";
            this.載入圖片BToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.載入圖片BToolStripMenuItem.Text = "載入圖片B";
            this.載入圖片BToolStripMenuItem.Click += new System.EventHandler(this.載入圖片BToolStripMenuItem_Click);
            // 
            // 解密ToolStripMenuItem
            // 
            this.解密ToolStripMenuItem.Name = "解密ToolStripMenuItem";
            this.解密ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.解密ToolStripMenuItem.Text = "解密";
            this.解密ToolStripMenuItem.Click += new System.EventHandler(this.解密ToolStripMenuItem_Click);
            // 
            // 輸出圖片ToolStripMenuItem
            // 
            this.輸出圖片ToolStripMenuItem.Name = "輸出圖片ToolStripMenuItem";
            this.輸出圖片ToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.輸出圖片ToolStripMenuItem.Text = "輸出圖片";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(11, 121);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(62, 45);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 16;
            this.PictureBox1.TabStop = false;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(73, 73);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(1022, 25);
            this.TextBox2.TabIndex = 15;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(73, 31);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(1020, 25);
            this.TextBox1.TabIndex = 14;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 76);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 15);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "金鑰B：";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(5, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(62, 15);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "金鑰A：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1614, 935);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "HandwrittenCrypt(解密檔)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem 載入圖片AToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 載入圖片BToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 解密ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 輸出圖片ToolStripMenuItem;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

