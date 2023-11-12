﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UBSDigital.Context;

#nullable disable

namespace UBSDigital.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231112214340_AlteracaoNoCampoNullableEmPaciente")]
    partial class AlteracaoNoCampoNullableEmPaciente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UBSDigital.Models.Consultas.AnexoDaConsulta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IdConsulta")
                        .HasColumnType("char(36)");

                    b.Property<string>("UrlAnexo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdConsulta");

                    b.ToTable("AnexosDasConsultas");
                });

            modelBuilder.Entity("UBSDigital.Models.Consultas.Consulta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataDaConsulta")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Diagnostico")
                        .HasColumnType("longtext");

                    b.Property<Guid>("IdPaciente")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("IdUsuarioAmbulatorial")
                        .HasColumnType("char(36)");

                    b.Property<string>("Parecer")
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPaciente");

                    b.HasIndex("IdUsuarioAmbulatorial");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("UBSDigital.Models.Pacientes.Paciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Complemento")
                        .HasColumnType("longtext");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("UBSDigital.Models.Pacientes.UsuarioAmbulatorial", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("UsuariosAmbulatoriais");
                });

            modelBuilder.Entity("UBSDigital.Models.Consultas.AnexoDaConsulta", b =>
                {
                    b.HasOne("UBSDigital.Models.Consultas.Consulta", "Consulta")
                        .WithMany("Anexos")
                        .HasForeignKey("IdConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consulta");
                });

            modelBuilder.Entity("UBSDigital.Models.Consultas.Consulta", b =>
                {
                    b.HasOne("UBSDigital.Models.Pacientes.Paciente", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UBSDigital.Models.Pacientes.UsuarioAmbulatorial", "UsuarioAmbulatorial")
                        .WithMany("Consultas")
                        .HasForeignKey("IdUsuarioAmbulatorial");

                    b.Navigation("Paciente");

                    b.Navigation("UsuarioAmbulatorial");
                });

            modelBuilder.Entity("UBSDigital.Models.Consultas.Consulta", b =>
                {
                    b.Navigation("Anexos");
                });

            modelBuilder.Entity("UBSDigital.Models.Pacientes.Paciente", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("UBSDigital.Models.Pacientes.UsuarioAmbulatorial", b =>
                {
                    b.Navigation("Consultas");
                });
#pragma warning restore 612, 618
        }
    }
}
