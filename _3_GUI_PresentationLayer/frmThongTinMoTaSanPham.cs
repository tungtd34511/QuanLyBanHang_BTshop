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
    public partial class frmThongTinMoTaSanPham : Form
    {
        private MoTaSanPham _moTa;
        public frmThongTinMoTaSanPham(MoTaSanPham moTaSanPham)
        {
            InitializeComponent();
            _moTa = new MoTaSanPham();
            _moTa = moTaSanPham;
            LoadMoTa(_moTa);
        }

        private void LoadMoTa(MoTaSanPham moTa)
        {
            try
            {
                txt_Id.Text = moTa.Id.ToString();
                txt_DungTich.Text = moTa.DungTich.ToString();
                txt_PhienBan.Text = moTa.PhienBan;
                txt_anh.Text = moTa.Anh;
                txt_ghichu.Text = moTa.GhiChu;
                rbtn_nam.Checked = moTa.GioiTinh == true ? true : false;
                rbtn_nu.Checked = moTa.GioiTinh == false ? true : false;
            }
            catch (Exception e)
            {
            }
        }
        public MoTaSanPham GetMoTa()
        {
            _moTa = new MoTaSanPham();
            _moTa.Id = Convert.ToInt32(txt_Id.Text);
            _moTa.DungTich = Convert.ToInt32(txt_DungTich.Text);
            _moTa.PhienBan = txt_PhienBan.Text;
            _moTa.Anh = txt_anh.Text;
            _moTa.GhiChu = txt_ghichu.Text;
            _moTa.GioiTinh = rbtn_nam.Checked ? true : false;
            return _moTa;
        }

        public Button GetBtnLUU()
        {
            return btn_Luu;
        }
    }
}
