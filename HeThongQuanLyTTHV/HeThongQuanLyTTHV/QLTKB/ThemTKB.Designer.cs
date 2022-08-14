namespace HeThongQuanLyTTHV.QLTKB
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
            this.lvDSKH = new System.Windows.Forms.ListView();
            this.colMaLich = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoBuoiHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSLHV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKhungGioHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbContent1 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.gbThemTKB = new System.Windows.Forms.GroupBox();
            this.lbTenCTDT = new System.Windows.Forms.Label();
            this.txtMaLich = new System.Windows.Forms.TextBox();
            this.lbMaLich = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.lbTenGV = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lbPhong = new System.Windows.Forms.Label();
            this.cbbKhungGioHoc = new System.Windows.Forms.ComboBox();
            this.lbGioHoc = new System.Windows.Forms.Label();
            this.cbbThu = new System.Windows.Forms.ComboBox();
            this.lbThu = new System.Windows.Forms.Label();
            this.txtSLHV = new System.Windows.Forms.TextBox();
            this.txtSoBuoiHoc = new System.Windows.Forms.TextBox();
            this.lbSLHV = new System.Windows.Forms.Label();
            this.lbSoBuoiHoc = new System.Windows.Forms.Label();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.lbLop = new System.Windows.Forms.Label();
            this.cbbCapLop = new System.Windows.Forms.ComboBox();
            this.lbCapLop = new System.Windows.Forms.Label();
            this.cbbCTDT = new System.Windows.Forms.ComboBox();
            this.gbThemTKB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieuDe.Enabled = false;
            this.lbTieuDe.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lbTieuDe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(676, 63);
            this.lbTieuDe.TabIndex = 1;
            this.lbTieuDe.Text = "THỜI KHOÁ BIỂU";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvDSKH
            // 
            this.lvDSKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDSKH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaLich,
            this.colTenKH,
            this.colCap,
            this.colLop,
            this.colSoBuoiHoc,
            this.colSLHV,
            this.colThu,
            this.colKhungGioHoc,
            this.colPhong,
            this.colGV});
            this.lvDSKH.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDSKH.HideSelection = false;
            this.lvDSKH.Location = new System.Drawing.Point(14, 421);
            this.lvDSKH.Name = "lvDSKH";
            this.lvDSKH.Size = new System.Drawing.Size(643, 189);
            this.lvDSKH.TabIndex = 6;
            this.lvDSKH.UseCompatibleStateImageBehavior = false;
            // 
            // colMaLich
            // 
            this.colMaLich.Text = "Mã Lịch";
            this.colMaLich.Width = 100;
            // 
            // colTenKH
            // 
            this.colTenKH.Text = "Tên Khoá Học";
            this.colTenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenKH.Width = 300;
            // 
            // colCap
            // 
            this.colCap.Text = "Cấp Lớp";
            this.colCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCap.Width = 200;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            this.colLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLop.Width = 200;
            // 
            // colSoBuoiHoc
            // 
            this.colSoBuoiHoc.Text = "Số Buổi Học";
            this.colSoBuoiHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSoBuoiHoc.Width = 250;
            // 
            // colSLHV
            // 
            this.colSLHV.Text = "Số Lượng Học Viên";
            this.colSLHV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSLHV.Width = 250;
            // 
            // colThu
            // 
            this.colThu.Text = "Thứ";
            this.colThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colThu.Width = 250;
            // 
            // colKhungGioHoc
            // 
            this.colKhungGioHoc.Text = "Khung Giờ Học";
            this.colKhungGioHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colKhungGioHoc.Width = 250;
            // 
            // colPhong
            // 
            this.colPhong.Text = "Phòng";
            this.colPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPhong.Width = 150;
            // 
            // colGV
            // 
            this.colGV.Text = "Giảng Viên";
            this.colGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGV.Width = 250;
            // 
            // lbContent1
            // 
            this.lbContent1.AutoSize = true;
            this.lbContent1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbContent1.Location = new System.Drawing.Point(9, 395);
            this.lbContent1.Name = "lbContent1";
            this.lbContent1.Size = new System.Drawing.Size(308, 18);
            this.lbContent1.TabIndex = 5;
            this.lbContent1.Text = "Danh sách các khoá học đã thêm";
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.Brown;
            this.btBack.Location = new System.Drawing.Point(548, 629);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(109, 30);
            this.btBack.TabIndex = 7;
            this.btBack.Text = "Trở lại";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // gbThemTKB
            // 
            this.gbThemTKB.Controls.Add(this.lbTenCTDT);
            this.gbThemTKB.Controls.Add(this.txtMaLich);
            this.gbThemTKB.Controls.Add(this.lbMaLich);
            this.gbThemTKB.Controls.Add(this.txtTenGV);
            this.gbThemTKB.Controls.Add(this.lbTenGV);
            this.gbThemTKB.Controls.Add(this.btLuu);
            this.gbThemTKB.Controls.Add(this.btThem);
            this.gbThemTKB.Controls.Add(this.txtPhong);
            this.gbThemTKB.Controls.Add(this.lbPhong);
            this.gbThemTKB.Controls.Add(this.cbbKhungGioHoc);
            this.gbThemTKB.Controls.Add(this.lbGioHoc);
            this.gbThemTKB.Controls.Add(this.cbbThu);
            this.gbThemTKB.Controls.Add(this.lbThu);
            this.gbThemTKB.Controls.Add(this.txtSLHV);
            this.gbThemTKB.Controls.Add(this.txtSoBuoiHoc);
            this.gbThemTKB.Controls.Add(this.lbSLHV);
            this.gbThemTKB.Controls.Add(this.lbSoBuoiHoc);
            this.gbThemTKB.Controls.Add(this.cbbLop);
            this.gbThemTKB.Controls.Add(this.lbLop);
            this.gbThemTKB.Controls.Add(this.cbbCapLop);
            this.gbThemTKB.Controls.Add(this.lbCapLop);
            this.gbThemTKB.Controls.Add(this.cbbCTDT);
            this.gbThemTKB.Location = new System.Drawing.Point(14, 66);
            this.gbThemTKB.Name = "gbThemTKB";
            this.gbThemTKB.Size = new System.Drawing.Size(649, 301);
            this.gbThemTKB.TabIndex = 8;
            this.gbThemTKB.TabStop = false;
            this.gbThemTKB.Text = "Thông tin về lịch học";
            // 
            // lbTenCTDT
            // 
            this.lbTenCTDT.AutoSize = true;
            this.lbTenCTDT.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenCTDT.Location = new System.Drawing.Point(190, 26);
            this.lbTenCTDT.Name = "lbTenCTDT";
            this.lbTenCTDT.Size = new System.Drawing.Size(128, 18);
            this.lbTenCTDT.TabIndex = 25;
            this.lbTenCTDT.Text = "Tên Khoá Học";
            // 
            // txtMaLich
            // 
            this.txtMaLich.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLich.Location = new System.Drawing.Point(6, 47);
            this.txtMaLich.Name = "txtMaLich";
            this.txtMaLich.Size = new System.Drawing.Size(148, 26);
            this.txtMaLich.TabIndex = 24;
            // 
            // lbMaLich
            // 
            this.lbMaLich.AutoSize = true;
            this.lbMaLich.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLich.Location = new System.Drawing.Point(6, 26);
            this.lbMaLich.Name = "lbMaLich";
            this.lbMaLich.Size = new System.Drawing.Size(78, 18);
            this.lbMaLich.TabIndex = 23;
            this.lbMaLich.Text = "Mã Lịch";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGV.Location = new System.Drawing.Point(160, 84);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(208, 26);
            this.txtTenGV.TabIndex = 22;
            // 
            // lbTenGV
            // 
            this.lbTenGV.AutoSize = true;
            this.lbTenGV.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenGV.Location = new System.Drawing.Point(6, 92);
            this.lbTenGV.Name = "lbTenGV";
            this.lbTenGV.Size = new System.Drawing.Size(148, 18);
            this.lbTenGV.TabIndex = 21;
            this.lbTenGV.Text = "Tên giảng viên";
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.ForeColor = System.Drawing.Color.Brown;
            this.btLuu.Location = new System.Drawing.Point(528, 265);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(109, 30);
            this.btLuu.TabIndex = 20;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Brown;
            this.btThem.Location = new System.Drawing.Point(386, 265);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(109, 30);
            this.btThem.TabIndex = 19;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtPhong
            // 
            this.txtPhong.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhong.Location = new System.Drawing.Point(492, 209);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(137, 26);
            this.txtPhong.TabIndex = 18;
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhong.Location = new System.Drawing.Point(388, 212);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(98, 18);
            this.lbPhong.TabIndex = 17;
            this.lbPhong.Text = "Phòng học";
            // 
            // cbbKhungGioHoc
            // 
            this.cbbKhungGioHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhungGioHoc.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhungGioHoc.FormattingEnabled = true;
            this.cbbKhungGioHoc.Location = new System.Drawing.Point(160, 209);
            this.cbbKhungGioHoc.Name = "cbbKhungGioHoc";
            this.cbbKhungGioHoc.Size = new System.Drawing.Size(187, 26);
            this.cbbKhungGioHoc.TabIndex = 16;
            // 
            // lbGioHoc
            // 
            this.lbGioHoc.AutoSize = true;
            this.lbGioHoc.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioHoc.Location = new System.Drawing.Point(6, 212);
            this.lbGioHoc.Name = "lbGioHoc";
            this.lbGioHoc.Size = new System.Drawing.Size(138, 18);
            this.lbGioHoc.TabIndex = 15;
            this.lbGioHoc.Text = "Khung giờ học";
            // 
            // cbbThu
            // 
            this.cbbThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThu.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThu.FormattingEnabled = true;
            this.cbbThu.Location = new System.Drawing.Point(160, 165);
            this.cbbThu.Name = "cbbThu";
            this.cbbThu.Size = new System.Drawing.Size(187, 26);
            this.cbbThu.TabIndex = 14;
            // 
            // lbThu
            // 
            this.lbThu.AutoSize = true;
            this.lbThu.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThu.Location = new System.Drawing.Point(6, 168);
            this.lbThu.Name = "lbThu";
            this.lbThu.Size = new System.Drawing.Size(38, 18);
            this.lbThu.TabIndex = 13;
            this.lbThu.Text = "Thứ";
            // 
            // txtSLHV
            // 
            this.txtSLHV.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLHV.Location = new System.Drawing.Point(501, 125);
            this.txtSLHV.Name = "txtSLHV";
            this.txtSLHV.Size = new System.Drawing.Size(128, 26);
            this.txtSLHV.TabIndex = 12;
            this.txtSLHV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoBuoiHoc_KeyPress);
            // 
            // txtSoBuoiHoc
            // 
            this.txtSoBuoiHoc.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoBuoiHoc.Location = new System.Drawing.Point(160, 125);
            this.txtSoBuoiHoc.Name = "txtSoBuoiHoc";
            this.txtSoBuoiHoc.Size = new System.Drawing.Size(108, 26);
            this.txtSoBuoiHoc.TabIndex = 11;
            this.txtSoBuoiHoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoBuoiHoc_KeyPress);
            // 
            // lbSLHV
            // 
            this.lbSLHV.AutoSize = true;
            this.lbSLHV.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLHV.Location = new System.Drawing.Point(317, 128);
            this.lbSLHV.Name = "lbSLHV";
            this.lbSLHV.Size = new System.Drawing.Size(178, 18);
            this.lbSLHV.TabIndex = 10;
            this.lbSLHV.Text = "Số lượng học viên";
            // 
            // lbSoBuoiHoc
            // 
            this.lbSoBuoiHoc.AutoSize = true;
            this.lbSoBuoiHoc.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoBuoiHoc.Location = new System.Drawing.Point(6, 128);
            this.lbSoBuoiHoc.Name = "lbSoBuoiHoc";
            this.lbSoBuoiHoc.Size = new System.Drawing.Size(118, 18);
            this.lbSoBuoiHoc.TabIndex = 8;
            this.lbSoBuoiHoc.Text = "Số buổi học";
            // 
            // cbbLop
            // 
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(537, 84);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(92, 26);
            this.cbbLop.TabIndex = 7;
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.Location = new System.Drawing.Point(493, 84);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(38, 18);
            this.lbLop.TabIndex = 6;
            this.lbLop.Text = "Lớp";
            // 
            // cbbCapLop
            // 
            this.cbbCapLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCapLop.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCapLop.FormattingEnabled = true;
            this.cbbCapLop.Location = new System.Drawing.Point(496, 47);
            this.cbbCapLop.Name = "cbbCapLop";
            this.cbbCapLop.Size = new System.Drawing.Size(133, 26);
            this.cbbCapLop.TabIndex = 5;
            this.cbbCapLop.SelectedIndexChanged += new System.EventHandler(this.cbbCapLop_SelectedIndexChanged);
            // 
            // lbCapLop
            // 
            this.lbCapLop.AutoSize = true;
            this.lbCapLop.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapLop.Location = new System.Drawing.Point(493, 26);
            this.lbCapLop.Name = "lbCapLop";
            this.lbCapLop.Size = new System.Drawing.Size(78, 18);
            this.lbCapLop.TabIndex = 4;
            this.lbCapLop.Text = "Cấp lớp";
            // 
            // cbbCTDT
            // 
            this.cbbCTDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCTDT.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCTDT.FormattingEnabled = true;
            this.cbbCTDT.Location = new System.Drawing.Point(193, 47);
            this.cbbCTDT.Name = "cbbCTDT";
            this.cbbCTDT.Size = new System.Drawing.Size(248, 26);
            this.cbbCTDT.TabIndex = 3;
            this.cbbCTDT.SelectedIndexChanged += new System.EventHandler(this.cbbCTDT_SelectedIndexChanged);
            // 
            // ThemTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(676, 671);
            this.Controls.Add(this.gbThemTKB);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.lvDSKH);
            this.Controls.Add(this.lbContent1);
            this.Controls.Add(this.lbTieuDe);
            this.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ThemTKB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm TKB";
            this.Load += new System.EventHandler(this.ThemTKB_Load);
            this.gbThemTKB.ResumeLayout(false);
            this.gbThemTKB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.ListView lvDSKH;
        private System.Windows.Forms.Label lbContent1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.GroupBox gbThemTKB;
        private System.Windows.Forms.ComboBox cbbCapLop;
        private System.Windows.Forms.Label lbCapLop;
        private System.Windows.Forms.ComboBox cbbCTDT;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbSLHV;
        private System.Windows.Forms.Label lbSoBuoiHoc;
        private System.Windows.Forms.TextBox txtSLHV;
        private System.Windows.Forms.TextBox txtSoBuoiHoc;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.ComboBox cbbKhungGioHoc;
        private System.Windows.Forms.Label lbGioHoc;
        private System.Windows.Forms.ComboBox cbbThu;
        private System.Windows.Forms.Label lbThu;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ColumnHeader colMaLich;
        private System.Windows.Forms.ColumnHeader colTenKH;
        private System.Windows.Forms.ColumnHeader colCap;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.ColumnHeader colSoBuoiHoc;
        private System.Windows.Forms.ColumnHeader colSLHV;
        private System.Windows.Forms.ColumnHeader colThu;
        private System.Windows.Forms.ColumnHeader colKhungGioHoc;
        private System.Windows.Forms.ColumnHeader colPhong;
        private System.Windows.Forms.ColumnHeader colGV;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label lbTenGV;
        private System.Windows.Forms.TextBox txtMaLich;
        private System.Windows.Forms.Label lbMaLich;
        private System.Windows.Forms.Label lbTenCTDT;
    }
}