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
    [Migration("20221006234707_AtualizandoBanco9")]
    partial class AtualizandoBanco9
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

                    b.Property<int>("Funcionario_Id")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Funcionario");

                    b.Property<double>("QuantidadeHoras")
                        .HasColumnType("REAL");

                    b.Property<double>("ValorHora")
                        .HasColumnType("REAL");

                    b.HasKey("FolhaPagamentoId");

                    b.HasIndex("Funcionario_Id");

                    b.ToTable("FolhaPagamento");
                });

            modelBuilder.Entity("API_Folhas.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
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
                        .HasForeignKey("Funcionario_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}
