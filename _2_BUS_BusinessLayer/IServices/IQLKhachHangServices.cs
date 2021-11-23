using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IQLKhachHangServices
    {
        List<KhachHang> GetlstKhachHangs();
        void Update(KhachHang khachHang);
        void Add(KhachHang khachHang);
        void Delete(KhachHang khachHang);
    }
}
