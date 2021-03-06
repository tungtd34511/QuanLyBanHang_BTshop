using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.DALServices;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IDALServices;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.Services
{
    public class BanHangServices : IBanHangServices
    {
        //Field
        private ISanPhamServices _iSanPhamServices;
        private IDonHangServices _iDonHangServices;
        private IHoaDonServices _iHoaDonServices;
        private List<Info_HoaDon> _lstInfoHoaDons;
        private List<SanPham> _lstSanPhams;
        private KhachHang _khachHang;
        private BinaryFormatter _bf;
        private FileStream _fs;
        private string _path = @"C:\Users\Admin\OneDrive - Hanoi University of Science and Technology\Desktop\QuanLyBanHang_BTshop\_3_GUI_PresentationLayer\DataTamThoi\Hoadon.bin";
        public BanHangServices()
        {
            _iDonHangServices = new DonHangServices();
            _iHoaDonServices = new HoaDonServices();
            _iSanPhamServices = new SanPhamServices();
            _lstInfoHoaDons = new List<Info_HoaDon>();
            _lstSanPhams = new List<SanPham>();
            _lstSanPhams = _iSanPhamServices.GetlstSanPhams();

        }
        //Method
        public List<Info_HoaDon> GetlstInfoHoaDon()
        {
            return _lstInfoHoaDons;
        }
        public List<SanPham> GetlstSanPhams()
        {
            return _iSanPhamServices.GetlstSanPhams(); ;
        }
        public List<HoaDon> GetlstHoaDon()
        {
            return _iHoaDonServices.GetlstHoaDons();
        }
        public List<DonHang> GetlstDonHang()
        {
            return _iDonHangServices.GetlstDonHangs();
        }
        public void Openfile()
        {
                _fs = new FileStream(_path, FileMode.Open);
                _bf = new BinaryFormatter();//Khởi tạo
                var data = _bf.Deserialize(_fs);
                _lstInfoHoaDons = new List<Info_HoaDon>();
                _lstInfoHoaDons = (List<Info_HoaDon>)data;
                _fs.Close();
        }
        public void Savefile()
        {
                _fs = new FileStream(_path, FileMode.Create);
                _bf = new BinaryFormatter();//Khởi tạo
                _bf.Serialize(_fs,_lstInfoHoaDons);
                _fs.Close();
        }

        public void Add(Info_HoaDon infoHoaDon)
        {
            _lstInfoHoaDons.Add(infoHoaDon);
        }

        public void Update(Info_HoaDon infoHoaDon, int index)
        {
            if (index!=null)
            {
                _lstInfoHoaDons[index] = infoHoaDon;
            }
        }

        public void UpdateSP(SanPham sanPham)
        {
            _iSanPhamServices.UpdateSanPham(sanPham);
        }

        public void Delete(int index)
        {
            if (index!= null)
            {
                _lstInfoHoaDons.RemoveAt(index);
            }
        }

        public KhachHang GetKhachHang()
        {
            return _khachHang;
        }

        public void AddtoDB(HoaDonChiTiet hoaDonChiTiet, List<int> lstSanPham)
        {
            hoaDonChiTiet.HoaDon.Id = new int();
            _iHoaDonServices.AddHoaDon(hoaDonChiTiet.HoaDon);
            HoaDon hoaDon = _iHoaDonServices.GetlstHoaDons().LastOrDefault();
            foreach (var x in hoaDonChiTiet.LstDonHangs)
            {
                x.HoaDon = null;
                x.SanPham = null;
                _iDonHangServices.AddDonHang(x);
            }
            for (int j = 0; j < hoaDonChiTiet.LstDonHangs.Count; j++)
            {
                hoaDonChiTiet.LstDonHangs[j].HoaDon = new HoaDon();
                hoaDonChiTiet.LstDonHangs[j].HoaDon = hoaDon;
                hoaDonChiTiet.LstDonHangs[j].SanPham = new SanPham();
                hoaDonChiTiet.LstDonHangs[j].SanPham = _iSanPhamServices.GetlstSanPhams().FirstOrDefault(c=>c.Id== lstSanPham[j]);
                _iDonHangServices.UpdateDonHang(hoaDonChiTiet.LstDonHangs[j]);
            }
        }
    }
}
