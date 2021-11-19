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
    public class ChucVuServices : IChucVuServices
    {
        private List<ChucVu> _lstChucVus;
        private DBContext_BTShop _dbContext;
        public ChucVuServices()
        {
            _dbContext = new DBContext_BTShop();
            _lstChucVus = new List<ChucVu>();
            GetlstChucVusFromDB();
        }
        public List<ChucVu> GetlstChucVus()
        {
            return _lstChucVus;
        }

        public void GetlstChucVusFromDB()
        {
            _lstChucVus = _dbContext.CHUCVU.ToList();
        }

        public string AddChucVu(ChucVu chucVu)
        {
            _dbContext.Add(chucVu);
            _dbContext.SaveChanges();
            GetlstChucVusFromDB();
            return "Thêm thành công";
        }
        public string UpdateChucVu(ChucVu chucVu)
        {
            _dbContext.Update(chucVu);
            _dbContext.SaveChanges();
            GetlstChucVusFromDB();
            return "Sửa thành công";
        }
        public string DeleteChucVu(int id)
        {
            _dbContext.Remove(_lstChucVus.FirstOrDefault(c => c.Id == id));
            _dbContext.SaveChanges();
            GetlstChucVusFromDB();
            return "Xóa thành công";
        }
    }
}
