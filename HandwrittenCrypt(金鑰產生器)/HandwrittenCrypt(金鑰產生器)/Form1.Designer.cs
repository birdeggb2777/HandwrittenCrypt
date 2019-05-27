namespace HandwrittenCrypt_金鑰產生器_
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
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.產生金鑰ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.複製金鑰AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.複製金鑰BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(452, 41);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox2.Size = new System.Drawing.Size(434, 534);
            this.TextBox2.TabIndex = 4;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(12, 40);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox1.Size = new System.Drawing.Size(434, 534);
            this.TextBox1.TabIndex = 3;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.產生金鑰ToolStripMenuItem,
            this.複製金鑰AToolStripMenuItem,
            this.複製金鑰BToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(900, 28);
            this.MenuStrip1.TabIndex = 5;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // 產生金鑰ToolStripMenuItem
            // 
            this.產生金鑰ToolStripMenuItem.Name = "產生金鑰ToolStripMenuItem";
            this.產生金鑰ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.產生金鑰ToolStripMenuItem.Text = "產生金鑰";
            this.產生金鑰ToolStripMenuItem.Click += new System.EventHandler(this.產生金鑰ToolStripMenuItem_Click);
            // 
            // 複製金鑰AToolStripMenuItem
            // 
            this.複製金鑰AToolStripMenuItem.Name = "複製金鑰AToolStripMenuItem";
            this.複製金鑰AToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.複製金鑰AToolStripMenuItem.Text = "複製金鑰A";
            this.複製金鑰AToolStripMenuItem.Click += new System.EventHandler(this.複製金鑰AToolStripMenuItem_Click);
            // 
            // 複製金鑰BToolStripMenuItem
            // 
            this.複製金鑰BToolStripMenuItem.Name = "複製金鑰BToolStripMenuItem";
            this.複製金鑰BToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.複製金鑰BToolStripMenuItem.Text = "複製金鑰B";
            this.複製金鑰BToolStripMenuItem.Click += new System.EventHandler(this.複製金鑰BToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 590);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "Form1";
            this.Text = "HandwrittenCrypt(金鑰產生器)";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem 產生金鑰ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 複製金鑰AToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 複製金鑰BToolStripMenuItem;
    }
}

