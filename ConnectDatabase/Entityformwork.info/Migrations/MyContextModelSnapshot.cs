﻿// <auto-generated />
using System;
using Entityformwork.info;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entityformwork.info.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("BookTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BookTypeId");

                    b.ToTable("Book", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "鲁迅",
                            BookTypeId = 1,
                            CreatedDate = new DateTime(2023, 4, 5, 22, 17, 48, 143, DateTimeKind.Local).AddTicks(8051),
                            Name = "百草集"
                        },
                        new
                        {
                            Id = 2,
                            Author = "鲁迅",
                            BookTypeId = 1,
                            CreatedDate = new DateTime(2023, 4, 5, 22, 17, 48, 143, DateTimeKind.Local).AddTicks(8056),
                            Name = "彷徨"
                        },
                        new
                        {
                            Id = 3,
                            Author = "余华",
                            BookTypeId = 1,
                            CreatedDate = new DateTime(2023, 4, 5, 22, 17, 48, 143, DateTimeKind.Local).AddTicks(8058),
                            Name = "活着"
                        },
                        new
                        {
                            Id = 4,
                            Author = "海明威",
                            BookTypeId = 2,
                            CreatedDate = new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "老人与海"
                        });
                });

            modelBuilder.Entity("Models.BookType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("BookType", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TypeName = "国语书籍"
                        },
                        new
                        {
                            Id = 2,
                            TypeName = "外语书籍"
                        });
                });

            modelBuilder.Entity("Models.Book", b =>
                {
                    b.HasOne("Models.BookType", null)
                        .WithMany("Books")
                        .HasForeignKey("BookTypeId");
                });

            modelBuilder.Entity("Models.BookType", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
