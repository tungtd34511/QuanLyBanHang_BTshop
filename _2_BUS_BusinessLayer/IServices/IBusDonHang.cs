using _1_DAL_DataAcessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    interface IBusDonHang
    {
        List<DonHang> GetlstDonHangs();
        void AddDonHang(DonHang donHang);
        void UpdateBangGia(DonHang donHang);
        void DeleteDonHang(int index);
    }
}
