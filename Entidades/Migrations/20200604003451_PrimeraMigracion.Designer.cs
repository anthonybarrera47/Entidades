﻿// <auto-generated />
using System;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entidades.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200604003451_PrimeraMigracion")]
    partial class PrimeraMigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entidades.Citas", b =>
                {
                    b.Property<int>("CitaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteUsuarioID");

                    b.Property<string>("CodigoComprobacion");

                    b.Property<int>("CreadoPor");

                    b.Property<int>("Estado");

                    b.Property<DateTime>("FechaCreacion");

                    b.Property<DateTime>("FechaFin");

                    b.Property<DateTime>("FechaInicio");

                    b.Property<DateTime>("FechaModificacion");

                    b.Property<int>("ModificadoPor");

                    b.Property<int?>("NegocioID");

                    b.HasKey("CitaID");

                    b.HasIndex("ClienteUsuarioID");

                    b.HasIndex("NegocioID");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("Entidades.CitasDetalle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad");

                    b.Property<int?>("CitaID");

                    b.Property<decimal>("Precio");

                    b.Property<int>("ProductoID");

                    b.HasKey("ID");

                    b.HasIndex("CitaID");

                    b.ToTable("CitasDetalle");
                });

            modelBuilder.Entity("Entidades.Ciudad", b =>
                {
                    b.Property<int>("CiudadID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminName");

                    b.Property<string>("Capital");

                    b.Property<string>("City");

                    b.Property<string>("CityAscii");

                    b.Property<string>("Country");

                    b.Property<string>("Iso2");

                    b.Property<string>("Iso3");

                    b.Property<string>("Lat");

                    b.Property<string>("Lng");

                    b.HasKey("CiudadID");

                    b.ToTable("Ciudad");
                });

            modelBuilder.Entity("Entidades.Empleados", b =>
                {
                    b.Property<int>("EmpleadoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<int>("CreadoPor");

                    b.Property<bool>("Estado");

                    b.Property<DateTime>("FechaCreacion");

                    b.Property<DateTime>("FechaModificacion");

                    b.Property<string>("Foto");

                    b.Property<int>("Genero");

                    b.Property<int>("ModificadoPor");

                    b.Property<int?>("NegocioID");

                    b.Property<string>("Nombre");

                    b.HasKey("EmpleadoID");

                    b.HasIndex("NegocioID");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Entidades.Etiquetas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreadoPor");

                    b.Property<DateTime>("FechaCreacion");

                    b.Property<DateTime>("FechaModificacion");

                    b.Property<int>("ModificadoPor");

                    b.Property<string>("Nombre");

                    b.Property<int?>("ProductosProductoID");

                    b.HasKey("ID");

                    b.HasIndex("ProductosProductoID");

                    b.ToTable("Etiquetas");
                });

            modelBuilder.Entity("Entidades.FotosProductos", b =>
                {
                    b.Property<int>("FotoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Foto");

                    b.Property<int?>("ProductosProductoID");

                    b.HasKey("FotoId");

                    b.HasIndex("ProductosProductoID");

                    b.ToTable("FotosProductos");
                });

            modelBuilder.Entity("Entidades.Horarios", b =>
                {
                    b.Property<int>("HorarioID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Domingo");

                    b.Property<string>("Jueves");

                    b.Property<string>("Lunes");

                    b.Property<string>("Martes");

                    b.Property<string>("Miercoles");

                    b.Property<string>("Sabado");

                    b.Property<string>("viernes");

                    b.HasKey("HorarioID");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("Entidades.Mensajes", b =>
                {
                    b.Property<int>("MensajeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteUsuarioID");

                    b.Property<string>("Contenido");

                    b.Property<int>("CreadoPor");

                    b.Property<DateTime>("FechaCreacion");

                    b.Property<DateTime>("FechaModificacion");

                    b.Property<int>("ModificadoPor");

                    b.Property<int?>("NegociosNegocioID");

                    b.Property<int>("Tipo");

                    b.HasKey("MensajeID");

                    b.HasIndex("ClienteUsuarioID");

                    b.HasIndex("NegociosNegocioID");

                    b.ToTable("Mensaje");
                });

            modelBuilder.Entity("Entidades.Negocios", b =>
                {
                    b.Property<int>("NegocioID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CiudadID");

                    b.Property<int>("CreadoPor");

                    b.Property<string>("Direccion");

                    b.Property<DateTime>("FechaCreacion");

                    b.Property<DateTime>("FechaModificacion");

                    b.Property<int?>("HorariosHorarioID");

                    b.Property<string>("Latitud");

                    b.Property<string>("Longitud");

                    b.Property<int>("ModificadoPor");

                    b.Property<string>("NombreComercial");

                    b.Property<string>("Telefono1");

                    b.Property<string>("Telefono2");

                    b.Property<int?>("UsuarioID");

                    b.HasKey("NegocioID");

                    b.HasIndex("CiudadID");

                    b.HasIndex("HorariosHorarioID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Negocios");
                });

            modelBuilder.Entity("Entidades.Productos", b =>
                {
                    b.Property<int>("ProductoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreadoPor");

                    b.Property<string>("Descripcion");

                    b.Property<int?>("EmpleadosEmpleadoID");

                    b.Property<DateTime>("FechaCreacion");

                    b.Property<DateTime>("FechaModificacion");

                    b.Property<int>("ModificadoPor");

                    b.Property<int?>("NegociosNegocioID");

                    b.Property<string>("Nombre");

                    b.Property<decimal>("Precio");

                    b.Property<decimal>("PrecioOferta");

                    b.Property<int>("Stock");

                    b.Property<int>("TipoProductos");

                    b.Property<int>("Unidad");

                    b.HasKey("ProductoID");

                    b.HasIndex("EmpleadosEmpleadoID");

                    b.HasIndex("NegociosNegocioID");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Entidades.Usuarios", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos");

                    b.Property<bool>("Confirmado");

                    b.Property<int>("CreadoPor");

                    b.Property<string>("Email");

                    b.Property<bool>("Estado");

                    b.Property<DateTime>("FechaCreacion");

                    b.Property<DateTime>("FechaModificacion");

                    b.Property<string>("Foto");

                    b.Property<int>("Genero");

                    b.Property<int>("ModificadoPor");

                    b.Property<string>("Nombres");

                    b.Property<string>("Password");

                    b.Property<int>("TipoUsuario");

                    b.Property<string>("UserName");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Entidades.Ventas", b =>
                {
                    b.Property<int>("VentaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreadoPor");

                    b.Property<DateTime>("Fecha");

                    b.Property<DateTime>("FechaCreacion");

                    b.Property<DateTime>("FechaModificacion");

                    b.Property<int>("ModificadoPor");

                    b.Property<decimal>("Monto");

                    b.Property<int?>("NegociosNegocioID");

                    b.Property<int?>("UsuariosUsuarioID");

                    b.HasKey("VentaID");

                    b.HasIndex("NegociosNegocioID");

                    b.HasIndex("UsuariosUsuarioID");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Entidades.VentasDetalle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad");

                    b.Property<decimal>("Precio");

                    b.Property<int>("ProductoID");

                    b.Property<int?>("VentaID");

                    b.HasKey("ID");

                    b.HasIndex("VentaID");

                    b.ToTable("VentasDetalle");
                });

            modelBuilder.Entity("Entidades.Citas", b =>
                {
                    b.HasOne("Entidades.Usuarios", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteUsuarioID");

                    b.HasOne("Entidades.Negocios", "Negocio")
                        .WithMany()
                        .HasForeignKey("NegocioID");
                });

            modelBuilder.Entity("Entidades.CitasDetalle", b =>
                {
                    b.HasOne("Entidades.Citas", "Cita")
                        .WithMany("Details")
                        .HasForeignKey("CitaID");
                });

            modelBuilder.Entity("Entidades.Empleados", b =>
                {
                    b.HasOne("Entidades.Negocios", "Negocio")
                        .WithMany()
                        .HasForeignKey("NegocioID");
                });

            modelBuilder.Entity("Entidades.Etiquetas", b =>
                {
                    b.HasOne("Entidades.Productos")
                        .WithMany("Etiquetas")
                        .HasForeignKey("ProductosProductoID");
                });

            modelBuilder.Entity("Entidades.FotosProductos", b =>
                {
                    b.HasOne("Entidades.Productos", "Productos")
                        .WithMany("Fotos")
                        .HasForeignKey("ProductosProductoID");
                });

            modelBuilder.Entity("Entidades.Mensajes", b =>
                {
                    b.HasOne("Entidades.Usuarios", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteUsuarioID");

                    b.HasOne("Entidades.Negocios", "Negocios")
                        .WithMany()
                        .HasForeignKey("NegociosNegocioID");
                });

            modelBuilder.Entity("Entidades.Negocios", b =>
                {
                    b.HasOne("Entidades.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("CiudadID");

                    b.HasOne("Entidades.Horarios", "Horarios")
                        .WithMany()
                        .HasForeignKey("HorariosHorarioID");

                    b.HasOne("Entidades.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID");
                });

            modelBuilder.Entity("Entidades.Productos", b =>
                {
                    b.HasOne("Entidades.Empleados")
                        .WithMany("Productos")
                        .HasForeignKey("EmpleadosEmpleadoID");

                    b.HasOne("Entidades.Negocios", "Negocios")
                        .WithMany()
                        .HasForeignKey("NegociosNegocioID");
                });

            modelBuilder.Entity("Entidades.Ventas", b =>
                {
                    b.HasOne("Entidades.Negocios", "Negocios")
                        .WithMany()
                        .HasForeignKey("NegociosNegocioID");

                    b.HasOne("Entidades.Usuarios", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuariosUsuarioID");
                });

            modelBuilder.Entity("Entidades.VentasDetalle", b =>
                {
                    b.HasOne("Entidades.Ventas", "Venta")
                        .WithMany("Details")
                        .HasForeignKey("VentaID");
                });
#pragma warning restore 612, 618
        }
    }
}
