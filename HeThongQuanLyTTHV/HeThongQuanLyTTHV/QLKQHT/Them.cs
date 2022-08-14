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


namespace HeThongQuanLyTTHV.QLKQHT
{
    public partial class Them : Form
    {
        
        public Them()
        {
            InitializeComponent();
        }

        string dsP = Application.StartupPath + @"DSP.txt";

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
                cccd = int.Parse(txtCCCD.Text);
                diem = int.Parse(txtDiem.Text);
                sdt = int.Parse(txtSDT.Text);
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

                    if (listView1.Items.Count == 0)
                    {
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
                    else
                    {
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
            
        }

        private void btTroLai_Click(object sender, EventArgs e)
        {
            DSKQHT f=new DSKQHT();
            f.ShowDialog();
            Application.Exit(); 
        }
    }
}
