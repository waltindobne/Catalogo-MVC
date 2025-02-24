﻿// <auto-generated />
using Catalogo_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Catalogo_MVC.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("Catalogo_MVC.Models.Carrinho", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("idProduto")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idUsuario")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Carrinho");
                });

            modelBuilder.Entity("Catalogo_MVC.Models.Produtos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nomeProd")
                        .HasColumnType("TEXT");

                    b.Property<string>("quantidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("valor")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Catalogo_MVC.Models.Usuarios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("senha")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
