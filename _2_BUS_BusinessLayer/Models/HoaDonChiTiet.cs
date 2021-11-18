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
       private string maHoaDon;
       private string maNhanVien;
       private string tenNhanVien;
       private DateTime ngayban;
       private int giamGia;
       private int giaTriDonHang;
       private List<DonHang> lstDonHangs;
       private KhachHang khachHang;
       private bool tinhTrang;

       public HoaDonChiTiet()
       {
       }

       public HoaDonChiTiet(string maNhanVien, string tenNhanVien, DateTime ngayban, int giamGia, int giaTriDonHang, List<DonHang> lstDonHangs, KhachHang khachHang, string maHoaDon,bool tinhTrang)
       {
           this.maHoaDon = maHoaDon;
           this.maNhanVien = maNhanVien;
           this.tenNhanVien = tenNhanVien;
           this.ngayban = ngayban;
           this.giamGia = giamGia;
           this.giaTriDonHang = giaTriDonHang;
           this.lstDonHangs = lstDonHangs;
           this.khachHang = khachHang;
           this.tinhTrang = tinhTrang;
       }

       public bool TinhTrang
       {
           get => tinhTrang;
           set => tinhTrang = value;
       }

       public string MaHoaDon
       {
           get => maHoaDon;
           set => maHoaDon = value;
       }

       public string MaNhanVien
       {
           get => maNhanVien;
           set => maNhanVien = value;
       }

       public string TenNhanVien
       {
           get => tenNhanVien;
           set => tenNhanVien = value;
       }

       public DateTime Ngayban
       {
           get => ngayban;
           set => ngayban = value;
       }

       public int GiamGia
       {
           get => giamGia;
           set => giamGia = value;
       }

       public int GiaTriDonHang
       {
           get => giaTriDonHang;
           set => giaTriDonHang = value;
       }

       public List<DonHang> LstDonHangs
       {
           get => lstDonHangs;
           set => lstDonHangs = value;
       }

       public KhachHang KhachHang
       {
           get => khachHang;
           set => khachHang = value;
       }
   }
}
