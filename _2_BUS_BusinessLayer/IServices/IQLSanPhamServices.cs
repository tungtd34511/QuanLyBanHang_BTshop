using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IQLSanPhamServices
    {
        List<SanPham> GetlstSanPhams();
        void Update(SanPham sanPham);
        void Add(SanPham sanPham);
        void Delete(SanPham sanPham);
    }
}
