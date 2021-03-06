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
    public class XuatXuServices : IXuatXuServices
    {
        private List<XuatXu> _lstXuatXus;
        private DBContext_BTShop _dbContext;
        public XuatXuServices()
        {
            _dbContext = new DBContext_BTShop();
            _lstXuatXus = new List<XuatXu>();
            GetlstXuatXusFromDB();
        }
        public List<XuatXu> GetlstXuatXus()
        {
            GetlstXuatXusFromDB();
            return _lstXuatXus;
        }

        public void GetlstXuatXusFromDB()
        {
            _lstXuatXus = _dbContext.XUATXU.ToList();
        }

        public string AddXuatXu(XuatXu xuatXu)
        {
            _dbContext.Add(xuatXu);
            _dbContext.SaveChanges();
            return "Thêm thành công";
        }
        public string UpdateXuatXu(XuatXu xuatXu)
        {
            var entry = _dbContext.XUATXU.First(e => e.Id == xuatXu.Id);
            _dbContext.Entry(entry).CurrentValues.SetValues(xuatXu);
            _dbContext.SaveChanges();
            return "Sửa thành công";
        }
        public string DeleteXuatXu(int id)
        {
            _dbContext.Remove(_lstXuatXus.FirstOrDefault(c => c.Id == id));
            _dbContext.SaveChanges();
            return "Xóa thành công";
        }
    }
}
