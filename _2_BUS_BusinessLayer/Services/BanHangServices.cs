using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.Services
{
    public class BanHangServices : IBanHangServices
    {
        //Field
        private List<Info_HoaDon> _lstInfoHoaDons;
        private List<SanPham> _lstSanPhams;
        private KhachHang _khachHang;
        private BinaryFormatter _bf;
        private FileStream _fs;
        private string _path = @"C:\Users\Admin\OneDrive - Hanoi University of Science and Technology\Desktop\QuanLyBanHang_BTshop\_3_GUI_PresentationLayer\DataTamThoi\Hoadon.bin";
        public BanHangServices()
        {
            _lstInfoHoaDons = new List<Info_HoaDon>();
            _lstSanPhams = new List<SanPham>();
            Openfile();
        }
        //Method
        public List<Info_HoaDon> GetlstInfoHoaDon()
        {
            return _lstInfoHoaDons;
        }
        public List<SanPham> GetlstSanPhams()
        {
            return _lstSanPhams;
        }

        public void Openfile()
        {
            try
            {
                _fs = new FileStream(_path, FileMode.Open);
                _bf = new BinaryFormatter();//Khởi tạo
                var data = _bf.Deserialize(_fs);
                _lstInfoHoaDons = new List<Info_HoaDon>();
                _lstInfoHoaDons = (List<Info_HoaDon>)data;
                _fs.Close();
            }
            catch (Exception e)
            {
            }
        }
        public void Savefile()
        {
            try
            {
                _fs = new FileStream(_path, FileMode.Create);
                _bf = new BinaryFormatter();//Khởi tạo
                _bf.Serialize(_fs,_lstInfoHoaDons);
                _fs.Close();
            }
            catch (Exception e)
            {
            }
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
    }
}
