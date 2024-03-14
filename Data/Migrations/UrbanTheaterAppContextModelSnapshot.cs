﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UrbanTheater.Data;

#nullable disable

namespace UrbanTheater.Data.Migrations
{
    [DbContext(typeof(UrbanTheaterAppContext))]
    partial class UrbanTheaterAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UrbanTheater.Models.Asiento", b =>
                {
                    b.Property<int>("idAsiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idAsiento"));

                    b.Property<bool>("isFree")
                        .HasColumnType("bit");

                    b.HasKey("idAsiento");

                    b.ToTable("Asientos");

                    b.HasData(
                        new
                        {
                            idAsiento = 1,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 2,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 3,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 4,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 5,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 6,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 7,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 8,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 9,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 10,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 11,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 12,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 13,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 14,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 15,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 16,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 17,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 18,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 19,
                            isFree = true
                        },
                        new
                        {
                            idAsiento = 20,
                            isFree = true
                        });
                });

            modelBuilder.Entity("UrbanTheater.Models.AsientosObrasDatos", b =>
                {
                    b.Property<int>("idObjeto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idObjeto"));

                    b.Property<int>("idAsiento")
                        .HasColumnType("int");

                    b.Property<int>("idObra")
                        .HasColumnType("int");

                    b.Property<int>("idSesion")
                        .HasColumnType("int");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.HasKey("idObjeto");

                    b.ToTable("AsientosObrasDatos");
                });

            modelBuilder.Entity("UrbanTheater.Models.Historial", b =>
                {
                    b.Property<int>("idObjeto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idObjeto"));

                    b.Property<int>("asiento")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.Property<string>("nombreObra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sesion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idObjeto");

                    b.ToTable("Historial");
                });

            modelBuilder.Entity("UrbanTheater.Models.Obra", b =>
                {
                    b.Property<int>("ObraID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObraID"));

                    b.Property<string>("Actores")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Autores")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cartel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Duracion")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaDos")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaTres")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaUno")
                        .HasColumnType("datetime2");

                    b.Property<string>("Imagenes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObraID");

                    b.ToTable("Obras");

                    b.HasData(
                        new
                        {
                            ObraID = 1,
                            Actores = "Alexander Montgomery, Isabella Ramirez, Benjamin Worthington, Olivia Hawthorne, Nathaniel Harrington",
                            Autores = "Samuel Beckett",
                            Cartel = "https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Esperando-Godot/esperando-a-godot.jpg",
                            Descripcion = "Una obra teatral absurda que sigue a dos personajes, Vladimir y Estragon, mientras esperan en un lugar desolado a alguien llamado Godot, explorando temas de la existencia, la alienación y la esperanza.",
                            Duracion = 7200,
                            FechaDos = new DateTime(2024, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaTres = new DateTime(2024, 3, 18, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaUno = new DateTime(2024, 3, 3, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Imagenes = "https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Esperando-Godot/esperando-a-godot_FN.jpg , https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Esperando-Godot/esperando-a-godot_FN2.jpg , https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Esperando-Godot/una-escena-de-esperando-a-godot.jpg",
                            Nombre = "Esperando a Godot"
                        },
                        new
                        {
                            ObraID = 2,
                            Actores = "Sophia Anderson, Daniel Blackwood, Elena Rodriguez, Nicholas Smith, Isabella Johnson ",
                            Autores = "Andrew Lloyd Webber, Charles Hart, Richard Stilgoe",
                            Cartel = "https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Fantasma-opera/fantasma-opera.jpg",
                            Descripcion = "Una icónica obra de teatro musical que narra la historia de un misterioso y desfigurado hombre conocido como el Fantasma, que vive en los pasadizos de la Ópera de París y se obsesiona con una joven y talentosa soprano, Christine.",
                            Duracion = 4800,
                            FechaDos = new DateTime(2024, 1, 12, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaTres = new DateTime(2024, 1, 22, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaUno = new DateTime(2024, 1, 7, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Imagenes = "https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Fantasma-opera/fantasma-opera_FN.jpg , https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Fantasma-opera/Fantasma-operea_FN2.jpg",
                            Nombre = "El Fantasma de la Ópera"
                        },
                        new
                        {
                            ObraID = 3,
                            Actores = "Miguel Ángel Jiménez, Laura González, José Martín, Carmen Sánchez, Diego Torres",
                            Autores = "Valentina Moreno, Carlos Ruiz",
                            Cartel = "https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Galder/Galder.jpeg",
                            Descripcion = "Un audaz espectáculo que desafía las convenciones, combinando elementos de teatro, danza y performance art. La trama sigue a un grupo ecléctico de artistas mientras exploran temas de identidad, realidad y percepción a través de actuaciones vanguardistas.",
                            Duracion = 9000,
                            FechaDos = new DateTime(2024, 5, 15, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaTres = new DateTime(2024, 5, 20, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaUno = new DateTime(2024, 5, 1, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            Imagenes = "https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Galder/galder2.jpg , https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Galder/galder3.jpg",
                            Nombre = "Esto No Es Un Show"
                        },
                        new
                        {
                            ObraID = 4,
                            Actores = "Alexander Knight, Sarah Miller, David Johnson, Emily White, Richard Brown",
                            Autores = "William Shakespeare",
                            Cartel = "https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Hamlet/hamlet.jpg",
                            Descripcion = "Una de las tragedias más emblemáticas de William Shakespeare, centrada en la historia del príncipe Hamlet de Dinamarca, quien busca vengar la muerte de su padre. La obra explora temas complejos como la locura, la traición, la venganza y la moralidad.",
                            Duracion = 6300,
                            FechaDos = new DateTime(2024, 6, 6, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaTres = new DateTime(2024, 6, 10, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaUno = new DateTime(2024, 6, 1, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            Imagenes = "https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Hamlet/hamlet_FN2.jpg , https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Hamlet/hamlet_FN.jpg",
                            Nombre = "Hamlet"
                        },
                        new
                        {
                            ObraID = 5,
                            Actores = "Michael James, Elizabeth Green, Thomas Hill, Rachel Adams, William Parker",
                            Autores = "Irene Mecchi, Jonathan Roberts, Linda Woolverton",
                            Cartel = "https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Rey-Leon/reyLeon.webp",
                            Descripcion = "Un musical espectacular basado en la famosa película animada de Disney. La historia sigue las aventuras de Simba, un joven león que debe enfrentar numerosos desafíos para reclamar su lugar como el legítimo rey de la sabana. El musical es conocido por su impresionante uso de disfraces, marionetas y efectos visuales para recrear el ambiente de África.",
                            Duracion = 4800,
                            FechaDos = new DateTime(2024, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaTres = new DateTime(2024, 7, 20, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaUno = new DateTime(2024, 7, 1, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Imagenes = "https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Rey-Leon/reyleonIMG3.jpg , https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Rey-Leon/reyLeonImg1.jpg , https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/Rey-Leon/reyleonIMG2.avif",
                            Nombre = "El Rey León"
                        },
                        new
                        {
                            ObraID = 6,
                            Actores = "Elena Sánchez, Carlos Pérez, María López, José Torres, Laura Jiménez",
                            Autores = "Ana García, Luis Hernández",
                            Cartel = "https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/BodasDeSangre/BodasDeSangre.jpg",
                            Descripcion = "Una comedia romántica contemporánea que sigue la historia de varias parejas que se preparan para sus respectivas bodas. La obra teje una trama llena de enredos amorosos, malentendidos cómicos y momentos de reflexión sobre las relaciones y el matrimonio.",
                            Duracion = 9000,
                            FechaDos = new DateTime(2024, 8, 12, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaTres = new DateTime(2024, 8, 21, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaUno = new DateTime(2024, 8, 2, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Imagenes = "https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/BodasDeSangre/BodasDeSangre_NF2.jpg , https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/BodasDeSangre/BodasDeSangre_NF.jpg",
                            Nombre = "Bodas de sangre"
                        },
                        new
                        {
                            ObraID = 7,
                            Actores = "Augusto González, Fernando Ardévol, Juan Luis García",
                            Autores = "Alberto Marca, Carlos Marco",
                            Cartel = "https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/B-vocal/b-vocal_LG.jpg",
                            Descripcion = "Un aclamado grupo vocal que destaca por su habilidad para fusionar a cappella y comedia en sus actuaciones. B-Vocal cautiva al público con su mezcla única de música, humor y la sorprendente habilidad de crear sonidos instrumentales con sus voces, explorando diversos géneros musicales desde el pop hasta el clásico.",
                            Duracion = 7200,
                            FechaDos = new DateTime(2024, 9, 3, 22, 30, 0, 0, DateTimeKind.Unspecified),
                            FechaTres = new DateTime(2024, 9, 10, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaUno = new DateTime(2024, 9, 1, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Imagenes = "https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/B-vocal/b-vocal_NF.jpg , https://ik.imagekit.io/daniel2003/fotos-descripción-obras-teatro/B-vocal/b.jpg",
                            Nombre = "B-Vocal"
                        });
                });

            modelBuilder.Entity("UrbanTheater.Models.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idUsuario"));

                    b.Property<string>("contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rol")
                        .HasColumnType("int");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            idUsuario = 1,
                            contrasena = "Daniel_Admin123",
                            nombreUsuario = "Daniel_Admin",
                            rol = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
