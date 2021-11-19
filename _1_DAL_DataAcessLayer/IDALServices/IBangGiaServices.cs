using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IDALServices
{
    public interface IBangGiaServices
    {
        List<BangGia> GetlstBangGias();
        void GetlstBangGiasFromDB();
        string AddBangGia(BangGia bangGia);
        string UpdateBangGia(BangGia bangGia);
        string DeleteBangGia(int id);
    }
}
