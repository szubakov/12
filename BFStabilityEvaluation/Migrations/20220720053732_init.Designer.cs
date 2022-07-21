﻿// <auto-generated />
using System;
using BFStabilityEvaluation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BFStabilityEvaluation.Migrations
{
    [DbContext(typeof(PraktiContext))]
    [Migration("20220720053732_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BFStabilityEvaluation.Models.Parameter", b =>
                {
                    b.Property<int>("IdParam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_param")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Alias")
                        .HasColumnType("int");

                    b.Property<double>("MaxValue")
                        .HasColumnType("float");

                    b.Property<double>("MinValue")
                        .HasColumnType("float")
                        .HasColumnName("MinValue_");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Unit_");

                    b.HasKey("IdParam")
                        .HasName("PK__Paramete__FD2AA0F98CC29996");

                    b.ToTable("Parameter");
                });

            modelBuilder.Entity("BFStabilityEvaluation.Models.ParameterValue", b =>
                {
                    b.Property<int>("IdParam")
                        .HasColumnType("int")
                        .HasColumnName("ID_param");

                    b.Property<int>("Npech")
                        .HasColumnType("int")
                        .HasColumnName("NPech_");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("date");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasIndex("IdParam");

                    b.ToTable("ParameterValue");
                });

            modelBuilder.Entity("BFStabilityEvaluation.Models.StabilitySign", b =>
                {
                    b.Property<int>("IdstabPokaz")
                        .HasColumnType("int")
                        .HasColumnName("IDstabPokaz");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)");

                    b.Property<double>("LimitDanger")
                        .HasColumnType("float");

                    b.Property<double>("LimitWarning")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)");

                    b.HasKey("IdstabPokaz")
                        .HasName("PK__Stabilit__1EEBF21482C3EADF");

                    b.ToTable("StabilitySign");
                });

            modelBuilder.Entity("BFStabilityEvaluation.Models.StabilitySignKriterium", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<double>("AcceptableDelta")
                        .HasColumnType("float");

                    b.Property<double>("ActionType")
                        .HasColumnType("float");

                    b.Property<int>("IdParam")
                        .HasColumnType("int")
                        .HasColumnName("ID_param");

                    b.Property<int>("IdstabPokaz")
                        .HasColumnType("int")
                        .HasColumnName("IDstabPokaz");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)");

                    b.Property<int>("Npech")
                        .HasColumnType("int")
                        .HasColumnName("NPech_");

                    b.Property<double>("Rang")
                        .HasColumnType("float")
                        .HasColumnName("Rang_");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("Unit_");

                    b.HasKey("Id");

                    b.HasIndex("IdParam");

                    b.HasIndex("IdstabPokaz");

                    b.ToTable("_StabilitySignKriteria");
                });

            modelBuilder.Entity("BFStabilityEvaluation.Models.User", b =>
                {
                    b.Property<byte>("CodeUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasMaxLength(32)
                        .IsUnicode(false)
                        .HasColumnType("char(32)")
                        .IsFixedLength(true);

                    b.Property<byte?>("Role")
                        .HasColumnType("tinyint");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("char(50)")
                        .IsFixedLength(true);

                    b.HasKey("CodeUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BFStabilityEvaluation.Models.ParameterValue", b =>
                {
                    b.HasOne("BFStabilityEvaluation.Models.Parameter", "IdParamNavigation")
                        .WithMany()
                        .HasForeignKey("IdParam")
                        .HasConstraintName("FK__Parameter__ID_pa__1273C1CD")
                        .IsRequired();

                    b.Navigation("IdParamNavigation");
                });

            modelBuilder.Entity("BFStabilityEvaluation.Models.StabilitySignKriterium", b =>
                {
                    b.HasOne("BFStabilityEvaluation.Models.Parameter", "IdParamNavigation")
                        .WithMany("StabilitySignKriteria")
                        .HasForeignKey("IdParam")
                        .HasConstraintName("FK___Stabilit__ID_pa__182C9B23")
                        .IsRequired();

                    b.HasOne("BFStabilityEvaluation.Models.StabilitySign", "IdstabPokazNavigation")
                        .WithMany("StabilitySignKriteria")
                        .HasForeignKey("IdstabPokaz")
                        .HasConstraintName("FK___Stabilit__IDsta__173876EA")
                        .IsRequired();

                    b.Navigation("IdParamNavigation");

                    b.Navigation("IdstabPokazNavigation");
                });

            modelBuilder.Entity("BFStabilityEvaluation.Models.Parameter", b =>
                {
                    b.Navigation("StabilitySignKriteria");
                });

            modelBuilder.Entity("BFStabilityEvaluation.Models.StabilitySign", b =>
                {
                    b.Navigation("StabilitySignKriteria");
                });
#pragma warning restore 612, 618
        }
    }
}
