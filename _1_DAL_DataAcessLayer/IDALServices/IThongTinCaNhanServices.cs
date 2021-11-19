using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IDALServices
{
    public interface IThongTinCaNhanServices
    {
        List<ThongTinCaNhan> GetlstThongTinCaNhans();
        void GetlstThongTinCaNhansFromDB();
        string AddThongTinCaNhan(ThongTinCaNhan thongTinCaNhan);
        string UpdateThongTinCaNhan(ThongTinCaNhan thongTinCaNhan);
        string DeleteThongTinCaNhan(int id);
    }
}
