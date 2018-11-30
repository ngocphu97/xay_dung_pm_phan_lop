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
    public partial class ThemHDDK : DevExpress.XtraEditors.XtraForm
    {
        public ThemHDDK()
        {
            InitializeComponent();
            setma();
            setcombo();
        }
        public void setma()
        {
            HDDKDao a = new HDDKDao();
            txtMahddk.Text = a.getlastnhanvien();
        }
        public void setcombo()
        {
            HDDKDao a = new HDDKDao();
            var b = a.load();
            foreach (var i in b)
            {
                cboIDSIM.Properties.Items.Add(i.IDSIM);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(cboIDSIM.Text==null)
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                HDDKDao a = new HDDKDao();
                HoaDonDangKy hddk = new HoaDonDangKy();
                hddk.MaHDDK = txtMahddk.Text;
                hddk.IDSIM = cboIDSIM.Text;
                hddk.ChiPhiDangKy = 50000;
                hddk.Flag = true;
                a.themhd(hddk);
                XtraMessageBox.Show("Thêm thành công");
                this.Close();
            }
            
        }
    }
}