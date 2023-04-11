﻿// <auto-generated />
using System;
using A_DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace A_DAL.Migrations
{
    [DbContext(typeof(NhaNghiDbContext))]
    [Migration("20230410153258_v3")]
    partial class v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("A_DAL.Models.ChiTietPhieuDichVu", b =>
                {
                    b.Property<Guid>("Id")
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

                    b.HasKey("Id");

                    b.HasIndex("DichVuID");

                    b.HasIndex("PhieuDichVuID");

                    b.ToTable("ChiTietPhieuDichVu");
                });

            modelBuilder.Entity("A_DAL.Models.ChucVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("QuyenTruyCap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("A_DAL.Models.DichVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Gia")
                        .HasColumnType("money");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("DichVu");
                });

            modelBuilder.Entity("A_DAL.Models.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasColumnType("ntext");

                    b.Property<Guid?>("KhachHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayThanhToan")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("NhanVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("PhuongThucThanhToan")
                        .HasColumnType("int");

                    b.Property<decimal?>("TongTien")
                        .HasColumnType("money");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KhachHangId");

                    b.HasIndex("NhanVienId");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("A_DAL.Models.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
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
                        .HasColumnType("datetime");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("A_DAL.Models.LoaiPhong", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("GiaDem")
                        .HasColumnType("money");

                    b.Property<decimal?>("GiaGio")
                        .HasColumnType("money");

                    b.Property<decimal?>("GiaNgay")
                        .HasColumnType("money");

                    b.Property<string>("Mota")
                        .HasColumnType("ntext");

                    b.Property<int?>("OToiDa")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiPhong");
                });

            modelBuilder.Entity("A_DAL.Models.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
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
                        .HasColumnType("datetime");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTaiKhoan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChucVuId");

                    b.HasIndex("TenTaiKhoan")
                        .IsUnique()
                        .HasFilter("[TenTaiKhoan] IS NOT NULL");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("A_DAL.Models.PhieuDatPhong", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasColumnType("ntext");

                    b.Property<Guid?>("HoaDonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("KhachHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("KieuDat")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayDat")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayDatTra")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayNhan")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayTra")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("NhanVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("PhiPhong")
                        .HasColumnType("money");

                    b.Property<Guid?>("PhongId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HoaDonId");

                    b.HasIndex("KhachHangId");

                    b.HasIndex("NhanVienId");

                    b.HasIndex("PhongId");

                    b.ToTable("PhieuDatPhong");
                });

            modelBuilder.Entity("A_DAL.Models.PhieuDichVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasColumnType("ntext");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("NhanVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PhieuDatPhongId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NhanVienId");

                    b.HasIndex("PhieuDatPhongId");

                    b.ToTable("PhieuDichVu");
                });

            modelBuilder.Entity("A_DAL.Models.Phong", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasColumnType("ntext");

                    b.Property<Guid?>("LoaiPhongId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Tang")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoaiPhongId");

                    b.ToTable("Phong");
                });

            modelBuilder.Entity("A_DAL.Models.ThuChiKhac", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime");

                    b.Property<string>("NoiDung")
                        .HasColumnType("ntext");

                    b.Property<decimal?>("SoTien")
                        .HasColumnType("money");

                    b.Property<bool>("isThu")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ThuChiKhac");
                });

            modelBuilder.Entity("A_DAL.Models.ChiTietPhieuDichVu", b =>
                {
                    b.HasOne("A_DAL.Models.DichVu", "DichVu")
                        .WithMany("ChiTietPhieuDichVus")
                        .HasForeignKey("DichVuID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("A_DAL.Models.PhieuDichVu", "PhieuDichVu")
                        .WithMany("ChiTietPhieuDichVus")
                        .HasForeignKey("PhieuDichVuID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("DichVu");

                    b.Navigation("PhieuDichVu");
                });

            modelBuilder.Entity("A_DAL.Models.HoaDon", b =>
                {
                    b.HasOne("A_DAL.Models.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("KhachHangId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("A_DAL.Models.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("A_DAL.Models.NhanVien", b =>
                {
                    b.HasOne("A_DAL.Models.ChucVu", "ChucVu")
                        .WithMany("NhanViens")
                        .HasForeignKey("ChucVuId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("A_DAL.Models.PhieuDatPhong", b =>
                {
                    b.HasOne("A_DAL.Models.HoaDon", "HoaDon")
                        .WithMany("PhieuDatPhongs")
                        .HasForeignKey("HoaDonId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("A_DAL.Models.KhachHang", "KhachHang")
                        .WithMany("PhieuDatPhongs")
                        .HasForeignKey("KhachHangId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("A_DAL.Models.NhanVien", "NhanVien")
                        .WithMany("PhieuDatPhongs")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("A_DAL.Models.Phong", "Phong")
                        .WithMany("PhieuDatPhongs")
                        .HasForeignKey("PhongId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("HoaDon");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");

                    b.Navigation("Phong");
                });

            modelBuilder.Entity("A_DAL.Models.PhieuDichVu", b =>
                {
                    b.HasOne("A_DAL.Models.NhanVien", "NhanVien")
                        .WithMany("PhieuDichVus")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("A_DAL.Models.PhieuDatPhong", "PhieuDatPhong")
                        .WithMany("PhieuDichVus")
                        .HasForeignKey("PhieuDatPhongId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("NhanVien");

                    b.Navigation("PhieuDatPhong");
                });

            modelBuilder.Entity("A_DAL.Models.Phong", b =>
                {
                    b.HasOne("A_DAL.Models.LoaiPhong", "LoaiPhong")
                        .WithMany("Phongs")
                        .HasForeignKey("LoaiPhongId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("LoaiPhong");
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
                });

            modelBuilder.Entity("A_DAL.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDons");

                    b.Navigation("PhieuDatPhongs");
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
                });

            modelBuilder.Entity("A_DAL.Models.PhieuDatPhong", b =>
                {
                    b.Navigation("PhieuDichVus");
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
