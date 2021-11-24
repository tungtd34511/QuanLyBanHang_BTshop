using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;

namespace _3_GUI_PresentationLayer
{
    public partial class frmThongTinHoaDonCHiTiet : Form
    {
        //Fields
        private IQLSanPhamServices _iQlNuocHoaServices;
        private IQLHoaDonServices _iHoaDonChiTietServices;
        private HoaDonChiTiet _hoaDonChiTiet;
        public frmThongTinHoaDonCHiTiet()
        {
            InitializeComponent();
        }
        public frmThongTinHoaDonCHiTiet(HoaDonChiTiet hoaDonChiTiet)
        {
            InitializeComponent();
            _iQlNuocHoaServices = new QLSanPhamServices();
            //_iDonHangServices = new DonHangServices();
            //_iQlKhachHangServices = new QLKhachHangServices();
            _iHoaDonChiTietServices = new QLHoaDonServices();
            LoadDanhSachSP(hoaDonChiTiet);
            LoadThongTin(hoaDonChiTiet);
        }
        //method
        private void LoadThongTin(HoaDonChiTiet hoaDonChiTiet)
        {
            //if (hoaDonChiTiet != null)
            //{
            //    txt_maNhanVien.Text = hoaDonChiTiet.MaNhanVien;
            //    txt_tenNhanVien.Text = hoaDonChiTiet.TenNhanVien;
            //    txt_tenKhachHang.Text = hoaDonChiTiet.KhachHang.TenKhachHang;
            //    txt_SDT.Text = hoaDonChiTiet.KhachHang.Sdt;
            //    txt_email.Text = hoaDonChiTiet.KhachHang.Email;
            //    txt_MaKhachHang.Text = hoaDonChiTiet.KhachHang.MaKhachHang;
            //    txt_diaChi.Text = hoaDonChiTiet.KhachHang.DiaChi;
            //    txt_maHoaDon.Text = hoaDonChiTiet.MaHoaDon;
            //    if (hoaDonChiTiet.TinhTrang == true)
            //    {
            //        rbtn_hoatDong.Checked = true;
            //    }
            //    else
            //    {
            //        rbtn_KhongHoatDong.Checked = true;
            //    }
            //    txt_Giamgia.Text = hoaDonChiTiet.GiamGia.ToString();
            //    int thanhtien = 0;
            //    int i = dgrid_sanPham.RowCount;
            //    for (int j = 0; j < i; j++)
            //    {
            //        thanhtien += Convert.ToInt32(dgrid_sanPham.Rows[j].Cells[6].Value);
            //    }
            //    int a = thanhtien;
            //    txt_ThanhTien.Text = thanhtien.ToString();
            //   txt_KhoanThu.Text = (Convert.ToInt32(txt_ThanhTien.Text) * (1 - hoaDonChiTiet.GiamGia / 100)).ToString();
            //   txt_NgayNhap.Text = hoaDonChiTiet.Ngayban.ToString();
            //}
        }

        private void LoadDanhSachSP(HoaDonChiTiet hoaDonChiTiet)
        {
            //var lstSP =
            //    from a in _iDonHangServices.GetlstDonHangs()
            //    join b in _iQlNuocHoaServices.getlstNuocHoas()
            //        on a.MaSanPham equals b.MaHang
            //    select new 
            //    {
            //        MaSP = a.MaSanPham,
            //        TenSP = b.NhaSx + " "+ b.TenHang+" "+b.PhienBan+" "+b.DungTich.ToString()+" ml",
            //        DonGia = b.DonGiaNhap,
            //        soLuong = a.SoLuong,
            //        giamGia = 0,
            //        thanhTien = b.DonGiaNhap*a.SoLuong-b.DonGiaNhap*a.SoLuong*0/100
            //    };
            //int t = lstSP.ToList().Count;
            dgrid_sanPham.ColumnCount = 7;
            dgrid_sanPham.Columns[0].Name = "STT";
            dgrid_sanPham.Columns[1].Name = "Mã sản phâm";
            dgrid_sanPham.Columns[2].Name = "Tên sản phẩm";
            dgrid_sanPham.Columns[3].Name = "Số lượng";
            dgrid_sanPham.Columns[4].Name = "Đơn giá";
            dgrid_sanPham.Columns[5].Name = "Giảm giá";
            dgrid_sanPham.Columns[6].Name = "Thành tiền";
            dgrid_sanPham.Rows.Clear();
            int stt = 1;
            //foreach (var x in lstSP.ToList())
            //{
            //    dgrid_sanPham.Rows.Add(stt, x.MaSP, x.TenSP, x.soLuong, x.DonGia, x.giamGia, x.thanhTien);
            //}
        }

        public Control getButtonLuu()
        {
            return btn_luu;
        }

        public HoaDonChiTiet GetHoaDonChiTiet()
        {
            _hoaDonChiTiet = new HoaDonChiTiet();
            _hoaDonChiTiet = _iHoaDonChiTietServices.GetlstHoaDonChiTiets()
                .FirstOrDefault(c => c.HoaDon.Id ==Convert.ToInt32(txt_maHoaDon.Text));
            if (rbtn_hoatDong.Checked)
            {
                _hoaDonChiTiet.HoaDon.TinhTrang = true;
            }
            else
            {
                _hoaDonChiTiet.HoaDon.TinhTrang = false;
            }

            return _hoaDonChiTiet;
        }
    }
}
