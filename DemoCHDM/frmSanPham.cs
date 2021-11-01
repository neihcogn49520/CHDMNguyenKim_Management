using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoCHDM.Properties;
using DemoCHDM.entityframework;

namespace DemoCHDM
{
    public partial class frmSanPham : Form
    {
        string del="";
        DataTable dt;
        public frmSanPham()
        {
            InitializeComponent();
        }

        /**********************DESIGN SECTION***************************/
        private bool check;
        //sự kiện ngăn điều hướng
        private void picMenu_Click(object sender, EventArgs e)
        {
            timeDieuHuong.Start(); //đổi icon menu và xổ ra ngăn điều hướng menu
        }

        //sự kiện time_Tick đổi icon và xổ ngăn điều hướng khi click vào picturebox Menu
        private void timeDieuHuong_Tick(object sender, EventArgs e)
        {
            if (check)
            {
                panChinh.Width += 10;
                if (panChinh.Size == panChinh.MaximumSize)
                {
                    picMenu.Left += 140;
                    timeDieuHuong.Stop();
                    check = false;
                    picMenu.Image = Resources._2561330_arrow_left_icon;
                }
            }
            else
            {
                panChinh.Width -= 10;
                if (panChinh.Size == panChinh.MinimumSize)
                {
                    picMenu.Left = 18;
                    timeDieuHuong.Stop();
                    check = true;
                    picMenu.Image = Resources._2561466_menu_icon;
                }
            }
        }

        //hiển thị Menu PopUp
        private void showMenuTopUp()
        {
            if (panMenuTopUp.Visible == false)
            {
                panMenuTopUp.Visible = true;
            }
            else
            {
                panMenuTopUp.Visible = false;
            }
        }

        //gọi hàm hiển thị menu popup khi click vào picturebox 3 chấm
        private void picDotList_Click(object sender, EventArgs e)
        {
            showMenuTopUp();
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            frmTrangchu trangchu = new frmTrangchu();
            trangchu.Show();
            this.Hide();
        }

        

        //link đến trang web nguyenkim.com
        private void btHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nguyenkim.com");
        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.Show();
            this.Hide();
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.Show();
            this.Hide();
        }
        private void btHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            hd.Show();
            this.Hide();
        }

        private void btGiaoDich_Click(object sender, EventArgs e)
        {
            frmGiaoDich gd = new frmGiaoDich();
            gd.Show();
            this.Hide();
        }

        
        void PhanQuyen()
        {
            switch (Const.TK.Loaitk)
            {
                case taikhoan.Ltk.nhanvien:
                    btNhanVien.Enabled = false;
                    break;
            }
            btTK.Text = Const.TK.Hienthiten;
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            cmbsp.Items.Add("Tivi ");
            cmbsp.Items.Add("Tủ lạnh ");
            cmbsp.Items.Add("Máy giặt ");
            cmbsp.Items.Add("Lap top ");
            cmbsp.Items.Add("Điện Thoại ");
            cmbsp.Items.Add("Máy lạnh ");
            dt = new DataTable();
            dt.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
            dt.Columns.Add("Tên sản phẩm", System.Type.GetType("System.String"));
            dt.Columns.Add("Số lượng", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Giá", System.Type.GetType("System.Decimal"));
            dt.Columns.Add("Ngày Nhập", System.Type.GetType("System.DateTime"));
            xuat();
        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            lbNgayNhap.Visible = false;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        int countID = 0;
        private string auto_id()
        {
            string id;
            id = "sp" + countID.ToString();
            return id;
        }
        string setID()
        {
            QLCHDMEntities db = new QLCHDMEntities();
            countID = 0;
            foreach (var item in db.sanphams.ToList())
            {
                if (item.masp.Trim().Equals(auto_id().Trim()))
                {
                    countID++;
                }
            }
            return auto_id();
        }
        void xuat()
        {
            dt.Clear();
            QLCHDMEntities db = new QLCHDMEntities();
            List<sanpham> nv = db.sanphams.ToList();
            txtMaSP.Text = setID();
            foreach (var item in nv)
            {
                dt.Rows.Add(new Object[] { item.masp, item.tensp, item.Soluong, item.gia, item.ngaynhap });
            }
            dgvThongTinSP.DataSource = dt;
            reset();
        }
        void reset()
        {
            txtTenSP.Text = "";
            txtSL.Text = "";
            txtGiaban.Text = "";
            lbNgayNhap.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            QLCHDMEntities db = new QLCHDMEntities();
            sanpham sp = new sanpham();
            List<sanpham> spt = db.sanphams.ToList();            
            string kt = "";
            if (txtTenSP.Text == "") kt = kt + "Chưa nhập Tên sản phẩm\n";
            if (txtSL.Text == "") kt = kt + "Chưa nhập Số luọng\n";
            if (txtGiaban.Text == "") kt = kt + "Chưa nhập Giá tiền\n";
            if (cmbsp.Text.Trim() == "") kt = kt + "Chưa chọn loại sản phẩm\n";
            if (kt != "")
            {
                MessageBox.Show(kt);
            }
            else
            {
                sp.masp = setID().Trim();
                sp.tensp = cmbsp.Text + txtTenSP.Text;
                sp.Soluong = Convert.ToInt32(txtSL.Text);
                sp.gia = Convert.ToDecimal(txtGiaban.Text);
                sp.ngaynhap = DateTime.Parse(dtpNgayNhap.Text);
                db.sanphams.Add(sp);
                db.SaveChanges();
                xuat();
            }
        }
        private void dgvThongTinSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgvThongTinSP.Rows[e.RowIndex];
                txtTenSP.Text = dgv.Cells[1].Value.ToString();
                txtSL.Text = dgv.Cells[2].Value.ToString();
                txtGiaban.Text = dgv.Cells[3].Value.ToString();
                dtpNgayNhap.Text = dgv.Cells[4].Value.ToString();
            }
            dgvThongTinSP.CurrentCell.Selected = false;
            if (e.RowIndex >= 0)
            {
                del = dgvThongTinSP.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            }
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            QLCHDMEntities db = new QLCHDMEntities();
            dt.Clear();
            foreach (var item in db.sanphams.ToList())
            {
                if (txtTimKiem.Text.Trim().Equals(item.masp.Trim()))
                {
                    dt.Rows.Add(new Object[] { txtTimKiem.Text, item.tensp, item.Soluong, item.gia, item.ngaynhap });
                }
            }
            dgvThongTinSP.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dt.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
                dt.Columns.Add("Tên sản phẩm", System.Type.GetType("System.String"));
                dt.Columns.Add("Số lượng", System.Type.GetType("System.Int32"));
                dt.Columns.Add("Giá", System.Type.GetType("System.Decimal"));
                dt.Columns.Add("Ngày Nhập", System.Type.GetType("System.DateTime"));
                QLCHDMEntities db = new QLCHDMEntities();
                var timkiem = db.sanphams.SqlQuery("select * from sanpham where tensp like '%" + txtTimKiem.Text + "%'").ToList();
                foreach (var kh in timkiem)
                {
                    dt.Rows.Add(new object[]
                    {
                        kh.masp,kh.tensp,kh.Soluong,kh.gia,kh.ngaynhap
                    });
                    dgvThongTinSP.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "" && txtSL.Text == "" && txtGiaban.Text == "")
            {
                MessageBox.Show("Chưa chọn cột để sửa");
            }
            else
            {
                QLCHDMEntities db = new QLCHDMEntities();
                List<sanpham> nv = db.sanphams.ToList();
                var update = (from u in db.sanphams where u.masp == del select u).Single();
                update.tensp = txtTenSP.Text;
                update.Soluong = Convert.ToInt32(txtSL.Text);
                update.gia = Convert.ToDecimal(txtGiaban.Text);
                update.ngaynhap = DateTime.Parse(dtpNgayNhap.Text);
                db.SaveChanges();
                xuat();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtGiaban.Text == "" && txtSL.Text == "" && txtTenSP.Text == "")
            {
                MessageBox.Show("Chưa chọn cột");
            }
            else
            {
                try
                {
                    QLCHDMEntities db = new QLCHDMEntities();
                    var delete = (from d in db.sanphams where d.masp == del select d).Single();
                    db.sanphams.Remove(delete);
                    db.SaveChanges();
                    xuat();
                }
                catch
                {
                    MessageBox.Show("Sản phẩm này có trong hóa đơn không thể xóa");
                }
            }
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
        }
    }
}
