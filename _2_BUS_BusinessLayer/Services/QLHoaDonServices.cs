using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.DALServices;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IDALServices;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;

namespace _2_BUS_BusinessLayer.Models
{
    public class QLHoaDonServices : IQLHoaDonServices
    {
        private IHoaDonServices _iHoaDonServices;
        private IDonHangServices _iDonHangServices;
        private List<HoaDonChiTiet> _lstHoaDonChiTiets;

        public QLHoaDonServices()
        {
            _iHoaDonServices = new HoaDonServices();
            _iDonHangServices = new DonHangServices();
            _lstHoaDonChiTiets = new List<HoaDonChiTiet>();
            GetlstHoaDonChiTiets();
        }
        public List<HoaDonChiTiet> GetlstHoaDonChiTiets()
        {
            _lstHoaDonChiTiets = new List<HoaDonChiTiet>();
            foreach (var x in _iHoaDonServices.GetlstHoaDons())
            {
                _lstHoaDonChiTiets.Add(new HoaDonChiTiet()
                {
                    HoaDon = x,
                    LstDonHangs = _iDonHangServices.GetlstDonHangs().Where(c => c.HoaDon.Id == x.Id).ToList()
                });
            }
            return _lstHoaDonChiTiets;
        }

        public void Add(HoaDonChiTiet hoaDonChiTiet)
        {
            if (hoaDonChiTiet != null)
            {
                foreach (var x in hoaDonChiTiet.LstDonHangs)
                {
                    _iDonHangServices.AddDonHang(x);
                }
                GetlstHoaDonChiTiets();
            }
        }

        public void Update(HoaDonChiTiet hoaDonChiTiet)
        {
            if (hoaDonChiTiet != null)
            {
                _iHoaDonServices.UpdateHoaDon(hoaDonChiTiet.HoaDon);
                foreach (var x in hoaDonChiTiet.LstDonHangs)
                {
                    _iDonHangServices.UpdateDonHang(x);
                }
            }
        }

        public void Delete(HoaDonChiTiet hoaDonChiTiet)
        {
            _iHoaDonServices.DeleteHoaDon(hoaDonChiTiet.HoaDon.Id);
            foreach (var x in hoaDonChiTiet.LstDonHangs)
            {
                _iDonHangServices.DeleteDonHang(x.Id);
            }
        }
    }
}
