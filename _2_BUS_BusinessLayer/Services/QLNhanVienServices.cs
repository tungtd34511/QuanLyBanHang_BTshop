using _1_DAL_DataAcessLayer.DALServices;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IDALServices;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.Services
{
    public class QLNhanVienServices : IQLNhanVienServices
    {
        private INhanVienServices _iKhachHangServices;
        private List<NhanVien> _lstKhachHangs;
        private NhanVienServices _iNhanVienServices;
        private List<NhanVien> _lstNhanViens;

        public QLNhanVienServices()
        {
            _iNhanVienServices = new NhanVienServices();
        }

        public List<NhanVien> GetlstNhanViens()
        {
            _lstNhanViens = new List<NhanVien>();
            _lstNhanViens = _iNhanVienServices.GetlstNhanViens();
            return _lstNhanViens;
        }

        public void Update(NhanVien nhanVien)
        {
            _iNhanVienServices.UpdateNhanVien(nhanVien);
            GetlstNhanViens();
        }

        public void Add(NhanVien nhanVien)
        {
            _iNhanVienServices.AddNhanVien(nhanVien);
            GetlstNhanViens();
        }

        public void Delete(NhanVien nhanVien)
        {
            _iNhanVienServices.DeleteNhanVien(nhanVien.Id);
            GetlstNhanViens();
        }
    }
}
