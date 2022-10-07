﻿// <auto-generated />
using System;
using API_Folhas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_FOlhas.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221006233838_AtualizandoBanco5")]
    partial class AtualizandoBanco5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("API_Folhas.Models.FolhaPagamento", b =>
                {
                    b.Property<int>("FolhaPagamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<int>("Funcionario_ID")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Funcionario");

                    b.Property<double>("ImpostoFgts")
                        .HasColumnType("REAL");

                    b.Property<double>("ImpostoInnss")
                        .HasColumnType("REAL");

                    b.Property<double>("ImpostoRenda")
                        .HasColumnType("REAL");

                    b.Property<double>("QuantidadeHoras")
                        .HasColumnType("REAL");

                    b.Property<double>("SalarioBruto")
                        .HasColumnType("REAL");

                    b.Property<double>("SalarioLiquido")
                        .HasColumnType("REAL");

                    b.Property<double>("ValorHora")
                        .HasColumnType("REAL");

                    b.HasKey("FolhaPagamentoId");

                    b.HasIndex("Funcionario_ID");

                    b.ToTable("FolhaPagamento");
                });

            modelBuilder.Entity("API_Folhas.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("FolhaPagamento");

                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Salario")
                        .HasColumnType("INTEGER");

                    b.HasKey("FuncionarioId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("API_Folhas.Models.FolhaPagamento", b =>
                {
                    b.HasOne("API_Folhas.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("Funcionario_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("API_Folhas.Models.Funcionario", b =>
                {
                    b.HasOne("API_Folhas.Models.FolhaPagamento", "FolhaPagamento")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FolhaPagamento");
                });
#pragma warning restore 612, 618
        }
    }
}