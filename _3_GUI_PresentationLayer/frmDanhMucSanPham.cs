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
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.Utilities;

namespace _3_GUI_PresentationLayer
{
    public partial class frmDanhMucSanPham : Form
    {
        private IQLSanPhamServices _iqlSanPhamServices;
        private List<SanPham> _lstSanPhams;
        private SanPham _sanPham;
        private Timer[] timerList = new Timer[100];
        private int timerMaxIndex = -1;
        private void NgayGio()
        {
            lb_NgayGio.Text = "Time: "+ DateTime.Now.ToString();
        }
        public int SetInterval(int time, Action function)
        {
            Timer tmr = new Timer();
            tmr.Interval = time;
            tmr.Tick += new EventHandler(delegate (object s, EventArgs ev)
            {
                function();
            });
            tmr.Start();
            timerMaxIndex++;
            var index = timerMaxIndex;
            timerList[timerMaxIndex] = tmr;
            return index;
        }
        private void LoadDS(List<SanPham> _list)
        {
            dgrid_DSsanPham.ColumnCount = 16;
            dgrid_DSsanPham.Columns[0].Name = "STT";
            dgrid_DSsanPham.Columns[1].Name = "Mã Hàng";
            dgrid_DSsanPham.Columns[2].Name = "Tên Hàng";
            dgrid_DSsanPham.Columns[3].Name = "Nhà sản xuất";
            dgrid_DSsanPham.Columns[4].Name = "Xuất xứ";
            dgrid_DSsanPham.Columns[5].Name = "Phiên bản";
            dgrid_DSsanPham.Columns[6].Name = "Dung tích";
            dgrid_DSsanPham.Columns[7].Name = "Phái";
            dgrid_DSsanPham.Columns[8].Name = "Năm phát hành";
            dgrid_DSsanPham.Columns[9].Name = "Số lượng";
            dgrid_DSsanPham.Columns[10].Name = "Tình trạng";
            dgrid_DSsanPham.Columns[11].Name = "Giá nhập";
            dgrid_DSsanPham.Columns[12].Name = "Giá Bán";
            dgrid_DSsanPham.Columns[13].Name = "Mã QR";
            dgrid_DSsanPham.Columns[14].Name = "Ghi chú";
            dgrid_DSsanPham.Columns[15].Name = "Ảnh";
            dgrid_DSsanPham.Rows.Clear();
            int stt = 1;
            foreach (var x in _list)
            {
                dgrid_DSsanPham.Rows.Add(stt, x.Id, x.Ten, x.XuatXu.ThuongHieu, x.XuatXu.NoiSanXuat, x.MoTaSanPham.PhienBan, x.MoTaSanPham.DungTich.ToString()+" ml", x.MoTaSanPham.GioiTinh == true?"Nam":"Nữ",

                    x.XuatXu.NamPhatHanh, x.SoLuong,x.TinhTrang==true?"Mỡ bán":"Không mở bán" , x.BangGia.GiaNhap, x.BangGia.GiaBan,x.MaQR, x.MoTaSanPham.GhiChu,x.MoTaSanPham.Anh);
                if (stt % 2 == 0)
                {
                    for (int i = 0; i < dgrid_DSsanPham.ColumnCount; i++)
                    {
                        dgrid_DSsanPham.Rows[stt-1].Cells[i].Style.BackColor = Color.LightSkyBlue;
                    }
                }
                stt += 1;
            }
        }
        public frmDanhMucSanPham()
        {
            InitializeComponent();
            _iqlSanPhamServices = new QLSanPhamServices();
            SetInterval(1000, NgayGio);
            LoadDS(_iqlSanPhamServices.GetlstSanPhams());
        }

        private void dgrid_DSsanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _iqlSanPhamServices = new QLSanPhamServices();
            int rowindex = e.RowIndex;
            if (rowindex < _iqlSanPhamServices.GetlstSanPhams().Count && rowindex != -1)
            {
                int listindex = _iqlSanPhamServices.GetlstSanPhams()
                    .FindIndex(c => c.Id.ToString() == dgrid_DSsanPham.Rows[rowindex].Cells[1].Value.ToString());
                _lstSanPhams = _iqlSanPhamServices.GetlstSanPhams();
                frmThongTinSanPham frmThongTinSanPham = new frmThongTinSanPham(_lstSanPhams[listindex]);
                frmThongTinSanPham.GetControl().Click += (s, e) =>
                {
                    this._sanPham = new SanPham();
                    _sanPham = frmThongTinSanPham.getNuocHoa();
                    int a, b, c, d;
                    a = _lstSanPhams[listindex].Id;
                    b = _lstSanPhams[listindex].MoTaSanPham.Id;
                    c = _lstSanPhams[listindex].XuatXu.Id;
                    d = _lstSanPhams[listindex].BangGia.Id;
                    _lstSanPhams[listindex] = _sanPham;
                    _lstSanPhams[listindex].Id = a;
                    _lstSanPhams[listindex].MoTaSanPham.Id = b;
                    _lstSanPhams[listindex].XuatXu.Id=c;
                    _lstSanPhams[listindex].BangGia.Id=d;
                    _iqlSanPhamServices.Update(_lstSanPhams[listindex]);
                    frmThongTinSanPham.Close();
                    LoadDS(_lstSanPhams);
                };
                frmThongTinSanPham.ShowDialog();
            }
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            _lstSanPhams = new List<SanPham>();
            foreach (var x in _iqlSanPhamServices.GetlstSanPhams().Where(c=>c.Id==int.Parse(txt_TimKiem.Text)||c.Ten.ToLower().StartsWith(txt_TimKiem.Text.ToLower())))
            {
                _lstSanPhams.Add(x);
            }
            LoadDS(_lstSanPhams);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            _sanPham = new SanPham()
            {
                BangGia = new BangGia(),
                XuatXu = new XuatXu(),
                MoTaSanPham = new MoTaSanPham()
            };
            frmThongTinSanPham frmThongTinSanPham = new frmThongTinSanPham(_sanPham);
            frmThongTinSanPham.GetControl().Click += (s, e) =>
            {
                this._sanPham = new SanPham();
                _sanPham = frmThongTinSanPham.getNuocHoa();
                _sanPham.XuatXu.NgayNhap = DateTime.Now;
                _iqlSanPhamServices.Add(_sanPham);
                frmThongTinSanPham.Close();
                this.LoadDS(_iqlSanPhamServices.GetlstSanPhams());
            };
            frmThongTinSanPham.ShowDialog();
        }
    }
}
