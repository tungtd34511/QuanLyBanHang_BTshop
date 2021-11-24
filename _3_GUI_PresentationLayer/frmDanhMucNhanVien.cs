using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer;

namespace _3_GUI_PresentationLayer
{
    public partial class frmDanhMucNhanVien : Form
    {
        public frmDanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void LoadData(List<NhanVien> listNhanVien)
        {
            dgrid_NhanVien.Rows.Clear();
            dgrid_NhanVien.ColumnCount = 12;
            dgrid_NhanVien.Columns[0].Name = "STT";
            dgrid_NhanVien.Columns[1].Name = "Mã nhân viên";
            dgrid_NhanVien.Columns[2].Name = "Tên Nhân viên";
            dgrid_NhanVien.Columns[3].Name = "Số điện thoại";
            dgrid_NhanVien.Columns[4].Name = "Email";
            dgrid_NhanVien.Columns[5].Name = "Ngày sinh";
            dgrid_NhanVien.Columns[6].Name = "Giới tính";
            dgrid_NhanVien.Columns[7].Name = "Chức vụ";
            dgrid_NhanVien.Columns[8].Name = "Ảnh";
            dgrid_NhanVien.Columns[9].Name = "Ghi chú";
            dgrid_NhanVien.Columns[10].Name = "Địa chỉ";
            dgrid_NhanVien.Columns[11].Name = "Tình trạng";
            if (listNhanVien.Count>0)
            {
                int stt = 1;
                foreach (var x in listNhanVien)
                {
                    dgrid_NhanVien.Rows.Add(stt, x.Id, x.Ten, x.Sdt, x.Email, x.NgaySinh, x.GioiTinh == true ? "Nam" : "Nữ", x.ChucVu == true  ? "Nhân viên" : "Quản lý", _iAnhServices.GetlstAnhs().FirstOrDefault(c => c.Id == x.MaAnh).Path, x.DiaChi, x.GhiChu, x.TinhTrang == true ? "Hoạt động" : "Không Hoạt động");
                    stt += 1;
                }
            }
        }

        private void dgrid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e, object _iNhanVienServices)
        {
            int rowindex = e.RowIndex;
            int Listindex = _iNhanVienServices.GetlstNhanViens()
                .FindIndex(c => c.Id == dgrid_NhanVien.Rows[rowindex].Cells[1].Value);
            frmThongTinNhanVien frmThongTinNhanVien =
                new frmThongTinNhanVien(_iNhanVienServices.GetlstNhanViens()[Listindex]);
            frmThongTinNhanVien.GetBtnLuu().Click += (o, e) =>
            {
                _iNhanVienServices.EditNhanVien(frmThongTinNhanVien.GetNhanVien(), Listindex);
                frmThongTinNhanVien.Close();
                LoadData(_iNhanVienServices.GetlstNhanViens());
            };
            frmThongTinNhanVien.ShowDialog();
        }

        private void btn_them_Click(object sender, EventArgs e, object _iNhanVienServices)
        {
            frmThongTinNhanVien frmThongTinNhanVien =
                new frmThongTinNhanVien();
            frmThongTinNhanVien.GetBtnLuu().Click += (o, e) =>
            {
                _iNhanVienServices.ADDNhanVien(frmThongTinNhanVien.GetNhanVien());
                frmThongTinNhanVien.Close();
                LoadData(_iNhanVienServices.GetlstNhanViens());
            };
            frmThongTinNhanVien.ShowDialog();
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (txt_timKiem.Text != null && txt_timKiem.Text != "")
            {
               LoadData(_iNhanVienServices.GetlstNhanViens().Where(c=>c.Ten.ToLower().StartsWith(txt_timKiem.Text)&&c.Id==txt_timKiem.Text).ToList());
           }
        }
    }
}
