using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoCHDM.entityframework;

namespace DemoCHDM
{
    public partial class frmDangNhap : Form
    {
        List<taikhoan> listtk = danhsachtaikhoan.Instance.ListTK;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            panTT.Parent = pictureBox1;
            panTT.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.IconRight = Properties.Resources._6351969_eye_key_look_password_security_icon;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.IconRight = Properties.Resources._6351930_eye_password_see_view_icon;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txtTenDN.Text, txtPassword.Text))
            {
                frmTrangchu tc = new frmTrangchu();
                tc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
                txtTenDN.Focus();
            }
            //tc.DangXuat += Tc_DangXuat;


            /*QLCHDMEntities1 db = new QLCHDMEntities1();
            List<C_user> u = db.C_user.ToList();
            foreach(var tk in u)
            {
                if(txtTenDN.Text.Trim().Equals(tk.tendangnhap.Trim()) && txtPassword.Text.Trim().Equals(tk.matkhau.Trim()))
                {
                    frmTrangchu trangchu = new frmTrangchu();
                    trangchu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
                }
            }*/
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool KiemTraDangNhap(string tentk, string mk)
        {
            for(int i = 0; i<listtk.Count; i++)
            {
                if (tentk == listtk[i].Tentk && mk == listtk[i].Matkhau)
                {
                    Const.TK = listtk[i];
                    return true;
                }
            }

            return false;
        }
    }
}
