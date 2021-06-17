﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using minhaflortshirt.Models;

namespace MinhaFlorTshirt.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("minhaflortshirt.Models.Camiseta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<string>("cor_camiseta")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("estampa_camiseta")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("nome_camiseta")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("quantidade_camiseta")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("tamanho_camiseta")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Camisetas");
                });

            modelBuilder.Entity("minhaflortshirt.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email_cliente")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("nome_cliente")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("tamanho_cliente")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("telefone_cliente")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("minhaflortshirt.Models.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("login_colaborador")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("nascimento_colaborador")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("nome_colaborador")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("senha_colaborador")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Colaboradores");
                });

            modelBuilder.Entity("minhaflortshirt.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email_fornecedor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("nome_fornecedor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("site_fornecedor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("telefone_fornecedor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("minhaflortshirt.Models.Camiseta", b =>
                {
                    b.HasOne("minhaflortshirt.Models.Fornecedor", "fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
