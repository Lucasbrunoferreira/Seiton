﻿// <auto-generated />
using BancoDeDados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DAL.Migrations
{
    [DbContext(typeof(BancoDeDados.BancoDeDados))]
    partial class BancoDeDadosModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("BancoDeDados.Models.Serie", b =>
                {
                    b.Property<int>("IdSerie")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("IdSerie");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("DAL.Models.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired();

                    b.Property<string>("Cep")
                        .IsRequired();

                    b.Property<string>("Cidade");

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Estado");

                    b.Property<string>("NomeRazaoSocial");

                    b.Property<int>("NumeroDaCasa");

                    b.Property<string>("PontoReferencia");

                    b.Property<string>("Rua");

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.HasKey("IdClient");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("DAL.Models.Contribuitor", b =>
                {
                    b.Property<int>("IdContribuitor")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int>("IdSector");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<string>("Usuario")
                        .IsRequired();

                    b.HasKey("IdContribuitor");

                    b.HasIndex("IdSector");

                    b.ToTable("Contribuitor");
                });

            modelBuilder.Entity("DAL.Models.Line", b =>
                {
                    b.Property<int>("IdLine")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("IdLine");

                    b.ToTable("Line");
                });

            modelBuilder.Entity("DAL.Models.Product", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoBarra");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataEntrada");

                    b.Property<DateTime>("DataValidade");

                    b.Property<decimal>("Desconto");

                    b.Property<int>("Estoque");

                    b.Property<decimal>("Icms");

                    b.Property<int>("IdLine");

                    b.Property<int>("IdProvider");

                    b.Property<string>("Lote");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<double>("PrecoCompra");

                    b.Property<double>("PrecoVenda");

                    b.Property<bool>("StatusProduct");

                    b.HasKey("IdProduct");

                    b.HasIndex("IdLine");

                    b.HasIndex("IdProvider");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("DAL.Models.ProductSale", b =>
                {
                    b.Property<int>("IdProduct");

                    b.Property<int>("IdSale");

                    b.Property<DateTime>("SaleDate");

                    b.HasKey("IdProduct", "IdSale");

                    b.HasIndex("IdSale");

                    b.ToTable("ProductSale");
                });

            modelBuilder.Entity("DAL.Models.Provider", b =>
                {
                    b.Property<int>("IdProvider")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cidade");

                    b.Property<string>("Cnpj")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nome");

                    b.Property<string>("Responsavel");

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.HasKey("IdProvider");

                    b.ToTable("Provider");
                });

            modelBuilder.Entity("DAL.Models.Sale", b =>
                {
                    b.Property<int>("IdSale")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataVenda");

                    b.Property<int>("IdClient");

                    b.Property<int>("IdContribuitor");

                    b.Property<string>("TipoVenda");

                    b.HasKey("IdSale");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdContribuitor");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("DAL.Models.Sector", b =>
                {
                    b.Property<int>("IdSector")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NivelAcesso");

                    b.Property<string>("Nome");

                    b.HasKey("IdSector");

                    b.ToTable("Sector");
                });

            modelBuilder.Entity("DAL.Models.Contribuitor", b =>
                {
                    b.HasOne("DAL.Models.Sector", "Sector")
                        .WithMany("Contribuitors")
                        .HasForeignKey("IdSector")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Models.Product", b =>
                {
                    b.HasOne("DAL.Models.Line", "Line")
                        .WithMany("Products")
                        .HasForeignKey("IdLine")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Models.Provider", "Provider")
                        .WithMany("Products")
                        .HasForeignKey("IdProvider")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Models.ProductSale", b =>
                {
                    b.HasOne("DAL.Models.Product", "Product")
                        .WithMany("ProductSales")
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Models.Sale", "Sale")
                        .WithMany("ProductSales")
                        .HasForeignKey("IdSale")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Models.Sale", b =>
                {
                    b.HasOne("DAL.Models.Client", "Client")
                        .WithMany("Sale")
                        .HasForeignKey("IdClient")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Models.Contribuitor", "Contribuitor")
                        .WithMany("Sales")
                        .HasForeignKey("IdContribuitor")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
