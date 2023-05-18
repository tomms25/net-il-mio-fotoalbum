﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using net_il_mio_fotoalbum.Models;
using System.Reflection.Emit;

#nullable disable

namespace net_il_mio_fotoalbum.Migrations
{
    [DbContext(typeof(PhotoContext))]
    [Migration("20230421083641_CreateTables")]
    partial class CreateTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryPhoto", b =>
            {
                b.Property<long>("CategoriesId")
                    .HasColumnType("bigint");
                b.Property<long>("PhotosId")
                    .HasColumnType("bigint");
                b.HasKey("CategoriesId", "PhotosId");
                b.HasIndex("PhotosId");
                b.ToTable("CategoryPhoto");
            });

            modelBuilder.Entity("net_il_mio_fotoalbum.Models.Category", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));
                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");
                b.HasKey("Id");
                b.ToTable("Categories");
            });

            modelBuilder.Entity("net_il_mio_fotoalbum.Models.Photo", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));
                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");
                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");
                b.Property<string>("Url")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");
                b.Property<bool>("Visible")
                    .HasColumnType("bit");
                b.HasKey("Id");
                b.ToTable("Photos");
            });

            modelBuilder.Entity("CategoryPhoto", b =>
            {
                b.HasOne("net_il_mio_fotoalbum.Models.Category", null)
                    .WithMany()
                    .HasForeignKey("CategoriesId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
                b.HasOne("net_il_mio_fotoalbum.Models.Photo", null)
                    .WithMany()
                    .HasForeignKey("PhotosId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
        }
    }
}