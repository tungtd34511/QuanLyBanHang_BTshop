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
using _1_DAL_DataAcessLayer.Entities;
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
        private IQLSanPhamServices _iQlNuocHoaServices;
        private IQLHoaDonServices _iHoaDonChiTietServices;
        private IQLSanPhamServices _iQlSanPhamServices;
        private IBanHangServices _iBanHangServices;
        private List<int> _lstDonHangs;
        private List<int> _soLuongSP;
        private Info_HoaDon _infoHoaDon;
        private KhachHang _khachHang;
        private int _indexInfo = 0;

        public frmBanHang()
        {
            InitializeComponent();
            _iHoaDonChiTietServices = new QLHoaDonServices();
            _iQlNuocHoaServices = new QLSanPhamServices();
            _iBanHangServices = new BanHangServices();
            _iQlSanPhamServices = new QLSanPhamServices();
            //_iBanHangServices.GetlstInfoHoaDon().Clear();
            //_iBanHangServices.Savefile();
            _iBanHangServices.Openfile();
            _khachHang = new KhachHang();
            _stt = 1;
            if (_iBanHangServices.GetlstInfoHoaDon().Count < 1)
            {
                _iBanHangServices.GetlstInfoHoaDon().Add(new Info_HoaDon()
                {
                    Index = 0,
                    KhachHang = new KhachHang(),
                    LstSanPhams = new List<int>(),
                    SoLuongSp = new List<int>(),
                    TienKhachTra = 0
                });
            }
            _index = 0;
            dgrid_thongtin.ColumnCount = 6;
            dgrid_thongtin.Columns[0].Name = "STT";
            dgrid_thongtin.Columns[1].Name = "Mã hàng";
            dgrid_thongtin.Columns[2].Name = "Tên sản phẩm chi tiết";
            dgrid_thongtin.Columns[3].Name = "Đơn Giá";
            dgrid_thongtin.Columns[4].Name = "Số Lượng";
            dgrid_thongtin.Columns[5].Name = "Thành tiền";
            //Load Btn_Title
            foreach (var x in _iBanHangServices.GetlstInfoHoaDon())
            {
                _indexHoadon= x.Index;
                btn_ThemHoaDon.Visible = false;
                Panel title_HoaDon = new Panel();
                title_HoaDon.Name = "title_HoaDon" + _indexHoadon.ToString();
                title_HoaDon.Dock = DockStyle.Left;
                title_HoaDon.BackColor = Color.Transparent;
                IconButton btn_X = new IconButton();
                btn_X.Name = "btn_x" + _indexHoadon.ToString();
                btn_X.Text = "X";
                btn_X.Font = new Font("Arial", 15, FontStyle.Bold);
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
                                _iBanHangServices.GetlstInfoHoaDon().RemoveAt(Convert.ToInt32(title_HoaDon.Name.Substring(title_HoaDon.Name.Length - 1, 1))-1);
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                    }
                };
                Button nameHoaDon = new Button();
                nameHoaDon.Name = "nameHoaDon" + _indexHoadon.ToString();
                nameHoaDon.Text = "Hóa đơn " + _indexHoadon.ToString();
                nameHoaDon.Font = new Font("Arial", 10);
                nameHoaDon.Dock = DockStyle.Fill;
                nameHoaDon.FlatStyle = FlatStyle.Flat;
                nameHoaDon.FlatAppearance.BorderSize = 0;
                nameHoaDon.TextAlign = ContentAlignment.MiddleLeft;
                nameHoaDon.Click += (o, s) =>
                {
                    dgrid_thongtin.Rows.Clear();
                    LoadinfoHoaDon(_iBanHangServices.GetlstInfoHoaDon().FirstOrDefault(c =>
                        c.Index == Convert.ToInt32(nameHoaDon.Name.Substring(nameHoaDon.Name.Length - 1, 1))));
                    _indexHoadon = _iBanHangServices.GetlstInfoHoaDon().FirstOrDefault(c =>
                        c.Index == Convert.ToInt32(nameHoaDon.Name.Substring(nameHoaDon.Name.Length - 1, 1))).Index;
                    _indexInfo = _iBanHangServices.GetlstInfoHoaDon().FirstOrDefault(c =>
                        c.Index == Convert.ToInt32(nameHoaDon.Name.Substring(nameHoaDon.Name.Length - 1, 1))).Index;
                    nameHoaDon.BackColor = Color.White;
                };
                title_HoaDon.Controls.Add(btn_X);
                title_HoaDon.Controls.Add(nameHoaDon);
                title_HoaDon.Controls.Add(new Button()
                {
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(2, 5),
                    FlatAppearance = { BorderSize = 1, BorderColor = Color.Gray },
                    Dock = DockStyle.Right
                });
                Menu_BanHang.Panel1.Controls.Add(title_HoaDon);
                btn_ThemHoaDon.Visible = true;
            }
            LoadinfoHoaDon(_iBanHangServices.GetlstInfoHoaDon()[0]);
            _indexInfo = _iBanHangServices.GetlstInfoHoaDon()[0].Index;
            //Làm mới index hóa đơn
            _indexHoadon = 0;
            foreach (var x in _iBanHangServices.GetlstInfoHoaDon())
            {
                if (_indexHoadon < x.Index)
                {
                    _indexHoadon = x.Index;
                }
            }
        }
        #region Load danh sách hình ảnh sản phẩm
        private int _stt;
        private int _index;
        private int _indexHoadon;
        private void LoadDS(List<SanPham> _list)
        {
            var t = _list[0].MoTaSanPham.Id;
            for (int i = 0; i < _list.Count; i++)
            {
                try
                {
                    Color myColor = Color.FromArgb(150, Color.Black);
                    string istr = i.ToString();
                    Label _lbl_1 = new Label();
                    _lbl_1.Text = String.Format("{0:#,##0.##}", _list[i].BangGia.GiaBan.ToString()) + " vnđ";
                    _lbl_1.Name = "lbl" + istr;
                    _lbl_1.Dock = DockStyle.Bottom;
                    _lbl_1.BackColor = myColor;
                    _lbl_1.ForeColor = Color.White;
                    Label lb2 = new Label();
                    lb2.Text = _list[i].XuatXu.ThuongHieu + " " + _list[i].Ten + " " + _list[i].MoTaSanPham.PhienBan + " " + _list[i].MoTaSanPham.DungTich.ToString() + " ml";
                    lb2.Dock = DockStyle.Bottom;
                    Panel panel1 = new Panel();
                    panel1.Controls.Add(_lbl_1);
                    panel1.Controls.Add(lb2);
                    panel1.Name = "btn" + istr;
                    panel1.Size = panel.Size;
                    panel1.Visible = true;
                    panel1.BackColor = Color.White;
                    panel1.BackgroundImage = Image.FromFile(_list[i].MoTaSanPham.Anh);
                    panel1.BackgroundImageLayout = ImageLayout.Zoom;
                    panel1.Click += (o, s) =>
                    {
                        ADDGridThongtin(_list[Convert.ToInt32(panel1.Name.ToString().Substring(panel1.Name.Length - 1, 1))].Id.ToString(),1);
                    };
                    panel.Controls.Add(panel1);
                }
                catch (Exception e)
                {
                }
            }
        }

        private void ADDGridThongtin(string input,int soLuong)
        {
            if (input != null&&soLuong!=null)
            {
                string tenchitiet;
                _stt = dgrid_thongtin.RowCount + 1;
                var x = _iBanHangServices.GetlstSanPhams()
                    .FirstOrDefault(c => c.MaQR == input || c.Id == Convert.ToInt32(input));
                x.SoLuong = soLuong;
                try
                {
                    tenchitiet = x.XuatXu.ThuongHieu + " " + x.Ten + " " + x.MoTaSanPham.PhienBan + " " +
                                 x.MoTaSanPham.DungTich.ToString() + " ml";
                }
                catch (Exception e)
                {
                    tenchitiet = "";
                }

                dgrid_thongtin.Rows.Add(_stt, x.Id, tenchitiet, x.BangGia.GiaBan, x.SoLuong,
                    x.SoLuong * x.BangGia.GiaBan);
            }
        }
        private void loadQR(string data)
        {
            txt_timKiem.Text = "";
            txt_timKiem.Text = data;
        }
        #endregion
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadDS(_iQlSanPhamServices.GetlstSanPhams());
        }

        private void btn_QuetQR_Click(object sender, EventArgs e)
        {
            frmQuetQR frmQuetQr = new frmQuetQR();
            frmQuetQr.sendQr = new frmQuetQR.SendQR(loadQR);
            frmQuetQr.ShowDialog();
            ADDGridThongtin(txt_timKiem.Text,1);
        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            frmThongTinKhachHang frmThongTinKhach = new frmThongTinKhachHang();
            frmThongTinKhach.getbtn_Luu().Click += (o, args) =>
            {
                _khachHang = frmThongTinKhach.GetKhachHang();
                frmThongTinKhach.Close();
                txt_TenKhachHang.Text = _khachHang.Ten;
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
            //_iHoaDonChiTietServices.ADDHoaDonChiTiet(new HoaDonChiTiet()
            //{
            //    GiamGia = 0,
            //    GiaTriDonHang = int.Parse(txt_TienHang.Text),
            //    KhachHang = _khachHang,
            //    LstDonHangs = new List<DonHang>(),
            //    MaHoaDon = "HD0001",
            //    MaNhanVien = "NV001",
            //    Ngayban = DateTime.Today,
            //    TenNhanVien = "Tạ DUy Tùng",
            //    TinhTrang = true
            //});
        }
        private void btn_ThemHoaDon_Click(object sender, EventArgs e)
        {
           ADDBtnTitleHoaDon();
        }
        private void ADDBtnTitleHoaDon()
        {
            _indexHoadon += 1;
            btn_ThemHoaDon.Visible = false;
            Panel title_HoaDon = new Panel();
            title_HoaDon.Name = "title_HoaDon" + _indexHoadon.ToString();
            title_HoaDon.Dock = DockStyle.Left;
            title_HoaDon.BackColor = Color.Transparent;
            IconButton btn_X = new IconButton();
            btn_X.Name = "btn_x" + _indexHoadon.ToString();
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
            nameHoaDon.Name = "nameHoaDon" + _indexHoadon.ToString();
            nameHoaDon.Text = "Hóa đơn " + _indexHoadon.ToString();
            nameHoaDon.Font = new Font("Arial", 10);
            nameHoaDon.Dock = DockStyle.Fill;
            nameHoaDon.FlatStyle = FlatStyle.Flat;
            nameHoaDon.FlatAppearance.BorderSize = 0;
            nameHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            nameHoaDon.Click += (o, s) =>
            {
                dgrid_thongtin.Rows.Clear();
                LoadinfoHoaDon(_iBanHangServices.GetlstInfoHoaDon().FirstOrDefault(c =>
                    c.Index == Convert.ToInt32(nameHoaDon.Name.Substring(nameHoaDon.Name.Length - 1, 1))));
                _iBanHangServices.Update(GetInfoHoaDon(),_iBanHangServices.GetlstInfoHoaDon().FindIndex(c=>c.Index==_indexInfo));
            };
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
            //Add thông tin vào list
            _iBanHangServices.GetlstInfoHoaDon().Add(new Info_HoaDon()
            {
                Index = _indexHoadon,
                KhachHang = new KhachHang(),
                LstSanPhams = new List<int>(),
                SoLuongSp =new List<int>(),
                TienKhachTra = 0
            });
        }
        //Load thông tin hóa đơn
        private void LoadinfoHoaDon(Info_HoaDon _hoaDon)
        {
                txt_TienKhachTra.Text = _hoaDon.TienKhachTra.ToString();
                for (int i = 0; i < _hoaDon.LstSanPhams.Count; i++)
                {
                    ADDGridThongtin(_hoaDon.LstSanPhams[i].ToString(),_hoaDon.SoLuongSp[i]);
                }
                _khachHang = _hoaDon.KhachHang;
                txt_TenKhachHang.Text = _khachHang.Ten;
        }
        //Load Tiền
        private void dgrid_thongtin_DataMemberChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void TinhTien()
        {
            int thanhtien = 0;
            for (int i = 0; i < dgrid_thongtin.RowCount; i++)
            {
                thanhtien += int.Parse(dgrid_thongtin.Rows[i].Cells[5].Value.ToString());
            }
            txt_TienHang.Text = thanhtien.ToString();
            txt_TienKhachCanTra.Text = txt_TienHang.Text;
        }

        private void dgrid_thongtin_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TinhTien();
        }

        private void frmBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            _iBanHangServices.Update(GetInfoHoaDon(),_iBanHangServices.GetlstInfoHoaDon().FindIndex(c=>c.Index==_indexInfo));
            _iBanHangServices.Savefile();
        }
        //Lấy thông tin của hóa đơn
        private Info_HoaDon GetInfoHoaDon()
        {
            _infoHoaDon = new Info_HoaDon();
            _infoHoaDon.KhachHang = _khachHang;
            _infoHoaDon.TienKhachTra = Convert.ToInt32(txt_TienKhachTra.Text);
            _lstDonHangs = new List<int>();
            _soLuongSP = new List<int>();
            for (int i = 0; i < dgrid_thongtin.RowCount; i++)
            {
                _lstDonHangs.Add(int.Parse(dgrid_thongtin.Rows[i].Cells[1].Value.ToString()));
                _soLuongSP.Add(int.Parse(dgrid_thongtin.Rows[i].Cells[4].Value.ToString()));
            }
            _infoHoaDon.LstSanPhams = _lstDonHangs;
            _infoHoaDon.SoLuongSp = _soLuongSP;
            _infoHoaDon.Index = _indexInfo;
            return _infoHoaDon;
        }
    }
}
