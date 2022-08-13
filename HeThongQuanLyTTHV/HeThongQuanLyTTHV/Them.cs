﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HeThongQuanLyTTHV;


namespace HeThongQuanLyTTHV
{
    public partial class Them : Form
    {
        
        public Them()
        {
            InitializeComponent();
        }
        
        private void Them_Load(object sender, EventArgs e)
        {
            
            //ĐN columns listview
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns[0].Width = (int)(listView1.Width * 0.09);
            listView1.Columns[1].Width = (int)(listView1.Width * 0.12);
            listView1.Columns[2].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[3].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[4].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[5].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[6].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[7].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[8].Width = (int)(listView1.Width * 0.08);
            listView1.Columns[9].Width = (int)(listView1.Width * 0.1);
            listView1.Columns[10].Width = (int)(listView1.Width * 0.1);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            int cccd,diem,sdt;
            ListViewItem item = new ListViewItem();
            //Xử lý không điền đủ thông tin
            try
            {
                if (string.IsNullOrEmpty(txtMaPhieu.Text) || string.IsNullOrEmpty(txtHoTen.Text)
                       || string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtDiem.Text)
                       || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtLop.Text)
                       || string.IsNullOrEmpty(txtKhoa.Text) || string.IsNullOrEmpty(txtCap.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                else
                {
                    // Thêm Items

                    if (txtMaPhieu.Text != "")
                    {
                        cccd = int.Parse(txtCCCD.Text);
                        diem = int.Parse(txtDiem.Text);
                        sdt = int.Parse(txtSDT.Text);
                        item = new ListViewItem(txtMaPhieu.Text);
                        item.SubItems.Add(txtHoTen.Text);
                        item.SubItems.Add(txtCCCD.Text);
                        item.SubItems.Add(txtCap.Text);
                        item.SubItems.Add(txtKhoa.Text);
                        item.SubItems.Add(txtLop.Text);
                        item.SubItems.Add(txtSDT.Text);
                        item.SubItems.Add(dtNgaySinh.Value.ToShortDateString());
                        item.SubItems.Add(txtDiem.Text);
                        item.SubItems.Add(rbNam.Checked ? "Nam" : "Nữ");
                        item.SubItems.Add(txtGhiChu.Text);

                        listView1.Items.Add(item);
                        txtMaPhieu.Text = "";
                        txtCCCD.Text = "";
                        txtMaPhieu.Focus();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("CCCD, SĐT, Điểm nhập số!");
            }
        }
        
        private void btLuu_Click(object sender, EventArgs e)
        {
            MaPhieu = new PhieuKetQua(); 
            //for (int i = 0; i < listView1.Items.Count; i++)
            //{
            //    ChinhSua.maPhieu[i] = listView1.Items[i].SubItems[0].Text;
            //    ChinhSua.hoTen[i] = listView1.Items[i].SubItems[1].Text;
            //    ChinhSua.cCCD[i] = int.Parse(listView1.Items[i].SubItems[2].Text);
            //    ChinhSua.capHoc[i] = listView1.Items[i].SubItems[3].Text;
            //    ChinhSua.khoaHoc[i] = listView1.Items[i].SubItems[4].Text;
            //    ChinhSua.lop[i] = listView1.Items[i].SubItems[5].Text;
            //    ChinhSua.sDT[i] = int.Parse(listView1.Items[i].SubItems[6].Text);
            //    ChinhSua.ngaySinh[i] = listView1.Items[i].SubItems[7].Text;
            //    ChinhSua.diem[i]= int.Parse(listView1.Items[i].SubItems[8].Text);
            //    ChinhSua.gioiTinh[i] = listView1.Items[i].SubItems[9].Text;
            //    ChinhSua.ghiChu[i] = listView1.Items[i].SubItems[10].Text;
            //}
        }

        private void btTroLai_Click(object sender, EventArgs e)
        {
            DSKQHT f=new DSKQHT();
            f.ShowDialog();
            Application.Exit(); 
        }
    }
}

