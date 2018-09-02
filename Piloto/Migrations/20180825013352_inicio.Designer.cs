﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Piloto.ContextoBaseDatos;

namespace Piloto.Migrations
{
    [DbContext(typeof(PIS_Contexto))]
    [Migration("20180825013352_inicio")]
    partial class inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Piloto.ContextoBaseDatos.Permiso", b =>
                {
                    b.Property<int>("PermisoID");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("PermisoID");

                    b.ToTable("Permiso");
                });

            modelBuilder.Entity("Piloto.ContextoBaseDatos.RelacionRol_Permiso", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PermisoID");

                    b.Property<int?>("Rolid");

                    b.HasKey("id");

                    b.HasIndex("PermisoID");

                    b.HasIndex("Rolid");

                    b.ToTable("RelacionRol_Permiso");
                });

            modelBuilder.Entity("Piloto.ContextoBaseDatos.RelacionUsuario_Rol", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Rolid");

                    b.Property<int?>("Usuarioid");

                    b.HasKey("id");

                    b.HasIndex("Rolid");

                    b.HasIndex("Usuarioid");

                    b.ToTable("RelacionUsuario_Rol");
                });

            modelBuilder.Entity("Piloto.ContextoBaseDatos.Rol", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("descripcion")
                        .HasMaxLength(50);

                    b.Property<string>("nombre")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("Piloto.ContextoBaseDatos.Seguimiento_usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Usuarioid");

                    b.Property<int>("actividad");

                    b.HasKey("id");

                    b.HasIndex("Usuarioid");

                    b.ToTable("Seguimiento_usuario");
                });

            modelBuilder.Entity("Piloto.ContextoBaseDatos.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email");

                    b.Property<string>("nombre");

                    b.Property<string>("password");

                    b.HasKey("id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Piloto.ContextoBaseDatos.RelacionRol_Permiso", b =>
                {
                    b.HasOne("Piloto.ContextoBaseDatos.Permiso", "Permiso")
                        .WithMany()
                        .HasForeignKey("PermisoID");

                    b.HasOne("Piloto.ContextoBaseDatos.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("Rolid");
                });

            modelBuilder.Entity("Piloto.ContextoBaseDatos.RelacionUsuario_Rol", b =>
                {
                    b.HasOne("Piloto.ContextoBaseDatos.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("Rolid");

                    b.HasOne("Piloto.ContextoBaseDatos.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Usuarioid");
                });

            modelBuilder.Entity("Piloto.ContextoBaseDatos.Seguimiento_usuario", b =>
                {
                    b.HasOne("Piloto.ContextoBaseDatos.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Usuarioid");
                });
#pragma warning restore 612, 618
        }
    }
}
