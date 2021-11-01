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
    public partial class frmGiaoDich : Form
    {
        public frmGiaoDich()
        {
            InitializeComponent();
        }

        static public List<GiaoDich> listhd;
        public static List<TKSanPham> listTKSP;

        decimal sum = 0;
        int count = 0;
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
        DataTable dt;
        int dem = 1;

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

        private void frmGiaoDich_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            dt = new DataTable();
            dt.Columns.Add("STT", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Mã hóa đơn", System.Type.GetType("System.String"));
            dt.Columns.Add("Mã nhân viên", System.Type.GetType("System.String"));
            dt.Columns.Add("Mã khách hàng", System.Type.GetType("System.String"));
            dt.Columns.Add("Ngày lập hóa đơn", System.Type.GetType("System.DateTime"));
            dt.Columns.Add("Tổng tiền", System.Type.GetType("System.Decimal"));
            xuat();
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

        /*string del = "", del1 = "", del2 = "", del3 = "", del4 = "";*/
        private void btThanhToan_Click(object sender, EventArgs e)
        {

            listhd = new List<GiaoDich>();
            QLCHDMEntities db = new QLCHDMEntities();
            try 
            { 
                foreach (DataRow dr in dt.Rows)
                {
                        GiaoDich hd = new GiaoDich();
                        hd.stt = Convert.ToInt32(dr[0].ToString()); ;
                        hd.sohd = Convert.ToInt32(dr[1].ToString());
                        hd.manv = dr[2].ToString();
                        hd.makh = dr[3].ToString();
                        hd.ngayhd = dr[4].ToString();
                        hd.tongtien = Convert.ToDecimal(dr[5].ToString());
                        listhd.Add(hd);
                }
                
                frmBaoCao b = new frmBaoCao();
                b.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
        }
        void xuat()
        {
            dt.Clear();
            QLCHDMEntities db = new QLCHDMEntities();
            List<hoadon> listhd = db.hoadons.ToList();
            List<cthd> cthd = db.cthds.ToList();
            List<sanpham> listsp = db.sanphams.ToList();

            foreach (var hd in listhd)
            {
                foreach(var item in cthd)
                {
                    foreach(var sp in listsp)
                    {
                        if (item.masp.Equals(sp.masp))
                        {
                            if(hd.sohd == item.sohd)
                            {
                                sum += (Decimal)(item.soluong * sp.gia);
                            }
                        }
                    }
                }
                dt.Rows.Add(new Object[] {dem, hd.sohd, hd.manv, hd.makh, hd.ngayhd, sum });
                dem++;
                sum = 0;
            }
            dgvThongTinGD.DataSource = dt;
        }

        private void ckbXemTrongThang_CheckedChanged(object sender, EventArgs e)
        {
            QLCHDMEntities db = new QLCHDMEntities();
            List<hoadon> listhd = db.hoadons.ToList();
            List<cthd> cthd = db.cthds.ToList();
            List<sanpham> listsp = db.sanphams.ToList();
            dt = new DataTable();
            dt.Columns.Add("STT", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Mã hóa đơn", System.Type.GetType("System.String"));
            dt.Columns.Add("Mã nhân viên", System.Type.GetType("System.String"));
            dt.Columns.Add("Mã khách hàng", System.Type.GetType("System.String"));
            dt.Columns.Add("Ngày lập hóa đơn", System.Type.GetType("System.DateTime"));
            dt.Columns.Add("Tổng tiền", System.Type.GetType("System.Decimal"));
            if (ckbXemTrongThang.Checked)
            {
                foreach (var hd in listhd)
                {
                    if (dtpTuNgay.Value.Month == hd.ngayhd.Month)
                    {
                        foreach (var item in cthd)
                        {
                            foreach (var sp in listsp)
                            {
                                if (item.masp.Equals(sp.masp))
                                {
                                    if (hd.sohd == item.sohd)
                                    {
                                        sum += (Decimal)(item.soluong * sp.gia);
                                    }
                                }
                            }
                        }
                        dt.Rows.Add(new Object[] {dem, hd.sohd, hd.manv, hd.makh, hd.ngayhd, sum });
                        dem++;
                        sum = 0;
                    }
                }
                dgvThongTinGD.DataSource = dt;
            }
            else
            {
                xuat();
            }
        }
        private void dgvThongTinGD_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //dgvThongTinGD.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvThongTinGD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                /*del = dgvThongTinGD.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                del1 = dgvThongTinGD.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                del2 = dgvThongTinGD.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                del3 = dgvThongTinGD.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                del4 = dgvThongTinGD.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();*/
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

