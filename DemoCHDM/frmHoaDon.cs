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
using DemoCHDM.datareport;

namespace DemoCHDM
{
    public partial class frmHoaDon : Form
    {
        static public List<Hoadon> listhd;
        public static List<TKSanPham> listTKSP;
        public frmHoaDon()
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

        //link đến trang web nguyenkim.com
        private void btHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nguyenkim.com");
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            frmTrangchu trangchu = new frmTrangchu();
            trangchu.Show();
            this.Hide();
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

        private void btGiaoDich_Click(object sender, EventArgs e)
        {
            frmGiaoDich gd = new frmGiaoDich();
            gd.Show();
            this.Hide();
        }

        private void btSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham sp = new frmSanPham();
            sp.Show();
            this.Hide();
        }
        string del = "";
        DataTable dt;

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
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            PhanQuyen();

            xuat();
        }
        int countID = 0;
        
        int setID()
        {
            QLCHDMEntities db = new QLCHDMEntities();
            countID = 0;
            foreach (var item in db.hoadons.ToList())
            {
                if (item.sohd == countID)
                {
                    countID++;
                }
            }
            return countID;
        }
        void xuat()
        {
            QLCHDMEntities db = new QLCHDMEntities();
            List<hoadon> listHD = db.hoadons.ToList();
            txtMaHD.Text = setID().ToString();
            cmbSoHD.DataSource = listHD;
            cmbSoHD.ValueMember = "sohd";
            cmbSoHD.DisplayMember = "sohd";
            List<khachhang> listKH = db.khachhangs.ToList();
            cmbMakh.DataSource = listKH;
            cmbMakh.ValueMember = "makh";
            cmbMakh.DisplayMember = "makh";
            List<sanpham> listSP = db.sanphams.ToList();
            cbmMasp.DataSource = listSP;
            cbmMasp.ValueMember = "masp";
            cbmMasp.DisplayMember = "masp";
            List<nhanvien> listNV = db.nhanviens.ToList();
            cmbmanv.DataSource = listNV;
            cmbmanv.ValueMember = "manv";
            cmbmanv.DisplayMember = "manv";
            dt = new DataTable();


            dgvThongTinHD.DataSource = dt;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            QLCHDMEntities db = new QLCHDMEntities();
            List<hoadon> lhd = db.hoadons.ToList();
            List<cthd> cthd = db.cthds.ToList();
            List<sanpham> lsp = db.sanphams.ToList();
            dt = new DataTable();
            dt.Columns.Add("STT", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Mã sản phẩm", System.Type.GetType("System.String"));
            dt.Columns.Add("Tên sản phẩm", System.Type.GetType("System.String"));
            dt.Columns.Add("Số lượng", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Đơn giá", System.Type.GetType("System.Decimal"));
            decimal sum = 0;
            int dem = 0;
            foreach (var item in lhd)
            {
                if (Convert.ToInt32(cmbSoHD.Text) == (item.sohd))
                {
                    foreach (var itm in cthd)
                    {
                        if (itm.sohd == item.sohd)
                        {
                            foreach (var tem in lsp)
                            {
                                if (itm.masp.Trim().Equals(tem.masp.Trim()))
                                {

                                    sum = sum + (decimal)(tem.gia * itm.soluong);
                                    dem++;
                                    dt.Rows.Add(new Object[] { dem, tem.masp, tem.tensp, itm.soluong, tem.gia });
                                }
                            }
                        }
                    }
                }
            }
            txtThanhtien.Text = sum.ToString();
            dgvThongTinHD.DataSource = dt;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            QLCHDMEntities db = new QLCHDMEntities();
            hoadon hd = new hoadon();
            string kt = "";
            if (txtMaHD.Text == "") kt = kt + "Chưa nhập số hóa đơn";
            if (kt != "")
            {
                MessageBox.Show(kt);
            }
            else
            {
                int a = Convert.ToInt32(txtMaHD.Text);
                int st = 0;
                foreach (var item in db.hoadons.ToList())
                {
                    int b = item.sohd;
                    if (a == b)
                    {
                        st = 1;
                        break;
                    }
                    else st = 0;
                }
                if (st != 0)
                {
                    MessageBox.Show("Mã hóa đơn bị trùng");
                }
                else
                {
                    hd.sohd = Convert.ToInt32(txtMaHD.Text);
                    hd.ngayhd = DateTime.Parse(dtpngayban.Text);
                    hd.makh = cmbMakh.Text;
                    hd.manv = cmbmanv.Text;
                    db.hoadons.Add(hd);
                    db.SaveChanges();
                }
            }
            xuat();
        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (del == "")
            {
                MessageBox.Show("Chưa chọn cột");
            }
            else
            {
                QLCHDMEntities db = new QLCHDMEntities();
                int a = Convert.ToInt32(cmbSoHD.Text);
                var delete = (from d in db.cthds where d.masp == del && d.sohd == a select d).Single();
                db.cthds.Remove(delete);
                db.SaveChanges();
                btnTimKiem_Click(sender, e);
                del = "";
            }
        }
        private void btnTvhd_Click(object sender, EventArgs e)
        {
            QLCHDMEntities db = new QLCHDMEntities();
            int a = Convert.ToInt32(cmbSoHD.Text);
            string b = cbmMasp.Text.Trim();
            if (Convert.ToInt32(numSoLuong.Value) == 0)
            {
                MessageBox.Show("Số lượng phải khác 0");
            }
            else
            {
                foreach (var item in db.cthds.ToList())
                {
                    if (cbmMasp.Text.Trim().Equals(item.masp.Trim()) && a == item.sohd)
                    {
                        var update = (from u in db.cthds where (u.sohd == a && u.masp == b) select u).Single();
                        update.sohd = item.sohd;
                        update.masp = item.masp;
                        update.soluong = item.soluong + Convert.ToInt32(numSoLuong.Value);
                        db.SaveChanges();
                        break;
                    }
                    else
                    {
                        try
                        {
                            cthd ct = new cthd();
                            ct.sohd = Convert.ToInt32(cmbSoHD.Text);
                            ct.masp = cbmMasp.Text;
                            ct.soluong = Convert.ToInt32(numSoLuong.Value);
                            db.cthds.Add(ct);
                            db.SaveChanges();
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.Message);
                        }
                        break;
                    }
                }
                btnTimKiem_Click(sender, e);
            }
        }

        private void cboHeSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMaKH.Visible = false;
        }
        string a = "", b = "", c = "", d = "";
        private void dgvThongTinHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgvThongTinHD.Rows[e.RowIndex];
                del = dgv.Cells[1].Value.ToString();
                a = dgv.Cells[0].Value.ToString();
                b = dgv.Cells[2].Value.ToString();
                c = dgv.Cells[3].Value.ToString();
                d = dgv.Cells[4].Value.ToString();
            }
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
        }

        

        private void btThanhToan_Click_1(object sender, EventArgs e)
        {

            listhd = new List<Hoadon>();
            QLCHDMEntities db = new QLCHDMEntities();
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Hoadon hd = new Hoadon();
                    hd.stt = Convert.ToInt32(dr[0].ToString());
                    hd.sohd = Convert.ToInt32(cmbSoHD.Text);
                    hd.tensp = dr[2].ToString();
                    decimal s = Convert.ToDecimal(txtThanhtien.Text) / Convert.ToDecimal(dt.Rows.Count.ToString());
                    hd.Thanhtien = Math.Round(s, 1);
                    hd.Soluong = Convert.ToInt32(dr[3].ToString());
                    hd.Dongia = Convert.ToDecimal(dr[4].ToString());
                    foreach (var hoadon in db.hoadons.ToList())
                    {
                        if (hd.sohd == hoadon.sohd)
                        {
                            hd.ngayhd = hoadon.ngayhd.ToLongDateString();
                        }
                    }
                    listhd.Add(hd);
                }
                frmXuatHoaDon bc = new frmXuatHoaDon();
                bc.Show();
            }
            catch
            {
                MessageBox.Show("xem chi tiết hóa đơn trước khi xuất");
            }
        }

        private void dgvThongTinHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSua_Click_1(object sender, EventArgs e)
        {
            QLCHDMEntities db = new QLCHDMEntities();
            int a = Convert.ToInt32(cmbSoHD.Text);
            string b = cbmMasp.Text.Trim();
            try
            {
                if (numSoLuong.Value != 0)
                {
                    var update = (from u in db.cthds where (u.sohd == a && u.masp == b) select u).Single();
                    update.sohd = a;
                    update.masp = cbmMasp.Text;
                    update.soluong = Convert.ToInt32(numSoLuong.Value);
                    db.SaveChanges();
                    btnTimKiem_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Nhập số lượng");
                }
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
        }
        
    }
}
