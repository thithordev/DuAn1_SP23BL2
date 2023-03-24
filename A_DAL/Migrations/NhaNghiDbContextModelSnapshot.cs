﻿// <auto-generated />
using System;
using A_DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace A_DAL.Migrations
{
    [DbContext(typeof(NhaNghiDbContext))]
    partial class NhaNghiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("A_DAL.Models.ChiTietPhieuDichVu", b =>
                {
                    b.Property<Guid>("IDChiTietPhieuDichVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DichVuID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("DonGia")
                        .HasColumnType("money");

                    b.Property<Guid?>("PhieuDichVuID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IDChiTietPhieuDichVu");

                    b.HasIndex("DichVuID");

                    b.HasIndex("PhieuDichVuID");

                    b.ToTable("ChiTietPhieuDichVu", (string)null);
                });

            modelBuilder.Entity("A_DAL.Models.ChucVu", b =>
                {
                    b.Property<Guid>("IDChucVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("QuyenTruyCap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDChucVu");

                    b.ToTable("ChucVu", (string)null);
                });

            modelBuilder.Entity("A_DAL.Models.DichVu", b =>
                {
                    b.Property<Guid>("IdDichVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Gia")
                        .HasColumnType("money");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDichVu");

                    b.ToTable("DichVu", (string)null);
                });

            modelBuilder.Entity("A_DAL.Models.HoaDon", b =>
                {
                    b.Property<Guid>("IdHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasColumnType("ntext");

                    b.Property<Guid?>("KhachHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("NhanVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("PhuongThucThanhToan")
                        .HasColumnType("int");

                    b.Property<decimal?>("TongTien")
                        .HasColumnType("money");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdHoaDon");

                    b.HasIndex("KhachHangId");

                    b.HasIndex("NhanVienId");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("A_DAL.Models.KhachHang", b =>
                {
                    b.Property<Guid>("IdKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CCCD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GhiChu")
                        .HasColumnType("ntext");

                    b.Property<bool?>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdKhachHang");

                    b.ToTable("KhachHang", (string)null);
                });

            modelBuilder.Entity("A_DAL.Models.LoaiDoanhThu", b =>
                {
                    b.Property<Guid>("IDLoaiDoanhThu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Kieu")
                        .HasColumnType("bit");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDLoaiDoanhThu");

                    b.ToTable("LoaiDoanhThu", (string)null);
                });

            modelBuilder.Entity("A_DAL.Models.LoaiPhong", b =>
                {
                    b.Property<Guid>("IdLoaiPhong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("GiaNgay")
                        .HasColumnType("money");

                    b.Property<decimal?>("GiaPhong")
                        .HasColumnType("money");

                    b.Property<string>("Mota")
                        .HasColumnType("ntext");

                    b.Property<int?>("SoGiuong")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLoaiPhong");

                    b.ToTable("LoaiPhong", (string)null);
                });

            modelBuilder.Entity("A_DAL.Models.NhanVien", b =>
                {
                    b.Property<Guid>("IdNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CCCD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ChucVuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GhiChu")
                        .HasColumnType("ntext");

                    b.Property<bool?>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Luong")
                        .HasColumnType("money");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTaiKhoan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdNhanVien");

                    b.HasIndex("ChucVuId");

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("A_DAL.Models.PhieuDatPhong", b =>
                {
                    b.Property<Guid>("IdPhieuDatPhong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasColumnType("ntext");

                    b.Property<Guid?>("HoaDonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("KhachHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayDat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayGioTaoPhieu")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTra")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("NhanVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("PhiCuoc")
                        .HasColumnType("money");

                    b.Property<decimal?>("PhiPhong")
                        .HasColumnType("money");

                    b.Property<Guid?>("PhongId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdPhieuDatPhong");

                    b.HasIndex("HoaDonId");

                    b.HasIndex("KhachHangId");

                    b.HasIndex("NhanVienId");

                    b.HasIndex("PhongId");

                    b.ToTable("PhieuDatPhong", (string)null);
                });

            modelBuilder.Entity("A_DAL.Models.PhieuDichVu", b =>
                {
                    b.Property<Guid>("IdPhieuDichVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasColumnType("ntext");

                    b.Property<Guid?>("HoaDonIdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("KhachHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("NhanVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdPhieuDichVu");

                    b.HasIndex("HoaDonIdHoaDon");

                    b.HasIndex("KhachHangId");

                    b.HasIndex("NhanVienId");

                    b.ToTable("PhieuDichVu", (string)null);
                });

            modelBuilder.Entity("A_DAL.Models.Phong", b =>
                {
                    b.Property<Guid>("IdPhong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasColumnType("ntext");

                    b.Property<Guid?>("LoaiPhongId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdPhong");

                    b.HasIndex("LoaiPhongId");

                    b.ToTable("Phong", (string)null);
                });

            modelBuilder.Entity("A_DAL.Models.ThongKeDoanhThu", b =>
                {
                    b.Property<Guid>("IDThongKeDoanhThu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LoaiDoanhThuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NoiDung")
                        .HasColumnType("ntext");

                    b.Property<decimal?>("SoTien")
                        .HasColumnType("money");

                    b.HasKey("IDThongKeDoanhThu");

                    b.HasIndex("LoaiDoanhThuId");

                    b.ToTable("ThongKeDoanhThu", (string)null);
                });

            modelBuilder.Entity("A_DAL.Models.YeuCau", b =>
                {
                    b.Property<Guid>("IdYeuCau")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("ChiPhi")
                        .HasColumnType("money");

                    b.Property<string>("GhiChu")
                        .HasColumnType("ntext");

                    b.Property<Guid?>("NhanVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Noidung")
                        .HasColumnType("ntext");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdYeuCau");

                    b.HasIndex("NhanVienId");

                    b.ToTable("YeuCau", (string)null);
                });

            modelBuilder.Entity("A_DAL.Models.ChiTietPhieuDichVu", b =>
                {
                    b.HasOne("A_DAL.Models.DichVu", "DichVu")
                        .WithMany("ChiTietPhieuDichVus")
                        .HasForeignKey("DichVuID");

                    b.HasOne("A_DAL.Models.PhieuDichVu", "PhieuDichVu")
                        .WithMany("ChiTietPhieuDichVus")
                        .HasForeignKey("PhieuDichVuID");

                    b.Navigation("DichVu");

                    b.Navigation("PhieuDichVu");
                });

            modelBuilder.Entity("A_DAL.Models.HoaDon", b =>
                {
                    b.HasOne("A_DAL.Models.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("KhachHangId");

                    b.HasOne("A_DAL.Models.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("NhanVienId");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("A_DAL.Models.NhanVien", b =>
                {
                    b.HasOne("A_DAL.Models.ChucVu", "ChucVu")
                        .WithMany("NhanViens")
                        .HasForeignKey("ChucVuId");

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("A_DAL.Models.PhieuDatPhong", b =>
                {
                    b.HasOne("A_DAL.Models.HoaDon", "HoaDon")
                        .WithMany("PhieuDatPhongs")
                        .HasForeignKey("HoaDonId");

                    b.HasOne("A_DAL.Models.KhachHang", "KhachHang")
                        .WithMany("PhieuDatPhongs")
                        .HasForeignKey("KhachHangId");

                    b.HasOne("A_DAL.Models.NhanVien", "NhanVien")
                        .WithMany("PhieuDatPhongs")
                        .HasForeignKey("NhanVienId");

                    b.HasOne("A_DAL.Models.Phong", "Phong")
                        .WithMany("PhieuDatPhongs")
                        .HasForeignKey("PhongId");

                    b.Navigation("HoaDon");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");

                    b.Navigation("Phong");
                });

            modelBuilder.Entity("A_DAL.Models.PhieuDichVu", b =>
                {
                    b.HasOne("A_DAL.Models.HoaDon", "HoaDon")
                        .WithMany("PhieuDichVus")
                        .HasForeignKey("HoaDonIdHoaDon");

                    b.HasOne("A_DAL.Models.KhachHang", "KhachHang")
                        .WithMany("PhieuDichVus")
                        .HasForeignKey("KhachHangId");

                    b.HasOne("A_DAL.Models.NhanVien", "NhanVien")
                        .WithMany("PhieuDichVus")
                        .HasForeignKey("NhanVienId");

                    b.Navigation("HoaDon");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("A_DAL.Models.Phong", b =>
                {
                    b.HasOne("A_DAL.Models.LoaiPhong", "LoaiPhong")
                        .WithMany("Phongs")
                        .HasForeignKey("LoaiPhongId");

                    b.Navigation("LoaiPhong");
                });

            modelBuilder.Entity("A_DAL.Models.ThongKeDoanhThu", b =>
                {
                    b.HasOne("A_DAL.Models.LoaiDoanhThu", "LoaiDoanhThu")
                        .WithMany("ThongKeDoanhThus")
                        .HasForeignKey("LoaiDoanhThuId");

                    b.Navigation("LoaiDoanhThu");
                });

            modelBuilder.Entity("A_DAL.Models.YeuCau", b =>
                {
                    b.HasOne("A_DAL.Models.NhanVien", "NhanVien")
                        .WithMany("YeuCaus")
                        .HasForeignKey("NhanVienId");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("A_DAL.Models.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("A_DAL.Models.DichVu", b =>
                {
                    b.Navigation("ChiTietPhieuDichVus");
                });

            modelBuilder.Entity("A_DAL.Models.HoaDon", b =>
                {
                    b.Navigation("PhieuDatPhongs");

                    b.Navigation("PhieuDichVus");
                });

            modelBuilder.Entity("A_DAL.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDons");

                    b.Navigation("PhieuDatPhongs");

                    b.Navigation("PhieuDichVus");
                });

            modelBuilder.Entity("A_DAL.Models.LoaiDoanhThu", b =>
                {
                    b.Navigation("ThongKeDoanhThus");
                });

            modelBuilder.Entity("A_DAL.Models.LoaiPhong", b =>
                {
                    b.Navigation("Phongs");
                });

            modelBuilder.Entity("A_DAL.Models.NhanVien", b =>
                {
                    b.Navigation("HoaDons");

                    b.Navigation("PhieuDatPhongs");

                    b.Navigation("PhieuDichVus");

                    b.Navigation("YeuCaus");
                });

            modelBuilder.Entity("A_DAL.Models.PhieuDichVu", b =>
                {
                    b.Navigation("ChiTietPhieuDichVus");
                });

            modelBuilder.Entity("A_DAL.Models.Phong", b =>
                {
                    b.Navigation("PhieuDatPhongs");
                });
#pragma warning restore 612, 618
        }
    }
}
