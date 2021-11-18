﻿using System;
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
    public partial class frmThongTinKhachHang : Form
    {
        //Fields
        private KhachHang _khachHang;
        public frmThongTinKhachHang()
        {
            InitializeComponent();
        }
        public frmThongTinKhachHang(KhachHang khachHang)
        {
            InitializeComponent();
            //LoadDS
            LoadThongTin(khachHang);
        }
        //Method
        private void LoadThongTin(KhachHang khachHang)
        {
            //if (khachHang != null)
            //{
            //    txtMaKhachHang.Text = khachHang.MaKhachHang;
            //    txtTenKhachHang.Text = khachHang.TenKhachHang;
            //    txt_SDT.Text = khachHang.Sdt;
            //    txt_email.Text = khachHang.Email;
            //    if (khachHang.TinhTrang == true)
            //    {
            //        rbtn_HoatDong.Checked = true;
            //    }
            //    else
            //    {
            //        rbtn_KhongHoatDong.Checked = true;
            //    }
            //    txt_Diachi.Text = khachHang.DiaChi;
            //}
        }

        public Control getbtn_Luu()
        {
            return btn_Luu;
        }

        //public KhachHang GetKhachHang()
        //{
        //    _khachHang = new KhachHang();
        //    _khachHang.MaKhachHang = txtMaKhachHang.Text;
        //    _khachHang.TenKhachHang = txtTenKhachHang.Text;
        //    _khachHang.Sdt = txt_SDT.Text;
        //    _khachHang.Email = txt_email.Text;
        //    if (rbtn_HoatDong.Checked)
        //    {
        //        _khachHang.TinhTrang = true;
        //    }
        //    else
        //    {
        //        _khachHang.TinhTrang = false;
        //    }

        //    _khachHang.DiaChi = txt_Diachi.Text;
        //    return _khachHang;
        //}
    }
}
