﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI_APPINT.Context;

#nullable disable

namespace WebAPI_APPINT.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240603215255_Reg")]
    partial class Reg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.Autor", b =>
                {
                    b.Property<int>("PkAutor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkAutor"), 1L, 1);

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkAutor");

                    b.ToTable("Autores");

                    b.HasData(
                        new
                        {
                            PkAutor = 1,
                            Nacionalidad = "Mexicano",
                            Nombre = "Charly"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Libro", b =>
                {
                    b.Property<int>("PkLibro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkLibro"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Editorial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FkAutor")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkLibro");

                    b.HasIndex("FkAutor");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("Domain.Entities.Registro", b =>
                {
                    b.Property<int>("PkRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkRegistro"), 1L, 1);

                    b.Property<string>("Cantidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FkTipo")
                        .HasColumnType("int");

                    b.HasKey("PkRegistro");

                    b.HasIndex("FkTipo");

                    b.ToTable("Registros");

                    b.HasData(
                        new
                        {
                            PkRegistro = 1,
                            Cantidad = "$1999",
                            Descripcion = "Mexicano",
                            Fecha = "Charly",
                            FkTipo = 1
                        });
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Property<int>("PkRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkRol"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkRol");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            PkRol = 1,
                            Nombre = "sa"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Tipo", b =>
                {
                    b.Property<int>("PkTipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkTipo"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkTipo");

                    b.ToTable("Tipos");

                    b.HasData(
                        new
                        {
                            PkTipo = 1,
                            Nombre = "Entrada"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("PkUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkUsuario"), 1L, 1);

                    b.Property<int>("FkRol")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkUsuario");

                    b.HasIndex("FkRol");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            PkUsuario = 1,
                            FkRol = 1,
                            Nombre = "Carlos",
                            Password = "123",
                            User = "Usuario1"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Libro", b =>
                {
                    b.HasOne("Domain.Entities.Autor", "Autores")
                        .WithMany()
                        .HasForeignKey("FkAutor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autores");
                });

            modelBuilder.Entity("Domain.Entities.Registro", b =>
                {
                    b.HasOne("Domain.Entities.Tipo", "Tipos")
                        .WithMany()
                        .HasForeignKey("FkTipo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipos");
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.HasOne("Domain.Entities.Rol", "Roles")
                        .WithMany()
                        .HasForeignKey("FkRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
