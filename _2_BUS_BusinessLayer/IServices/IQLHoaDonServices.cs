using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IQLHoaDonServices
    {
        List<HoaDonChiTiet> GetlstHoaDonChiTiets();
        void Add(HoaDonChiTiet hoaDonChiTiet);
        void Update(HoaDonChiTiet hoaDonChiTiet);
        void Delete(HoaDonChiTiet hoaDonChiTiet);
    }
}
