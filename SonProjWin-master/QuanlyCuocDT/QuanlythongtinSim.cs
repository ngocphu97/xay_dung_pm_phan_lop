﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using QuanlyCuocDT.Dao;
using QuanlyCuocDT.Model;

namespace QuanlyCuocDT
{
    public partial class QuanlythongtinSim : DevExpress.XtraEditors.XtraUserControl
    {
        QLCuocDTContext db = new QLCuocDTContext();
        public QuanlythongtinSim()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            QuanlyCuocDT.Model.QLCuocDTContext dbContext = new QuanlyCuocDT.Model.QLCuocDTContext();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.ThongTinSIMs.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.ThongTinSIMs.Where(p => p.Flag == true).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            loadcombo();
        }

        public void loadcombo()
        {
            var a = ThongtinSimDao.load();
            foreach(var i in a)
            {
                cboMaKH.Properties.Items.Add(i.MaKH);
            }
        }


        public void loadlai()
        {
            QuanlyCuocDT.Model.QLCuocDTContext dbContext = new QuanlyCuocDT.Model.QLCuocDTContext();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.ThongTinSIMs.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.ThongTinSIMs.Where(p => p.Flag == true).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtIDSIM.Text = gridView1.GetFocusedRowCellValue(colIDSIM).ToString();
            cboMaKH.Text = gridView1.GetFocusedRowCellValue(colMaKH).ToString();
            txtSDT.Text = gridView1.GetFocusedRowCellValue(colSoDienThoai).ToString();
            dtmNgayđangki.Text = gridView1.GetFocusedRowCellValue(colNgayDangKy).ToString();
            dtmNgayhethan.Text = gridView1.GetFocusedRowCellValue(colNgayHetHan).ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtSDT.Text == null || cboMaKH ==null || dtmNgayđangki.Text==null|| dtmNgayhethan.Text== null)
            {
                XtraMessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                ThongtinSimDao ttsim = new ThongtinSimDao();

                ttsim.suaidsim(txtIDSIM.Text, txtSDT.Text, cboMaKH.Text, dtmNgayđangki.DateTime, dtmNgayhethan.DateTime);
                XtraMessageBox.Show("Sửa thành công");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            loadlai();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            ThemIDSim t = new ThemIDSim();
            t.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Xác nhận", "Bạn thực sự muốn xóa?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string dongdangchon = gridView1.GetFocusedRowCellValue(colIDSIM).ToString();
                if (dongdangchon == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn dòng!!");
                }
                else
                {
                    var kh = db.ThongTinSIMs.Find(dongdangchon);
                    kh.Flag = false;
                    db.SaveChanges();
                    XtraMessageBox.Show("Đã xóa thành công!!");
                    loadlai();
                }
            }
        }
    }
}
