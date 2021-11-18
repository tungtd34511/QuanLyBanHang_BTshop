using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _2_BUS_BusinessLayer.Models
{
    [Serializable]
    public class Info_HoaDon
    {
        private KhachHang khachHang;
        private List<DonHang> listDonHang;
        private int index;
        private int tienKhachTra;

        public Info_HoaDon()
        {
        }

        public Info_HoaDon(KhachHang khachHang, List<DonHang> listDonHang, int index, int tienKhachTra)
        {
            this.khachHang = khachHang;
            this.listDonHang = listDonHang;
            this.index = index;
            this.tienKhachTra = tienKhachTra;
        }

        public KhachHang KhachHang
        {
            get => khachHang;
            set => khachHang = value;
        }

        public List<DonHang> ListDonHang
        {
            get => listDonHang;
            set => listDonHang = value;
        }

        public int Index
        {
            get => index;
            set => index = value;
        }

        public int TienKhachTra
        {
            get => tienKhachTra;
            set => tienKhachTra = value;
        }
    }
}
