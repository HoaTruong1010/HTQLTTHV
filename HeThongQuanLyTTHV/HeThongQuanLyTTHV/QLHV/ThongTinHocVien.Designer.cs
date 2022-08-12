
namespace HeThongQuanLyTTHV.QLHV
{
    partial class ThongTinHocVien
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbTTHV = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.gbHoc = new System.Windows.Forms.GroupBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbCapHoc = new System.Windows.Forms.ComboBox();
            this.cbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbCapHoc = new System.Windows.Forms.Label();
            this.lbKhoaHoc = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.gbTTHV.SuspendLayout();
            this.gbHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Brown;
            this.lbTitle.Location = new System.Drawing.Point(1, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(962, 90);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "THÔNG TIN HỌC VIÊN";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTTHV
            // 
            this.gbTTHV.Controls.Add(this.dtpDOB);
            this.gbTTHV.Controls.Add(this.rdFemale);
            this.gbTTHV.Controls.Add(this.rdMale);
            this.gbTTHV.Controls.Add(this.txtAdress);
            this.gbTTHV.Controls.Add(this.txtPhone);
            this.gbTTHV.Controls.Add(this.txtName);
            this.gbTTHV.Controls.Add(this.lbName);
            this.gbTTHV.Controls.Add(this.txtEmail);
            this.gbTTHV.Controls.Add(this.txtID);
            this.gbTTHV.Controls.Add(this.lbPhone);
            this.gbTTHV.Controls.Add(this.lbGender);
            this.gbTTHV.Controls.Add(this.lbEmail);
            this.gbTTHV.Controls.Add(this.lbAdress);
            this.gbTTHV.Controls.Add(this.lbID);
            this.gbTTHV.Controls.Add(this.lbDOB);
            this.gbTTHV.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTTHV.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbTTHV.Location = new System.Drawing.Point(72, 97);
            this.gbTTHV.Name = "gbTTHV";
            this.gbTTHV.Size = new System.Drawing.Size(816, 355);
            this.gbTTHV.TabIndex = 2;
            this.gbTTHV.TabStop = false;
            this.gbTTHV.Text = "Thông tin cá nhân";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(232, 135);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(191, 32);
            this.dtpDOB.TabIndex = 4;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemale.Location = new System.Drawing.Point(707, 137);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(57, 28);
            this.rdFemale.TabIndex = 3;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Nữ";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMale.Location = new System.Drawing.Point(626, 138);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(70, 28);
            this.rdMale.TabIndex = 3;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Nam";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.Location = new System.Drawing.Point(232, 293);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(529, 32);
            this.txtAdress.TabIndex = 2;
            this.txtAdress.TabStop = false;
            this.txtAdress.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(232, 241);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(529, 32);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.TabStop = false;
            this.txtPhone.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(232, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(529, 32);
            this.txtName.TabIndex = 2;
            this.txtName.TabStop = false;
            this.txtName.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(35, 94);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(140, 24);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Họ và tên:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(232, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(529, 32);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TabStop = false;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(232, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(529, 32);
            this.txtID.TabIndex = 2;
            this.txtID.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(35, 247);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(192, 24);
            this.lbPhone.TabIndex = 1;
            this.lbPhone.Text = "Số điện thoại:";
            this.lbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(474, 139);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(140, 24);
            this.lbGender.TabIndex = 1;
            this.lbGender.Text = "Giới tính:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(35, 196);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(88, 24);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email:";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdress.Location = new System.Drawing.Point(35, 297);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(114, 24);
            this.lbAdress.TabIndex = 1;
            this.lbAdress.Text = "Địa chỉ:";
            this.lbAdress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(35, 47);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(140, 24);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "CMND/CCCD:";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDOB.Location = new System.Drawing.Point(35, 141);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(140, 24);
            this.lbDOB.TabIndex = 1;
            this.lbDOB.Text = "Ngày sinh:";
            this.lbDOB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbHoc
            // 
            this.gbHoc.Controls.Add(this.cbLop);
            this.gbHoc.Controls.Add(this.cbCapHoc);
            this.gbHoc.Controls.Add(this.cbKhoaHoc);
            this.gbHoc.Controls.Add(this.lbLop);
            this.gbHoc.Controls.Add(this.lbCapHoc);
            this.gbHoc.Controls.Add(this.lbKhoaHoc);
            this.gbHoc.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHoc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbHoc.Location = new System.Drawing.Point(72, 473);
            this.gbHoc.Name = "gbHoc";
            this.gbHoc.Size = new System.Drawing.Size(559, 205);
            this.gbHoc.TabIndex = 3;
            this.gbHoc.TabStop = false;
            this.gbHoc.Text = "Thông tin khóa học";
            // 
            // cbLop
            // 
            this.cbLop.DropDownHeight = 75;
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.DropDownWidth = 244;
            this.cbLop.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.IntegralHeight = false;
            this.cbLop.Items.AddRange(new object[] {
            "K20C1L1",
            "K20C1L2",
            "K20C2L1",
            "K20C2L2",
            "K20C3L1",
            "K20C3L2",
            "K21C1L1",
            "K21C1L2",
            "K21C2L1",
            "K21C2L2",
            "K21C3L1",
            "K21C3L2",
            "K22C1L1",
            "K22C1L2",
            "K22C2L1",
            "K22C2L2",
            "K22C3L1",
            "K22C3L2"});
            this.cbLop.Location = new System.Drawing.Point(223, 149);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(244, 32);
            this.cbLop.TabIndex = 2;
            // 
            // cbCapHoc
            // 
            this.cbCapHoc.DropDownHeight = 75;
            this.cbCapHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCapHoc.DropDownWidth = 244;
            this.cbCapHoc.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCapHoc.FormattingEnabled = true;
            this.cbCapHoc.IntegralHeight = false;
            this.cbCapHoc.Items.AddRange(new object[] {
            "K20C1",
            "K20C2",
            "K20C3",
            "K21C1",
            "K21C2",
            "K22C1",
            "K22C2"});
            this.cbCapHoc.Location = new System.Drawing.Point(223, 98);
            this.cbCapHoc.Name = "cbCapHoc";
            this.cbCapHoc.Size = new System.Drawing.Size(244, 32);
            this.cbCapHoc.TabIndex = 2;
            // 
            // cbKhoaHoc
            // 
            this.cbKhoaHoc.DropDownHeight = 50;
            this.cbKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoaHoc.DropDownWidth = 75;
            this.cbKhoaHoc.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoaHoc.FormattingEnabled = true;
            this.cbKhoaHoc.IntegralHeight = false;
            this.cbKhoaHoc.Items.AddRange(new object[] {
            "Khóa 2020",
            "Khóa 2021",
            "Khóa 2022"});
            this.cbKhoaHoc.Location = new System.Drawing.Point(223, 49);
            this.cbKhoaHoc.Name = "cbKhoaHoc";
            this.cbKhoaHoc.Size = new System.Drawing.Size(244, 32);
            this.cbKhoaHoc.TabIndex = 2;
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.Location = new System.Drawing.Point(64, 157);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(114, 24);
            this.lbLop.TabIndex = 1;
            this.lbLop.Text = "Lớp học:";
            this.lbLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCapHoc
            // 
            this.lbCapHoc.AutoSize = true;
            this.lbCapHoc.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapHoc.Location = new System.Drawing.Point(64, 106);
            this.lbCapHoc.Name = "lbCapHoc";
            this.lbCapHoc.Size = new System.Drawing.Size(114, 24);
            this.lbCapHoc.TabIndex = 1;
            this.lbCapHoc.Text = "Cấp học:";
            this.lbCapHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbKhoaHoc
            // 
            this.lbKhoaHoc.AutoSize = true;
            this.lbKhoaHoc.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoaHoc.Location = new System.Drawing.Point(64, 57);
            this.lbKhoaHoc.Name = "lbKhoaHoc";
            this.lbKhoaHoc.Size = new System.Drawing.Size(127, 24);
            this.lbKhoaHoc.TabIndex = 1;
            this.lbKhoaHoc.Text = "Khóa học:";
            this.lbKhoaHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btExit
            // 
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(339, 716);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(107, 55);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btSave
            // 
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(522, 716);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(107, 55);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ThongTinHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(962, 810);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.gbHoc);
            this.Controls.Add(this.gbTTHV);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "ThongTinHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin học viên";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ThemHocVien_Load);
            this.gbTTHV.ResumeLayout(false);
            this.gbTTHV.PerformLayout();
            this.gbHoc.ResumeLayout(false);
            this.gbHoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbTTHV;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox gbHoc;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbCapHoc;
        private System.Windows.Forms.ComboBox cbKhoaHoc;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbCapHoc;
        private System.Windows.Forms.Label lbKhoaHoc;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btSave;
    }
}