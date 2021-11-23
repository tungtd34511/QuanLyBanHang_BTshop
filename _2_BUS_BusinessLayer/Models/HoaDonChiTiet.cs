using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _2_BUS_BusinessLayer.Models
{
   public class HoaDonChiTiet
   {
       private HoaDon hoaDon;
       private List<DonHang> lstDonHangs;

       public HoaDonChiTiet()
       {
       }

       public HoaDonChiTiet(HoaDon hoaDon, List<DonHang> lstDonHangs)
       {
           this.hoaDon = hoaDon;
           this.lstDonHangs = lstDonHangs;
       }

       public HoaDon HoaDon
       {
           get => hoaDon;
           set => hoaDon = value;
       }

       public List<DonHang> LstDonHangs
       {
           get => lstDonHangs;
           set => lstDonHangs = value;
       }
   }
}
