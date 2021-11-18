using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Models
{
    public class NuocHoa
    {
        private string maHang;
        private string tenHang;
        private string maQr;
        private string nhaSx;
        private string xuatxu;
        private int namPhatHanh;
        private string phai;
        private string phienBan;
        private int soluong;
        private double donGiaNhap;
        private double donnGiaBan;
        private int dungTich;
        private int tinhTrang;
        private string anh;
        private string ghiChu;

        public NuocHoa()
        {
        }
        public NuocHoa(string maHang, string tenHang, string maQr, string nhaSx, string xuatxu, int namPhatHanh, string phai, string phienBan, int soluong, double donGiaNhap, double donnGiaBan, int dungTich, int tinhTrang, string anh, string ghiChu)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.maQr = maQr;
            this.nhaSx = nhaSx;
            this.xuatxu = xuatxu;
            this.namPhatHanh = namPhatHanh;
            this.phai = phai;
            this.phienBan = phienBan;
            this.soluong = soluong;
            this.donGiaNhap = donGiaNhap;
            this.donnGiaBan = donnGiaBan;
            this.dungTich = dungTich;
            this.tinhTrang = tinhTrang;
            this.anh = anh;
            this.ghiChu = ghiChu;
        }

        public string MaHang
        {
            get => maHang;
            set => maHang = value;
        }

        public string TenHang
        {
            get => tenHang;
            set => tenHang = value;
        }

        public string MaQr
        {
            get => maQr;
            set => maQr = value;
        }

        public string NhaSx
        {
            get => nhaSx;
            set => nhaSx = value;
        }

        public string Xuatxu
        {
            get => xuatxu;
            set => xuatxu = value;
        }

        public int NamPhatHanh
        {
            get => namPhatHanh;
            set => namPhatHanh = value;
        }

        public string Phai
        {
            get => phai;
            set => phai = value;
        }

        public string PhienBan
        {
            get => phienBan;
            set => phienBan = value;
        }

        public int Soluong
        {
            get => soluong;
            set => soluong = value;
        }

        public double DonGiaNhap
        {
            get => donGiaNhap;
            set => donGiaNhap = value;
        }

        public double DonnGiaBan
        {
            get => donnGiaBan;
            set => donnGiaBan = value;
        }

        public int DungTich
        {
            get => dungTich;
            set => dungTich = value;
        }

        public int TinhTrang
        {
            get => tinhTrang;
            set => tinhTrang = value;
        }

        public string Anh
        {
            get => anh;
            set => anh = value;
        }

        public string GhiChu
        {
            get => ghiChu;
            set => ghiChu = value;
        }
    }
}
