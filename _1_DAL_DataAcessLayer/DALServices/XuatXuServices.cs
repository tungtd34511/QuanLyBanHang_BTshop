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
            GetlstXuatXusFromDB();
            return "Thêm thành công";
        }
        public string UpdateXuatXu(XuatXu xuatXu)
        {
            _dbContext.Update(xuatXu);
            _dbContext.SaveChanges();
            GetlstXuatXusFromDB();
            return "Sửa thành công";
        }
        public string DeleteXuatXu(int id)
        {
            _dbContext.Remove(_lstXuatXus.FirstOrDefault(c => c.Id == id));
            _dbContext.SaveChanges();
            GetlstXuatXusFromDB();
            return "Xóa thành công";
        }
    }
}
