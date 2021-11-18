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

namespace _3_GUI_PresentationLayer
{
    public partial class frmThongTinNhanVien : Form
    {
        //Fields
        private NhanVien _nhanVien;
        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }
        public frmThongTinNhanVien(NhanVien nhanVien)
        {
            InitializeComponent();
            _nhanVien = new NhanVien();
            LoadthongTin(nhanVien);
        }
        //method
        public Control GetBtnLuu()
        {
            return btn_Luu;
        }

        //public NhanVien GetNhanVien()
        //{
        //    _nhanVien = new NhanVien();
        //    _nhanVien.Id = txt_MaNhanVien.Text;
        //    _nhanVien.Ten = txt_TenNhanVien.Text;
        //    _nhanVien.NgaySinh = txt_NgaySinh.Value;
        //    _nhanVien.ChucVu = rbtn_HoatDong.Checked == true ? true : false;
        //    _nhanVien.GioiTinh = txt_Phai.Text == "Nam" ? true : false;
        //    _nhanVien.GhiChu = txt_GhiCHu.Text;
        //    _nhanVien.Email = txt_email.Text;
        //    _nhanVien.Sdt = txt_SoDienThoai.Text;
        //    _nhanVien.DiaChi = txt_DiaChi.Text;
        //    _nhanVien.TinhTrang = rbtn_HoatDong.Checked == true ? true : false;
        //    return _nhanVien;
        //}
        private void LoadthongTin(NhanVien nhanVien)
        {
            //if (nhanVien != null)
            //{
            //    txt_MaNhanVien.Text = nhanVien.Id;
            //    txt_TenNhanVien.Text = nhanVien.Ten;
            //    txt_NgaySinh.Value = nhanVien.NgaySinh;
            //    txt_ChucVu.Text = nhanVien.ChucVu == true ? "Quản lý" : "Nhân viên";
            //    txt_Phai.Text = nhanVien.GioiTinh == true ? "Nam" : "Nữ";
            //    txt_GhiCHu.Text = nhanVien.GhiChu;
            //    txt_email.Text = nhanVien.Email;
            //    txt_SoDienThoai.Text = nhanVien.Sdt;
            //    txt_DiaChi.Text = nhanVien.DiaChi;
            //    rbtn_HoatDong.Checked = nhanVien.TinhTrang == true ? true : false;
            //    rbtn_KhongHoatDong.Checked = nhanVien.TinhTrang == false ? true : false;
            //    txt_anh.Text = _iAnhServices.GetlstAnhs().FirstOrDefault(c => c.Id == nhanVien.MaAnh).Path;
            //    img_NhanVien.Image = Image.FromFile(txt_anh.Text);
            //}
        }

        private void btn_linkIMG_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a img file",
                Title = "Open img file"
            };
            openFileDialog1.FileOk += (o, args) =>
            {
                var filePath = openFileDialog1.FileName;
                txt_anh.Text = filePath.ToString();
                img_NhanVien.Image = Image.FromFile(filePath);
            };
            openFileDialog1.ShowDialog();
        }
        private OpenFileDialog openFileDialog1;
    }
}
