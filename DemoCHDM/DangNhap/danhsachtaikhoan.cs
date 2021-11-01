 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoCHDM.entityframework;

namespace DemoCHDM
{
    public class danhsachtaikhoan
    {
        private static danhsachtaikhoan instance;

        public static danhsachtaikhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new danhsachtaikhoan();
                return instance;
            }
            set => instance = value;
        }

        List<taikhoan> listTK;

        public List<taikhoan> ListTK
        {
            get => listTK;
            set => listTK = value;
        }

        danhsachtaikhoan()
        {
            listTK = new List<taikhoan>();
            /*QLCHDMEntities1 db = new QLCHDMEntities1();
            List<C_user> listUser = db.C_user.ToList();
            foreach(var user in listUser)
            {
                listTK.Add(new taikhoan(user.tendangnhap, user.matkhau, taikhoan.Ltk.quanly));
                listTK.Add(new taikhoan(user.tendangnhap, user.matkhau, taikhoan.Ltk.nhanvien));
            }*/
            listTK.Add(new taikhoan("admin", "12345", taikhoan.Ltk.quanly));
            listTK.Add(new taikhoan("user", "123456789", taikhoan.Ltk.nhanvien));
        }
    }
}
