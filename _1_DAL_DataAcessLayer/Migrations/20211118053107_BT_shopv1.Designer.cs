// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_DAL_DataAcessLayer.DatabaseContext;

namespace _1_DAL_DataAcessLayer.Migrations
{
    [DbContext(typeof(DBContext_BTShop))]
    [Migration("20211118053107_BT_shopv1")]
    partial class BT_shopv1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Acc")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int?>("MaNhanVien")
                        .HasColumnType("int");

                    b.Property<string>("Pass")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("TinhTrang")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("TAIKHOAN");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.BangGia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GiaBan")
                        .HasColumnType("int");

                    b.Property<int>("GiaNhap")
                        .HasColumnType("int");

                    b.Property<int>("GiamGia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BANGGIA");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.ChucVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenChucVu")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("CHUCVU");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.DonHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("MaHoaDon")
                        .HasColumnType("int");

                    b.Property<int?>("MaSanPham")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<bool>("TinhTrang")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MaHoaDon");

                    b.HasIndex("MaSanPham");

                    b.ToTable("DONHANG");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.HoaDon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GiamGia")
                        .HasColumnType("int");

                    b.Property<int?>("MaKhachHang")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TheLoai")
                        .HasColumnType("bit");

                    b.Property<bool>("TinhTrang")
                        .HasColumnType("bit");

                    b.Property<bool>("TinhTrangThanhToan")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MaKhachHang");

                    b.ToTable("HOADON");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.KhachHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SDT")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Ten")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<bool>("TinhTrang")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("KHACHHANG");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.MoTaSanPham", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Anh")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("DungTich")
                        .HasColumnType("int");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("PhienBan")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("MOTASANPHAM");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.NhanVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("MaChucVu")
                        .HasColumnType("int");

                    b.Property<int?>("MaMoTa")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<bool>("TinhTrang")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MaChucVu");

                    b.HasIndex("MaMoTa");

                    b.ToTable("NHANVIEN");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.SanPham", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("MaBangGia")
                        .HasColumnType("int");

                    b.Property<int?>("MaMoTa")
                        .HasColumnType("int");

                    b.Property<string>("MaQR")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int?>("MaXuatXu")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("TinhTrang")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MaBangGia");

                    b.HasIndex("MaMoTa");

                    b.HasIndex("MaXuatXu");

                    b.ToTable("SANPHAM");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.ThongTinCaNhan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Anh")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("THONGTINCANHAN");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.XuatXu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NamPhatHanh")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiSanXuat")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ThuongHieu")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("XUATXU");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.Account", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("MaNhanVien");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.DonHang", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.HoaDon", "HoaDon")
                        .WithMany()
                        .HasForeignKey("MaHoaDon");

                    b.HasOne("_1_DAL_DataAcessLayer.Entities.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("MaSanPham");

                    b.Navigation("HoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.HoaDon", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("MaKhachHang");

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.NhanVien", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.ChucVu", "ChucVu")
                        .WithMany()
                        .HasForeignKey("MaChucVu");

                    b.HasOne("_1_DAL_DataAcessLayer.Entities.ThongTinCaNhan", "ThongTinCaNhan")
                        .WithMany()
                        .HasForeignKey("MaMoTa");

                    b.Navigation("ChucVu");

                    b.Navigation("ThongTinCaNhan");
                });

            modelBuilder.Entity("_1_DAL_DataAcessLayer.Entities.SanPham", b =>
                {
                    b.HasOne("_1_DAL_DataAcessLayer.Entities.BangGia", "BangGia")
                        .WithMany()
                        .HasForeignKey("MaBangGia");

                    b.HasOne("_1_DAL_DataAcessLayer.Entities.MoTaSanPham", "MoTaSanPham")
                        .WithMany()
                        .HasForeignKey("MaMoTa");

                    b.HasOne("_1_DAL_DataAcessLayer.Entities.XuatXu", "XuatXu")
                        .WithMany()
                        .HasForeignKey("MaXuatXu");

                    b.Navigation("BangGia");

                    b.Navigation("MoTaSanPham");

                    b.Navigation("XuatXu");
                });
#pragma warning restore 612, 618
        }
    }
}
