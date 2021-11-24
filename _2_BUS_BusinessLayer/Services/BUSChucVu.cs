using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    class BUSChucVu : IBusChucVu
    {
        private IBusChucVu _IbusChucVu;
        private List<ChucVu> _lstChucVu;

        public BUSChucVu()
        {
            _IbusChucVu = new BUSChucVu();
            _lstChucVu = new List<ChucVu>();
            GetlstChucVus();
        }
        public List<ChucVu> GetlstChucVus()
        {
            return _lstChucVu;
        }

        public void AddChucVu(ChucVu chucVu)
        {
            _IbusChucVu.AddChucVu(chucVu);
            GetlstChucVus();
        }

        public void DeleteChucVu(int index)
        {
            _IbusChucVu.DeleteChucVu(index);
            GetlstChucVus();
        }

        

        public void UpdateChucVu(ChucVu chucVu)
        {
            _IbusChucVu.UpdateChucVu(chucVu);
            GetlstChucVus();
        }
    }
}
