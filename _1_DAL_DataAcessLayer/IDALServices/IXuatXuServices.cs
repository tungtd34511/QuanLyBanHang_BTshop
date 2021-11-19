using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IDALServices
{ 
    public interface IXuatXuServices
    {
        List<XuatXu> GetlstXuatXus();
        void GetlstXuatXusFromDB();
        string AddXuatXu(XuatXu xuatXu);
        string UpdateXuatXu(XuatXu xuatXu);
        string DeleteXuatXu(int id);
    }
}
