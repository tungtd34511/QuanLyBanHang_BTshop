using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    class BusXuatXu : IBusXuatXu
    {
        private IBusXuatXu _IbusXuatXu;
        private List<XuatXu> _lstXuatXu;

        public BusXuatXu()
        {
            _IbusXuatXu = new BusXuatXu();
            _lstXuatXu = new List<XuatXu>();
            GetXuatXus();
        }

        public List<XuatXu> GetXuatXus()
        {
            return _lstXuatXu;
        }

        public void AddXuatXu(XuatXu xuatXu)
        {
            _IbusXuatXu.AddXuatXu(xuatXu);
        }

        public void DeleteXuatXu(int index)
        {
            _IbusXuatXu.DeleteXuatXu(index);
        }

        

        public void UpdateXuatXu(XuatXu xuatXu)
        {
            _IbusXuatXu.UpdateXuatXu(xuatXu);
        }
    }
}
