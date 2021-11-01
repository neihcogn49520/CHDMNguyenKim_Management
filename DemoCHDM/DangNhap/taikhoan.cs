using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCHDM
{
    public class taikhoan
    {
        public enum Ltk
        {
            quanly,
            nhanvien,
        }
        private string tentk;
        public string Tentk
        {
            get => tentk;
            set => tentk = value;
        }

        private string matkhau;
        public string Matkhau
        {
            get => matkhau;
            set => matkhau = value;
        }




        private Ltk loaitk;
        public Ltk Loaitk
        {
            get { return loaitk; }
            set => loaitk = value;
        }
        private string hienthiten;
        public string Hienthiten
        {
            get
            {
                switch (Loaitk)
                {
                    case Ltk.nhanvien:
                        Hienthiten = "nhanvien";
                        break;
                    case Ltk.quanly:
                        Hienthiten = "quanly";
                        break;
                    default:
                        Hienthiten = "nhanvien";
                        break;
                }
                return hienthiten;
            }
            set => hienthiten = value;
        }

        public taikhoan(string tentk, string matkhau, Ltk loaitk)
        {
            this.Tentk = tentk;
            this.Matkhau = matkhau;
            this.Loaitk = loaitk;
        }
    }
}
