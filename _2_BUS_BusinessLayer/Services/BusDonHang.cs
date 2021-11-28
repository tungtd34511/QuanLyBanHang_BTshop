using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    class BusDonHang : IBusDonHang
    {
        private IBusDonHang _IbusDonHang;
        private List<DonHang> _lstDonHangs;

        public BusDonHang()
        {
            _IbusDonHang = new BusDonHang();
            _lstDonHangs = new List<DonHang>();
            GetlstDonHangs();   
        }

        public List<DonHang> GetlstDonHangs()
        {
            return _lstDonHangs;
        }

        public void AddDonHang(DonHang donHang)
        {
            _IbusDonHang.AddDonHang(donHang);
            GetlstDonHangs();
        }

        public void DeleteDonHang(int index)
        {
            _IbusDonHang.DeleteDonHang(index);
            GetlstDonHangs();
        }

        

        public void UpdateBangGia(DonHang donHang)
        {
            _IbusDonHang.UpdateBangGia(donHang);
            GetlstDonHangs();
        }
    }
}
