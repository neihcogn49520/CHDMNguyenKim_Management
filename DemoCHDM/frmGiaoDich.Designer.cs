
namespace DemoCHDM
{
    partial class frmGiaoDich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panChinh = new System.Windows.Forms.Panel();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.panPhu = new System.Windows.Forms.Panel();
            this.btGiaoDich = new Guna.UI2.WinForms.Guna2Button();
            this.btTroVe = new Guna.UI2.WinForms.Guna2Button();
            this.btHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btSanPham = new Guna.UI2.WinForms.Guna2Button();
            this.btNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.panGD = new Guna.UI2.WinForms.Guna2Panel();
            this.picDotList = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThongTinGD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ckbXemTrongThang = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panMenuTopUp = new System.Windows.Forms.Panel();
            this.btDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btHelp = new Guna.UI2.WinForms.Guna2Button();
            this.btTK = new Guna.UI2.WinForms.Guna2Button();
            this.timeDieuHuong = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dtpTuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbNgayGD = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.panChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.panPhu.SuspendLayout();
            this.panGD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDotList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinGD)).BeginInit();
            this.panMenuTopUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panChinh
            // 
            this.panChinh.BackColor = System.Drawing.Color.White;
            this.panChinh.Controls.Add(this.picMenu);
            this.panChinh.Controls.Add(this.panPhu);
            this.panChinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.panChinh.Location = new System.Drawing.Point(0, 0);
            this.panChinh.MaximumSize = new System.Drawing.Size(260, 800);
            this.panChinh.MinimumSize = new System.Drawing.Size(85, 800);
            this.panChinh.Name = "panChinh";
            this.panChinh.Size = new System.Drawing.Size(85, 800);
            this.panChinh.TabIndex = 2;
            // 
            // picMenu
            // 
            this.picMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMenu.Image = global::DemoCHDM.Properties.Resources._2561466_menu_icon;
            this.picMenu.Location = new System.Drawing.Point(12, 20);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(39, 35);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu.TabIndex = 1;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            // 
            // panPhu
            // 
            this.panPhu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panPhu.Controls.Add(this.btGiaoDich);
            this.panPhu.Controls.Add(this.btTroVe);
            this.panPhu.Controls.Add(this.btHoaDon);
            this.panPhu.Controls.Add(this.btSanPham);
            this.panPhu.Controls.Add(this.btNhanVien);
            this.panPhu.Controls.Add(this.btKhachHang);
            this.panPhu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panPhu.Location = new System.Drawing.Point(0, 77);
            this.panPhu.Name = "panPhu";
            this.panPhu.Size = new System.Drawing.Size(85, 723);
            this.panPhu.TabIndex = 0;
            // 
            // btGiaoDich
            // 
            this.btGiaoDich.BackColor = System.Drawing.Color.Transparent;
            this.btGiaoDich.CheckedState.Parent = this.btGiaoDich;
            this.btGiaoDich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGiaoDich.CustomImages.Parent = this.btGiaoDich;
            this.btGiaoDich.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btGiaoDich.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btGiaoDich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btGiaoDich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btGiaoDich.DisabledState.Parent = this.btGiaoDich;
            this.btGiaoDich.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btGiaoDich.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGiaoDich.ForeColor = System.Drawing.Color.White;
            this.btGiaoDich.HoverState.Parent = this.btGiaoDich;
            this.btGiaoDich.Image = global::DemoCHDM.Properties.Resources._7030314_direction_transaction_app_arrow_user_interface_icon;
            this.btGiaoDich.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btGiaoDich.ImageOffset = new System.Drawing.Point(4, 0);
            this.btGiaoDich.ImageSize = new System.Drawing.Size(40, 40);
            this.btGiaoDich.Location = new System.Drawing.Point(0, 392);
            this.btGiaoDich.Name = "btGiaoDich";
            this.btGiaoDich.ShadowDecoration.Parent = this.btGiaoDich;
            this.btGiaoDich.Size = new System.Drawing.Size(260, 61);
            this.btGiaoDich.TabIndex = 6;
            this.btGiaoDich.Text = "Giao dịch";
            this.btGiaoDich.TextOffset = new System.Drawing.Point(15, 0);
            this.btGiaoDich.UseTransparentBackground = true;
            // 
            // btTroVe
            // 
            this.btTroVe.BackColor = System.Drawing.Color.Transparent;
            this.btTroVe.CheckedState.Parent = this.btTroVe;
            this.btTroVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTroVe.CustomImages.Parent = this.btTroVe;
            this.btTroVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btTroVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btTroVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btTroVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btTroVe.DisabledState.Parent = this.btTroVe;
            this.btTroVe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btTroVe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTroVe.ForeColor = System.Drawing.Color.White;
            this.btTroVe.HoverState.Parent = this.btTroVe;
            this.btTroVe.Image = global::DemoCHDM.Properties.Resources._216437_back_arrow_icon;
            this.btTroVe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btTroVe.ImageOffset = new System.Drawing.Point(5, 0);
            this.btTroVe.ImageSize = new System.Drawing.Size(40, 40);
            this.btTroVe.Location = new System.Drawing.Point(0, 641);
            this.btTroVe.Name = "btTroVe";
            this.btTroVe.ShadowDecoration.Parent = this.btTroVe;
            this.btTroVe.Size = new System.Drawing.Size(260, 82);
            this.btTroVe.TabIndex = 5;
            this.btTroVe.Text = "Trở về";
            this.btTroVe.TextOffset = new System.Drawing.Point(15, 0);
            this.btTroVe.UseTransparentBackground = true;
            this.btTroVe.Click += new System.EventHandler(this.btTroVe_Click);
            // 
            // btHoaDon
            // 
            this.btHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btHoaDon.CheckedState.Parent = this.btHoaDon;
            this.btHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHoaDon.CustomImages.Parent = this.btHoaDon;
            this.btHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHoaDon.DisabledState.Parent = this.btHoaDon;
            this.btHoaDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btHoaDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHoaDon.ForeColor = System.Drawing.Color.White;
            this.btHoaDon.HoverState.Parent = this.btHoaDon;
            this.btHoaDon.Image = global::DemoCHDM.Properties.Resources._7340559_e_commerce_online_shopping_ui_receipt_icon;
            this.btHoaDon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHoaDon.ImageOffset = new System.Drawing.Point(2, 0);
            this.btHoaDon.ImageSize = new System.Drawing.Size(45, 45);
            this.btHoaDon.Location = new System.Drawing.Point(0, 305);
            this.btHoaDon.Name = "btHoaDon";
            this.btHoaDon.ShadowDecoration.Parent = this.btHoaDon;
            this.btHoaDon.Size = new System.Drawing.Size(260, 65);
            this.btHoaDon.TabIndex = 3;
            this.btHoaDon.Text = "Hóa đơn";
            this.btHoaDon.TextOffset = new System.Drawing.Point(15, 0);
            this.btHoaDon.UseTransparentBackground = true;
            this.btHoaDon.Click += new System.EventHandler(this.btHoaDon_Click);
            // 
            // btSanPham
            // 
            this.btSanPham.BackColor = System.Drawing.Color.Transparent;
            this.btSanPham.CheckedState.Parent = this.btSanPham;
            this.btSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSanPham.CustomImages.Parent = this.btSanPham;
            this.btSanPham.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSanPham.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSanPham.DisabledState.Parent = this.btSanPham;
            this.btSanPham.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSanPham.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSanPham.ForeColor = System.Drawing.Color.White;
            this.btSanPham.HoverState.Parent = this.btSanPham;
            this.btSanPham.Image = global::DemoCHDM.Properties.Resources._7340573_e_commerce_online_shopping_ui_package_icon;
            this.btSanPham.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btSanPham.ImageOffset = new System.Drawing.Point(5, 0);
            this.btSanPham.ImageSize = new System.Drawing.Size(45, 45);
            this.btSanPham.Location = new System.Drawing.Point(0, 218);
            this.btSanPham.Name = "btSanPham";
            this.btSanPham.ShadowDecoration.Parent = this.btSanPham;
            this.btSanPham.Size = new System.Drawing.Size(260, 65);
            this.btSanPham.TabIndex = 2;
            this.btSanPham.Text = "Sản phẩm";
            this.btSanPham.TextOffset = new System.Drawing.Point(15, 0);
            this.btSanPham.UseTransparentBackground = true;
            this.btSanPham.Click += new System.EventHandler(this.btSanPham_Click);
            // 
            // btNhanVien
            // 
            this.btNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btNhanVien.CheckedState.Parent = this.btNhanVien;
            this.btNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNhanVien.CustomImages.Parent = this.btNhanVien;
            this.btNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btNhanVien.DisabledState.Parent = this.btNhanVien;
            this.btNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhanVien.ForeColor = System.Drawing.Color.White;
            this.btNhanVien.HoverState.Parent = this.btNhanVien;
            this.btNhanVien.Image = global::DemoCHDM.Properties.Resources._290119_card_id_identification_identity_profile_icon;
            this.btNhanVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btNhanVien.ImageOffset = new System.Drawing.Point(5, 0);
            this.btNhanVien.ImageSize = new System.Drawing.Size(40, 40);
            this.btNhanVien.Location = new System.Drawing.Point(0, 131);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.ShadowDecoration.Parent = this.btNhanVien;
            this.btNhanVien.Size = new System.Drawing.Size(260, 65);
            this.btNhanVien.TabIndex = 1;
            this.btNhanVien.Text = "Nhân viên";
            this.btNhanVien.TextOffset = new System.Drawing.Point(15, 0);
            this.btNhanVien.UseTransparentBackground = true;
            this.btNhanVien.Click += new System.EventHandler(this.btNhanVien_Click);
            // 
            // btKhachHang
            // 
            this.btKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btKhachHang.CheckedState.Parent = this.btKhachHang;
            this.btKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btKhachHang.CustomImages.Parent = this.btKhachHang;
            this.btKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btKhachHang.DisabledState.Parent = this.btKhachHang;
            this.btKhachHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btKhachHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKhachHang.ForeColor = System.Drawing.Color.White;
            this.btKhachHang.HoverState.Parent = this.btKhachHang;
            this.btKhachHang.Image = global::DemoCHDM.Properties.Resources._309041_users_group_people_icon;
            this.btKhachHang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btKhachHang.ImageOffset = new System.Drawing.Point(5, 0);
            this.btKhachHang.ImageSize = new System.Drawing.Size(40, 40);
            this.btKhachHang.Location = new System.Drawing.Point(0, 44);
            this.btKhachHang.Name = "btKhachHang";
            this.btKhachHang.ShadowDecoration.Parent = this.btKhachHang;
            this.btKhachHang.Size = new System.Drawing.Size(260, 65);
            this.btKhachHang.TabIndex = 0;
            this.btKhachHang.Text = "Khách hàng";
            this.btKhachHang.TextOffset = new System.Drawing.Point(15, 0);
            this.btKhachHang.UseTransparentBackground = true;
            this.btKhachHang.Click += new System.EventHandler(this.btKhachHang_Click);
            // 
            // panGD
            // 
            this.panGD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panGD.Controls.Add(this.picDotList);
            this.panGD.Controls.Add(this.label1);
            this.panGD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panGD.Location = new System.Drawing.Point(85, 0);
            this.panGD.Name = "panGD";
            this.panGD.ShadowDecoration.Parent = this.panGD;
            this.panGD.Size = new System.Drawing.Size(1095, 78);
            this.panGD.TabIndex = 3;
            // 
            // picDotList
            // 
            this.picDotList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDotList.Image = global::DemoCHDM.Properties.Resources._3844442_dot_menu_more_vertical_icon;
            this.picDotList.Location = new System.Drawing.Point(1034, 20);
            this.picDotList.Name = "picDotList";
            this.picDotList.Size = new System.Drawing.Size(39, 35);
            this.picDotList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDotList.TabIndex = 3;
            this.picDotList.TabStop = false;
            this.picDotList.Click += new System.EventHandler(this.picDotList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIAO DỊCH";
            // 
            // dgvThongTinGD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvThongTinGD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTinGD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinGD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvThongTinGD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongTinGD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTinGD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinGD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongTinGD.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinGD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongTinGD.EnableHeadersVisualStyles = false;
            this.dgvThongTinGD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvThongTinGD.Location = new System.Drawing.Point(94, 236);
            this.dgvThongTinGD.Name = "dgvThongTinGD";
            this.dgvThongTinGD.RowHeadersVisible = false;
            this.dgvThongTinGD.RowHeadersWidth = 51;
            this.dgvThongTinGD.RowTemplate.Height = 24;
            this.dgvThongTinGD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinGD.Size = new System.Drawing.Size(1075, 499);
            this.dgvThongTinGD.TabIndex = 12;
            this.dgvThongTinGD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinGD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongTinGD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinGD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongTinGD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinGD.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvThongTinGD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvThongTinGD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvThongTinGD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongTinGD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThongTinGD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongTinGD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongTinGD.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvThongTinGD.ThemeStyle.ReadOnly = false;
            this.dgvThongTinGD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinGD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTinGD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongTinGD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongTinGD.ThemeStyle.RowsStyle.Height = 24;
            this.dgvThongTinGD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinGD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongTinGD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinGD_CellClick);
            this.dgvThongTinGD.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvThongTinGD_RowPostPaint);
            // 
            // ckbXemTrongThang
            // 
            this.ckbXemTrongThang.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ckbXemTrongThang.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ckbXemTrongThang.CheckedState.BorderRadius = 0;
            this.ckbXemTrongThang.CheckedState.BorderThickness = 0;
            this.ckbXemTrongThang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ckbXemTrongThang.CheckMarkColor = System.Drawing.Color.Black;
            this.ckbXemTrongThang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbXemTrongThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ckbXemTrongThang.ForeColor = System.Drawing.Color.DimGray;
            this.ckbXemTrongThang.Location = new System.Drawing.Point(644, 147);
            this.ckbXemTrongThang.Name = "ckbXemTrongThang";
            this.ckbXemTrongThang.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.ckbXemTrongThang.Size = new System.Drawing.Size(244, 39);
            this.ckbXemTrongThang.TabIndex = 14;
            this.ckbXemTrongThang.Text = "Xem giao dịch trong tháng";
            this.ckbXemTrongThang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbXemTrongThang.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ckbXemTrongThang.UncheckedState.BorderRadius = 1;
            this.ckbXemTrongThang.UncheckedState.BorderThickness = 0;
            this.ckbXemTrongThang.UncheckedState.FillColor = System.Drawing.Color.White;
            this.ckbXemTrongThang.CheckedChanged += new System.EventHandler(this.ckbXemTrongThang_CheckedChanged);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.dgvThongTinGD;
            // 
            // panMenuTopUp
            // 
            this.panMenuTopUp.Controls.Add(this.btDangXuat);
            this.panMenuTopUp.Controls.Add(this.btHelp);
            this.panMenuTopUp.Controls.Add(this.btTK);
            this.panMenuTopUp.Location = new System.Drawing.Point(1005, 84);
            this.panMenuTopUp.Name = "panMenuTopUp";
            this.panMenuTopUp.Size = new System.Drawing.Size(153, 140);
            this.panMenuTopUp.TabIndex = 15;
            this.panMenuTopUp.Visible = false;
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
            // btHelp
            // 
            this.btHelp.CheckedState.Parent = this.btHelp;
            this.btHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHelp.CustomImages.Parent = this.btHelp;
            this.btHelp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHelp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHelp.DisabledState.Parent = this.btHelp;
            this.btHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btHelp.FillColor = System.Drawing.Color.White;
            this.btHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHelp.ForeColor = System.Drawing.Color.Black;
            this.btHelp.HoverState.Parent = this.btHelp;
            this.btHelp.Image = global::DemoCHDM.Properties.Resources._4213426_about_description_help_info_information_icon;
            this.btHelp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHelp.Location = new System.Drawing.Point(0, 96);
            this.btHelp.Name = "btHelp";
            this.btHelp.ShadowDecoration.Parent = this.btHelp;
            this.btHelp.Size = new System.Drawing.Size(153, 44);
            this.btHelp.TabIndex = 2;
            this.btHelp.Text = "Help";
            this.btHelp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
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
            this.btTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // timeDieuHuong
            // 
            this.timeDieuHuong.Enabled = true;
            this.timeDieuHuong.Interval = 10;
            this.timeDieuHuong.Tick += new System.EventHandler(this.timeDieuHuong_Tick);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 10;
            this.guna2Elipse3.TargetControl = this.panMenuTopUp;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dtpTuNgay.BorderRadius = 10;
            this.dtpTuNgay.BorderThickness = 1;
            this.dtpTuNgay.Checked = true;
            this.dtpTuNgay.CheckedState.Parent = this.dtpTuNgay;
            this.dtpTuNgay.FillColor = System.Drawing.Color.White;
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.HoverState.Parent = this.dtpTuNgay;
            this.dtpTuNgay.Location = new System.Drawing.Point(381, 150);
            this.dtpTuNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTuNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.ShadowDecoration.Parent = this.dtpTuNgay;
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 36);
            this.dtpTuNgay.TabIndex = 16;
            this.dtpTuNgay.Value = new System.DateTime(2021, 10, 28, 20, 46, 58, 979);
            // 
            // lbNgayGD
            // 
            this.lbNgayGD.AutoSize = true;
            this.lbNgayGD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayGD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbNgayGD.Location = new System.Drawing.Point(265, 158);
            this.lbNgayGD.Name = "lbNgayGD";
            this.lbNgayGD.Size = new System.Drawing.Size(110, 20);
            this.lbNgayGD.TabIndex = 17;
            this.lbNgayGD.Text = "Ngày giao dịch";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panGD;
            // 
            // btThanhToan
            // 
            this.btThanhToan.AutoRoundedCorners = true;
            this.btThanhToan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThanhToan.BorderRadius = 22;
            this.btThanhToan.CheckedState.Parent = this.btThanhToan;
            this.btThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThanhToan.CustomImages.Parent = this.btThanhToan;
            this.btThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btThanhToan.DisabledState.Parent = this.btThanhToan;
            this.btThanhToan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btThanhToan.ForeColor = System.Drawing.Color.White;
            this.btThanhToan.HoverState.Parent = this.btThanhToan;
            this.btThanhToan.Image = global::DemoCHDM.Properties.Resources._4230540_analysis_graph_report_icon;
            this.btThanhToan.ImageSize = new System.Drawing.Size(35, 35);
            this.btThanhToan.Location = new System.Drawing.Point(987, 741);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.ShadowDecoration.Parent = this.btThanhToan;
            this.btThanhToan.Size = new System.Drawing.Size(171, 47);
            this.btThanhToan.TabIndex = 13;
            this.btThanhToan.Text = "Xuất báo cáo";
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // frmGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 800);
            this.Controls.Add(this.lbNgayGD);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.panMenuTopUp);
            this.Controls.Add(this.ckbXemTrongThang);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.dgvThongTinGD);
            this.Controls.Add(this.panGD);
            this.Controls.Add(this.panChinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiaoDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiaoDich";
            this.Load += new System.EventHandler(this.frmGiaoDich_Load);
            this.panChinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.panPhu.ResumeLayout(false);
            this.panGD.ResumeLayout(false);
            this.panGD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDotList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinGD)).EndInit();
            this.panMenuTopUp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panChinh;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Panel panPhu;
        private Guna.UI2.WinForms.Guna2Button btGiaoDich;
        private Guna.UI2.WinForms.Guna2Button btTroVe;
        private Guna.UI2.WinForms.Guna2Button btHoaDon;
        private Guna.UI2.WinForms.Guna2Button btSanPham;
        private Guna.UI2.WinForms.Guna2Button btNhanVien;
        private Guna.UI2.WinForms.Guna2Button btKhachHang;
        private Guna.UI2.WinForms.Guna2Panel panGD;
        private System.Windows.Forms.PictureBox picDotList;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongTinGD;
        private Guna.UI2.WinForms.Guna2Button btThanhToan;
        private Guna.UI2.WinForms.Guna2CheckBox ckbXemTrongThang;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel panMenuTopUp;
        private Guna.UI2.WinForms.Guna2Button btDangXuat;
        private Guna.UI2.WinForms.Guna2Button btHelp;
        private Guna.UI2.WinForms.Guna2Button btTK;
        private System.Windows.Forms.Timer timeDieuHuong;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Label lbNgayGD;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTuNgay;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}