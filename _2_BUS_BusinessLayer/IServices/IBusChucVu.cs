using _1_DAL_DataAcessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    interface IBusChucVu
    {
        List<ChucVu> GetlstChucVus();
        void AddChucVu(ChucVu chucVu);
        void UpdateChucVu(ChucVu chucVu);
        void DeleteChucVu(int index);
    }
}
