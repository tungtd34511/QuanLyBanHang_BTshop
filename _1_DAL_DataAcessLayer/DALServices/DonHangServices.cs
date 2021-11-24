using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.DatabaseContext;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IDALServices;

namespace _1_DAL_DataAcessLayer.DALServices
{
    public class DonHangServices : IDonHangServices
    {
        private List<DonHang> _lstDonHangs;
        private DBContext_BTShop _dbContext;
        public DonHangServices()
        {
            _dbContext = new DBContext_BTShop();
            _lstDonHangs = new List<DonHang>();
            GetlstDonHangsFromDB();
        }
        public List<DonHang> GetlstDonHangs()
        {
            return _lstDonHangs;
        }

        public void GetlstDonHangsFromDB()
        {
            _lstDonHangs = _dbContext.DONHANG.ToList();
        }

        public string AddDonHang(DonHang donHang)
        {
            _dbContext.Add(donHang);
            _dbContext.SaveChanges();
            GetlstDonHangsFromDB();
            return "Thêm thành công";
        }
        public string UpdateDonHang(DonHang donHang)
        {
            var entry = _dbContext.DONHANG.First(e => e.Id == donHang.Id);
            _dbContext.Entry(entry).CurrentValues.SetValues(donHang);
            _dbContext.SaveChanges();
            GetlstDonHangsFromDB();
            return "Sửa thành công";
        }
        public string DeleteDonHang(int id)
        {
            _dbContext.Remove(_lstDonHangs.FirstOrDefault(c => c.Id == id));
            _dbContext.SaveChanges();
            GetlstDonHangsFromDB();
            return "Xóa thành công";
        }
    }
}
