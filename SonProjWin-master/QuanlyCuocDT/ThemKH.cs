using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanlyCuocDT.Dao;
using QuanlyCuocDT.Model;

namespace QuanlyCuocDT
{
    public partial class ThemKH : DevExpress.XtraEditors.XtraForm
    {
        Khachhangdao khachhangdao = new Khachhangdao();
        public ThemKH()
        {
            InitializeComponent();
            set();
        }
        public void set()
        {
            
            txtMaKH.Text = khachhangdao.getlastnhanvien();
        }
        public void themkh()
        {
            if(txtTenKH.Text=="" || txtCMND.Text== "" || txtDiachi.Text== "" || txtChucvu.Text == "" || txtNghenghiep.Text=="")
            {
                XtraMessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = txtMaKH.Text;
                kh.TenKH = txtTenKH.Text;
                kh.CMND = txtCMND.Text;
                kh.DiaChi = txtDiachi.Text;
                kh.ChucVu = txtChucvu.Text;
                kh.NgheNghiep = txtNghenghiep.Text;
                kh.Flag = true;
                khachhangdao.themkh(kh);
                XtraMessageBox.Show("Thêm thành công");
            }
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            themkh();
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}