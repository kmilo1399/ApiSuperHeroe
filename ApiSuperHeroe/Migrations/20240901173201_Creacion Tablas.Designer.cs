﻿// <auto-generated />
using ApiSuperHeroe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiSuperHeroe.Migrations
{
    [DbContext(typeof(SuperHeroeContext))]
    [Migration("20240901173201_Creacion Tablas")]
    partial class CreacionTablas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiSuperHeroe.Models.Clases.DetalleUsuarioSuperHeroe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioSuperHeroe")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.HasIndex("IdUsuarioSuperHeroe");

                    b.ToTable("DetalleUsuarioSuperHeroes");
                });

            modelBuilder.Entity("ApiSuperHeroe.Models.Clases.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("ApiSuperHeroe.Models.Clases.Imagenes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ruta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tamano")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Imagenes");
                });

            modelBuilder.Entity("ApiSuperHeroe.Models.Clases.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("ApiSuperHeroe.Models.Clases.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGenero")
                        .HasColumnType("int");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdGenero");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ApiSuperHeroe.Models.Clases.superHeroe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdImagenes")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdImagenes");

                    b.ToTable("superHeroes");
                });

            modelBuilder.Entity("ApiSuperHeroe.Models.Clases.DetalleUsuarioSuperHeroe", b =>
                {
                    b.HasOne("ApiSuperHeroe.Models.Clases.Usuarios", "Usuarios")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiSuperHeroe.Models.Clases.superHeroe", "SuperHeroe")
                        .WithMany()
                        .HasForeignKey("IdUsuarioSuperHeroe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SuperHeroe");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("ApiSuperHeroe.Models.Clases.Login", b =>
                {
                    b.HasOne("ApiSuperHeroe.Models.Clases.Usuarios", "Usuarios")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("ApiSuperHeroe.Models.Clases.Usuarios", b =>
                {
                    b.HasOne("ApiSuperHeroe.Models.Clases.Genero", "genero")
                        .WithMany()
                        .HasForeignKey("IdGenero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("genero");
                });

            modelBuilder.Entity("ApiSuperHeroe.Models.Clases.superHeroe", b =>
                {
                    b.HasOne("ApiSuperHeroe.Models.Clases.Imagenes", "Imagenes")
                        .WithMany()
                        .HasForeignKey("IdImagenes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Imagenes");
                });
#pragma warning restore 612, 618
        }
    }
}
