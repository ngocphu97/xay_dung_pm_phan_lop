using QuanLyBaoHiem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanlyCuocDT
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }
        private void AddTabControl(UserControl userControl, string itemTabName, string icon)
        {
            bool isExist = false;
            int soluong = xtraTabControl1.TabPages.Count;
            if (soluong != 0)
            {
                xtraTabControl1.TabPages.RemoveAt(soluong - 1);
            }

            if (isExist == false)
            {
                AddTab addTab = new AddTab();
                addTab.AddTabControl(xtraTabControl1, itemTabName, icon, userControl);
            }


        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuanlyKhachhang quanlykh = new QuanlyKhachhang();
            AddTabControl(quanlykh, "Quản lý khách hàng", "");
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuanlythongtinSim quanlythongtinsim = new QuanlythongtinSim();
            AddTabControl(quanlythongtinsim, "Quản lý thông tin Sim", "");
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuanlyHDDangki quanlythongtinsim = new QuanlyHDDangki();
            AddTabControl(quanlythongtinsim, "Quản lý hóa đơn đăng kí", "");
        }
    }
}
