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
        private List<int> _lstSanPhams;
        private List<int> soLuongSP;
        private int tienKhachTra;
        private int index;
        public Info_HoaDon()
        {
        }

        public Info_HoaDon(KhachHang khachHang, List<int> listSanPhams,List<int> soluongSP, int index, int tienKhachTra)
        {
            this.khachHang = khachHang;
            this._lstSanPhams = listSanPhams;
            this.soLuongSP = soluongSP;
            this.tienKhachTra = tienKhachTra;
            this.index = index;
        }

        public KhachHang KhachHang
        {
            get => khachHang;
            set => khachHang = value;
        }
        public int TienKhachTra
        {
            get => tienKhachTra;
            set => tienKhachTra = value;
        }
        public int Index
        {
            get => index;
            set => index = value;
        }

        public List<int> LstSanPhams
        {
            get => _lstSanPhams;
            set => _lstSanPhams = value;
        }

        public List<int> SoLuongSp
        {
            get => soLuongSP;
            set => soLuongSP = value;
        }
    }
}
