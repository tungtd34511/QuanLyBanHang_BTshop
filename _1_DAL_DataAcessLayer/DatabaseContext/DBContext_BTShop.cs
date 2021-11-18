using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_DataAcessLayer.DatabaseContext
{
    public class DBContext_BTShop : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Khi cấu hình đường dẫn nếu chưa có DB thì có thể đặt tên DB ở đây
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-R5JG4O1\\TEW_SQLEXPRESS;Initial Catalog=QuanLyNuocHoa_BTSHOP;Persist Security Info=True;User ID=tungtdph16451;Password=123");
            }
        }
        public DbSet<Account> TAIKHOAN { get; set; }
        public DbSet<BangGia> BANGGIA { get; set; }
        public DbSet<ChucVu> CHUCVU { get; set; }
        public DbSet<DonHang> DONHANG { get; set; }
        public DbSet<HoaDon> HOADON { get; set; }
        public DbSet<KhachHang> KHACHHANG { get; set; }
        public DbSet<MoTaSanPham> MOTASANPHAM { get; set; }
        public DbSet<NhanVien> NHANVIEN { get; set; }
        public DbSet<SanPham> SANPHAM { get; set; }
        public DbSet<ThongTinCaNhan> THONGTINCANHAN { get; set; }
        public DbSet<XuatXu> XUATXU { get; set; }
    }
}
