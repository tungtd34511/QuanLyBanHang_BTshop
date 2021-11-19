using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IDALServices
{
    public interface ISanPhamServices
    {
        List<SanPham> GetlstSanPhams();
        void GetlstSanPhamsFromDB();
        string AddSanPham(SanPham sanPham);
        string UpdateSanPham(SanPham sanPham);
        string DeleteSanPham(int id);
    }
}
