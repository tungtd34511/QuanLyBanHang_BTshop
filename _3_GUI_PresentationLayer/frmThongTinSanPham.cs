using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.Models;

namespace _3_GUI_PresentationLayer
{
    public partial class frmThongTinSanPham : Form
    {
        #region  lấy truyền dữ liệu từ bảng danh mục

        public Control GetControl()
        {
            return btn_Luu;
        }
        public SanPham getNuocHoa()
        {
            _nuocHoa = new SanPham();
            _nuocHoa.Id = int.Parse(txt_MaHang.Text);
            _nuocHoa.Ten = txt_TenHang.Text;
            _nuocHoa.XuatXu = new XuatXu()
            {
                ThuongHieu = txt_ThuongHieu.Text,
                NoiSanXuat = txt_XuatXu.Text,
                NamPhatHanh = Convert.ToInt32(txt_NamPhatHanh.Text)
            };
            _nuocHoa.BangGia = new BangGia()
            {
                GiaNhap = int.Parse(txt_DonGiaNhap.Text),
                GiaBan = int.Parse(txt_DonGiaBan.Text)
            };
            _nuocHoa.MoTaSanPham = new MoTaSanPham()
            {
                GioiTinh = txt_Phai.Text == "Nam" ? true : false,
                DungTich = Convert.ToInt32(txt_DungTich.Text),
                Anh = txt_anh.Text,
                GhiChu = txt_GhiCHu.Text,
                PhienBan = txt_PhienBan.Text
            };
            _nuocHoa.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
            _nuocHoa.TinhTrang = rbtn_MoBan.Checked==true ? true : false;
            _nuocHoa.MaQR = txt_QR.Text;
            return _nuocHoa;
        }
        #endregion
        private SanPham _nuocHoa;
        public frmThongTinSanPham(SanPham sanPham)
        {
            InitializeComponent();
            LoadData(sanPham);
        }

        private void loadQR(string data)
        {
            txt_QR.Text = "";
            txt_QR.Text = data;
        }
        public void LoadData(SanPham nuocHoa)
        {
            try
            {
                txt_MaHang.Text = nuocHoa.Id.ToString();
                txt_TenHang.Text = nuocHoa.Ten;
                txt_ThuongHieu.Text = nuocHoa.XuatXu.ThuongHieu;
                txt_XuatXu.Text = nuocHoa.XuatXu.NoiSanXuat;
                txt_NamPhatHanh.Text = nuocHoa.XuatXu.NamPhatHanh.ToString();
                txt_Phai.Text = nuocHoa.MoTaSanPham.GioiTinh == true ? "Nam" : "Nữ";
                txt_SoLuong.Text = nuocHoa.SoLuong.ToString();
                txt_DonGiaBan.Text = nuocHoa.BangGia.GiaBan.ToString();
                txt_DonGiaNhap.Text = nuocHoa.BangGia.GiaNhap.ToString();
                txt_DungTich.Text = nuocHoa.MoTaSanPham.DungTich.ToString();
                rbtn_MoBan.Checked = nuocHoa.TinhTrang == true ? true : false;
                rbtn_KhongMoBan.Checked = nuocHoa.TinhTrang == false ? true : false;
                txt_anh.Text = nuocHoa.MoTaSanPham.Anh;
                txt_GhiCHu.Text = nuocHoa.MoTaSanPham.GhiChu;
                txt_PhienBan.Text = nuocHoa.MoTaSanPham.PhienBan;
                txt_QR.Text = nuocHoa.MaQR;
                try
                {

                    img_SanPham.Image = Image.FromFile(txt_anh.Text);
                }
                catch (Exception e)
                {
                }
            }
            catch (Exception e)
            {
                
            }
        }
        private void btn_QuetMa_Click(object sender, EventArgs e)
        {
            frmQuetQR frmQuetQr = new frmQuetQR();
            frmQuetQr.sendQr = new frmQuetQR.SendQR(loadQR);
            frmQuetQr.ShowDialog();
        }

        private void btn_linkIMG_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a img file",
                Title = "Open img file"
            };
            openFileDialog1.FileOk+=(o, args) => 
            {
                        var filePath = openFileDialog1.FileName;
                        txt_anh.Text = filePath.ToString();
                        img_SanPham.Image = Image.FromFile(filePath);
            };
            openFileDialog1.ShowDialog();
        }
        private OpenFileDialog openFileDialog1;

        public bool validate()
        {
            if (txt_TenHang.Text != "" && txt_DonGiaBan.Text != "" && txt_DonGiaNhap.Text != "" &&
                txt_DungTich.Text != "" && txt_GhiCHu.Text != "" && txt_NamPhatHanh.Text != "" && txt_Phai.Text != "" &&
                txt_PhienBan.Text != "" && txt_QR.Text != "" && txt_SoLuong.Text != "")
            {
                return true;
            }

            return false;
        }
    }
}
