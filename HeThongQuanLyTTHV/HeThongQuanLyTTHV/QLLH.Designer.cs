﻿
namespace HeThongQuanLyTTHV
{
    partial class QLLH
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
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.btThongBaoLichNghi = new System.Windows.Forms.Button();
            this.btThongBaoTKB = new System.Windows.Forms.Button();
            this.btChinhTKB = new System.Windows.Forms.Button();
            this.btXemTKB = new System.Windows.Forms.Button();
            this.btThemTKB = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.gbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieuDe.Enabled = false;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(802, 90);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "QUẢN LÝ LỊCH HỌC";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbChucNang
            // 
            this.gbChucNang.Controls.Add(this.btThongBaoLichNghi);
            this.gbChucNang.Controls.Add(this.btThongBaoTKB);
            this.gbChucNang.Controls.Add(this.btChinhTKB);
            this.gbChucNang.Controls.Add(this.btXemTKB);
            this.gbChucNang.Controls.Add(this.btThemTKB);
            this.gbChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChucNang.Location = new System.Drawing.Point(11, 96);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Size = new System.Drawing.Size(784, 190);
            this.gbChucNang.TabIndex = 1;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chọn Chức Năng";
            // 
            // btThongBaoLichNghi
            // 
            this.btThongBaoLichNghi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThongBaoLichNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongBaoLichNghi.Location = new System.Drawing.Point(629, 60);
            this.btThongBaoLichNghi.Name = "btThongBaoLichNghi";
            this.btThongBaoLichNghi.Size = new System.Drawing.Size(141, 86);
            this.btThongBaoLichNghi.TabIndex = 0;
            this.btThongBaoLichNghi.Text = "Thông báo lịch nghỉ";
            this.btThongBaoLichNghi.UseVisualStyleBackColor = false;
            this.btThongBaoLichNghi.Click += new System.EventHandler(this.btThemTKB_Click);
            // 
            // btThongBaoTKB
            // 
            this.btThongBaoTKB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThongBaoTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongBaoTKB.Location = new System.Drawing.Point(475, 60);
            this.btThongBaoTKB.Name = "btThongBaoTKB";
            this.btThongBaoTKB.Size = new System.Drawing.Size(141, 86);
            this.btThongBaoTKB.TabIndex = 0;
            this.btThongBaoTKB.Text = "Thông báo TKB";
            this.btThongBaoTKB.UseVisualStyleBackColor = false;
            this.btThongBaoTKB.Click += new System.EventHandler(this.btThemTKB_Click);
            // 
            // btChinhTKB
            // 
            this.btChinhTKB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btChinhTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChinhTKB.Location = new System.Drawing.Point(317, 60);
            this.btChinhTKB.Name = "btChinhTKB";
            this.btChinhTKB.Size = new System.Drawing.Size(141, 86);
            this.btChinhTKB.TabIndex = 0;
            this.btChinhTKB.Text = "Chỉnh sửa TKB";
            this.btChinhTKB.UseVisualStyleBackColor = false;
            this.btChinhTKB.Click += new System.EventHandler(this.btThemTKB_Click);
            // 
            // btXemTKB
            // 
            this.btXemTKB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btXemTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemTKB.Location = new System.Drawing.Point(161, 60);
            this.btXemTKB.Name = "btXemTKB";
            this.btXemTKB.Size = new System.Drawing.Size(141, 86);
            this.btXemTKB.TabIndex = 0;
            this.btXemTKB.Text = "Xem TKB";
            this.btXemTKB.UseVisualStyleBackColor = false;
            this.btXemTKB.Click += new System.EventHandler(this.btThemTKB_Click);
            // 
            // btThemTKB
            // 
            this.btThemTKB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThemTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemTKB.Location = new System.Drawing.Point(6, 60);
            this.btThemTKB.Name = "btThemTKB";
            this.btThemTKB.Size = new System.Drawing.Size(141, 86);
            this.btThemTKB.TabIndex = 0;
            this.btThemTKB.Text = "Thêm TKB";
            this.btThemTKB.UseVisualStyleBackColor = false;
            this.btThemTKB.Click += new System.EventHandler(this.btThemTKB_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(680, 293);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(101, 51);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // QLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 356);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.gbChucNang);
            this.Controls.Add(this.lbTieuDe);
            this.Name = "QLLH";
            this.Text = "Quản lý lịch học";
            this.gbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.GroupBox gbChucNang;
        private System.Windows.Forms.Button btChinhTKB;
        private System.Windows.Forms.Button btXemTKB;
        private System.Windows.Forms.Button btThemTKB;
        private System.Windows.Forms.Button btThongBaoLichNghi;
        private System.Windows.Forms.Button btThongBaoTKB;
        private System.Windows.Forms.Button btThoat;
    }
}
