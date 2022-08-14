namespace HeThongQuanLyTTHV.QLTKB
{
    partial class XemTKB
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
            this.lvTKB = new System.Windows.Forms.ListView();
            this.lbContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieuDe.Enabled = false;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lbTieuDe.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(581, 89);
            this.lbTieuDe.TabIndex = 2;
            this.lbTieuDe.Text = "THỜI KHOÁ BIỂU";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbCTDT
            // 
            this.cbbCTDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCTDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCTDT.FormattingEnabled = true;
            this.cbbCTDT.Location = new System.Drawing.Point(12, 95);
            this.cbbCTDT.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbbCTDT.Name = "cbbCTDT";
            this.cbbCTDT.Size = new System.Drawing.Size(356, 33);
            this.cbbCTDT.TabIndex = 3;
            this.cbbCTDT.SelectedIndexChanged += new System.EventHandler(this.cbbCTDT_SelectedIndexChanged);
            // 
            // lvTKB
            // 
            this.lvTKB.HideSelection = false;
            this.lvTKB.Location = new System.Drawing.Point(12, 193);
            this.lvTKB.Name = "lvTKB";
            this.lvTKB.Size = new System.Drawing.Size(483, 215);
            this.lvTKB.TabIndex = 6;
            this.lvTKB.UseCompatibleStateImageBehavior = false;
            // 
            // lbContent
            // 
            this.lbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbContent.Location = new System.Drawing.Point(11, 163);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(250, 26);
            this.lbContent.TabIndex = 5;
            this.lbContent.Text = "Danh sách các khoá học";
            // 
            // XemTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 437);
            this.Controls.Add(this.lvTKB);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.cbbCTDT);
            this.Controls.Add(this.lbTieuDe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "XemTKB";
            this.Text = "XemTKB";
            this.Load += new System.EventHandler(this.XemTKB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.ComboBox cbbCTDT;
        private System.Windows.Forms.ListView lvTKB;
        private System.Windows.Forms.Label lbContent;
    }
}