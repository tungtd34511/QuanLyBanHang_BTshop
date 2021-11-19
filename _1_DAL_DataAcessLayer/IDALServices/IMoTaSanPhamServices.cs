using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IDALServices
{
    public interface IMoTaSanPhamServices
    {
        List<MoTaSanPham> GetlstMoTaSanPhams();
        void GetlstMoTaSanPhamsFromDB();
        string AddMoTaSanPham(MoTaSanPham moTaSanPham);
        string UpdateMoTaSanPham(MoTaSanPham moTaSanPham);
        string DeleteMoTaSanPham(int id);
    }
}
