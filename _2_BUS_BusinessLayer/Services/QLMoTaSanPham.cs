using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.DALServices;
using _1_DAL_DataAcessLayer.IDALServices;

namespace _2_BUS_BusinessLayer.Services
{
    public class QLMoTaSanPham : IQLMoTaSanPham
    {
        private IMoTaSanPhamServices _iMoTaSanPhamServices;
        private List<MoTaSanPham> _lstMoTaSanPhams;
        public QLMoTaSanPham()
        {
            _iMoTaSanPhamServices = new MoTaSanPhamServices();
            _lstMoTaSanPhams = new List<MoTaSanPham>();
            _lstMoTaSanPhams = _iMoTaSanPhamServices.GetlstMoTaSanPhams();
            GetlstMoTaSanPham();
        }

        public List<MoTaSanPham> GetlstMoTaSanPham()
        {
            _iMoTaSanPhamServices.GetlstMoTaSanPhamsFromDB();
            return _lstMoTaSanPhams;
        }
        public void AddMoTaSanPham(MoTaSanPham moTaSanPham)
        {
            _iMoTaSanPhamServices.AddMoTaSanPham(moTaSanPham);
        }

        public void DeleteMoTaSanPham(int index)
        {
            _iMoTaSanPhamServices.DeleteMoTaSanPham(index);
        }
        public void UpdateMoTaSanPham(MoTaSanPham moTaSanPham)
        {
            _iMoTaSanPhamServices.UpdateMoTaSanPham(moTaSanPham);
        }
    }
}
