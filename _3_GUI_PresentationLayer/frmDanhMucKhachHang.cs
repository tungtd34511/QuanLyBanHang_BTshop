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

namespace _3_GUI_PresentationLayer
{
    public partial class frmDanhMucKhachHang : Form
    {
        //Fields 
        //Constructor
        public frmDanhMucKhachHang()
        {
            InitializeComponent();
        }
        //Method
        private void LoadDS(List<KhachHang> listKH)
        {
            dgrid_khachHang.Rows.Clear();
            dgrid_khachHang.ColumnCount = 7;
            dgrid_khachHang.Columns[0].Name = "STT";
            dgrid_khachHang.Columns[1].Name = "Mã Khách Hàng";
            dgrid_khachHang.Columns[2].Name = "Tên Khách Hàng";
            dgrid_khachHang.Columns[3].Name = "Số điện thoại";
            dgrid_khachHang.Columns[4].Name = "Email";
            dgrid_khachHang.Columns[5].Name = "Địa chỉ";
            dgrid_khachHang.Columns[6].Name = "Tình trạng";
            if (listKH != null)
            {
                int stt = 1;
                foreach (var x in listKH)
                {
                    dgrid_khachHang.Rows.Add(stt,/* x.MaKhachHang, x.TenKhachHang, x.Sdt, x.Email, x.DiaChi,*/
                        x.TinhTrang == true ? "Hoạt động" : "Không hoạt động");
                    stt += 1;
                }
            }
        }

        private void frmDanhMucKhachHang_Load(object sender, EventArgs e)
        {
            //LoadDS(_iQlKhachHangServices.GetlstKhachHangs());
        }

        private void dgrid_khachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex > -1)
            {
                //int listindex = _iQlKhachHangServices.GetlstKhachHangs().FindIndex(c =>
                //    c.MaKhachHang == dgrid_khachHang.Rows[rowindex].Cells[1].Value.ToString());
                /*frmThongTinKhachHang frmThongTinKhachHang = new frmThongTinKhachHang(/*//**_iQlKhachHangServices*/
                //    .GetlstKhachHangs()
                //    .FirstOrDefault(c => c.MaKhachHang == dgrid_khachHang.Rows[rowindex].Cells[1].Value.ToString()));
                //frmThongTinKhachHang.getbtn_Luu().Click += (o, e) =>
                //{
                //    _iQlKhachHangServices.EditKhachHang(frmThongTinKhachHang.GetKhachHang(), /*listindex);*/
                //    frmThongTinKhachHang.Close();
                //    LoadDS(_iQlKhachHangServices.GetlstKhachHangs());
                //};
                //frmThongTinKhachHang.ShowDialog();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            frmThongTinKhachHang frmThongTinKhach = new frmThongTinKhachHang();
            frmThongTinKhach.getbtn_Luu().Click += (o, args) =>
            {
                //_iQlKhachHangServices.AddKhachHang(frmThongTinKhach.GetKhachHang());
                //frmThongTinKhach.Close();
                //LoadDS(_iQlKhachHangServices.GetlstKhachHangs());
            };
            frmThongTinKhach.ShowDialog();
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            //if (txt_timKiem.Text != null || txt_timKiem.Text != "")
            //{
            //    LoadDS(_iQlKhachHangServices.GetlstKhachHangs().Where(c =>
            //        c.MaKhachHang == txt_timKiem.Text ||
            //        c.TenKhachHang.ToLower().StartsWith(txt_timKiem.Text.ToLower())).ToList());
            //}
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgrid_khachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
