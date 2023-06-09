﻿// <auto-generated />
using System;
using ETicaretApp.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ETicaretApp.DAL.Migrations
{
    [DbContext(typeof(ETicaretAppContext))]
    [Migration("20230623114733_DistrictCreated2")]
    partial class DistrictCreated2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ETicaretApp.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("ETicaretApp.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ETicaretApp.Entities.CategoryProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Property")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryProperties");
                });

            modelBuilder.Entity("ETicaretApp.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Adana"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Adıyaman"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Afyonkarahisar"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ağrı"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Amasya"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Ankara"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Antalya"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Artvin"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Aydın"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Balıkesir"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Bilecik"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Bingöl"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Bitlis"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Bolu"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Burdur"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Bursa"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Çanakkale"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Çankırı"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Çorum"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Denizli"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Diyarbakır"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Edirne"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Elazığ"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Erzincan"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Erzurum"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Eskişehir"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Gaziantep"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Giresun"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Gümüşhane"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Hakkari"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Hatay"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Isparta"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Mersin"
                        },
                        new
                        {
                            Id = 34,
                            Name = "İstanbul"
                        },
                        new
                        {
                            Id = 35,
                            Name = "İzmir"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Kars"
                        },
                        new
                        {
                            Id = 37,
                            Name = "Kastamonu"
                        },
                        new
                        {
                            Id = 38,
                            Name = "Kayseri"
                        },
                        new
                        {
                            Id = 39,
                            Name = "Kırklareli"
                        },
                        new
                        {
                            Id = 40,
                            Name = "Kırşehir"
                        },
                        new
                        {
                            Id = 41,
                            Name = "Kocaeli"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Konya"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Kütahya"
                        },
                        new
                        {
                            Id = 44,
                            Name = "Malatya"
                        },
                        new
                        {
                            Id = 45,
                            Name = "Manisa"
                        },
                        new
                        {
                            Id = 46,
                            Name = "Kahramanmaraş"
                        },
                        new
                        {
                            Id = 47,
                            Name = "Mardin"
                        },
                        new
                        {
                            Id = 48,
                            Name = "Muğla"
                        },
                        new
                        {
                            Id = 49,
                            Name = "Muş"
                        },
                        new
                        {
                            Id = 50,
                            Name = "Nevşehir"
                        },
                        new
                        {
                            Id = 51,
                            Name = "Niğde"
                        },
                        new
                        {
                            Id = 52,
                            Name = "Ordu"
                        },
                        new
                        {
                            Id = 53,
                            Name = "Rize"
                        },
                        new
                        {
                            Id = 54,
                            Name = "Sakarya"
                        },
                        new
                        {
                            Id = 55,
                            Name = "Samsun"
                        },
                        new
                        {
                            Id = 56,
                            Name = "Siirt"
                        },
                        new
                        {
                            Id = 57,
                            Name = "Sinop"
                        },
                        new
                        {
                            Id = 58,
                            Name = "Sivas"
                        },
                        new
                        {
                            Id = 59,
                            Name = "Tekirdağ"
                        },
                        new
                        {
                            Id = 60,
                            Name = "Tokat"
                        },
                        new
                        {
                            Id = 61,
                            Name = "Trabzon"
                        },
                        new
                        {
                            Id = 62,
                            Name = "Tunceli"
                        },
                        new
                        {
                            Id = 63,
                            Name = "Şanlıurfa"
                        },
                        new
                        {
                            Id = 64,
                            Name = "Uşak"
                        },
                        new
                        {
                            Id = 65,
                            Name = "Van"
                        },
                        new
                        {
                            Id = 66,
                            Name = "Yozgat"
                        },
                        new
                        {
                            Id = 67,
                            Name = "Zonguldak"
                        },
                        new
                        {
                            Id = 68,
                            Name = "Aksaray"
                        },
                        new
                        {
                            Id = 69,
                            Name = "Bayburt"
                        },
                        new
                        {
                            Id = 70,
                            Name = "Karaman"
                        },
                        new
                        {
                            Id = 71,
                            Name = "Kırıkkale"
                        },
                        new
                        {
                            Id = 72,
                            Name = "Batman"
                        },
                        new
                        {
                            Id = 73,
                            Name = "Şırnak"
                        },
                        new
                        {
                            Id = 74,
                            Name = "Bartın"
                        },
                        new
                        {
                            Id = 75,
                            Name = "Ardahan"
                        },
                        new
                        {
                            Id = 76,
                            Name = "Iğdır"
                        },
                        new
                        {
                            Id = 77,
                            Name = "Yalova"
                        },
                        new
                        {
                            Id = 78,
                            Name = "Karabük"
                        },
                        new
                        {
                            Id = 79,
                            Name = "Kilis"
                        },
                        new
                        {
                            Id = 80,
                            Name = "Osmaniye"
                        },
                        new
                        {
                            Id = 81,
                            Name = "Düzce"
                        });
                });

            modelBuilder.Entity("ETicaretApp.Entities.CompanyInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linkedin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Youtube")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompanyInformation");
                });

            modelBuilder.Entity("ETicaretApp.Entities.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("ETicaretApp.Entities.Member", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("ETicaretApp.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<double?>("DiscountedPrice")
                        .HasColumnType("float");

                    b.Property<bool>("IsNewProduct")
                        .HasColumnType("bit");

                    b.Property<bool>("IsShowcaseProduct")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ETicaretApp.Entities.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsShowcaseImage")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Queue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("ETicaretApp.Entities.PropertyValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryPropertyId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryPropertyId");

                    b.HasIndex("ProductId");

                    b.ToTable("PropertyValues");
                });

            modelBuilder.Entity("ETicaretApp.Entities.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainTittle")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Queue")
                        .HasColumnType("int");

                    b.Property<string>("SmallTittle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("ETicaretApp.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@gmail.com",
                            Password = "123456",
                            RegisterDate = new DateTime(2023, 6, 23, 14, 47, 33, 157, DateTimeKind.Local).AddTicks(9423),
                            Role = "Admin",
                            State = true
                        });
                });

            modelBuilder.Entity("ETicaretApp.Entities.CategoryProperty", b =>
                {
                    b.HasOne("ETicaretApp.Entities.Category", "Category")
                        .WithMany("CategoryProperties")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ETicaretApp.Entities.District", b =>
                {
                    b.HasOne("ETicaretApp.Entities.City", "City")
                        .WithMany("Districts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("ETicaretApp.Entities.Product", b =>
                {
                    b.HasOne("ETicaretApp.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ETicaretApp.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ETicaretApp.Entities.ProductImage", b =>
                {
                    b.HasOne("ETicaretApp.Entities.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ETicaretApp.Entities.PropertyValue", b =>
                {
                    b.HasOne("ETicaretApp.Entities.CategoryProperty", "CategoryProperty")
                        .WithMany("PropertyValues")
                        .HasForeignKey("CategoryPropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ETicaretApp.Entities.Product", "Product")
                        .WithMany("PropertyValues")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryProperty");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ETicaretApp.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ETicaretApp.Entities.Category", b =>
                {
                    b.Navigation("CategoryProperties");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ETicaretApp.Entities.CategoryProperty", b =>
                {
                    b.Navigation("PropertyValues");
                });

            modelBuilder.Entity("ETicaretApp.Entities.City", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("ETicaretApp.Entities.Product", b =>
                {
                    b.Navigation("ProductImages");

                    b.Navigation("PropertyValues");
                });
#pragma warning restore 612, 618
        }
    }
}
