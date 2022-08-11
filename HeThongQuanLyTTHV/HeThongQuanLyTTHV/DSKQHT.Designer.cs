namespace HeThongQuanLyTTHV
{
    partial class DSKQHT
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngBáoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 30);
            this.textBox1.TabIndex = 33;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(335, 90);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(136, 47);
            this.btTimKiem.TabIndex = 32;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 49);
            this.label1.TabIndex = 51;
            this.label1.Text = "Danh Sách Phiếu Kết Quả Học Tập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 182);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1184, 346);
            this.listView1.TabIndex = 56;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.thôngBáoToolStripMenuItem,
            this.thôngBáoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 28);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.quảnLýToolStripMenuItem.Text = "Thêm PKQHT";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // thôngBáoToolStripMenuItem
            // 
            this.thôngBáoToolStripMenuItem.Name = "thôngBáoToolStripMenuItem";
            this.thôngBáoToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.thôngBáoToolStripMenuItem.Text = "Sửa DSPKQHT";
            this.thôngBáoToolStripMenuItem.Click += new System.EventHandler(this.thôngBáoToolStripMenuItem_Click);
            // 
            // thôngBáoToolStripMenuItem1
            // 
            this.thôngBáoToolStripMenuItem1.Name = "thôngBáoToolStripMenuItem1";
            this.thôngBáoToolStripMenuItem1.Size = new System.Drawing.Size(95, 24);
            this.thôngBáoToolStripMenuItem1.Text = "Thông Báo";
            // 
            // DSKQHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 569);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DSKQHT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSKQHT";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngBáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngBáoToolStripMenuItem1;
    }
}