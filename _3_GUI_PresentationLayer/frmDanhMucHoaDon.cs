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

namespace _3_GUI_PresentationLayer
{
    public partial class frmDanhMucHoaDon : Form
    {
        private IHoaDonChiTietServices _iHoaDonChiTietServices;
        public frmDanhMucHoaDon()
        {
            InitializeComponent();
            _iHoaDonChiTietServices = new HoaDonChiTietServices();
            LoadDS(_iHoaDonChiTietServices.GetlstHoaDonChiTiets());
        }
        //method
        private void LoadDS(List<HoaDonChiTiet> listHoaDonChiTiets)
        {
                dgrid_Hoadon.ColumnCount = 7;
                dgrid_Hoadon.Columns[0].Name = "STT";
                dgrid_Hoadon.Columns[1].Name = "Mã hóa đơn";
                dgrid_Hoadon.Columns[2].Name = "Mã nhân viên";
                dgrid_Hoadon.Columns[3].Name = "Mã khách hàng";
                dgrid_Hoadon.Columns[4].Name = "Giá trị đơn hàng";
                dgrid_Hoadon.Columns[5].Name = "Giảm giá";
                dgrid_Hoadon.Columns[6].Name = "Khoản thu về";
                dgrid_Hoadon.Rows.Clear();
                int stt = 1;
                //foreach (var x in listHoaDonChiTiets)
                //{
                //    dgrid_Hoadon.Rows.Add(stt, x.MaHoaDon, x.MaNhanVien, x.KhachHang.MaKhachHang, x.GiaTriDonHang,
                //        x.GiamGia, x.GiaTriDonHang * x.GiamGia / 100);
                //    stt += 1;
                //}
        }

        private void dgrid_Hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int listIndex = _iHoaDonChiTietServices.GetlstHoaDonChiTiets().FindIndex(c =>
                c.MaHoaDon == dgrid_Hoadon.Rows[rowindex].Cells[1].Value.ToString());
            frmThongTinHoaDonCHiTiet frmThongTinHoaDonCHiTiet =
                new frmThongTinHoaDonCHiTiet(_iHoaDonChiTietServices.GetlstHoaDonChiTiets()[listIndex]);
            frmThongTinHoaDonCHiTiet.getButtonLuu().Click += (o, s) =>
            {
                _iHoaDonChiTietServices.EditHoaDonChitiet(frmThongTinHoaDonCHiTiet.GetHoaDonChiTiet(), listIndex);
                frmThongTinHoaDonCHiTiet.Close();
                LoadDS(_iHoaDonChiTietServices.GetlstHoaDonChiTiets());
            };
            frmThongTinHoaDonCHiTiet.ShowDialog();
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (txt_timKiem.Text != "")
            {
                LoadDS(_iHoaDonChiTietServices.GetlstHoaDonChiTiets().Where(c => c.MaHoaDon == txt_timKiem.Text)
                    .ToList());
            }
        }
    }
}
