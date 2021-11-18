using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;

namespace _2_BUS_BusinessLayer.Models
{
    public class HoaDonChiTietServices : IHoaDonChiTietServices
    {
        private List<HoaDonChiTiet> _lstHoaDonChiTiets;
        private List<DonHang> _lstDonHangs;
        private HoaDonChiTiet _hoaDonChiTiet;
        private string _input;

        public HoaDonChiTietServices()
        {
            _lstDonHangs = new List<DonHang>();
            _lstHoaDonChiTiets = new List<HoaDonChiTiet>()
            {
                new HoaDonChiTiet()
                {
                    MaHoaDon = "HD001",  Ngayban = DateTime.Today,
                    GiamGia = 0, MaNhanVien = "NV001", GiaTriDonHang = 300000,
                    TenNhanVien = "Tạ Duy Tùng",
                    TinhTrang = true
                }
            };
        }

        public List<HoaDonChiTiet> GetlstHoaDonChiTiets()
        {
            return _lstHoaDonChiTiets;
        }

        public HoaDonChiTiet FindHoaDonChiTiet(string input)
        {
            _hoaDonChiTiet = _lstHoaDonChiTiets.FirstOrDefault(c => c.MaHoaDon == input);
            return _hoaDonChiTiet;
        }

        public void ADDHoaDonChiTiet(HoaDonChiTiet hoaDonChiTiet)
        {
            if (hoaDonChiTiet != null)
            {
                _lstHoaDonChiTiets.Add(hoaDonChiTiet);
            }
        }

        public void EditHoaDonChitiet(HoaDonChiTiet hoaDonChiTiet, int index)
        {
            if (hoaDonChiTiet != null && index != null)
            {
                _lstHoaDonChiTiets[index] = hoaDonChiTiet;
            }
        }
    }
}
