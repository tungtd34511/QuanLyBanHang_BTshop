using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _2_BUS_BusinessLayer.Models
{
    public class InfoSanPham
    {
        private SanPham sanPham;
        private MoTaSanPham moTaSanPham;
        private BangGia bangGia;
        private XuatXu xuatXu;

        public InfoSanPham()
        {
        }

        public InfoSanPham(SanPham sanPham, MoTaSanPham moTaSanPham, BangGia bangGia, XuatXu xuatXu)
        {
            this.sanPham = sanPham;
            this.moTaSanPham = moTaSanPham;
            this.bangGia = bangGia;
            this.xuatXu = xuatXu;
        }

        public SanPham SanPham
        {
            get => sanPham;
            set => sanPham = value;
        }

        public MoTaSanPham MoTaSanPham
        {
            get => moTaSanPham;
            set => moTaSanPham = value;
        }

        public BangGia BangGia
        {
            get => bangGia;
            set => bangGia = value;
        }

        public XuatXu XuatXu
        {
            get => xuatXu;
            set => xuatXu = value;
        }
    }
}
