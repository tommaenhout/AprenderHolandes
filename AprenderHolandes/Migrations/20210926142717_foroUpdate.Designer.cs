﻿// <auto-generated />
using System;
using AprenderHolandes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AprenderHolandes.Migrations
{
    [DbContext(typeof(DbContextInstituto))]
    [Migration("20210926142717_foroUpdate")]
    partial class foroUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AprenderHolandes.Models.AlumnoMateriaCursada", b =>
                {
                    b.Property<Guid>("AlumnoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MateriaCursadaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CalificacionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AlumnoId", "MateriaCursadaId");

                    b.HasIndex("CalificacionId")
                        .IsUnique();

                    b.HasIndex("MateriaCursadaId");

                    b.ToTable("AlumnoMateriaCursadas");
                });

            modelBuilder.Entity("AprenderHolandes.Models.AlumnoMateriaCursadaEvaluaciondaNota", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AlumnoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MateriaCursadaEvaluacionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProfesorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("MateriaCursadaEvaluacionId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("AlumnoMateriaCursadaEvaluaciondaNotas");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Calificacion", b =>
                {
                    b.Property<Guid>("CalificacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MateriaCursadaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MateriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NotaFinal")
                        .HasColumnType("int");

                    b.Property<Guid>("ProfesorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CalificacionId");

                    b.HasIndex("MateriaCursadaId");

                    b.HasIndex("MateriaId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Calificaciones");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Carrera", b =>
                {
                    b.Property<Guid>("CarreraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CarreraId");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Clase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MateriaCursadaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProfesorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MateriaCursadaId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Clases");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Evaluacion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MateriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProfesorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("MateriaId");

                    b.ToTable("Evaluaciones");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Materia", b =>
                {
                    b.Property<Guid>("MateriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CarreraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoMateria")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<int>("CupoMaximo")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MateriaId");

                    b.HasIndex("CarreraId");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("AprenderHolandes.Models.MateriaCursada", b =>
                {
                    b.Property<Guid>("MateriaCursadaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<int>("CantidadHorasPorSemana")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaTermino")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MateriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<Guid>("ProfesorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MateriaCursadaId");

                    b.HasIndex("MateriaId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("MateriaCursadas");
                });

            modelBuilder.Entity("AprenderHolandes.Models.MateriaCursadaEvaluacion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<Guid>("EvaluacionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MateriaCursadaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EvaluacionId");

                    b.HasIndex("MateriaCursadaId");

                    b.ToTable("MateriaCursadaEvaluaciones");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Mensaje", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MateriaCursadaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MateriaCursadaId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Mensajes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Mensaje");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole<Guid>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser<Guid>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("PersonasRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Pregunta", b =>
                {
                    b.HasBaseType("AprenderHolandes.Models.Mensaje");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Pregunta");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Respuesta", b =>
                {
                    b.HasBaseType("AprenderHolandes.Models.Mensaje");

                    b.Property<Guid>("PreguntaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("PreguntaId");

                    b.HasDiscriminator().HasValue("Respuesta");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Rol", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>");

                    b.HasDiscriminator().HasValue("Rol");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Persona", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser<System.Guid>");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Persona");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Alumno", b =>
                {
                    b.HasBaseType("AprenderHolandes.Models.Persona");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<Guid>("CarreraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NumeroMatricula")
                        .HasColumnType("int");

                    b.HasIndex("CarreraId");

                    b.HasDiscriminator().HasValue("Alumno");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Empleado", b =>
                {
                    b.HasBaseType("AprenderHolandes.Models.Persona");

                    b.Property<string>("Legajo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Empleado");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Profesor", b =>
                {
                    b.HasBaseType("AprenderHolandes.Models.Persona");

                    b.Property<string>("Legajo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Profesor_Legajo");

                    b.HasDiscriminator().HasValue("Profesor");
                });

            modelBuilder.Entity("AprenderHolandes.Models.AlumnoMateriaCursada", b =>
                {
                    b.HasOne("AprenderHolandes.Models.Alumno", "Alumno")
                        .WithMany("AlumnosMateriasCursadas")
                        .HasForeignKey("AlumnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AprenderHolandes.Models.Calificacion", "Calificacion")
                        .WithOne("AlumnoMateriaCursada")
                        .HasForeignKey("AprenderHolandes.Models.AlumnoMateriaCursada", "CalificacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AprenderHolandes.Models.MateriaCursada", "MateriaCursada")
                        .WithMany("AlumnoMateriaCursadas")
                        .HasForeignKey("MateriaCursadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alumno");

                    b.Navigation("Calificacion");

                    b.Navigation("MateriaCursada");
                });

            modelBuilder.Entity("AprenderHolandes.Models.AlumnoMateriaCursadaEvaluaciondaNota", b =>
                {
                    b.HasOne("AprenderHolandes.Models.Alumno", "Alumno")
                        .WithMany("AlumnoMateriaCursadaEvaluaciondaNotas")
                        .HasForeignKey("AlumnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AprenderHolandes.Models.MateriaCursadaEvaluacion", "MateriaCursadaEvaluacion")
                        .WithMany("AlumnoMateriaCursadaEvaluaciondaNotas")
                        .HasForeignKey("MateriaCursadaEvaluacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AprenderHolandes.Models.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alumno");

                    b.Navigation("MateriaCursadaEvaluacion");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Calificacion", b =>
                {
                    b.HasOne("AprenderHolandes.Models.MateriaCursada", null)
                        .WithMany("Calificaciones")
                        .HasForeignKey("MateriaCursadaId");

                    b.HasOne("AprenderHolandes.Models.Materia", "Materia")
                        .WithMany("Calificaciones")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AprenderHolandes.Models.Profesor", "Profesor")
                        .WithMany("CalificacionesRealizadas")
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materia");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Clase", b =>
                {
                    b.HasOne("AprenderHolandes.Models.MateriaCursada", "MateriaCursada")
                        .WithMany("Clases")
                        .HasForeignKey("MateriaCursadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AprenderHolandes.Models.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MateriaCursada");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Evaluacion", b =>
                {
                    b.HasOne("AprenderHolandes.Models.Materia", "Materia")
                        .WithMany("Evaluaciones")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Materia", b =>
                {
                    b.HasOne("AprenderHolandes.Models.Carrera", "Carrera")
                        .WithMany("Materias")
                        .HasForeignKey("CarreraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrera");
                });

            modelBuilder.Entity("AprenderHolandes.Models.MateriaCursada", b =>
                {
                    b.HasOne("AprenderHolandes.Models.Materia", "Materia")
                        .WithMany("MateriasCursadas")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AprenderHolandes.Models.Profesor", "Profesor")
                        .WithMany("MateriasCursadasActivas")
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materia");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("AprenderHolandes.Models.MateriaCursadaEvaluacion", b =>
                {
                    b.HasOne("AprenderHolandes.Models.Evaluacion", "Evaluacion")
                        .WithMany("MateriaCursadaEvaluaciones")
                        .HasForeignKey("EvaluacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AprenderHolandes.Models.MateriaCursada", "MateriaCursada")
                        .WithMany("MateriaCursadaEvaluaciones")
                        .HasForeignKey("MateriaCursadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evaluacion");

                    b.Navigation("MateriaCursada");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Mensaje", b =>
                {
                    b.HasOne("AprenderHolandes.Models.MateriaCursada", "MateriaCursada")
                        .WithMany("Mensajes")
                        .HasForeignKey("MateriaCursadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AprenderHolandes.Models.Persona", "Persona")
                        .WithMany("Mensajes")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MateriaCursada");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AprenderHolandes.Models.Respuesta", b =>
                {
                    b.HasOne("AprenderHolandes.Models.Pregunta", "Pregunta")
                        .WithMany("Respuestas")
                        .HasForeignKey("PreguntaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pregunta");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Alumno", b =>
                {
                    b.HasOne("AprenderHolandes.Models.Carrera", "Carrera")
                        .WithMany("Alumnos")
                        .HasForeignKey("CarreraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrera");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Calificacion", b =>
                {
                    b.Navigation("AlumnoMateriaCursada");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Carrera", b =>
                {
                    b.Navigation("Alumnos");

                    b.Navigation("Materias");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Evaluacion", b =>
                {
                    b.Navigation("MateriaCursadaEvaluaciones");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Materia", b =>
                {
                    b.Navigation("Calificaciones");

                    b.Navigation("Evaluaciones");

                    b.Navigation("MateriasCursadas");
                });

            modelBuilder.Entity("AprenderHolandes.Models.MateriaCursada", b =>
                {
                    b.Navigation("AlumnoMateriaCursadas");

                    b.Navigation("Calificaciones");

                    b.Navigation("Clases");

                    b.Navigation("MateriaCursadaEvaluaciones");

                    b.Navigation("Mensajes");
                });

            modelBuilder.Entity("AprenderHolandes.Models.MateriaCursadaEvaluacion", b =>
                {
                    b.Navigation("AlumnoMateriaCursadaEvaluaciondaNotas");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Pregunta", b =>
                {
                    b.Navigation("Respuestas");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Persona", b =>
                {
                    b.Navigation("Mensajes");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Alumno", b =>
                {
                    b.Navigation("AlumnoMateriaCursadaEvaluaciondaNotas");

                    b.Navigation("AlumnosMateriasCursadas");
                });

            modelBuilder.Entity("AprenderHolandes.Models.Profesor", b =>
                {
                    b.Navigation("CalificacionesRealizadas");

                    b.Navigation("MateriasCursadasActivas");
                });
#pragma warning restore 612, 618
        }
    }
}
