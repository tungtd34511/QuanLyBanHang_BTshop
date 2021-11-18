using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
//using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.Utilities;
using FontAwesome.Sharp;
using FontStyle = System.Drawing.FontStyle;
using Size = System.Drawing.Size;

namespace _3_GUI_PresentationLayer
{
    public partial class frmBanHang : Form
    {
        //Fields
        private IQLNuocHoaServices _iQlNuocHoaServices;
        private IHoaDonChiTietServices _iHoaDonChiTietServices;
        private IBanHangServices _iBanHangServices;
        private Info_HoaDon _infoHoaDon;
        //private KhachHang _khachHang;
        public frmBanHang()
        {
            InitializeComponent();
            _iHoaDonChiTietServices = new HoaDonChiTietServices();
            _iQlNuocHoaServices = new QLNuocHoaServices();
            _iBanHangServices = new BanHangServices();
            //_khachHang = new KhachHang();
            _stt = 1;
            _index = 0;
            _indexHoadon = 0;
            dgrid_thongtin.ColumnCount = 6;
            dgrid_thongtin.Columns[0].Name = "STT";
            dgrid_thongtin.Columns[1].Name = "Mã hàng";
            dgrid_thongtin.Columns[2].Name = "Tên sản phẩm chi tiết";
            dgrid_thongtin.Columns[3].Name = "Đơn Giá";
            dgrid_thongtin.Columns[4].Name = "Số Lượng";
            dgrid_thongtin.Columns[5].Name = "Thành tiền";
            ADDBtnTitleHoaDon();
        }
        #region Load danh sách hình ảnh sản phẩm
        private int _stt;
        private int _index;
        private int _indexHoadon;
        private void LoadDS(List<NuocHoa> _list)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                try
                {
                    Color myColor = Color.FromArgb(150, Color.Black);
                    string istr = i.ToString();
                    Label _lbl_1 = new Label();
                    _lbl_1.Text = String.Format("{0:#,##0.##}", _list[i].DonnGiaBan) + " vnđ";
                    _lbl_1.Name = "lbl" + istr;
                    _lbl_1.Dock = DockStyle.Bottom;
                    _lbl_1.BackColor = myColor;
                    _lbl_1.ForeColor = Color.White;
                    Label lb2 = new Label();
                    lb2.Text = _list[i].NhaSx + " " + _list[i].TenHang + " " + _list[i].PhienBan + " " + _list[i].DungTich.ToString() + " ml";
                    lb2.Dock = DockStyle.Bottom;
                    Panel panel1 = new Panel();
                    panel1.Controls.Add(_lbl_1);
                    panel1.Controls.Add(lb2);
                    panel1.Name = "btn" + istr;
                    panel1.Size = panel.Size;
                    panel1.Visible = true;
                    panel1.BackColor = Color.White;
                    panel1.BackgroundImage = Image.FromFile(_list[i].Anh);
                    panel1.BackgroundImageLayout = ImageLayout.Zoom;
                    panel1.Click += (o, s) =>
                    {
                        ADDGridThongtin(_list[Convert.ToInt32(panel1.Name.ToString().Substring(panel1.Name.Length - 1, 1))].MaHang);
                    };
                    panel.Controls.Add(panel1);
                }
                catch (Exception e)
                {
                }
            }
        }

        private void ADDGridThongtin(string input)
        {
            _stt = dgrid_thongtin.RowCount + 1;
            var x = _iQlNuocHoaServices.getlstNuocHoas().FirstOrDefault(c => c.MaQr == input || c.MaHang == input);
            x.Soluong = 1;
            string tenchitiet = x.NhaSx + " " + x.TenHang + " " + x.PhienBan + " " + x.DungTich.ToString() + " ml";
            dgrid_thongtin.Rows.Add(_stt, x.MaHang, tenchitiet, x.DonGiaNhap, x.Soluong, x.Soluong * x.DonGiaNhap);
            int thanhtien = 0;
            for (int j = 0; j < dgrid_thongtin.RowCount; j++)
            {
                thanhtien += Convert.ToInt32(dgrid_thongtin.Rows[j].Cells[5].Value);
            }
            txt_TienHang.Text = thanhtien.ToString();
            txt_TienKhachCanTra.Text = txt_TienHang.Text;
        }
        private void loadQR(string data)
        {
            txt_timKiem.Text = "";
            txt_timKiem.Text = data;
        }
        #endregion
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadDS(_iQlNuocHoaServices.getlstNuocHoas());
        }

        private void btn_QuetQR_Click(object sender, EventArgs e)
        {
            frmQuetQR frmQuetQr = new frmQuetQR();
            frmQuetQr.sendQr = new frmQuetQR.SendQR(loadQR);
            frmQuetQr.ShowDialog();
            ADDGridThongtin(txt_timKiem.Text);
        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            frmThongTinKhachHang frmThongTinKhach = new frmThongTinKhachHang();
            frmThongTinKhach.getbtn_Luu().Click += (o, args) =>
            {
                //_khachHang = frmThongTinKhach.GetKhachHang();
                frmThongTinKhach.Close();
                btn_ThemKhachHang.Visible = false;
            };
            frmThongTinKhach.ShowDialog();
        }

        private void txt_TienKhachTra_TextChanged(object sender, EventArgs e)
        {
            txt_Tienthua.Text = (int.Parse(txt_TienKhachTra.Text) - int.Parse(txt_TienKhachCanTra.Text)).ToString();
        }

        private void dgrid_thongtin_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            for (int i = 0; i < dgrid_thongtin.RowCount; i++)
            {
                int a = int.Parse(dgrid_thongtin.Rows[rowindex].Cells[3].Value.ToString())*int.Parse(dgrid_thongtin.Rows[rowindex].Cells[4].Value.ToString());
                dgrid_thongtin.Rows[rowindex].Cells[5].Value = a.ToString();
            }
            int thanhtien = 0;
            for (int j = 0; j < dgrid_thongtin.RowCount; j++)
            {
                thanhtien += Convert.ToInt32(dgrid_thongtin.Rows[j].Cells[5].Value);
            }
            txt_TienHang.Text = thanhtien.ToString();
            txt_TienKhachCanTra.Text = txt_TienHang.Text;
        }

        private void dgrid_thongtin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgrid_thongtin.Rows.Remove(dgrid_thongtin.Rows[e.RowIndex]);
            int thanhtien = 0;
            for (int j = 0; j < dgrid_thongtin.RowCount; j++)
            {
                thanhtien += Convert.ToInt32(dgrid_thongtin.Rows[j].Cells[5].Value);
            }
            txt_TienHang.Text = thanhtien.ToString();
            txt_TienKhachCanTra.Text = txt_TienHang.Text;
        }
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            _iHoaDonChiTietServices.ADDHoaDonChiTiet(new HoaDonChiTiet()
            {
                GiamGia = 0,
                GiaTriDonHang = int.Parse(txt_TienHang.Text),
                //KhachHang = _khachHang,
                //LstDonHangs = new List<DonHang>(),
                MaHoaDon = "HD0001",
                MaNhanVien = "NV001",
                Ngayban = DateTime.Today,
                TenNhanVien = "Tạ DUy Tùng",
                TinhTrang = true
            });
        }
        private void btn_ThemHoaDon_Click(object sender, EventArgs e)
        {
           ADDBtnTitleHoaDon();
        }
        private void ADDBtnTitleHoaDon()
        {
            btn_ThemHoaDon.Visible = false;
            _indexHoadon += 1;
            _index = Menu_BanHang.Panel1.Controls.Count;
            Panel title_HoaDon = new Panel();
            title_HoaDon.Name = "title_HoaDon" + _index.ToString();
            title_HoaDon.Dock = DockStyle.Left;
            title_HoaDon.BackColor = Color.Transparent;
            IconButton btn_X = new IconButton();
            btn_X.Name = "btn_x" + _index.ToString();
            btn_X.Text = "X";
            btn_X.Font = new Font("Arial", 15,FontStyle.Bold);
            btn_X.FlatAppearance.BorderSize = 0;
            btn_X.FlatStyle = FlatStyle.Flat;
            btn_X.Size = new Size(45, 5);
            btn_X.Dock = DockStyle.Right;
            btn_X.Click += (o, e) =>
            {
                try
                {
                    if (Menu_BanHang.Panel1.Controls.Count > 2)
                    {
                        if (btn_X.Name.Substring(btn_X.Name.Length - 1, 1) ==
                            title_HoaDon.Name.Substring(title_HoaDon.Name.Length - 1, 1))
                        {
                            Menu_BanHang.Panel1.Controls.Remove(title_HoaDon);
                        }
                    }
                }
                catch (Exception exception)
                {
                }
            };
            Button nameHoaDon = new Button();
            nameHoaDon.Name = "nameHoaDon" + _index.ToString();
            nameHoaDon.Text = "Hóa đơn " + _indexHoadon.ToString();
            nameHoaDon.Font = new Font("Arial", 10);
            nameHoaDon.Dock = DockStyle.Fill;
            nameHoaDon.FlatStyle = FlatStyle.Flat;
            nameHoaDon.FlatAppearance.BorderSize = 0;
            nameHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            title_HoaDon.Controls.Add(btn_X);
            title_HoaDon.Controls.Add(nameHoaDon);
            title_HoaDon.Controls.Add(new Button()
            {
                FlatStyle = FlatStyle.Flat,
                Size = new Size(2, 5),
                FlatAppearance = { BorderSize = 1,BorderColor = Color.Gray},
                Dock = DockStyle.Right
            });
            Menu_BanHang.Panel1.Controls.Add(title_HoaDon);
            btn_ThemHoaDon.Visible = true;
        }
    }
}
