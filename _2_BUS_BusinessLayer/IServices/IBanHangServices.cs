using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IBanHangServices
    {
        List<Info_HoaDon> GetlstInfoHoaDon();
        List<SanPham> GetlstSanPhams();
        void Openfile();
        void Savefile();
        void Add(Info_HoaDon infoHoaDon);
        void Update(Info_HoaDon infoHoaDon, int index);
        void Delete(int index);
        KhachHang GetKhachHang();
    }
}
