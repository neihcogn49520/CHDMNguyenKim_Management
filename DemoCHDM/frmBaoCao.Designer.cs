
namespace DemoCHDM
{
    partial class frmBaoCao
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
            this.components = new System.ComponentModel.Container();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panBaoCao = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panMenuTopUp = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btThoat = new Guna.UI2.WinForms.Guna2Button();
            this.btTK = new Guna.UI2.WinForms.Guna2Button();
            this.picDotList = new System.Windows.Forms.PictureBox();
            this.HoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panBaoCao.SuspendLayout();
            this.panMenuTopUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDotList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoadonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DemoCHDM.xuatGD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 74);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1225, 679);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // panBaoCao
            // 
            this.panBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panBaoCao.Controls.Add(this.picDotList);
            this.panBaoCao.Controls.Add(this.label1);
            this.panBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.panBaoCao.Location = new System.Drawing.Point(0, 0);
            this.panBaoCao.Name = "panBaoCao";
            this.panBaoCao.ShadowDecoration.Parent = this.panBaoCao;
            this.panBaoCao.Size = new System.Drawing.Size(1225, 68);
            this.panBaoCao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(527, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO";
            // 
            // panMenuTopUp
            // 
            this.panMenuTopUp.Controls.Add(this.btDangXuat);
            this.panMenuTopUp.Controls.Add(this.btThoat);
            this.panMenuTopUp.Controls.Add(this.btTK);
            this.panMenuTopUp.Location = new System.Drawing.Point(1060, 74);
            this.panMenuTopUp.Name = "panMenuTopUp";
            this.panMenuTopUp.Size = new System.Drawing.Size(153, 140);
            this.panMenuTopUp.TabIndex = 9;
            this.panMenuTopUp.Visible = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.panMenuTopUp;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panBaoCao;
            // 
            // btDangXuat
            // 
            this.btDangXuat.CheckedState.Parent = this.btDangXuat;
            this.btDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDangXuat.CustomImages.Parent = this.btDangXuat;
            this.btDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDangXuat.DisabledState.Parent = this.btDangXuat;
            this.btDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDangXuat.FillColor = System.Drawing.Color.White;
            this.btDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btDangXuat.HoverState.Parent = this.btDangXuat;
            this.btDangXuat.Image = global::DemoCHDM.Properties.Resources._4115235_exit_logout_sign_out_icon;
            this.btDangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btDangXuat.Location = new System.Drawing.Point(0, 45);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.ShadowDecoration.Parent = this.btDangXuat;
            this.btDangXuat.Size = new System.Drawing.Size(153, 45);
            this.btDangXuat.TabIndex = 3;
            this.btDangXuat.Text = "Đăng xuất";
            this.btDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // btThoat
            // 
            this.btThoat.CheckedState.Parent = this.btThoat;
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.CustomImages.Parent = this.btThoat;
            this.btThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btThoat.DisabledState.Parent = this.btThoat;
            this.btThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btThoat.FillColor = System.Drawing.Color.White;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.Black;
            this.btThoat.HoverState.Parent = this.btThoat;
            this.btThoat.Image = global::DemoCHDM.Properties.Resources._1564506_close_exit_logout_power_icon__1_;
            this.btThoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btThoat.Location = new System.Drawing.Point(0, 96);
            this.btThoat.Name = "btThoat";
            this.btThoat.ShadowDecoration.Parent = this.btThoat;
            this.btThoat.Size = new System.Drawing.Size(153, 44);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btThoat.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // btTK
            // 
            this.btTK.CheckedState.Parent = this.btTK;
            this.btTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTK.CustomImages.Parent = this.btTK;
            this.btTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btTK.DisabledState.Parent = this.btTK;
            this.btTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTK.FillColor = System.Drawing.Color.White;
            this.btTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btTK.ForeColor = System.Drawing.Color.Black;
            this.btTK.HoverState.Parent = this.btTK;
            this.btTK.Image = global::DemoCHDM.Properties.Resources._1564535_customer_user_userphoto_account_person_icon;
            this.btTK.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btTK.Location = new System.Drawing.Point(0, 0);
            this.btTK.Name = "btTK";
            this.btTK.ShadowDecoration.Parent = this.btTK;
            this.btTK.Size = new System.Drawing.Size(153, 45);
            this.btTK.TabIndex = 0;
            this.btTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // picDotList
            // 
            this.picDotList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDotList.Image = global::DemoCHDM.Properties.Resources._3844442_dot_menu_more_vertical_icon;
            this.picDotList.Location = new System.Drawing.Point(1174, 21);
            this.picDotList.Name = "picDotList";
            this.picDotList.Size = new System.Drawing.Size(39, 35);
            this.picDotList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDotList.TabIndex = 4;
            this.picDotList.TabStop = false;
            this.picDotList.Click += new System.EventHandler(this.picDotList_Click);
            // 
            // HoadonBindingSource
            // 
            this.HoadonBindingSource.DataSource = typeof(DemoCHDM.datareport.Hoadon);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 753);
            this.Controls.Add(this.panMenuTopUp);
            this.Controls.Add(this.panBaoCao);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaoCao";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.panBaoCao.ResumeLayout(false);
            this.panBaoCao.PerformLayout();
            this.panMenuTopUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDotList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoadonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoadonBindingSource;
        private Guna.UI2.WinForms.Guna2Panel panBaoCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picDotList;
        private System.Windows.Forms.Panel panMenuTopUp;
        private Guna.UI2.WinForms.Guna2Button btDangXuat;
        private Guna.UI2.WinForms.Guna2Button btThoat;
        private Guna.UI2.WinForms.Guna2Button btTK;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}