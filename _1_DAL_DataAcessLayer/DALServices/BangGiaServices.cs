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
    public class BangGiaServices:IBangGiaServices
    {
        private List<BangGia> _lstBangGias;
        private DBContext_BTShop _dbContext;
        public BangGiaServices()
        {
            _dbContext = new DBContext_BTShop();
            _lstBangGias = new List<BangGia>();
            GetlstBangGiasFromDB();
        }
        public List<BangGia> GetlstBangGias()
        {
            return _lstBangGias;
        }

        public void GetlstBangGiasFromDB()
        {
            _lstBangGias = _dbContext.BANGGIA.ToList();
        }

        public string AddBangGia(BangGia bangGia)
        {
            _dbContext.Add(bangGia);
            _dbContext.SaveChanges();
            GetlstBangGiasFromDB();
            return "Thêm thành công";
        }
        public string UpdateBangGia(BangGia bangGia)
        {
            var entry = _dbContext.BANGGIA.First(e => e.Id == bangGia.Id);
            _dbContext.Entry(entry).CurrentValues.SetValues(bangGia);
            _dbContext.SaveChanges();
            GetlstBangGiasFromDB();
            return "Sửa thành công";
        }
        public string DeleteBangGia(int id)
        {
            _dbContext.Remove(_lstBangGias.FirstOrDefault(c => c.Id == id));
            _dbContext.SaveChanges();
            GetlstBangGiasFromDB();
            return "Xóa thành công";
        }
    }
}
