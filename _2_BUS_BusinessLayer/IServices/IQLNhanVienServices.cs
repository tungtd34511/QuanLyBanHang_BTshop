using _1_DAL_DataAcessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IQLNhanVienServices
    {
        List<NhanVien> GetlstNhanViens();
        void Update(NhanVien nhanVien);
        void Add(NhanVien nhanVien);
        void Delete(NhanVien nhanVien);
    }
}
