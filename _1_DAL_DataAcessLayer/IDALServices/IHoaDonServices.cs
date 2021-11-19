using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IDALServices
{
    public interface IHoaDonServices
    {
        List<HoaDon> GetlstHoaDons();
        void GetlstHoaDonsFromDB();
        string AddHoaDon(HoaDon hoaDon);
        string UpdateHoaDon(HoaDon hoaDon);
        string DeleteHoaDon(int id);
    }
}
