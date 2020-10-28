﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Segundatentativa.Server;

namespace Segundatentativa.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201027210831_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Segundatentativa.Shared.Cupom", b =>
                {
                    b.Property<int>("Cupom_Id")
                        .HasColumnType("int");

                    b.Property<int>("Desconto")
                        .HasColumnType("int");

                    b.Property<int>("Pedido_Id")
                        .HasColumnType("int");

                    b.HasKey("Cupom_Id");

                    b.ToTable("Cupons");
                });

            modelBuilder.Entity("Segundatentativa.Shared.Pedido", b =>
                {
                    b.Property<int>("Pedido_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cupom_Id")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("Usuario_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Usuario_Id1")
                        .HasColumnType("int");

                    b.HasKey("Pedido_Id");

                    b.HasIndex("Usuario_Id1");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Segundatentativa.Shared.PedidoProduto", b =>
                {
                    b.Property<int>("Pedido_Id")
                        .HasColumnType("int");

                    b.Property<int>("Produto_Id")
                        .HasColumnType("int");

                    b.Property<int>("PedidoProduto_Id")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Pedido_Id", "Produto_Id");

                    b.HasIndex("Produto_Id");

                    b.ToTable("PedidosProdutos");
                });

            modelBuilder.Entity("Segundatentativa.Shared.Produto", b =>
                {
                    b.Property<int>("Produto_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Preco")
                        .HasColumnType("int");

                    b.HasKey("Produto_Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Segundatentativa.Shared.Usuario", b =>
                {
                    b.Property<int>("Usuario_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("AcceptTerms")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ConfirmarSenha")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Endereço")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Usuario_Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Segundatentativa.Shared.Cupom", b =>
                {
                    b.HasOne("Segundatentativa.Shared.Pedido", "Pedido")
                        .WithOne("Cupom")
                        .HasForeignKey("Segundatentativa.Shared.Cupom", "Cupom_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Segundatentativa.Shared.Pedido", b =>
                {
                    b.HasOne("Segundatentativa.Shared.Usuario", "Usuario")
                        .WithMany("Pedidos")
                        .HasForeignKey("Usuario_Id1");
                });

            modelBuilder.Entity("Segundatentativa.Shared.PedidoProduto", b =>
                {
                    b.HasOne("Segundatentativa.Shared.Pedido", "Pedido")
                        .WithMany("PedidoProduto")
                        .HasForeignKey("Pedido_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Segundatentativa.Shared.Produto", "Produto")
                        .WithMany("PedidoProduto")
                        .HasForeignKey("Produto_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
