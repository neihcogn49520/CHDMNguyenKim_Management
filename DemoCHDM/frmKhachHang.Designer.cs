
namespace DemoCHDM
{
    partial class frmKhachHang
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
            this.panKH = new Guna.UI2.WinForms.Guna2Panel();
            this.picDotList = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeDieuHuong = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.panMenuTopUp = new System.Windows.Forms.Panel();
            this.btDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btHelp = new Guna.UI2.WinForms.Guna2Button();
            this.btTK = new Guna.UI2.WinForms.Guna2Button();
            this.dgvThongTinKH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btSua = new Guna.UI2.WinForms.Guna2Button();
            this.btXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btThem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenKh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.panPhu.SuspendLayout();
            this.panKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDotList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panMenuTopUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKH)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
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
            this.btGiaoDich.Click += new System.EventHandler(this.btGiaoDich_Click);
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
            // 
            // panKH
            // 
            this.panKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panKH.Controls.Add(this.picDotList);
            this.panKH.Controls.Add(this.label1);
            this.panKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panKH.Location = new System.Drawing.Point(85, 0);
            this.panKH.Name = "panKH";
            this.panKH.ShadowDecoration.Parent = this.panKH;
            this.panKH.Size = new System.Drawing.Size(1095, 78);
            this.panKH.TabIndex = 3;
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
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // timeDieuHuong
            // 
            this.timeDieuHuong.Enabled = true;
            this.timeDieuHuong.Interval = 10;
            this.timeDieuHuong.Tick += new System.EventHandler(this.timeDieuHuong_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.panMenuTopUp);
            this.panel1.Controls.Add(this.dgvThongTinKH);
            this.panel1.Controls.Add(this.guna2Panel2);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(85, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 723);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.AutoRoundedCorners = true;
            this.btnTimkiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTimkiem.BorderRadius = 19;
            this.btnTimkiem.CheckedState.Parent = this.btnTimkiem;
            this.btnTimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimkiem.CustomImages.Parent = this.btnTimkiem;
            this.btnTimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiem.DisabledState.Parent = this.btnTimkiem;
            this.btnTimkiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnTimkiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTimkiem.ForeColor = System.Drawing.Color.White;
            this.btnTimkiem.HoverState.Parent = this.btnTimkiem;
            this.btnTimkiem.Image = global::DemoCHDM.Properties.Resources._2867938_search_icon;
            this.btnTimkiem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTimkiem.Location = new System.Drawing.Point(610, 242);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.ShadowDecoration.Parent = this.btnTimkiem;
            this.btnTimkiem.Size = new System.Drawing.Size(70, 41);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Click += new System.EventHandler(this.btgTimkiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtTimKiem.BorderThickness = 2;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FillColor = System.Drawing.SystemColors.Control;
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.IconRightSize = new System.Drawing.Size(25, 25);
            this.txtTimKiem.Location = new System.Drawing.Point(230, 242);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(361, 41);
            this.txtTimKiem.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTimKiem.TabIndex = 11;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // panMenuTopUp
            // 
            this.panMenuTopUp.Controls.Add(this.btDangXuat);
            this.panMenuTopUp.Controls.Add(this.btHelp);
            this.panMenuTopUp.Controls.Add(this.btTK);
            this.panMenuTopUp.Location = new System.Drawing.Point(920, 7);
            this.panMenuTopUp.Name = "panMenuTopUp";
            this.panMenuTopUp.Size = new System.Drawing.Size(153, 140);
            this.panMenuTopUp.TabIndex = 9;
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
            // dgvThongTinKH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvThongTinKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTinKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvThongTinKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongTinKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTinKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongTinKH.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongTinKH.EnableHeadersVisualStyles = false;
            this.dgvThongTinKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvThongTinKH.Location = new System.Drawing.Point(7, 295);
            this.dgvThongTinKH.Name = "dgvThongTinKH";
            this.dgvThongTinKH.RowHeadersVisible = false;
            this.dgvThongTinKH.RowHeadersWidth = 51;
            this.dgvThongTinKH.RowTemplate.Height = 24;
            this.dgvThongTinKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinKH.Size = new System.Drawing.Size(1076, 428);
            this.dgvThongTinKH.TabIndex = 10;
            this.dgvThongTinKH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinKH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongTinKH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinKH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongTinKH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinKH.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvThongTinKH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvThongTinKH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dgvThongTinKH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongTinKH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThongTinKH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongTinKH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongTinKH.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvThongTinKH.ThemeStyle.ReadOnly = false;
            this.dgvThongTinKH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinKH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTinKH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongTinKH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongTinKH.ThemeStyle.RowsStyle.Height = 24;
            this.dgvThongTinKH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinKH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongTinKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinKH_CellClick);
            this.dgvThongTinKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinKH_CellContentClick);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.btSua);
            this.guna2Panel2.Controls.Add(this.btXoa);
            this.guna2Panel2.Controls.Add(this.btThem);
            this.guna2Panel2.Location = new System.Drawing.Point(830, 31);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(193, 242);
            this.guna2Panel2.TabIndex = 9;
            // 
            // btSua
            // 
            this.btSua.AutoRoundedCorners = true;
            this.btSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSua.BorderRadius = 21;
            this.btSua.CheckedState.Parent = this.btSua;
            this.btSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSua.CustomImages.Parent = this.btSua;
            this.btSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSua.DisabledState.Parent = this.btSua;
            this.btSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.HoverState.Parent = this.btSua;
            this.btSua.Image = global::DemoCHDM.Properties.Resources._2931178_change_edit_pencil_creative_design_icon1;
            this.btSua.ImageSize = new System.Drawing.Size(30, 30);
            this.btSua.Location = new System.Drawing.Point(22, 101);
            this.btSua.Name = "btSua";
            this.btSua.ShadowDecoration.Parent = this.btSua;
            this.btSua.Size = new System.Drawing.Size(147, 45);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.AutoRoundedCorners = true;
            this.btXoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btXoa.BorderRadius = 21;
            this.btXoa.CheckedState.Parent = this.btXoa;
            this.btXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoa.CustomImages.Parent = this.btXoa;
            this.btXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btXoa.DisabledState.Parent = this.btXoa;
            this.btXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.HoverState.Parent = this.btXoa;
            this.btXoa.Image = global::DemoCHDM.Properties.Resources._3669360_delete_forever_ic_icon;
            this.btXoa.ImageSize = new System.Drawing.Size(35, 35);
            this.btXoa.Location = new System.Drawing.Point(22, 180);
            this.btXoa.Name = "btXoa";
            this.btXoa.ShadowDecoration.Parent = this.btXoa;
            this.btXoa.Size = new System.Drawing.Size(147, 45);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.AutoRoundedCorners = true;
            this.btThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThem.BorderRadius = 21;
            this.btThem.CheckedState.Parent = this.btThem;
            this.btThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThem.CustomImages.Parent = this.btThem;
            this.btThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btThem.DisabledState.Parent = this.btThem;
            this.btThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.HoverState.Parent = this.btThem;
            this.btThem.Image = global::DemoCHDM.Properties.Resources._4781840___add_circle_create_expand_icon1;
            this.btThem.ImageSize = new System.Drawing.Size(30, 30);
            this.btThem.Location = new System.Drawing.Point(22, 22);
            this.btThem.Name = "btThem";
            this.btThem.ShadowDecoration.Parent = this.btThem;
            this.btThem.Size = new System.Drawing.Size(147, 45);
            this.btThem.TabIndex = 1;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.txtMaKH);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.txtDiachi);
            this.guna2Panel1.Controls.Add(this.txtTenKh);
            this.guna2Panel1.Controls.Add(this.txtSDT);
            this.guna2Panel1.Location = new System.Drawing.Point(63, 31);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(749, 185);
            this.guna2Panel1.TabIndex = 8;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.DefaultText = "";
            this.txtMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.DisabledState.Parent = this.txtMaKH;
            this.txtMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.FocusedState.Parent = this.txtMaKH;
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.HoverState.Parent = this.txtMaKH;
            this.txtMaKH.Location = new System.Drawing.Point(118, 31);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PasswordChar = '\0';
            this.txtMaKH.PlaceholderText = "";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.ShadowDecoration.Parent = this.txtMaKH;
            this.txtMaKH.Size = new System.Drawing.Size(222, 36);
            this.txtMaKH.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMaKH.TabIndex = 13;
            this.txtMaKH.TextOffset = new System.Drawing.Point(0, -2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(58, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã KH";
            // 
            // txtDiachi
            // 
            this.txtDiachi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtDiachi.BorderRadius = 10;
            this.txtDiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiachi.DefaultText = "";
            this.txtDiachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachi.DisabledState.Parent = this.txtDiachi;
            this.txtDiachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachi.FocusedState.Parent = this.txtDiachi;
            this.txtDiachi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiachi.ForeColor = System.Drawing.Color.Black;
            this.txtDiachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachi.HoverState.Parent = this.txtDiachi;
            this.txtDiachi.Location = new System.Drawing.Point(399, 86);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.PasswordChar = '\0';
            this.txtDiachi.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtDiachi.PlaceholderText = "Địa chỉ";
            this.txtDiachi.SelectedText = "";
            this.txtDiachi.ShadowDecoration.Parent = this.txtDiachi;
            this.txtDiachi.Size = new System.Drawing.Size(303, 82);
            this.txtDiachi.TabIndex = 7;
            // 
            // txtTenKh
            // 
            this.txtTenKh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtTenKh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKh.DefaultText = "";
            this.txtTenKh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKh.DisabledState.Parent = this.txtTenKh;
            this.txtTenKh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKh.FocusedState.Parent = this.txtTenKh;
            this.txtTenKh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKh.ForeColor = System.Drawing.Color.Black;
            this.txtTenKh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKh.HoverState.Parent = this.txtTenKh;
            this.txtTenKh.Location = new System.Drawing.Point(62, 119);
            this.txtTenKh.Name = "txtTenKh";
            this.txtTenKh.PasswordChar = '\0';
            this.txtTenKh.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTenKh.PlaceholderText = "Tên khách hàng";
            this.txtTenKh.SelectedText = "";
            this.txtTenKh.ShadowDecoration.Parent = this.txtTenKh;
            this.txtTenKh.Size = new System.Drawing.Size(278, 36);
            this.txtTenKh.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTenKh.TabIndex = 5;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.Parent = this.txtSDT;
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedState.Parent = this.txtSDT;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.HoverState.Parent = this.txtSDT;
            this.txtSDT.Location = new System.Drawing.Point(399, 31);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSDT.PlaceholderText = "Số điện thoại";
            this.txtSDT.SelectedText = "";
            this.txtSDT.ShadowDecoration.Parent = this.txtSDT;
            this.txtSDT.Size = new System.Drawing.Size(303, 36);
            this.txtSDT.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSDT.TabIndex = 6;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.dgvThongTinKH;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panKH;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 10;
            this.guna2Elipse3.TargetControl = this.panMenuTopUp;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panKH);
            this.Controls.Add(this.panChinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.panChinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.panPhu.ResumeLayout(false);
            this.panKH.ResumeLayout(false);
            this.panKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDotList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panMenuTopUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKH)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panChinh;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Panel panPhu;
        private Guna.UI2.WinForms.Guna2Button btTroVe;
        private Guna.UI2.WinForms.Guna2Button btHoaDon;
        private Guna.UI2.WinForms.Guna2Button btSanPham;
        private Guna.UI2.WinForms.Guna2Button btNhanVien;
        private Guna.UI2.WinForms.Guna2Button btKhachHang;
        private Guna.UI2.WinForms.Guna2Panel panKH;
        private System.Windows.Forms.PictureBox picDotList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timeDieuHuong;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2Button btXoa;
        private Guna.UI2.WinForms.Guna2Button btSua;
        private Guna.UI2.WinForms.Guna2TextBox txtDiachi;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKh;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongTinKH;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panMenuTopUp;
        private Guna.UI2.WinForms.Guna2Button btDangXuat;
        private Guna.UI2.WinForms.Guna2Button btHelp;
        private Guna.UI2.WinForms.Guna2Button btTK;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Button btGiaoDich;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
    }
}

