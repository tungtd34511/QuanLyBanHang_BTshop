using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;
//using _1_DAL_DataAcessLayer.DALServices;
//using _1_DAL_DataAcessLayer.IDALServices;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.Services
{
    public class QLNuocHoaServices : IQLNuocHoaServices
    {
        //private ISanPhamServices _iSanPhamServices;
        //private IAnhServices _iAnhServices;
        private List<NuocHoa> _lstNuocHoas;
        private NuocHoa _nuocHoa;
        private string _input;
        public QLNuocHoaServices()
        {
            //_iSanPhamServices = new SanPhamServices();
            //_iAnhServices = new AnhServices();
            getlstNuocHoas();
        }
        public void addNuocHoa(NuocHoa nuocHoa)
        {
            _lstNuocHoas.Add(nuocHoa);
        }

        public NuocHoa findNuocHoa(string input)
        {
            _nuocHoa = _lstNuocHoas.FirstOrDefault(c => c.MaQr == input);
            return _nuocHoa;
        }
        public void editNuocHoa(NuocHoa nuocHoa, int index)
        {
            _lstNuocHoas[index] = nuocHoa;
        }
        public List<NuocHoa> getlstNuocHoas()
        {
            _lstNuocHoas = new List<NuocHoa>();
            //var lstSP =
            //    from a in _iAnhServices.GetlstAnhs()
            //    join b in _iSanPhamServices.GetlstSanPhams()
            //        on a.Id equals b.MaAnh
            //    select (a.Path, b.MaSanPham, b.TenHang, b.MaQr, b.NhaSx, b.Xuatxu, b.NamPhatHanh, b.Phai, b.PhienBan,
            //        b.Soluong, b.DonGiaNhap, b.DonnGiaBan, b.DungTich, b.TinhTrang, b.GhiChu);
            //for (int i = 0;i< lstSP.ToList().Count; i++)
            //{
            //    _lstNuocHoas.Add(new NuocHoa()
            //    {
            //        MaHang = lstSP.ToList()[i].MaSanPham,
            //        TenHang = lstSP.ToList()[i].TenHang,
            //        Anh = lstSP.ToList()[i].Path,
            //        MaQr = lstSP.ToList()[i].MaQr,
            //        NhaSx = lstSP.ToList()[i].NhaSx,
            //        Xuatxu = lstSP.ToList()[i].Xuatxu,
            //        NamPhatHanh = lstSP.ToList()[i].NamPhatHanh,
            //        Phai = lstSP.ToList()[i].Phai,
            //        PhienBan = lstSP.ToList()[i].PhienBan,
            //        Soluong = lstSP.ToList()[i].Soluong,
            //        DonGiaNhap = lstSP.ToList()[i].DonGiaNhap,
            //        DonnGiaBan = lstSP.ToList()[i].DonnGiaBan,
            //        DungTich = lstSP.ToList()[i].DungTich,
            //        TinhTrang = lstSP.ToList()[i].TinhTrang==true?1:0,
            //        GhiChu = lstSP.ToList()[i].GhiChu,
            //    });
            //}
            Account _account = new Account();
            return _lstNuocHoas;
        }
    }
}
