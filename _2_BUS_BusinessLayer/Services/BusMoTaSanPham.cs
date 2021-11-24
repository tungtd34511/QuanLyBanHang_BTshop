using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    class BusMoTaSanPham : IBusMoTaSanPham
    {
        private IBusMoTaSanPham _IbusMoTaSanPham;
        private List<MoTaSanPham> _lstMoTaSanPhams;
        public BusMoTaSanPham()
        {
            _IbusMoTaSanPham = new BusMoTaSanPham();
            _lstMoTaSanPhams = new List<MoTaSanPham>();
            GetlstMoTaSanPham();
        }

        public List<MoTaSanPham> GetlstMoTaSanPham()
        {
            return _lstMoTaSanPhams;
        }
        public void AddMoTaSanPham(MoTaSanPham moTaSanPham)
        {
            _IbusMoTaSanPham.AddMoTaSanPham(moTaSanPham);
        }

        public void DeleteMoTaSanPham(int index)
        {
            _IbusMoTaSanPham.DeleteMoTaSanPham(index);
        }

        

        public void UpdateBMoTaSanPham(MoTaSanPham moTaSanPham)
        {
            _IbusMoTaSanPham.UpdateBMoTaSanPham(moTaSanPham);
        }
    }
}
