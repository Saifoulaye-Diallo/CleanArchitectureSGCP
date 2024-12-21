﻿// <auto-generated />
using System;
using CleanArchitectureSGCP.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CleanArchitectureSGCP.Infrastructure.Migrations
{
    [DbContext(typeof(SGCPContext))]
    [Migration("20241221092404_migrationFinal")]
    partial class migrationFinal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Consultation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diagnostic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DossierMedicalId")
                        .HasColumnType("int");

                    b.Property<string>("Motif")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DossierMedicalId");

                    b.HasIndex("SessionId");

                    b.ToTable("Consultations");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.DossierMedical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId")
                        .IsUnique();

                    b.ToTable("DossiersMedicals");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Addresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddresseCourriel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateDeNaissance")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MedecinId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelephones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MedecinId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Prescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ConsultationId")
                        .HasColumnType("int");

                    b.Property<string>("Dosage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DossierMedicalId")
                        .HasColumnType("int");

                    b.Property<string>("Duree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instruction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicament")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("etat")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsultationId");

                    b.HasIndex("DossierMedicalId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateConnexion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDeconnexion")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedecinId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedecinId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("MotDePasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomUtilisateur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utilisateurs");

                    b.HasDiscriminator().HasValue("Utilisateur");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Medecin", b =>
                {
                    b.HasBaseType("CleanArchitectureSGCP.Core.Entities.Utilisateur");

                    b.Property<string>("Addresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddresseCourriel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroLicence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Medecin");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Consultation", b =>
                {
                    b.HasOne("CleanArchitectureSGCP.Core.Entities.DossierMedical", null)
                        .WithMany("Consultations")
                        .HasForeignKey("DossierMedicalId");

                    b.HasOne("CleanArchitectureSGCP.Core.Entities.Session", null)
                        .WithMany("Consultations")
                        .HasForeignKey("SessionId");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.DossierMedical", b =>
                {
                    b.HasOne("CleanArchitectureSGCP.Core.Entities.Patient", "Patient")
                        .WithOne("DossierMedical")
                        .HasForeignKey("CleanArchitectureSGCP.Core.Entities.DossierMedical", "PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Patient", b =>
                {
                    b.HasOne("CleanArchitectureSGCP.Core.Entities.Medecin", null)
                        .WithMany("Patients")
                        .HasForeignKey("MedecinId");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Prescription", b =>
                {
                    b.HasOne("CleanArchitectureSGCP.Core.Entities.Consultation", null)
                        .WithMany("Prescriptions")
                        .HasForeignKey("ConsultationId");

                    b.HasOne("CleanArchitectureSGCP.Core.Entities.DossierMedical", null)
                        .WithMany("TraitementPasses")
                        .HasForeignKey("DossierMedicalId");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Session", b =>
                {
                    b.HasOne("CleanArchitectureSGCP.Core.Entities.Medecin", "Medecin")
                        .WithMany("Sessions")
                        .HasForeignKey("MedecinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medecin");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Consultation", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.DossierMedical", b =>
                {
                    b.Navigation("Consultations");

                    b.Navigation("TraitementPasses");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Patient", b =>
                {
                    b.Navigation("DossierMedical")
                        .IsRequired();
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Session", b =>
                {
                    b.Navigation("Consultations");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Medecin", b =>
                {
                    b.Navigation("Patients");

                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
