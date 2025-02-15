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
    [Migration("20241201223649_SGCPDB")]
    partial class SGCPDB
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

                    b.Property<string>("Motif")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Consultations");
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

                    b.Property<string>("Duree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instruction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicament")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsultationId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Prescription", b =>
                {
                    b.HasOne("CleanArchitectureSGCP.Core.Entities.Consultation", null)
                        .WithMany("Prescriptions")
                        .HasForeignKey("ConsultationId");
                });

            modelBuilder.Entity("CleanArchitectureSGCP.Core.Entities.Consultation", b =>
                {
                    b.Navigation("Prescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
