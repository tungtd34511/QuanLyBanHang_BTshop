using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IDALServices
{
    public interface IDonHangServices
    {
        List<DonHang> GetlstDonHangs();
        void GetlstDonHangsFromDB();
        string AddDonHang(DonHang donHang);
        string UpdateDonHang(DonHang donHang);
        string DeleteDonHang(int id);
    }
}
