using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IDALServices
{
    public interface INhanVienServices
    {
        List<NhanVien> GetlstNhanViens();
        void GetlstNhanViensFromDB();
        string AddNhanVien(NhanVien nhanVien);
        string UpdateNhanVien(NhanVien nhanVien);
        string DeleteNhanVien(int id);
    }
}
