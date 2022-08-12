
namespace HeThongQuanLyTTHV.QLHV
{
    partial class DanhSachHocVien
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.lbTitle = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btSort = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Brown;
            this.lbTitle.Location = new System.Drawing.Point(3, 1);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1782, 81);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "DANH SÁCH HỌC VIÊN";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.name,
            this.DOB,
            this.gender,
            this.email,
            this.phoneNumber,
            this.adress});
            this.listView1.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(10, 85);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1775, 624);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "Số CCCD";
            this.ID.Width = 170;
            // 
            // name
            // 
            this.name.Text = "Họ và tên";
            this.name.Width = 289;
            // 
            // DOB
            // 
            this.DOB.Text = "Ngày sinh";
            this.DOB.Width = 153;
            // 
            // gender
            // 
            this.gender.Text = "Giới tính";
            this.gender.Width = 136;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 264;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Text = "Số điện thoại";
            this.phoneNumber.Width = 183;
            // 
            // adress
            // 
            this.adress.Text = "Địa chỉ";
            this.adress.Width = 579;
            // 
            // btSort
            // 
            this.btSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSort.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSort.Location = new System.Drawing.Point(904, 724);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(221, 55);
            this.btSort.TabIndex = 5;
            this.btSort.Text = "Sắp xếp (A-Z)";
            this.btSort.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.Font = new System.Drawing.Font("Courier New", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(721, 724);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(107, 55);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // DanhSachHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1786, 800);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "DanhSachHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Học Viên";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader DOB;
        private System.Windows.Forms.ColumnHeader gender;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader phoneNumber;
        private System.Windows.Forms.ColumnHeader adress;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.Button btExit;
    }
}