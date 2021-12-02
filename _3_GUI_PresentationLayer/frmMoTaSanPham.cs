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
using _2_BUS_BusinessLayer.Services;

namespace _3_GUI_PresentationLayer
{
    public partial class frmMoTaSanPham : Form
    {
        private IQLMoTaSanPham _iBusMoTaSanPham;
        public frmMoTaSanPham()
        {
            InitializeComponent();
            _iBusMoTaSanPham = new QLMoTaSanPham();
            LoadGridMotasanpham(_iBusMoTaSanPham.GetlstMoTaSanPham());
        }

        public void LoadGridMotasanpham(List<MoTaSanPham> list)
        {
            dgrid_MotasanPham.ColumnCount = 6;
            dgrid_MotasanPham.Columns[0].Name = "ID";
            dgrid_MotasanPham.Columns[1].Name = "GIỚI TÍNH";
            dgrid_MotasanPham.Columns[2].Name = "DUNG TÍCH";
            dgrid_MotasanPham.Columns[3].Name = "PHIÊN BẢN";
            dgrid_MotasanPham.Columns[4].Name = "ẢNH";
            dgrid_MotasanPham.Columns[5].Name = "GHI CHÚ";
            dgrid_MotasanPham.Rows.Clear();
            try
            {
                foreach (var x in list)
                {
                    dgrid_MotasanPham.Rows.Add(x.Id, x.GioiTinh?"Nam":"Nữ", x.DungTich, x.PhienBan, x.Anh, x.GhiChu);
                }
            }
            catch
            {
                MessageBox.Show("Danh sách có vấn đề, Không hiển thị đc danh sách");
            }
        }

        private void dgrid_MotasanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowindex = e.RowIndex;
            frmThongTinMoTaSanPham frmMota = new frmThongTinMoTaSanPham(_iBusMoTaSanPham.GetlstMoTaSanPham()
                .FirstOrDefault(c => c.Id == Convert.ToInt32(dgrid_MotasanPham.Rows[rowindex].Cells[0].Value)));
            MoTaSanPham moTa = new MoTaSanPham();
            frmMota.GetBtnLUU().Click += (o, args) =>
            {
                moTa = frmMota.GetMoTa();
                _iBusMoTaSanPham.UpdateMoTaSanPham(moTa);
                LoadGridMotasanpham(_iBusMoTaSanPham.GetlstMoTaSanPham());
                frmMota.Close();
            };
            frmMota.ShowDialog();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frmThongTinMoTaSanPham frmMota = new frmThongTinMoTaSanPham(new MoTaSanPham());
            MoTaSanPham moTa = new MoTaSanPham();
            frmMota.GetBtnLUU().Click += (o, args) =>
            {
                moTa = frmMota.GetMoTa();
                _iBusMoTaSanPham.AddMoTaSanPham(moTa);
                LoadGridMotasanpham(_iBusMoTaSanPham.GetlstMoTaSanPham());
                frmMota.Close();
            };
            frmMota.ShowDialog();
        }
    }
}
