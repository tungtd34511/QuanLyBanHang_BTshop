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
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.Utilities;

namespace _3_GUI_PresentationLayer
{
    public partial class frmDanhMucSanPham : Form
    {
        private IQLNuocHoaServices _iqlSanPhamServices;
        private List<NuocHoa> _listNuocHoas;
        private NuocHoa _nuocHoa;
        private Timer[] timerList = new Timer[100];
        private int timerMaxIndex = -1;
        private ChkInfo chkInfo;
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
        private void LoadDS(List<NuocHoa> _list)
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
            int stt = 1;
            foreach (var x in _list)
            {
                dgrid_DSsanPham.Rows.Add(stt, x.MaHang, x.TenHang, x.NhaSx, x.Xuatxu, x.PhienBan, x.DungTich.ToString()+" ml", x.Phai,

                    x.NamPhatHanh, x.Soluong,chkInfo.chkTinhTrangSP(x.TinhTrang) , x.DonGiaNhap, x.DonnGiaBan,x.MaQr, x.GhiChu,x.Anh);
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
            _iqlSanPhamServices = new QLNuocHoaServices();
            chkInfo = new ChkInfo();
            SetInterval(1000, NgayGio);
            _listNuocHoas = new List<NuocHoa>();
            this.LoadDS(_iqlSanPhamServices.getlstNuocHoas());
        }

        private void dgrid_DSsanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _iqlSanPhamServices = new QLNuocHoaServices();
            int rowindex = e.RowIndex;
            if (rowindex < _iqlSanPhamServices.getlstNuocHoas().Count && rowindex != -1)
            {
                int listindex = _iqlSanPhamServices.getlstNuocHoas()
                    .FindIndex(c => c.MaHang == dgrid_DSsanPham.Rows[rowindex].Cells[1].Value.ToString());
                _listNuocHoas = _iqlSanPhamServices.getlstNuocHoas();
                frmThongTinSanPham frmThongTinSanPham = new frmThongTinSanPham(_listNuocHoas[listindex]);
                frmThongTinSanPham.GetControl().Click += (s, e) =>
                {
                    this._nuocHoa = new NuocHoa();
                    _nuocHoa = frmThongTinSanPham.getNuocHoa();
                    _iqlSanPhamServices.editNuocHoa(_nuocHoa, listindex);
                    frmThongTinSanPham.Close();
                    this.LoadDS(_iqlSanPhamServices.getlstNuocHoas());
                };
                frmThongTinSanPham.ShowDialog();
            }
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            _listNuocHoas = new List<NuocHoa>();
            foreach (var x in _iqlSanPhamServices.getlstNuocHoas().Where(c=>c.MaHang.ToLower().StartsWith(txt_TimKiem.Text.ToLower())||c.TenHang.ToLower().StartsWith(txt_TimKiem.Text.ToLower())))
            {
                _listNuocHoas.Add(x);
            }
            LoadDS(_listNuocHoas);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            _nuocHoa = new NuocHoa();
            frmThongTinSanPham frmThongTinSanPham = new frmThongTinSanPham(_nuocHoa);
            frmThongTinSanPham.GetControl().Click += (s, e) =>
            {
                this._nuocHoa = new NuocHoa();
                _nuocHoa = frmThongTinSanPham.getNuocHoa();
                _iqlSanPhamServices.addNuocHoa(_nuocHoa);
                frmThongTinSanPham.Close();
                this.LoadDS(_iqlSanPhamServices.getlstNuocHoas());
            };
            frmThongTinSanPham.ShowDialog();
        }
    }
}
