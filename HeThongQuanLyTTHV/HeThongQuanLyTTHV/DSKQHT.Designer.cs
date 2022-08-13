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
            this.label1 = new System.Windows.Forms.Label();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.txtT = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MaPhieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CCCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CapHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KhoaHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btThemm = new System.Windows.Forms.Button();
            this.btChinh = new System.Windows.Forms.Button();
            this.btThongBao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 43);
            this.label1.TabIndex = 51;
            this.label1.Text = "Danh Sách Phiếu Kết Quả Học Tập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.LightCyan;
            this.btTimKiem.Location = new System.Drawing.Point(335, 86);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(141, 34);
            this.btTimKiem.TabIndex = 32;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(18, 86);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(311, 30);
            this.txtT.TabIndex = 33;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaPhieu,
            this.HoTen,
            this.CCCD,
            this.CapHoc,
            this.KhoaHoc,
            this.Lop,
            this.SDT,
            this.NgaySinh,
            this.Diem,
            this.GioiTinh,
            this.GhiChu});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 148);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1179, 239);
            this.listView1.TabIndex = 75;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MaPhieu
            // 
            this.MaPhieu.Text = "Mã Phiếu";
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ Tên";
            // 
            // CCCD
            // 
            this.CCCD.Text = "CCCD";
            // 
            // CapHoc
            // 
            this.CapHoc.Text = "Cấp Học";
            // 
            // KhoaHoc
            // 
            this.KhoaHoc.Text = "Khóa Học";
            // 
            // Lop
            // 
            this.Lop.Text = "Lớp";
            // 
            // SDT
            // 
            this.SDT.Text = "SĐT";
            // 
            // NgaySinh
            // 
            this.NgaySinh.Text = "Ngày Sinh";
            // 
            // Diem
            // 
            this.Diem.Text = "Điểm";
            // 
            // GioiTinh
            // 
            this.GioiTinh.Text = "Giới Tính";
            // 
            // GhiChu
            // 
            this.GhiChu.Text = "GhiChu";
            this.GhiChu.Width = 145;
            // 
            // btThemm
            // 
            this.btThemm.BackColor = System.Drawing.Color.LightCyan;
            this.btThemm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThemm.Location = new System.Drawing.Point(24, 33);
            this.btThemm.Margin = new System.Windows.Forms.Padding(2);
            this.btThemm.Name = "btThemm";
            this.btThemm.Size = new System.Drawing.Size(97, 29);
            this.btThemm.TabIndex = 76;
            this.btThemm.Text = "Thêm";
            this.btThemm.UseVisualStyleBackColor = false;
            this.btThemm.Click += new System.EventHandler(this.btThemm_Click);
            // 
            // btChinh
            // 
            this.btChinh.BackColor = System.Drawing.Color.LightCyan;
            this.btChinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btChinh.Location = new System.Drawing.Point(125, 33);
            this.btChinh.Margin = new System.Windows.Forms.Padding(2);
            this.btChinh.Name = "btChinh";
            this.btChinh.Size = new System.Drawing.Size(126, 29);
            this.btChinh.TabIndex = 76;
            this.btChinh.Text = "Chỉnh Sửa";
            this.btChinh.UseVisualStyleBackColor = false;
            this.btChinh.Click += new System.EventHandler(this.btChinh_Click);
            // 
            // btThongBao
            // 
            this.btThongBao.BackColor = System.Drawing.Color.LightCyan;
            this.btThongBao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThongBao.Location = new System.Drawing.Point(255, 33);
            this.btThongBao.Margin = new System.Windows.Forms.Padding(2);
            this.btThongBao.Name = "btThongBao";
            this.btThongBao.Size = new System.Drawing.Size(124, 29);
            this.btThongBao.TabIndex = 76;
            this.btThongBao.Text = "Thông Báo";
            this.btThongBao.UseVisualStyleBackColor = false;
            this.btThongBao.Click += new System.EventHandler(this.btThongBao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btThongBao);
            this.groupBox1.Controls.Add(this.btChinh);
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btThemm);
            this.groupBox1.Location = new System.Drawing.Point(701, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 72);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.LightCyan;
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThoat.Location = new System.Drawing.Point(392, 33);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(98, 29);
            this.btThoat.TabIndex = 76;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // DSKQHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.btTimKiem);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DSKQHT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSKQHT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DSKQHT_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MaPhieu;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader CCCD;
        private System.Windows.Forms.ColumnHeader CapHoc;
        private System.Windows.Forms.ColumnHeader KhoaHoc;
        private System.Windows.Forms.ColumnHeader Lop;
        private System.Windows.Forms.ColumnHeader SDT;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader Diem;
        private System.Windows.Forms.ColumnHeader GioiTinh;
        private System.Windows.Forms.ColumnHeader GhiChu;
        private System.Windows.Forms.Button btThemm;
        private System.Windows.Forms.Button btChinh;
        private System.Windows.Forms.Button btThongBao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThoat;
    }
}