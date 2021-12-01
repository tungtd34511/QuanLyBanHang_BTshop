using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.DatabaseContext;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IDALServices;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_DataAcessLayer.DALServices
{
    public class HoaDonServices : IHoaDonServices
    {
        private List<HoaDon> _lstHoaDons;
        private DBContext_BTShop _dbContext;
        public HoaDonServices()
        {
            _dbContext = new DBContext_BTShop();
            _lstHoaDons = new List<HoaDon>();
            GetlstHoaDonsFromDB();
        }
        public List<HoaDon> GetlstHoaDons()
        {
            GetlstHoaDonsFromDB();
            return _lstHoaDons;
        }

        public void GetlstHoaDonsFromDB()
        {
            _lstHoaDons = _dbContext.HOADON.ToList();
        }

        public string AddHoaDon(HoaDon hoaDon)
        {
            hoaDon.KhachHang.Id = new int();
            _dbContext.Add(hoaDon);
            _dbContext.SaveChanges();
            GetlstHoaDonsFromDB();
            return "Thêm thành công";
        }
        public string UpdateHoaDon(HoaDon hoaDon)
        {
            var entry = _dbContext.HOADON.First(e => e.Id == hoaDon.Id);
            _dbContext.Entry(entry).CurrentValues.SetValues(hoaDon);
            _dbContext.SaveChanges();
            GetlstHoaDonsFromDB();
            return "Sửa thành công";
        }
        public string DeleteHoaDon(int id)
        {
            _dbContext.Remove(_lstHoaDons.FirstOrDefault(c => c.Id == id));
            _dbContext.SaveChanges();
            GetlstHoaDonsFromDB();
            return "Xóa thành công";
        }
    }
}
