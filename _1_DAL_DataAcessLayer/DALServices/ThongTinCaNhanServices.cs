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
    public class ThongTinCaNhanServices : IThongTinCaNhanServices
    {
        private List<ThongTinCaNhan> _lstThongTinCaNhans;
        private DBContext_BTShop _dbContext;
        public ThongTinCaNhanServices()
        {
            _dbContext = new DBContext_BTShop();
            _lstThongTinCaNhans = new List<ThongTinCaNhan>();
            GetlstThongTinCaNhansFromDB();
        }
        public List<ThongTinCaNhan> GetlstThongTinCaNhans()
        {
            return _lstThongTinCaNhans;
        }

        public void GetlstThongTinCaNhansFromDB()
        {
            _lstThongTinCaNhans = _dbContext.THONGTINCANHAN.ToList();
        }

        public string AddThongTinCaNhan(ThongTinCaNhan thongTinCaNhan)
        {
            _dbContext.Add(thongTinCaNhan);
            _dbContext.SaveChanges();
            GetlstThongTinCaNhansFromDB();
            return "Thêm thành công";
        }
        public string UpdateThongTinCaNhan(ThongTinCaNhan thongTinCaNhan)
        {
            _dbContext.Update(thongTinCaNhan);
            _dbContext.SaveChanges();
            GetlstThongTinCaNhansFromDB();
            return "Sửa thành công";
        }
        public string DeleteThongTinCaNhan(int id)
        {
            _dbContext.Remove(_lstThongTinCaNhans.FirstOrDefault(c => c.Id == id));
            _dbContext.SaveChanges();
            GetlstThongTinCaNhansFromDB();
            return "Xóa thành công";
        }
    }
}
