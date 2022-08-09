namespace HeThongQuanLyTTHV
{
    partial class ThemTKB
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
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.cbbCTDT = new System.Windows.Forms.ComboBox();
            this.lbContent = new System.Windows.Forms.Label();
            this.lvDSKH = new System.Windows.Forms.ListView();
            this.lvDSKHThemTC = new System.Windows.Forms.ListView();
            this.lbContent1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieuDe.Enabled = false;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lbTieuDe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(624, 68);
            this.lbTieuDe.TabIndex = 1;
            this.lbTieuDe.Text = "THỜI KHOÁ BIỂU";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbCTDT
            // 
            this.cbbCTDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCTDT.FormattingEnabled = true;
            this.cbbCTDT.Location = new System.Drawing.Point(13, 72);
            this.cbbCTDT.Name = "cbbCTDT";
            this.cbbCTDT.Size = new System.Drawing.Size(372, 33);
            this.cbbCTDT.TabIndex = 2;
            this.cbbCTDT.SelectedIndexChanged += new System.EventHandler(this.cbbChon_SelectedIndexChanged);
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbContent.Location = new System.Drawing.Point(12, 130);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(250, 26);
            this.lbContent.TabIndex = 3;
            this.lbContent.Text = "Danh sách các khoá học";
            // 
            // lvDSKH
            // 
            this.lvDSKH.HideSelection = false;
            this.lvDSKH.Location = new System.Drawing.Point(13, 160);
            this.lvDSKH.Name = "lvDSKH";
            this.lvDSKH.Size = new System.Drawing.Size(594, 205);
            this.lvDSKH.TabIndex = 4;
            this.lvDSKH.UseCompatibleStateImageBehavior = false;
            this.lvDSKH.SelectedIndexChanged += new System.EventHandler(this.lvDSKH_SelectedIndexChanged);
            // 
            // lvDSKHThemTC
            // 
            this.lvDSKHThemTC.HideSelection = false;
            this.lvDSKHThemTC.Location = new System.Drawing.Point(13, 458);
            this.lvDSKHThemTC.Name = "lvDSKHThemTC";
            this.lvDSKHThemTC.Size = new System.Drawing.Size(594, 205);
            this.lvDSKHThemTC.TabIndex = 6;
            this.lvDSKHThemTC.UseCompatibleStateImageBehavior = false;
            this.lvDSKHThemTC.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lbContent1
            // 
            this.lbContent1.AutoSize = true;
            this.lbContent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbContent1.Location = new System.Drawing.Point(8, 429);
            this.lbContent1.Name = "lbContent1";
            this.lbContent1.Size = new System.Drawing.Size(335, 26);
            this.lbContent1.TabIndex = 5;
            this.lbContent1.Text = "Danh sách các khoá học đã thêm";
            // 
            // ThemTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 683);
            this.Controls.Add(this.lvDSKHThemTC);
            this.Controls.Add(this.lbContent1);
            this.Controls.Add(this.lvDSKH);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.cbbCTDT);
            this.Controls.Add(this.lbTieuDe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ThemTKB";
            this.Text = "Thêm TKB";
            this.Load += new System.EventHandler(this.ThemTKB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.ComboBox cbbCTDT;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.ListView lvDSKH;
        private System.Windows.Forms.ListView lvDSKHThemTC;
        private System.Windows.Forms.Label lbContent1;
    }
}