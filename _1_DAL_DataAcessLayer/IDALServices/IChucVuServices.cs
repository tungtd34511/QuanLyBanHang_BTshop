using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IDALServices
{
     public interface IChucVuServices
    {
        List<ChucVu> GetlstChucVus();
        void GetlstChucVusFromDB();
        string AddChucVu(ChucVu chucVu);
        string UpdateChucVu(ChucVu chucVu);
        string DeleteChucVu(int id);
    }
}
