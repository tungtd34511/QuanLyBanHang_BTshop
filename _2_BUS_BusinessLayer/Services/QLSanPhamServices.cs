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

        public QLSanPhamServices()
        {
            _iSanPhamServices = new SanPhamServices();
            _iBangGiaServices = new BangGiaServices();
            _iXuatXuServices = new XuatXuServices();
            _iMoTaSanPhamServices = new MoTaSanPhamServices();
        }
        public List<SanPham> GetlstSanPhams()
        {
            return _iSanPhamServices.GetlstSanPhams();
        }

        public void Update(SanPham sanPham)
        {
            _iBangGiaServices.UpdateBangGia(sanPham.BangGia);
            _iMoTaSanPhamServices.UpdateMoTaSanPham(sanPham.MoTaSanPham);
            _iXuatXuServices.UpdateXuatXu(sanPham.XuatXu);
            _iSanPhamServices.UpdateSanPham(sanPham);
        }

        public void Add(SanPham sanPham)
        {
            _iSanPhamServices.AddSanPham(sanPham);
        }
        public void Delete(SanPham sanPham)
        {
            _iSanPhamServices.DeleteSanPham(sanPham.Id);
        }
    }
}
