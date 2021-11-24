using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.DALServices;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IDALServices;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.Services
{
    public class QLKhachHangServices : IQLKhachHangServices
    {
        private IKhachHangServices _iKhachHangServices;
        private List<KhachHang> _lstKhachHangs;
        public QLKhachHangServices()
        {
            _iKhachHangServices = new KhachHangServices();
        }

        public List<KhachHang> GetlstKhachHangs()
        {
            _lstKhachHangs = new List<KhachHang>();
            _lstKhachHangs = _iKhachHangServices.GetlstKhachHangs();
            return _lstKhachHangs;
        }

        public void Update(KhachHang khachHang)
        {
            _iKhachHangServices.UpdateKhachHang(khachHang);
            GetlstKhachHangs();
        }

        public void Add(KhachHang khachHang)
        {
            _iKhachHangServices.AddKhachHang(khachHang);
            GetlstKhachHangs();
        }

        public void Delete(KhachHang khachHang)
        {
            _iKhachHangServices.DeleteKhachHang(khachHang.Id);
            GetlstKhachHangs();
        }
    }
}
