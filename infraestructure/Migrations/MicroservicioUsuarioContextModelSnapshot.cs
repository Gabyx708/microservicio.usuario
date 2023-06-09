﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using infraestructure.Persistence;

#nullable disable

namespace infraestructure.Migrations
{
    [DbContext(typeof(MicroservicioUsuarioContext))]
    partial class MicroservicioUsuarioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Tarjeta", b =>
                {
                    b.Property<Guid>("TarjetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EntidadTarjeta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTarjeta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoTarjeta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Vencimiento")
                        .HasColumnType("datetime2");

                    b.HasKey("TarjetaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Tarjeta", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNac")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario", (string)null);

                    b.HasData(
                        new
                        {
                            UsuarioId = new Guid("db15a628-1320-4bee-83fc-1111f78783db"),
                            Apellido = "Lopez",
                            Dni = "343434",
                            Domicilio = "su casa",
                            Email = "test@gmail.com",
                            FechaNac = new DateTime(2023, 5, 13, 21, 53, 35, 390, DateTimeKind.Local).AddTicks(4088),
                            Nacionalidad = "peruano",
                            Nombre = "Mariana",
                            Telefono = "11234567"
                        },
                        new
                        {
                            UsuarioId = new Guid("1ea78b58-99fc-402c-91f7-4da4f9f56d08"),
                            Apellido = "Cyrus",
                            Dni = "343434",
                            Domicilio = "su casa",
                            Email = "test2@gmail.com",
                            FechaNac = new DateTime(2023, 5, 13, 21, 53, 35, 390, DateTimeKind.Local).AddTicks(4099),
                            Nacionalidad = "peruano",
                            Nombre = "Luca",
                            Telefono = "11234567"
                        },
                        new
                        {
                            UsuarioId = new Guid("5a95785b-3280-4f75-816c-4e6970013bfc"),
                            Apellido = "Alba",
                            Dni = "34656676",
                            Domicilio = "su casa",
                            Email = "test3@gmail.com",
                            FechaNac = new DateTime(2023, 5, 13, 21, 53, 35, 390, DateTimeKind.Local).AddTicks(4103),
                            Nacionalidad = "peruano",
                            Nombre = "Juan",
                            Telefono = "11234567"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Tarjeta", b =>
                {
                    b.HasOne("Domain.Entities.Usuario", "Usuario")
                        .WithMany("Tarjetas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Tarjetas");
                });
#pragma warning restore 612, 618
        }
    }
}
