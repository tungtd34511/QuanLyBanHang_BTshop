using _1_DAL_DataAcessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    interface IBusBangGia
    {
        List<BangGia> GetlstBangGias();
        void AddBangGia(BangGia bangGia);
        void UpdateBangGia(BangGia bangGia);
        void DeleteBangGia(int index);
    }
}
