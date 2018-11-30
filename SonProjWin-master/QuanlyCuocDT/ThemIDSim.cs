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
    public partial class ThemIDSim : DevExpress.XtraEditors.XtraForm
    {
        public ThemIDSim()
        {
            InitializeComponent();
            txtIDSIM.Text = ThongtinSimDao.getlastnhanvien();
            loadcombo();
        }

        public void loadcombo()
        {
            var a = ThongtinSimDao.load();
            foreach (var i in a)
            {
                cboMaKH.Properties.Items.Add(i.MaKH);
            }
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text == null || cboMaKH == null || dtmNgayđangki.Text == null || dtmNgayhethan.Text == null)
            {
                XtraMessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                ThongTinSIM ttsim = new ThongTinSIM();
                ttsim.IDSIM = txtIDSIM.Text;
                ttsim.SoDienThoai = txtSDT.Text;
                ttsim.MaKH = cboMaKH.Text;
                ttsim.NgayDangKy = dtmNgayđangki.DateTime;
                ttsim.NgayHetHan = dtmNgayhethan.DateTime;
                ttsim.Flag = true;
                ThongtinSimDao a = new ThongtinSimDao();
                a.themidsim(ttsim);
                XtraMessageBox.Show("Thêm thành công");
                this.Close();
            }
        }
    }
}