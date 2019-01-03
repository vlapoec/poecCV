﻿// <auto-generated />
using System;
using FormationCV.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FormationCV.Data.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190102095846_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FormationCV.Entities.CV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodePostal");

                    b.Property<string>("Commune");

                    b.Property<DateTime>("DateDeNaissance");

                    b.Property<string>("Nom");

                    b.Property<int>("NumeroDeRue");

                    b.Property<bool>("Permis");

                    b.Property<string>("Prenom");

                    b.Property<string>("Rue");

                    b.Property<string>("Titre");

                    b.HasKey("Id");

                    b.ToTable("CVs");
                });

            modelBuilder.Entity("FormationCV.Entities.Competence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVId");

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("Competences");
                });

            modelBuilder.Entity("FormationCV.Entities.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVId");

                    b.Property<DateTime>("DateDebut");

                    b.Property<DateTime?>("DateFin");

                    b.Property<string>("Description");

                    b.Property<string>("Entreprise");

                    b.Property<string>("Poste");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("FormationCV.Entities.Formation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVId");

                    b.Property<DateTime>("DateDebut");

                    b.Property<DateTime>("DateFin");

                    b.Property<string>("Description");

                    b.Property<string>("Diplome");

                    b.Property<string>("Ecole");

                    b.Property<string>("Intitule");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("Formations");
                });

            modelBuilder.Entity("FormationCV.Entities.Langue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVId");

                    b.Property<string>("Label");

                    b.Property<int>("Niveau");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("Langues");
                });

            modelBuilder.Entity("FormationCV.Entities.Competence", b =>
                {
                    b.HasOne("FormationCV.Entities.CV", "CV")
                        .WithMany("Competences")
                        .HasForeignKey("CVId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FormationCV.Entities.Experience", b =>
                {
                    b.HasOne("FormationCV.Entities.CV", "CV")
                        .WithMany("Experiences")
                        .HasForeignKey("CVId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FormationCV.Entities.Formation", b =>
                {
                    b.HasOne("FormationCV.Entities.CV", "CV")
                        .WithMany("Formations")
                        .HasForeignKey("CVId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FormationCV.Entities.Langue", b =>
                {
                    b.HasOne("FormationCV.Entities.CV", "CV")
                        .WithMany("Langues")
                        .HasForeignKey("CVId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
