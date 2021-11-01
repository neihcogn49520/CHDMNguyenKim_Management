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
    public partial class frmKhachHang : Form
    {
        DataTable dt;
        string del = "";
        public frmKhachHang()
        {
            InitializeComponent();
        }

        /******************DESIGN SECTION************************/
        private void btTroVe_Click(object sender, EventArgs e)
        {
            frmTrangchu trangchu = new frmTrangchu();
            trangchu.Show();
            this.Hide();
        }

        private bool check;
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

        //đổi icon menu và xổ ra ngăn điều hướng menu
        private void picMenu_Click(object sender, EventArgs e)
        {
            timeDieuHuong.Start();
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

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.Show();
            this.Hide();
        }


        //link đến trang web nguyenkim.com
        private void btHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nguyenkim.com");
        }

        private void btSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham sp = new frmSanPham();
            sp.Show();
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
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            dt = new DataTable();
            dt.Columns.Add("Mã khách hàng", System.Type.GetType("System.String"));
            dt.Columns.Add("Tên khách hàng", System.Type.GetType("System.String"));
            dt.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
            dt.Columns.Add("Địa chỉ", System.Type.GetType("System.String"));
            
            xuat();

        }
        int countID = 0;
        private string auto_id()
        {
            string id;
            id = "kh" + countID.ToString();
            return id;
        }
        string setID()
        {
            QLCHDMEntities db = new QLCHDMEntities();
            countID = 0;
            foreach (var item in db.khachhangs.ToList())
            {
                if (item.makh.Trim().Equals(auto_id().Trim()))
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
            List<khachhang> listkh = db.khachhangs.ToList();
            txtMaKH.Text = setID();
            foreach (var item in listkh)
            {
                dt.Rows.Add(new Object[] { item.makh, item.hovaten, item.sdt, item.diachi });
            }
            dgvThongTinKH.DataSource = dt;
            reset();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            QLCHDMEntities db = new QLCHDMEntities();
            khachhang kh = new khachhang();
            List<khachhang> listkh = db.khachhangs.ToList();
            string kt = "";
            if (txtTenKh.Text == "") kt = kt + "Chưa nhập tên khách hàng\n";
            if (txtSDT.Text == "") kt = kt + "Chưa nhập số điện thoại\n";
            if (txtDiachi.Text == "") kt = kt + "Chưa nhập địa chỉ\n";
            
            if (kt != "")
            {
                MessageBox.Show(kt);
            }
            else
            {
                kh.makh = setID().Trim();
                kh.hovaten = txtTenKh.Text;
                kh.sdt = txtSDT.Text;
                kh.diachi = txtDiachi.Text;
                db.khachhangs.Add(kh);
                db.SaveChanges();
                xuat();
            }
        }
        void reset()
        {
            txtTenKh.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            if ( txtTenKh.Text == "" && txtSDT.Text == "" && txtDiachi.Text == "" )
            {
                MessageBox.Show("Chưa chọn hàng để sửa");
            }
            else
            {
                QLCHDMEntities db = new QLCHDMEntities();
                List<khachhang> nv = db.khachhangs.ToList();
                var update = (from u in db.khachhangs where u.makh == del select u).Single();
                update.hovaten = txtTenKh.Text;
                update.sdt = txtSDT.Text;
                update.diachi = txtDiachi.Text;
                db.SaveChanges();
                xuat();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtTenKh.Text=="" &&txtSDT.Text ==""&&txtDiachi.Text=="")
            {
                MessageBox.Show("Chưa chọn hàng để xóa");
            }
            else
            {
                try
                {
                    QLCHDMEntities db = new QLCHDMEntities();
                    var delete = (from d in db.khachhangs where d.makh == del select d).Single();
                    db.khachhangs.Remove(delete);
                    db.SaveChanges();
                    xuat();
                }
                catch
                {
                    MessageBox.Show("Khách hàng này đang đặt hàng không thể xóa");
                }
            }
        }

        private void dgvThongTinKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow dgv = dgvThongTinKH.Rows[e.RowIndex];
                txtTenKh.Text = dgv.Cells[1].Value.ToString();
                txtSDT.Text = dgv.Cells[2].Value.ToString();
                txtDiachi.Text = dgv.Cells[3].Value.ToString();
            }
            dgvThongTinKH.CurrentCell.Selected = false;
            if(e.RowIndex>=0)
            {
                del = dgvThongTinKH.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            }
        }

        private void btgTimkiem_Click(object sender, EventArgs e)
        {          
            QLCHDMEntities db = new QLCHDMEntities();
            dt.Clear();
            foreach (var item in db.khachhangs.ToList())
            {
                if ((txtTimKiem.Text.Trim()).Equals(item.makh.Trim()))
                {
                    dt.Rows.Add(new Object[] { item.makh, item.hovaten, item.sdt, item.diachi });
                }
            }
            dgvThongTinKH.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dt.Columns.Add("Mã khách hàng", System.Type.GetType("System.String"));
                dt.Columns.Add("Tên khách hàng", System.Type.GetType("System.String"));
                dt.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
                dt.Columns.Add("Địa chỉ", System.Type.GetType("System.String"));
                QLCHDMEntities db = new QLCHDMEntities();
                var timkiem = db.khachhangs.SqlQuery("select * from khachhang where hovaten like '%" + txtTimKiem.Text + "%'").ToList();
                foreach(var kh in timkiem)
                {
                    dt.Rows.Add(new object[]
                    {
                        kh.makh,kh.hovaten,kh.sdt,kh.diachi
                    });
                    dgvThongTinKH.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvThongTinKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
        }
    }
}
