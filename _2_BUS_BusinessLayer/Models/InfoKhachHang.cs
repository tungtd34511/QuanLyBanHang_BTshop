using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Models
{
    public class InfoKhachHang
    {
        private int id;
        private string ten;
        private string emaii;
        private string sdt;
        private string diaCHi;
        private bool tinhTrang;

        public InfoKhachHang()
        {
        }

        public InfoKhachHang(int id, string ten, string emaii, string sdt, string diaCHi, bool tinhTrang)
        {
            this.id = id;
            this.ten = ten;
            this.emaii = emaii;
            this.sdt = sdt;
            this.diaCHi = diaCHi;
            this.tinhTrang = tinhTrang;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Emaii
        {
            get => emaii;
            set => emaii = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public string DiaCHi
        {
            get => diaCHi;
            set => diaCHi = value;
        }

        public bool TinhTrang
        {
            get => tinhTrang;
            set => tinhTrang = value;
        }
    }
}
