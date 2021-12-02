using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.Utilities;
using FontAwesome.Sharp;
using FontStyle = System.Drawing.FontStyle;
using MessageBox = System.Windows.MessageBox;
using Size = System.Drawing.Size;

namespace _3_GUI_PresentationLayer
{
    public partial class frmBanHang : Form
    {
        //Fields
        private IBanHangServices _iBanHangServices;
        private List<int> _lstDonHangs;
        private List<int> _soLuongSP;
        private List<DonHang> _donHangs;
        private List<SanPham> _lstSanPhams;
        private List<SanPham> _lstSanPhamsShow;
        private List<HoaDon> _lstHoaDons;
        private Info_HoaDon _infoHoaDon;
        private KhachHang _khachHang;
        private HoaDon _hoaDon;
        private string _maQR = "";
        private int _indexInfo = 0;
        private int firtIndex = 1;
        private int lastIndex;
        public frmBanHang()
        {
            InitializeComponent();
            _iBanHangServices = new BanHangServices();
            //_iBanHangServices.GetlstInfoHoaDon().Clear();
            //_iBanHangServices.Savefile();
            _iBanHangServices.Openfile();
            _lstSanPhams = new List<SanPham>();
            _lstSanPhamsShow = new List<SanPham>();
            _lstHoaDons = new List<HoaDon>();
            _khachHang = new KhachHang();
            _donHangs = new List<DonHang>();
            _hoaDon = new HoaDon();
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
            //Load Btn_Title
            foreach (var x in _iBanHangServices.GetlstInfoHoaDon())
            {
                _indexHoadon = x.Index;
                btn_ThemHoaDon.Visible = false;
                Panel title_HoaDon = new Panel();
                title_HoaDon.Name = "title_HoaDon" + _indexHoadon.ToString();
                title_HoaDon.Dock = DockStyle.Left;
                title_HoaDon.BackColor = Color.Transparent;
                IconButton btn_X = new IconButton();
                btn_X.Name = "btn_x" + _indexHoadon.ToString();
                btn_X.Text = "X";
                btn_X.Font = new Font("Arial", 10, FontStyle.Bold);
                btn_X.FlatAppearance.BorderSize = 0;
                btn_X.FlatStyle = FlatStyle.Flat;
                btn_X.Size = new Size(25, 5);
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
                                _iBanHangServices.GetlstInfoHoaDon().RemoveAt(_iBanHangServices.GetlstInfoHoaDon()
                                    .FindIndex(c =>
                                        c.Index == Convert.ToInt32(btn_X.Name.Substring(btn_X.Name.Length - 1, 1))));
                                //Load hóa đơn cuối trong danh sách
                                _indexInfo = _iBanHangServices.GetlstInfoHoaDon().Last().Index;
                                LoadinfoHoaDon(_iBanHangServices.GetlstInfoHoaDon().FirstOrDefault(c=>c.Index==_indexInfo));
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
                nameHoaDon.Cursor = Cursors.Hand;
                nameHoaDon.Click += (o, s) =>
                {
                    _iBanHangServices.Update(GetInfoHoaDon(),_iBanHangServices.GetlstInfoHoaDon().FindIndex(c=>c.Index==_indexInfo));
                    dgrid_thongtin.Rows.Clear();
                    _indexInfo = Convert.ToInt32(nameHoaDon.Name.Substring(nameHoaDon.Name.Length - 1, 1));
                    LoadinfoHoaDon(_iBanHangServices.GetlstInfoHoaDon().FirstOrDefault(c =>
                        c.Index == Convert.ToInt32(nameHoaDon.Name.Substring(nameHoaDon.Name.Length - 1, 1))));
                    _indexHoadon = _iBanHangServices.GetlstInfoHoaDon().FirstOrDefault(c =>
                        c.Index == Convert.ToInt32(nameHoaDon.Name.Substring(nameHoaDon.Name.Length - 1, 1))).Index;
                    _indexInfo = _iBanHangServices.GetlstInfoHoaDon().FirstOrDefault(c =>
                        c.Index == Convert.ToInt32(nameHoaDon.Name.Substring(nameHoaDon.Name.Length - 1, 1))).Index;
                    foreach (Control x in Menu_BanHang.Panel1.Controls)
                    {
                        if (x is Panel || x.Name != nameHoaDon.Name)
                        {
                            x.BackColor = Color.Transparent;
                        }
                    }
                    title_HoaDon.BackColor = Color.White;
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
        }
        #region Load danh sách hình ảnh sản phẩm
        private int _stt;
        private int _indexHoadon;
        //Load hình ảnh danh sách sản phẩm
        private void LoadDS(List<SanPham> _list)
        {
            panel.Controls.Clear();
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
                    panel1.Padding = new Padding(0, 5, 0, 5);
                    panel1.Visible = true;
                    panel1.BackColor = Color.White;
                    panel1.BackgroundImage = Image.FromFile(_list[i].MoTaSanPham.Anh);
                    panel1.BackgroundImageLayout = ImageLayout.Zoom;
                    panel1.Cursor = Cursors.Hand;
                    panel1.Click += (o, s) =>
                    {
                        int index = _list[Convert.ToInt32(panel1.Name.ToString().Substring(panel1.Name.Length - 1, 1))].Id;
                        int t=0;
                        for (int j = 0; j < dgrid_thongtin.Rows.Count; j++)
                        {
                            if (dgrid_thongtin.Rows[j].Cells[1].Value.ToString() == index.ToString())
                            {
                                dgrid_thongtin.Rows[j].Cells[4].Value =
                                    (Convert.ToInt32(dgrid_thongtin.Rows[j].Cells[4].Value) + 1).ToString();
                                t = 1;
                            }
                        }
                        if (t!=1)
                        {
                            ADDGridThongtin(_list[Convert.ToInt32(panel1.Name.ToString().Substring(panel1.Name.Length - 1, 1))].Id.ToString(), 1);
                        }
                    };
                    panel1.MouseHover += (o, s) =>
                    {
                        panel1.BackColor = Color.Coral;
                    };
                    panel1.MouseLeave += (o, s) =>
                    {
                        panel1.BackColor = Color.White;
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
                try
                {
                    tenchitiet = x.XuatXu.ThuongHieu + " " + x.Ten + " " + x.MoTaSanPham.PhienBan + " " +
                                 x.MoTaSanPham.DungTich.ToString() + " ml";
                }
                catch (Exception e)
                {
                    tenchitiet = "";
                }

                dgrid_thongtin.Rows.Add(_stt, x.Id, tenchitiet, x.BangGia.GiaBan,soLuong,
                    soLuong * x.BangGia.GiaBan);
            }
        }
        private void loadQR(string data)
        {
            _maQR = "";
            _maQR = data;
            if (_maQR != "")
            {
                int t = 0;
                for (int j = 0; j < dgrid_thongtin.Rows.Count; j++)
                {
                    if (dgrid_thongtin.Rows[j].Cells[1].Value.ToString() ==
                        _lstSanPhams.FirstOrDefault(c => c.MaQR == _maQR).Id.ToString())
                    {
                        dgrid_thongtin.Rows[j].Cells[4].Value =
                            (Convert.ToInt32(dgrid_thongtin.Rows[j].Cells[4].Value) + 1).ToString();
                        t = 1;
                    }
                }
                if (t != 1)
                {
                    ADDGridThongtin(_maQR, 1);
                }
            }
        }
        #endregion
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            //Hiện Danh sách sản phẩm
            _lstSanPhams = _iBanHangServices.GetlstSanPhams().Where(c => c.TinhTrang == true).ToList();
            LoadDS(_lstSanPhams);
            _lstSanPhamsShow = _lstSanPhams;
            LoadTxt_DanhMuc();
        }
        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            frmThongTinKhachHang frmThongTinKhach = new frmThongTinKhachHang(_khachHang);
            frmThongTinKhach.getbtn_Luu().Click += (o, args) =>
            {
                if (frmThongTinKhach.validate())
                {
                    _khachHang = frmThongTinKhach.GetKhachHang();
                    frmThongTinKhach.Close();
                    txt_TenKhachHang.Text = _khachHang.Ten;
                }
                else
                {
                    MessageBox.Show("Mời nhập lại thông tin khách hàng!");
                }
            };
            frmThongTinKhach.ShowDialog();
        }

        private void txt_TienKhachTra_TextChanged(object sender, EventArgs e)
        {
            if (txt_TienKhachTra.Text!=null&&txt_TienKhachTra.Text!=""&&txt_TienKhachTra.Text.Length<10)
            {
                txt_Tienthua.Text = (int.Parse(txt_TienKhachTra.Text) - int.Parse(txt_TienKhachCanTra.Text)).ToString();
            }
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
            if (e.RowIndex > -1)
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

            int stt = 1;
            for (int i = 0; i < dgrid_thongtin.Rows.Count; i++)
            {
                dgrid_thongtin.Rows[i].Cells[0].Value = stt.ToString();
                stt += 1;
            }
        }
        private void btn_ThemHoaDon_Click(object sender, EventArgs e)
        {
            foreach (var x in _iBanHangServices.GetlstInfoHoaDon())
            {
                if (_indexHoadon < x.Index)
                {
                    _indexHoadon = x.Index;
                }
            }
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
            btn_X.Font = new Font("Arial", 10,FontStyle.Bold);
            btn_X.FlatAppearance.BorderSize = 0;
            btn_X.FlatStyle = FlatStyle.Flat;
            btn_X.Size = new Size(25, 5);
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
                            _iBanHangServices.GetlstInfoHoaDon().RemoveAt(_iBanHangServices.GetlstInfoHoaDon()
                                .FindIndex(c =>
                                    c.Index == Convert.ToInt32(btn_X.Name.Substring(btn_X.Name.Length - 1, 1))));
                            //Load hóa đơn cuối trong danh sách
                            _indexInfo = _iBanHangServices.GetlstInfoHoaDon().Last().Index;
                            LoadinfoHoaDon(_iBanHangServices.GetlstInfoHoaDon().FirstOrDefault(c => c.Index == _indexInfo));
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
            nameHoaDon.Cursor = Cursors.Hand;
            nameHoaDon.Click += (o, s) =>
            {
                _iBanHangServices.Update(GetInfoHoaDon(), _iBanHangServices.GetlstInfoHoaDon().FindIndex(c => c.Index == _indexInfo));
                dgrid_thongtin.Rows.Clear();
                _indexInfo = Convert.ToInt32(nameHoaDon.Name.Substring(nameHoaDon.Name.Length - 1, 1));
                LoadinfoHoaDon(_iBanHangServices.GetlstInfoHoaDon().FirstOrDefault(c =>
                    c.Index == Convert.ToInt32(nameHoaDon.Name.Substring(nameHoaDon.Name.Length - 1, 1))));
                _iBanHangServices.Update(GetInfoHoaDon(),_iBanHangServices.GetlstInfoHoaDon().FindIndex(c=>c.Index==_indexInfo));
                foreach (Control x in Menu_BanHang.Panel1.Controls)
                {
                    if (x is Panel || x.Name != nameHoaDon.Name)
                    {
                        x.BackColor = Color.Transparent;
                    }
                }
                title_HoaDon.BackColor = Color.White;
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
            TinhTien();
        }
        //Load thông tin hóa đơn
        private void LoadinfoHoaDon(Info_HoaDon _hoaDon)
        {
            //Hiện table
            dgrid_thongtin.ColumnCount = 6;
            dgrid_thongtin.Columns[0].Name = "STT";
            dgrid_thongtin.Columns[1].Name = "Mã hàng";
            dgrid_thongtin.Columns[2].Name = "Tên sản phẩm chi tiết";
            dgrid_thongtin.Columns[3].Name = "Đơn Giá";
            dgrid_thongtin.Columns[4].Name = "Số Lượng";
            dgrid_thongtin.Columns[5].Name = "Thành tiền";
            dgrid_thongtin.Rows.Clear();
            txt_TienKhachTra.Text = _hoaDon.TienKhachTra.ToString();
            //
            dgrid_thongtin.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgrid_thongtin.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgrid_thongtin.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgrid_thongtin.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgrid_thongtin.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgrid_thongtin.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgrid_thongtin.Columns[1].HeaderCell.Style.BackColor = Color.Blue;
            dgrid_thongtin.Columns[2].HeaderCell.Style.BackColor = Color.DarkGray;
            dgrid_thongtin.Columns[3].HeaderCell.Style.BackColor = Color.DarkGray;
            dgrid_thongtin.Columns[4].HeaderCell.Style.BackColor = Color.DarkGray;
            dgrid_thongtin.Columns[5].HeaderCell.Style.BackColor = Color.DarkGray;
            dgrid_thongtin.Columns[0].HeaderCell.Style.BackColor = Color.DarkGray;
            for (int i = 0; i < _hoaDon.LstSanPhams.Count; i++)
            {
                ADDGridThongtin(_hoaDon.LstSanPhams[i].ToString(),_hoaDon.SoLuongSp[i]);
            }
            _khachHang = _hoaDon.KhachHang;
            txt_TenKhachHang.Text = _khachHang.Ten;
            TinhTien();
            //Làm sáng panel
            foreach (Control x in Menu_BanHang.Panel1.Controls)
            {
                if (x is Panel && x.Name == "title_HoaDon" + _indexInfo.ToString())
                {
                    x.BackColor = Color.White;
                }
            }
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
            txt_Tienthua.Text = (Convert.ToInt32(txt_TienKhachTra.Text) - Convert.ToInt32(txt_TienKhachCanTra.Text))
                .ToString();
        }

        private void dgrid_thongtin_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TinhTien();
        }

        private void frmBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Lưu lại hóa đơn đang làm
            if (_indexInfo != null && _indexInfo > -1)
            {
                _iBanHangServices.Update(GetInfoHoaDon(), _iBanHangServices.GetlstInfoHoaDon().FindIndex(c => c.Index == _indexInfo));
            }
            //Lưu file vào DAta.bin
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
        //Thanh toán
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                _iBanHangServices.Update(GetInfoHoaDon(), _iBanHangServices.GetlstInfoHoaDon().FindIndex(c => c.Index == _indexInfo));
                _iBanHangServices.Savefile();
                List<DonHang> listHang = new List<DonHang>();
                int i = 0;
                foreach (var x in GetInfoHoaDon().LstSanPhams)
                {
                    listHang.Add(new DonHang()
                    {
                        HoaDon = new HoaDon(),
                        SanPham = _iBanHangServices.GetlstSanPhams().FirstOrDefault(c => c.Id == x),
                        SoLuong = GetInfoHoaDon().SoLuongSp[i],
                        TinhTrang = true
                    });
                    i += 1;
                }
                _iBanHangServices.AddtoDB(new HoaDonChiTiet()
                {
                    HoaDon = new HoaDon()
                    {
                        Id = new int(),
                        KhachHang = GetInfoHoaDon().KhachHang,
                        GiamGia = Convert.ToInt32(txt_GiamGia.Text.ToString()),
                        NgayTao = DateTime.Now,
                        TheLoai = true,
                        TinhTrangThanhToan = true,
                        TinhTrang = true
                    },
                    LstDonHangs = listHang
                }, GetInfoHoaDon().LstSanPhams);
                // trừ đi sản phẩm
                for (int j = 0; j < GetInfoHoaDon().LstSanPhams.Count; j++)
                {
                    SanPham sanPham = new SanPham();
                    sanPham = _iBanHangServices.GetlstSanPhams()
                        .FirstOrDefault(c => c.Id == GetInfoHoaDon().LstSanPhams[j]);
                    int a = sanPham.SoLuong;
                    sanPham.SoLuong = a - GetInfoHoaDon().SoLuongSp[j];
                    _iBanHangServices.UpdateSP(sanPham);
                }
                MessageBox.Show("Thanh toán thành công !");
            }
        }

        private void btn_QuetQR_Click_1(object sender, EventArgs e)
        {
            frmQuetQR frmQuetQr = new frmQuetQR();
            frmQuetQr.sendQr = new frmQuetQR.SendQR(loadQR);
            frmQuetQr.ShowDialog();
        }
        //Hiện chỉ mục của _lstSanPhamsShow
        private void LoadTxt_DanhMuc()
        {
            lastIndex = (_lstSanPhamsShow.Count / 10)+1;
            txt_DanhMuc.Text = firtIndex.ToString() + " / " + lastIndex.ToString();
        }
        //Lọc Danh sách dản phẩm
        private void cbox_LocDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = cbox_LocDanhSach.SelectedIndex;
            if (index != null)
            {
                switch (index)
                {
                    case 0:
                        _lstSanPhamsShow = _lstSanPhams;
                        LoadDS(_lstSanPhamsShow);
                        break;
                    case 1:
                        _lstSanPhamsShow = _lstSanPhams.OrderBy(x=>x.XuatXu.ThuongHieu).ToList();
                        LoadDS(_lstSanPhamsShow);
                        break;
                    case 2:
                        _lstSanPhamsShow = _lstSanPhams.OrderByDescending(x => x.XuatXu.ThuongHieu).ToList();
                        LoadDS(_lstSanPhamsShow);
                        break;
                    case 3:
                        _lstSanPhamsShow = _lstSanPhams.OrderBy(x => x.MoTaSanPham.DungTich).ToList();
                        LoadDS(_lstSanPhamsShow);
                        break;
                    case 4:
                        _lstSanPhamsShow = _lstSanPhams.OrderByDescending(x => x.MoTaSanPham.DungTich).ToList(); ;
                        LoadDS(_lstSanPhamsShow);
                        break;
                    case 5:
                        _lstSanPhamsShow = _lstSanPhams.OrderBy(x => x.BangGia.GiaBan).ToList();
                        LoadDS(_lstSanPhamsShow);
                        break;
                    case 6:
                        _lstSanPhamsShow = _lstSanPhams.OrderByDescending(x => x.BangGia.GiaBan).ToList();
                        LoadDS(_lstSanPhamsShow);
                        break;
                    case 7:
                        _lstSanPhamsShow = _lstSanPhams.Where(x => x.MoTaSanPham.GioiTinh==true).ToList();
                        LoadDS(_lstSanPhamsShow);
                        break;
                    case 8:
                        _lstSanPhamsShow = _lstSanPhams.Where(x => x.MoTaSanPham.GioiTinh == false).ToList();
                        LoadDS(_lstSanPhamsShow);
                        break;
                    default:
                        _lstSanPhamsShow = _lstSanPhams;
                        LoadDS(_lstSanPhamsShow);
                        break;
                }
                LoadTxt_DanhMuc();
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            firtIndex += 1;
            if (firtIndex>lastIndex)
            {
                firtIndex = lastIndex;
            }
            Loadbyfirtindex();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            firtIndex = lastIndex;
            Loadbyfirtindex();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            firtIndex = 1;
            Loadbyfirtindex();
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            firtIndex -= 1;
            if (firtIndex < 1)
            {
                firtIndex = 1;
            }
            Loadbyfirtindex();
        }
        //LoadDanhSach theo firt index của list
        private void Loadbyfirtindex()
        {
            List<SanPham> _list = new List<SanPham>();
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    _list.Add(_lstSanPhamsShow[(firtIndex-1)*10+i]);
                }
                catch (Exception e)
                {
                    
                }
            }
            LoadDS(_list);
            LoadTxt_DanhMuc();
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            _lstSanPhamsShow = new List<SanPham>();
            if (txt_timKiem.Text!=null&&txt_timKiem.Text!=""){
                foreach (var x in _lstSanPhams)
                {
                    if (x.Ten.ToLower().StartsWith(txt_timKiem.Text.ToLower()) ||
                        x.XuatXu.ThuongHieu.ToLower().StartsWith(txt_timKiem.Text.ToLower()) ||
                        x.MoTaSanPham.PhienBan.ToLower().StartsWith(txt_timKiem.Text.ToLower()))
                    {
                        _lstSanPhamsShow.Add(x);
                    }

                }
                LoadDS(_lstSanPhamsShow);
                LoadTxt_DanhMuc();
            }
            else
            {
                _lstSanPhamsShow = _lstSanPhams;
                LoadDS(_lstSanPhams);
                LoadTxt_DanhMuc();
            }
        }

        private bool validate()
        {
            string txtEror = "";
            if (txt_TenKhachHang.Text == null || txt_TenKhachHang.Text == "")
            {
                txtEror += "Mời bạn nhập thông tin khách hàng!";
            }

            if (Convert.ToInt32(txt_Tienthua.Text)<0 )
            {
                txtEror += "Tiền khách trả phải lớn hơn tiền hàng!";
            }

            if (txt_TienHang.Text == 0.ToString())
            {
                txtEror += "Bạn chưa chọn sản phẩm cho đơn hàng";
            }

            if (txtEror != "")
            {
                MessageBox.Show(txtEror);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
