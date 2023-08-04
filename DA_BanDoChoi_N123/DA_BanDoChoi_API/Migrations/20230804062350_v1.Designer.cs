﻿// <auto-generated />
using System;
using DA_BanDoChoi_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DA_BanDoChoi_API.Migrations
{
    [DbContext(typeof(ShopDBContext))]
    [Migration("20230804062350_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Address", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressDetail")
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid?>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NameCustomer")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Age", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Ages");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Cart", b =>
                {
                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("UserID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.CartDetail", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CartID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductDetailID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CartID");

                    b.HasIndex("ProductDetailID");

                    b.ToTable("CartDetails");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Color", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Customer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("MemberID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("Point")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("MemberID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Employee", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(10)");

                    b.Property<Guid?>("ROleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ROleID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.FavoritesListDetail", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProductID");

                    b.ToTable("FavoritesListDetails");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Material", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.MemberType", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("MemberTypes");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Order", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid?>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateOfPayment")
                        .HasColumnType("Date");

                    b.Property<DateTime?>("DateOrder")
                        .HasColumnType("Date");

                    b.Property<DateTime?>("DateShip")
                        .HasColumnType("Date");

                    b.Property<string>("DeliveryPhoneNumber")
                        .HasColumnType("nvarchar(10)");

                    b.Property<Guid?>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PaymentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("TransportID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("VoucherID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("PaymentID");

                    b.HasIndex("TransportID");

                    b.HasIndex("VoucherID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.OrderDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.PaymentHistory", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("PaymentAmount")
                        .HasColumnType("int");

                    b.Property<Guid?>("PaymentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PaymentHistories");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Payments", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.PointHistory", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Desciption")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid?>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("PointUsed")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("OrderID");

                    b.ToTable("PointHistories");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Producer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Product", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.ProductCategory", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid?>("ParentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ParentID");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.ProductCategoryParent", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ProductCategoryParents");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.ProductDetail", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AgeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodeProduct")
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("ColorID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("ImportPrice")
                        .HasColumnType("int");

                    b.Property<Guid?>("MaterialID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<Guid?>("ProducerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SoundID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AgeID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("ColorID");

                    b.HasIndex("MaterialID");

                    b.HasIndex("ProducerID");

                    b.HasIndex("ProductID");

                    b.HasIndex("SoundID");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.ProductImage", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("ProductDetailID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("ProductDetailID");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Rating", b =>
                {
                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid?>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Star")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Role", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Sound", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Sounds");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Transport", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Transports");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Voucher", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("Date");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("Date");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Vouchers");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.VoucherDetail", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CouponID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Percent")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<Guid?>("ProductDetailID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CouponID");

                    b.HasIndex("ProductDetailID");

                    b.ToTable("VoucherDetails");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Address", b =>
                {
                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Customer", "Customer")
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerID");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Cart", b =>
                {
                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Customer", "Customer")
                        .WithOne("Cart")
                        .HasForeignKey("DA_BanDoChoi_N123_Share.Models.Cart", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.CartDetail", b =>
                {
                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Cart", "Cart")
                        .WithMany("CartDetails")
                        .HasForeignKey("CartID");

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.ProductDetail", "ProductDetail")
                        .WithMany("CartDetails")
                        .HasForeignKey("ProductDetailID");

                    b.Navigation("Cart");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Customer", b =>
                {
                    b.HasOne("DA_BanDoChoi_N123_Share.Models.MemberType", "MemberType")
                        .WithMany("Customer")
                        .HasForeignKey("MemberID");

                    b.Navigation("MemberType");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Employee", b =>
                {
                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Role", "Role")
                        .WithMany("Employees")
                        .HasForeignKey("ROleID");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.FavoritesListDetail", b =>
                {
                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Customer", "Customer")
                        .WithMany("FavoritesListDetail")
                        .HasForeignKey("CustomerID");

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.ProductDetail", "ProductDetail")
                        .WithMany("FavoritesListDetails")
                        .HasForeignKey("ProductID");

                    b.Navigation("Customer");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Order", b =>
                {
                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Customer", "Customer")
                        .WithMany("Order")
                        .HasForeignKey("CustomerID");

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Employee", "Employee")
                        .WithMany("Order")
                        .HasForeignKey("EmployeeID");

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Payments", "Payment")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentID");

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Transport", "Transport")
                        .WithMany("Orders")
                        .HasForeignKey("TransportID");

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.VoucherDetail", "VoucherDetail")
                        .WithMany("Order")
                        .HasForeignKey("VoucherID");

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Payment");

                    b.Navigation("Transport");

                    b.Navigation("VoucherDetail");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.OrderDetail", b =>
                {
                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Order", "Order")
                        .WithMany("OrderDetail")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.ProductDetail", "ProductDetail")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.PointHistory", b =>
                {
                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Customer", "Customer")
                        .WithMany("PointHistory")
                        .HasForeignKey("CustomerID");

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Order", "Order")
                        .WithMany("PointHistory")
                        .HasForeignKey("OrderID");

                    b.Navigation("Customer");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.ProductCategory", b =>
                {
                    b.HasOne("DA_BanDoChoi_N123_Share.Models.ProductCategoryParent", "ProductCategoryParent")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ParentID");

                    b.Navigation("ProductCategoryParent");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.ProductDetail", b =>
                {
                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Age", "Age")
                        .WithMany("ProductDetail")
                        .HasForeignKey("AgeID");

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.ProductCategory", "ProductCategory")
                        .WithMany("ProductDetails")
                        .HasForeignKey("CategoryID");

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Color", "Color")
                        .WithMany("ProductDetail")
                        .HasForeignKey("ColorID");

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Material", "Material")
                        .WithMany("ProductDetails")
                        .HasForeignKey("MaterialID");

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Producer", "Producer")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProducerID");

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Product", "Product")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductID");

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Sound", "Sound")
                        .WithMany("ProductDetails")
                        .HasForeignKey("SoundID");

                    b.Navigation("Age");

                    b.Navigation("Color");

                    b.Navigation("Material");

                    b.Navigation("Producer");

                    b.Navigation("Product");

                    b.Navigation("ProductCategory");

                    b.Navigation("Sound");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.ProductImage", b =>
                {
                    b.HasOne("DA_BanDoChoi_N123_Share.Models.ProductDetail", "ProductDetail")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductDetailID");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Rating", b =>
                {
                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Customer", "Customer")
                        .WithMany("Rating")
                        .HasForeignKey("CustomerID");

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.OrderDetail", "OrderDetail")
                        .WithMany("Ratings")
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.VoucherDetail", b =>
                {
                    b.HasOne("DA_BanDoChoi_N123_Share.Models.Voucher", "Voucher")
                        .WithMany("VoucherDetails")
                        .HasForeignKey("CouponID");

                    b.HasOne("DA_BanDoChoi_N123_Share.Models.ProductDetail", "ProductDetail")
                        .WithMany("VoucherDetails")
                        .HasForeignKey("ProductDetailID");

                    b.Navigation("ProductDetail");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Age", b =>
                {
                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Cart", b =>
                {
                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Color", b =>
                {
                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Customer", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("FavoritesListDetail");

                    b.Navigation("Order");

                    b.Navigation("PointHistory");

                    b.Navigation("Rating");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Employee", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Material", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.MemberType", b =>
                {
                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Order", b =>
                {
                    b.Navigation("OrderDetail");

                    b.Navigation("PointHistory");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.OrderDetail", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Payments", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Producer", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Product", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.ProductCategory", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.ProductCategoryParent", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.ProductDetail", b =>
                {
                    b.Navigation("CartDetails");

                    b.Navigation("FavoritesListDetails");

                    b.Navigation("OrderDetails");

                    b.Navigation("ProductImages");

                    b.Navigation("VoucherDetails");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Role", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Sound", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Transport", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.Voucher", b =>
                {
                    b.Navigation("VoucherDetails");
                });

            modelBuilder.Entity("DA_BanDoChoi_N123_Share.Models.VoucherDetail", b =>
                {
                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}