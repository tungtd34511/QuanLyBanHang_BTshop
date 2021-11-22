using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.DALServices;
using _1_DAL_DataAcessLayer.IDALServices;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.Services
{
    public class QLSanPhamServices : IQLSanPhamServices
    {
        private ISanPhamServices _iSanPhamServices;
        private IXuatXuServices _iXuatXuServices;
        private IBangGiaServices _iBangGiaServices;
        private IMoTaSanPhamServices _iMoTaSanPhamServices;
        private List<SanPham> _lstSanPhams;

        public QLSanPhamServices()
        {
            _iSanPhamServices = new SanPhamServices();
            _iBangGiaServices = new BangGiaServices();
            _iXuatXuServices = new XuatXuServices();
            _iMoTaSanPhamServices = new MoTaSanPhamServices();
            _lstSanPhams = new List<SanPham>();
            GetlstSanPhams();
        }
        public List<SanPham> GetlstSanPhams()
        {
            _lstSanPhams = _iSanPhamServices.GetlstSanPhams();
            return _lstSanPhams;
        }
    }
}
