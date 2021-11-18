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
        public NuocHoa getNuocHoa()
        {
            _nuocHoa = new NuocHoa();
            _nuocHoa.MaHang = txt_MaHang.Text;
            _nuocHoa.TenHang = txt_TenHang.Text;
            _nuocHoa.NhaSx = txt_ThuongHieu.Text;
            _nuocHoa.Xuatxu = txt_XuatXu.Text;
            _nuocHoa.NamPhatHanh = Convert.ToInt32(txt_NamPhatHanh.Text);
            _nuocHoa.Phai = txt_Phai.Text;
            _nuocHoa.Soluong = Convert.ToInt32(txt_SoLuong.Text);
            _nuocHoa.DonnGiaBan = Convert.ToDouble(txt_DonGiaBan.Text);
            _nuocHoa.DonGiaNhap = Convert.ToDouble(txt_DonGiaNhap.Text);
            _nuocHoa.DungTich = Convert.ToInt32(txt_DungTich.Text);
            if (rbtn_MoBan.Checked == true)
            {
                _nuocHoa.TinhTrang = 1;
            }
            else
            {
                _nuocHoa.TinhTrang = 0;
            }
            _nuocHoa.Anh = txt_anh.Text;
            _nuocHoa.GhiChu = txt_GhiCHu.Text;
            _nuocHoa.PhienBan = txt_PhienBan.Text;
            _nuocHoa.MaQr = txt_QR.Text;
            return _nuocHoa;
        }
        #endregion
        private NuocHoa _nuocHoa;
        public frmThongTinSanPham(NuocHoa _nuocHoa)
        {
            InitializeComponent();
            LoadData(_nuocHoa);
        }

        private void loadQR(string data)
        {
            txt_QR.Text = "";
            txt_QR.Text = data;
        }
        public void LoadData(NuocHoa nuocHoa)
        {
            txt_MaHang.Text = nuocHoa.MaHang;
            txt_TenHang.Text = nuocHoa.TenHang;
            txt_ThuongHieu.Text = nuocHoa.NhaSx;
            txt_XuatXu.Text = nuocHoa.Xuatxu;
            txt_NamPhatHanh.Text = nuocHoa.NamPhatHanh.ToString();
            txt_Phai.Text = nuocHoa.Phai;
            txt_SoLuong.Text = nuocHoa.Soluong.ToString();
            txt_DonGiaBan.Text = nuocHoa.DonnGiaBan.ToString();
            txt_DonGiaNhap.Text = nuocHoa.DonGiaNhap.ToString();
            txt_DungTich.Text = nuocHoa.DungTich.ToString();
            if (nuocHoa.TinhTrang == 1)
            {
                rbtn_MoBan.Checked = true;
            }
            else
            {
                rbtn_KhongMoBan.Checked = true;
            }
            txt_anh.Text = nuocHoa.Anh;
            txt_GhiCHu.Text = nuocHoa.GhiChu;
            txt_PhienBan.Text = nuocHoa.PhienBan;
            txt_QR.Text = nuocHoa.MaQr;
            try
            {

                img_SanPham.Image = Image.FromFile(txt_anh.Text);
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
    }
}
