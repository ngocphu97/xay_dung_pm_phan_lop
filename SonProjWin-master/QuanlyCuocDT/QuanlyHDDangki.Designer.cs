namespace QuanlyCuocDT
{
    partial class QuanlyHDDangki
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanlyHDDangki));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMahddk = new DevExpress.XtraEditors.TextEdit();
            this.txtchiphithanhtoan = new DevExpress.XtraEditors.TextEdit();
            this.cboIDSIM = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHDDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDSIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiPhiDangKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThongTinSIM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMahddk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchiphithanhtoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIDSIM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton5);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtMahddk);
            this.groupControl1.Controls.Add(this.txtchiphithanhtoan);
            this.groupControl1.Controls.Add(this.cboIDSIM);
            this.groupControl1.Location = new System.Drawing.Point(227, 23);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(870, 247);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Điền các thông tin";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Location = new System.Drawing.Point(725, 204);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(93, 32);
            this.simpleButton5.TabIndex = 34;
            this.simpleButton5.Text = "Hủy bỏ";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Location = new System.Drawing.Point(528, 204);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 32);
            this.btnLuu.TabIndex = 33;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(124, 73);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(20, 36);
            this.labelControl13.TabIndex = 23;
            this.labelControl13.Text = "(*)\r\n\r\n";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(50, 215);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(263, 17);
            this.labelControl11.TabIndex = 22;
            this.labelControl11.Text = ": Vui lòng Nhập những Thông Tin bắt buộc";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(27, 215);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(18, 34);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "(*)\r\n\r\n";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(454, 42);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(104, 16);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Chi phí thanh toán";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(27, 75);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 16);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "IDSIM";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 43);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 16);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Mã Hóa đơn đăng kí";
            // 
            // txtMahddk
            // 
            this.txtMahddk.Enabled = false;
            this.txtMahddk.Location = new System.Drawing.Point(149, 40);
            this.txtMahddk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMahddk.Name = "txtMahddk";
            this.txtMahddk.Size = new System.Drawing.Size(251, 22);
            this.txtMahddk.TabIndex = 0;
            // 
            // txtchiphithanhtoan
            // 
            this.txtchiphithanhtoan.Enabled = false;
            this.txtchiphithanhtoan.Location = new System.Drawing.Point(570, 38);
            this.txtchiphithanhtoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtchiphithanhtoan.Name = "txtchiphithanhtoan";
            this.txtchiphithanhtoan.Size = new System.Drawing.Size(251, 22);
            this.txtchiphithanhtoan.TabIndex = 6;
            // 
            // cboIDSIM
            // 
            this.cboIDSIM.Location = new System.Drawing.Point(149, 73);
            this.cboIDSIM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboIDSIM.Name = "cboIDSIM";
            this.cboIDSIM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIDSIM.Size = new System.Drawing.Size(251, 22);
            this.cboIDSIM.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnXoa);
            this.groupControl2.Controls.Add(this.btnUpdate);
            this.groupControl2.Controls.Add(this.btnThemNV);
            this.groupControl2.Location = new System.Drawing.Point(13, 23);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(175, 247);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(23, 172);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 44);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(23, 111);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 44);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Refresh";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.Appearance.Options.UseFont = true;
            this.btnThemNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNV.ImageOptions.Image")));
            this.btnThemNV.Location = new System.Drawing.Point(23, 49);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(128, 44);
            this.btnThemNV.TabIndex = 0;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(QuanlyCuocDT.Model.HoaDonDangKy);
            this.gridControl1.Location = new System.Drawing.Point(13, 279);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1084, 287);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHDDK,
            this.colIDSIM,
            this.colChiPhiDangKy,
            this.colFlag,
            this.colThongTinSIM});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMaHDDK
            // 
            this.colMaHDDK.Caption = "Mã hợp đồng đăng ký";
            this.colMaHDDK.FieldName = "MaHDDK";
            this.colMaHDDK.Name = "colMaHDDK";
            this.colMaHDDK.Visible = true;
            this.colMaHDDK.VisibleIndex = 0;
            // 
            // colIDSIM
            // 
            this.colIDSIM.Caption = "IDSIM";
            this.colIDSIM.FieldName = "IDSIM";
            this.colIDSIM.Name = "colIDSIM";
            this.colIDSIM.Visible = true;
            this.colIDSIM.VisibleIndex = 1;
            // 
            // colChiPhiDangKy
            // 
            this.colChiPhiDangKy.Caption = "Chi phí đăng kí";
            this.colChiPhiDangKy.FieldName = "ChiPhiDangKy";
            this.colChiPhiDangKy.Name = "colChiPhiDangKy";
            this.colChiPhiDangKy.Visible = true;
            this.colChiPhiDangKy.VisibleIndex = 2;
            // 
            // colFlag
            // 
            this.colFlag.FieldName = "Flag";
            this.colFlag.Name = "colFlag";
            // 
            // colThongTinSIM
            // 
            this.colThongTinSIM.FieldName = "ThongTinSIM";
            this.colThongTinSIM.Name = "colThongTinSIM";
            // 
            // QuanlyHDDangki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "QuanlyHDDangki";
            this.Size = new System.Drawing.Size(1124, 569);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMahddk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchiphithanhtoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIDSIM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMahddk;
        private DevExpress.XtraEditors.TextEdit txtchiphithanhtoan;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnThemNV;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHDDK;
        private DevExpress.XtraGrid.Columns.GridColumn colIDSIM;
        private DevExpress.XtraGrid.Columns.GridColumn colChiPhiDangKy;
        private DevExpress.XtraGrid.Columns.GridColumn colFlag;
        private DevExpress.XtraGrid.Columns.GridColumn colThongTinSIM;
        private DevExpress.XtraEditors.ComboBoxEdit cboIDSIM;
    }
}
