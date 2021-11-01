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

namespace DemoCHDM
{
    public partial class frmTrangchu : Form
    {
        public bool isThoat = true;
        public frmTrangchu()
        {
            InitializeComponent();
        }

        /*****************Design section**************/
        private bool check;
        //sự kiện ngăn điều hướng

        //sự kiện time_Tick đổi icon và xổ ngăn điều hướng khi click vào picturebox Menu
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check)
            {
                panChinh.Width += 10;
                if(panChinh.Size == panChinh.MaximumSize)
                {
                    picMenu.Left += 140;
                    timer1.Stop();
                    check = false;
                    picMenu.Image = Resources._2561330_arrow_left_icon;
                }
            }
            else
            {
                panChinh.Width -= 10;
                if(panChinh.Size == panChinh.MinimumSize)
                {
                    picMenu.Left = 18;
                    timer1.Stop();
                    check = true;
                    picMenu.Image = Resources._2561466_menu_icon;
                }
            }
        }
        //đổi icon menu và xổ ra ngăn điều hướng menu
        private void picMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //hiển thị Menu PopUp
        private void showMenuTopUp()
        {
            if(panMenuTopUp.Visible == false)
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


        private void btNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.Show();
            this.Hide();
        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.Show();
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

        private void btGiaoDich_Click(object sender, EventArgs e)
        {
            frmGiaoDich gd = new frmGiaoDich();
            gd.Show();
            this.Hide();
        }

        /**************SỰ KIỆN ĐĂNG XUẤT*************/
        //public event EventHandler DangXuat;

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            //isThoat = false;
            this.Close();
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
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


        private void frmTrangchu_Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }

        private void frmTrangchu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
