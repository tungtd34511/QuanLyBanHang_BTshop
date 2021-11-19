using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IDALServices
{
    public interface IKhachHangServices
    {
        List<KhachHang> GetlstKhachHangs();
        void GetlstKhachHangsFromDB();
        string AddKhachHang(KhachHang khachHang);
        string UpdateKhachHang(KhachHang khachHang);
        string DeleteKhachHang(int id);
    }
}
