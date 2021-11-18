using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IHoaDonChiTietServices
    {
        List<HoaDonChiTiet> GetlstHoaDonChiTiets();
        HoaDonChiTiet FindHoaDonChiTiet(string input);
        void ADDHoaDonChiTiet(HoaDonChiTiet hoaDonChiTiet);
        void EditHoaDonChitiet(HoaDonChiTiet hoaDonChiTiet, int index);
    }
}
