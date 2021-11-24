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
    public class NhanVienServices : INhanVienServices
    {
        private List<NhanVien> _lstNhanViens;
        private DBContext_BTShop _dbContext;
        public NhanVienServices()
        {
            _dbContext = new DBContext_BTShop();
            _lstNhanViens = new List<NhanVien>();
            GetlstNhanViensFromDB();
        }
        public List<NhanVien> GetlstNhanViens()
        {
            return _lstNhanViens;
        }

        public void GetlstNhanViensFromDB()
        {
            _lstNhanViens = _dbContext.NHANVIEN.ToList();
        }

        public string AddNhanVien(NhanVien nhanVien)
        {
            _dbContext.Add(nhanVien);
            _dbContext.SaveChanges();
            GetlstNhanViensFromDB();
            return "Thêm thành công";
        }
        public string UpdateNhanVien(NhanVien nhanVien)
        {
            var entry = _dbContext.NHANVIEN.First(e => e.Id == nhanVien.Id);
            _dbContext.Entry(entry).CurrentValues.SetValues(nhanVien);
            _dbContext.SaveChanges();
            GetlstNhanViensFromDB();
            return "Sửa thành công";
        }
        public string DeleteNhanVien(int id)
        {
            _dbContext.Remove(_lstNhanViens.FirstOrDefault(c => c.Id == id));
            _dbContext.SaveChanges();
            GetlstNhanViensFromDB();
            return "Xóa thành công";
        }
    }
}
