namespace QuanlyCuocDT
{
    partial class ThemHDDK
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
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMahddk = new DevExpress.XtraEditors.TextEdit();
            this.txtchiphithanhtoan = new DevExpress.XtraEditors.TextEdit();
            this.cboIDSIM = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMahddk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchiphithanhtoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIDSIM.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(165, 115);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(104, 16);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "Chi phí thanh toán";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(165, 74);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 16);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "IDSIM";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(165, 42);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 16);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Mã Hóa đơn đăng kí";
            // 
            // txtMahddk
            // 
            this.txtMahddk.Enabled = false;
            this.txtMahddk.Location = new System.Drawing.Point(287, 39);
            this.txtMahddk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMahddk.Name = "txtMahddk";
            this.txtMahddk.Size = new System.Drawing.Size(251, 22);
            this.txtMahddk.TabIndex = 16;
            // 
            // txtchiphithanhtoan
            // 
            this.txtchiphithanhtoan.EditValue = "50000.000";
            this.txtchiphithanhtoan.Enabled = false;
            this.txtchiphithanhtoan.Location = new System.Drawing.Point(287, 112);
            this.txtchiphithanhtoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtchiphithanhtoan.Name = "txtchiphithanhtoan";
            this.txtchiphithanhtoan.Size = new System.Drawing.Size(251, 22);
            this.txtchiphithanhtoan.TabIndex = 18;
            // 
            // cboIDSIM
            // 
            this.cboIDSIM.Location = new System.Drawing.Point(287, 72);
            this.cboIDSIM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboIDSIM.Name = "cboIDSIM";
            this.cboIDSIM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIDSIM.Size = new System.Drawing.Size(251, 22);
            this.cboIDSIM.TabIndex = 17;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(563, 188);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "Hủy";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(434, 188);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 29);
            this.simpleButton2.TabIndex = 23;
            this.simpleButton2.Text = "Thêm";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // ThemHDDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 270);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtMahddk);
            this.Controls.Add(this.txtchiphithanhtoan);
            this.Controls.Add(this.cboIDSIM);
            this.Name = "ThemHDDK";
            this.Text = "ThemHDDK";
            ((System.ComponentModel.ISupportInitialize)(this.txtMahddk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchiphithanhtoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIDSIM.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMahddk;
        private DevExpress.XtraEditors.TextEdit txtchiphithanhtoan;
        private DevExpress.XtraEditors.ComboBoxEdit cboIDSIM;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}