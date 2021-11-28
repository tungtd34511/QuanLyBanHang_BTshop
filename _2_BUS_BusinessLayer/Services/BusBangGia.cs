using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    class BusBangGia : IBusBangGia
    {
        private IBusBangGia _IbusBangGia;
        private List<BangGia> _lstBangGia;

        public BusBangGia()
        {
            _IbusBangGia = new BusBangGia();
            _lstBangGia = new List<BangGia>();
            GetlstBangGias();
        }

        public List<BangGia> GetlstBangGias()
        {
            return _lstBangGia;
        }

        public void AddBangGia(BangGia bangGia)
        {
            _IbusBangGia.AddBangGia(bangGia);
            GetlstBangGias();
        }

        public void UpdateBangGia(BangGia bangGia)
        {
            _IbusBangGia.UpdateBangGia(bangGia);
            GetlstBangGias();
        }

        public void DeleteBangGia(int index)
        {
            _IbusBangGia.DeleteBangGia(index);    
        }

        
    }
}
