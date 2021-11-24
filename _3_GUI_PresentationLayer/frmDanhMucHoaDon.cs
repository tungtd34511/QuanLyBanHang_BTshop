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
        private IQLHoaDonServices _iQlHoaDonServices;
        public frmDanhMucHoaDon()
        {
            InitializeComponent();
            _iQlHoaDonServices = new QLHoaDonServices();
            LoadDS(_iQlHoaDonServices.GetlstHoaDonChiTiets());
        }
        //method
        private void LoadDS(List<HoaDonChiTiet> listHoaDonChiTiets)
        {
            dgrid_Hoadon.ColumnCount = 9;
            dgrid_Hoadon.Columns[0].Name = "STT";
            dgrid_Hoadon.Columns[1].Name = "Mã hóa đơn";
            dgrid_Hoadon.Columns[3].Name = "Mã khách hàng";
            dgrid_Hoadon.Columns[4].Name = "Thể Loại";
            dgrid_Hoadon.Columns[5].Name = "Giảm giá";
            dgrid_Hoadon.Columns[6].Name = "Ngày tạo";
            dgrid_Hoadon.Columns[7].Name = "Tình trạng Thanh Toán";
            dgrid_Hoadon.Columns[8].Name = "Tình trạng";
            dgrid_Hoadon.Rows.Clear();
            int stt = 1;
            foreach (var x in listHoaDonChiTiets)
            {
                dgrid_Hoadon.Rows.Add(stt, x.HoaDon.Id, x.HoaDon.KhachHang.Id, x.HoaDon.TheLoai==true?"Thanh toán trực tiếp":"Đặt hàng",
                    x.HoaDon.GiamGia, x.HoaDon.NgayTao,x.HoaDon.TinhTrangThanhToan==true?"Đã thanh toán":"Chưa thanh toán",x.HoaDon.TinhTrang==true?"Còn hiệu lực":"Đã hủy");
                stt += 1;
            }
        }

        private void dgrid_Hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int listIndex = _iQlHoaDonServices.GetlstHoaDonChiTiets().FindIndex(c =>
                c.HoaDon.Id == Convert.ToInt32(dgrid_Hoadon.Rows[rowindex].Cells[1].Value.ToString()));
            frmThongTinHoaDonCHiTiet frmThongTinHoaDonCHiTiet =
                new frmThongTinHoaDonCHiTiet(_iQlHoaDonServices.GetlstHoaDonChiTiets()[listIndex]);
            frmThongTinHoaDonCHiTiet.getButtonLuu().Click += (o, s) =>
            {
                _iQlHoaDonServices.Update(frmThongTinHoaDonCHiTiet.GetHoaDonChiTiet());
                frmThongTinHoaDonCHiTiet.Close();
                LoadDS(_iQlHoaDonServices.GetlstHoaDonChiTiets());
            };
            frmThongTinHoaDonCHiTiet.ShowDialog();
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (txt_timKiem.Text != "")
            {
                LoadDS(_iQlHoaDonServices.GetlstHoaDonChiTiets().Where(c => c.HoaDon.Id == Convert.ToInt32(txt_timKiem.Text))
                    .ToList());
            }
        }
    }
}
