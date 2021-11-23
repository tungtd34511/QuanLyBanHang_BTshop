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
    public class SanPhamServices : ISanPhamServices
    {
        private List<SanPham> _lstSanPhams;
        private DBContext_BTShop _dbContext;
        public SanPhamServices()
        {
            _dbContext = new DBContext_BTShop();
            _lstSanPhams = new List<SanPham>();
            GetlstSanPhamsFromDB();
        }
        public List<SanPham> GetlstSanPhams()
        {
            return _lstSanPhams;
        }

        public void GetlstSanPhamsFromDB()
        {
            _lstSanPhams = _dbContext.SANPHAM.ToList();
        }

        public string AddSanPham(SanPham sanPham)
        {
            _dbContext.Add(sanPham);
            _dbContext.SaveChanges();
            GetlstSanPhamsFromDB();
            return "Thêm thành công";
        }
        public string UpdateSanPham(SanPham sanPham)
        {
            var entry = _dbContext.SANPHAM.First(e => e.Id == sanPham.Id);
            _dbContext.Entry(entry).CurrentValues.SetValues(sanPham);
            _dbContext.SaveChanges();
            GetlstSanPhamsFromDB();
            return "Sửa thành công";
        }
        public string DeleteSanPham(int id)
        {
            _dbContext.Remove(_lstSanPhams.FirstOrDefault(c => c.Id == id));
            _dbContext.SaveChanges();
            GetlstSanPhamsFromDB();
            return "Xóa thành công";
        }
    }
}
