﻿// <auto-generated />
using System;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20241202101255_hae")]
    partial class hae
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.DomainClass.ChiTietHoaDon", b =>
                {
                    b.Property<string>("MaHd")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaHD");

                    b.Property<string>("MaSp")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaSP");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<decimal?>("ThanhTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MaHd", "MaSp")
                        .HasName("PK__ChiTietH__F557F66148B7DE1B");

                    b.HasIndex("MaSp");

                    b.ToTable("ChiTietHoaDon");
                });

            modelBuilder.Entity("DAL.DomainClass.ChucVu", b =>
                {
                    b.Property<string>("MaChucVu")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenChucVu")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("MaChucVu")
                        .HasName("PK__ChucVu__D46395332EEC50B7");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("DAL.DomainClass.HoaDon", b =>
                {
                    b.Property<string>("MaHoaDon")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MaNhanVien")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MaVoucher")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("NgayLapHoaDon")
                        .HasColumnType("datetime");

                    b.Property<string>("Sdt")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("SDT");

                    b.Property<decimal?>("TienKhachDua")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaHoaDon")
                        .HasName("PK__HoaDon__835ED13B0DB74B94");

                    b.HasIndex("MaNhanVien");

                    b.HasIndex("MaVoucher");

                    b.HasIndex("Sdt");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("DAL.DomainClass.KhachHang", b =>
                {
                    b.Property<string>("Sdt")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("SDT");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("HinhAnh")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("NgayDangKy")
                        .HasColumnType("datetime");

                    b.Property<string>("TenKhachHang")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Sdt")
                        .HasName("PK__KhachHan__CA1930A44F24CFA0");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("DAL.DomainClass.KhuyenMai", b =>
                {
                    b.Property<string>("MaVoucher")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("GiamGia")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("MoTaVoucher")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("NgayBatDau")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayKetThuc")
                        .HasColumnType("datetime");

                    b.HasKey("MaVoucher")
                        .HasName("PK__KhuyenMa__0AAC5B1196A6763A");

                    b.ToTable("KhuyenMai");
                });

            modelBuilder.Entity("DAL.DomainClass.KichCo", b =>
                {
                    b.Property<string>("MaKichCoSp")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaKichCoSP");

                    b.Property<string>("KichCo1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("KichCo");

                    b.HasKey("MaKichCoSp")
                        .HasName("PK__KichCo__75335AFF2C57021E");

                    b.ToTable("KichCo");
                });

            modelBuilder.Entity("DAL.DomainClass.MauSac", b =>
                {
                    b.Property<string>("MaMauSp")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaMauSP");

                    b.Property<string>("MauSac1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MauSac");

                    b.HasKey("MaMauSp")
                        .HasName("PK__MauSac__487A0E4C3255AAA2");

                    b.ToTable("MauSac");
                });

            modelBuilder.Entity("DAL.DomainClass.NhanVien", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("MaChucVu")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MatKhau")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime");

                    b.Property<string>("Sdt")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("SDT");

                    b.Property<string>("TaiKhoan")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ten")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaNhanVien")
                        .HasName("PK__NhanVien__77B2CA47A51640EF");

                    b.HasIndex("MaChucVu");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("DAL.DomainClass.SanPham", b =>
                {
                    b.Property<string>("MaSanPham")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ChatLieu")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaKichCoSp")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaKichCoSP");

                    b.Property<string>("MaMauSp")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaMauSP");

                    b.Property<string>("MaThuongHieu")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("NgayNhap")
                        .HasColumnType("datetime");

                    b.Property<int?>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<string>("TenSanPham")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaSanPham")
                        .HasName("PK__SanPham__FAC7442D90ED2440");

                    b.HasIndex("MaKichCoSp");

                    b.HasIndex("MaMauSp");

                    b.HasIndex("MaThuongHieu");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("DAL.DomainClass.ThuongHieu", b =>
                {
                    b.Property<string>("MaThuongHieu")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenThuongHieu")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MaThuongHieu")
                        .HasName("PK__ThuongHi__A3733E2CB3011A42");

                    b.ToTable("ThuongHieu");
                });

            modelBuilder.Entity("DAL.DomainClass.ChiTietHoaDon", b =>
                {
                    b.HasOne("DAL.DomainClass.HoaDon", "MaHdNavigation")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("MaHd")
                        .IsRequired()
                        .HasConstraintName("FK__ChiTietHoa__MaHD__4E88ABD4");

                    b.HasOne("DAL.DomainClass.SanPham", "MaSpNavigation")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("MaSp")
                        .IsRequired()
                        .HasConstraintName("FK__ChiTietHoa__MaSP__4F7CD00D");

                    b.Navigation("MaHdNavigation");

                    b.Navigation("MaSpNavigation");
                });

            modelBuilder.Entity("DAL.DomainClass.HoaDon", b =>
                {
                    b.HasOne("DAL.DomainClass.NhanVien", "MaNhanVienNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaNhanVien")
                        .HasConstraintName("FK__HoaDon__MaNhanVi__4AB81AF0");

                    b.HasOne("DAL.DomainClass.KhuyenMai", "MaVoucherNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaVoucher")
                        .HasConstraintName("FK__HoaDon__MaVouche__4BAC3F29");

                    b.HasOne("DAL.DomainClass.KhachHang", "SdtNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("Sdt")
                        .HasConstraintName("FK__HoaDon__SDT__49C3F6B7");

                    b.Navigation("MaNhanVienNavigation");

                    b.Navigation("MaVoucherNavigation");

                    b.Navigation("SdtNavigation");
                });

            modelBuilder.Entity("DAL.DomainClass.NhanVien", b =>
                {
                    b.HasOne("DAL.DomainClass.ChucVu", "MaChucVuNavigation")
                        .WithMany("NhanViens")
                        .HasForeignKey("MaChucVu")
                        .HasConstraintName("FK__NhanVien__MaChuc__403A8C7D");

                    b.Navigation("MaChucVuNavigation");
                });

            modelBuilder.Entity("DAL.DomainClass.SanPham", b =>
                {
                    b.HasOne("DAL.DomainClass.KichCo", "MaKichCoSpNavigation")
                        .WithMany("SanPhams")
                        .HasForeignKey("MaKichCoSp")
                        .HasConstraintName("FK__SanPham__MaKichC__440B1D61");

                    b.HasOne("DAL.DomainClass.MauSac", "MaMauSpNavigation")
                        .WithMany("SanPhams")
                        .HasForeignKey("MaMauSp")
                        .HasConstraintName("FK__SanPham__MaMauSP__4316F928");

                    b.HasOne("DAL.DomainClass.ThuongHieu", "MaThuongHieuNavigation")
                        .WithMany("SanPhams")
                        .HasForeignKey("MaThuongHieu")
                        .HasConstraintName("FK__SanPham__MaThuon__44FF419A");

                    b.Navigation("MaKichCoSpNavigation");

                    b.Navigation("MaMauSpNavigation");

                    b.Navigation("MaThuongHieuNavigation");
                });

            modelBuilder.Entity("DAL.DomainClass.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("DAL.DomainClass.HoaDon", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });

            modelBuilder.Entity("DAL.DomainClass.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("DAL.DomainClass.KhuyenMai", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("DAL.DomainClass.KichCo", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("DAL.DomainClass.MauSac", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("DAL.DomainClass.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("DAL.DomainClass.SanPham", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });

            modelBuilder.Entity("DAL.DomainClass.ThuongHieu", b =>
                {
                    b.Navigation("SanPhams");
                });
#pragma warning restore 612, 618
        }
    }
}
