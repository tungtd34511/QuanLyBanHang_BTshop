using _1_DAL_DataAcessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IQLMoTaSanPham
    {
        List<MoTaSanPham> GetlstMoTaSanPham();
        void AddMoTaSanPham(MoTaSanPham moTaSanPham);
        void UpdateMoTaSanPham(MoTaSanPham moTaSanPham);
        void DeleteMoTaSanPham(int index);
    }
}
