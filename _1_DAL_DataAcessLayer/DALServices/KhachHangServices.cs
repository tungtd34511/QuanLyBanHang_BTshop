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
    public class KhachHangServices : IKhachHangServices
    {
        private List<KhachHang> _lstKhachHangs;
        private DBContext_BTShop _dbContext;
        public KhachHangServices()
        {
            _dbContext = new DBContext_BTShop();
            _lstKhachHangs = new List<KhachHang>();
            GetlstKhachHangsFromDB();
        }
        public List<KhachHang> GetlstKhachHangs()
        {
            return _lstKhachHangs;
        }

        public void GetlstKhachHangsFromDB()
        {
            _lstKhachHangs = _dbContext.KHACHHANG.ToList();
        }

        public string AddKhachHang(KhachHang khachHang)
        {
            khachHang.Id = new int();
            _dbContext.Add(khachHang);
            _dbContext.SaveChanges();
            GetlstKhachHangsFromDB();
            return "Thêm thành công";
        }
        public string UpdateKhachHang(KhachHang khachHang)
        {
            var entry = _dbContext.KHACHHANG.First(e => e.Id == khachHang.Id);
            _dbContext.Entry(entry).CurrentValues.SetValues(khachHang);
            _dbContext.SaveChanges();
            GetlstKhachHangsFromDB();
            return "Sửa thành công";
        }
        public string DeleteKhachHang(int id)
        {
            _dbContext.Remove(_lstKhachHangs.FirstOrDefault(c => c.Id == id));
            _dbContext.SaveChanges();
            GetlstKhachHangsFromDB();
            return "Xóa thành công";
        }
    }
}
