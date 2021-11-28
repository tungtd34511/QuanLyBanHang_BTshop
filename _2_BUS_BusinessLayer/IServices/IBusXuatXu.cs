using _1_DAL_DataAcessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    interface IBusXuatXu
    {
        List<XuatXu> GetXuatXus();
        void AddXuatXu(XuatXu xuatXu);
        void UpdateXuatXu(XuatXu xuatXu);
        void DeleteXuatXu(int index);
    }
}
