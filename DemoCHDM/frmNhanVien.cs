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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
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

        private void btTroVe_Click(object sender, EventArgs e)
        {
            frmTrangchu trangchu = new frmTrangchu();
            trangchu.Show();
            this.Hide();
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

        //link đến trang web nguyenkim.com
        private void btHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nguyenkim.com");
        }

        private void cboHeSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbHeSoLuong.Visible = false;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        DataTable dt;
        string del = "";

        void PhanQuyen()
        {
            btTK.Text = Const.TK.Hienthiten;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            cboHeSoLuong.Items.Add("0.3");
            cboHeSoLuong.Items.Add("0.5");
            cboHeSoLuong.Items.Add("0.7");
            cboHeSoLuong.Items.Add("0.9");
            dt = new DataTable();
            dt.Columns.Add("ID", System.Type.GetType("System.String"));
            dt.Columns.Add("Tên nhân viên", System.Type.GetType("System.String"));
            dt.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
            dt.Columns.Add("Ngày vào làm", System.Type.GetType("System.DateTime"));
            dt.Columns.Add("Lương", System.Type.GetType("System.Decimal"));
            xuat();
        }
        void reset()
        {
            txtTenNv.Text = "";
            txtSDT.Text = "";
            cboHeSoLuong.Text = "";
        }
        int countID = 0;
        private string auto_id()
        {
            string id;
            id = "nv" + countID.ToString();
            return id;
        }
        string setID()
        {
            QLCHDMEntities db = new QLCHDMEntities();
            countID = 0;
            foreach (var item in db.nhanviens.ToList()) 
            {
                if (item.manv.Trim().Equals(auto_id().Trim()))
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
            List<nhanvien> nv = db.nhanviens.ToList();
            txtMaNV.Text = setID();
            foreach (var item in nv)
            {                
                dt.Rows.Add(new Object[] { item.manv, item.hovaten, item.sdt, item.ngayvl, item.hsluong });
            }
            dgvThongTinNV.DataSource = dt;
            reset();
        }

        private void dgvThongTinNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgvThongTinNV.Rows[e.RowIndex];
                txtTenNv.Text = dgv.Cells[1].Value.ToString();
                txtSDT.Text = dgv.Cells[2].Value.ToString();
                dtpngayvaolam.Text = dgv.Cells[3].Value.ToString();
                cboHeSoLuong.Text = dgv.Cells[4].Value.ToString();
            }
            dgvThongTinNV.CurrentCell.Selected = false;
            if (e.RowIndex >= 0)
            {
                del = dgvThongTinNV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString().Trim();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            QLCHDMEntities db = new QLCHDMEntities();
            nhanvien nv = new nhanvien();
            List<nhanvien> listnv = db.nhanviens.ToList();
            string kt = "";
            if (txtTenNv.Text == "") kt = kt + "Chưa nhập tên Nhân viên\n";
            if (txtSDT.Text == "") kt = kt + "Chưa nhập số điện thoại\n";
            if (cboHeSoLuong.Text == "") kt = kt + "Chưa nhập hệ số lương\n";

            if (kt != "")
            {
                MessageBox.Show(kt);
            }
            else
            {
                string a = auto_id().Trim();
                nv.manv = a;
                nv.hovaten = txtTenNv.Text;
                nv.sdt = txtSDT.Text;
                nv.ngayvl = DateTime.Parse(dtpngayvaolam.Text);
                nv.hsluong = 4000000 + 4000000 * Convert.ToDecimal(cboHeSoLuong.Text);
                db.nhanviens.Add(nv);
                db.SaveChanges();
                xuat();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (del == "")
            {
                MessageBox.Show("Chưa chọn hàng để sửa");
            }
            else
            {
                if(cboHeSoLuong.Text.Trim() != "")
                {
                    QLCHDMEntities db = new QLCHDMEntities();
                    List<nhanvien> nv = db.nhanviens.ToList();
                    var update = (from u in db.nhanviens where u.manv == del select u).Single();
                    update.hovaten = txtTenNv.Text;
                    update.sdt = txtSDT.Text;
                    update.ngayvl = DateTime.Parse(dtpngayvaolam.Text);
                    update.hsluong = 4000000 + 4000000 * Convert.ToDecimal(cboHeSoLuong.Text);
                    db.SaveChanges();
                    xuat();
                    del = "";
                }
                else
                {
                    MessageBox.Show("Chọn hệ số lương");
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtTenNv.Text == "" && txtSDT.Text == "" && cboHeSoLuong.Text == "")
            {
                MessageBox.Show("Chưa chọn cột để xóa");
            }
            else
            {
                if(del != "")
                {
                    try
                    {
                        QLCHDMEntities db = new QLCHDMEntities();
                        string a = del.Trim();
                        var delete = (from d in db.nhanviens where d.manv == a select d).Single();
                        db.nhanviens.Remove(delete);
                        db.SaveChanges();
                        xuat();
                        del = "";
                    }
                    catch
                    {
                        MessageBox.Show("Nhân viên này sử lý hóa đơn không thể xóa");
                    }
                }
                else
                {
                    MessageBox.Show("chưa chon hàng cần xóa");
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text;
            QLCHDMEntities db = new QLCHDMEntities();
            dt.Clear();
            foreach (var item in db.nhanviens.ToList())
            {
                if ((txtTimKiem.Text.Trim()).Equals(item.manv.Trim()))
                {
                    dt.Rows.Add(new Object[] { item.manv, item.hovaten, item.sdt, item.ngayvl, item.hsluong });
                }
            }
            dgvThongTinNV.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dt.Columns.Add("ID", System.Type.GetType("System.String"));
                dt.Columns.Add("Tên nhân viên", System.Type.GetType("System.String"));
                dt.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
                dt.Columns.Add("Ngày vào làm", System.Type.GetType("System.DateTime"));
                dt.Columns.Add("Lương", System.Type.GetType("System.Decimal"));
                QLCHDMEntities db = new QLCHDMEntities();
                var timkiem = db.nhanviens.SqlQuery("select * from nhanvien where hovaten like '%" + txtTimKiem.Text + "%'").ToList();
                foreach (var kh in timkiem)
                {
                    dt.Rows.Add(new object[]
                    {
                        kh.manv,kh.hovaten,kh.sdt,kh.ngayvl,kh.hsluong
                    });
                    dgvThongTinNV.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void panNhapTT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }

        private void dgvThongTinNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.Show();
            this.Hide();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
        }
    }
}
