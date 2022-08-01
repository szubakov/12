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
    [Migration("20220727185400_TablesHasData")]
    partial class TablesHasData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BFStabilityEvaluation.Models.Parameter", b =>
                {
                    b.Property<int>("ParameterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<double>("MaxValue")
                        .HasColumnType("float");

                    b.Property<double>("MinValue")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Unit")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("ParameterId");

                    b.ToTable("Parameters");

                    b.HasData(
                        new
                        {
                            ParameterId = 1,
                            Alias = "SpecPerformance",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Удельная производительность",
                            Unit = "т/м3"
                        },
                        new
                        {
                            ParameterId = 2,
                            Alias = "Spec Сonsumption coke",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Удельный расход кокса",
                            Unit = "кг/т чугуна"
                        },
                        new
                        {
                            ParameterId = 3,
                            Alias = "Current downtime",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Текущие простои",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 4,
                            Alias = "Quiet running",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Тихий ход",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 5,
                            Alias = "The proportion of pellets",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Доля окатышей в шихте",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 6,
                            Alias = "Share of sinter",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Доля агломерата в шихте",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 7,
                            Alias = "Fe content",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Содержание Fe в доменной шихте",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 8,
                            Alias = "Basicity  CaO/Sio2",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Основность ЖРМ CaO/Sio2",
                            Unit = "-"
                        },
                        new
                        {
                            ParameterId = 9,
                            Alias = "Basicity  (CaO+MgO)/(SiO2)",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Основность ЖРМ (CaO+MgO)/(SiO2)",
                            Unit = "-"
                        },
                        new
                        {
                            ParameterId = 10,
                            Alias = "Basicity (CaO+MgO)/(SiO2+Al2O3)",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Основность ЖРМ (CaO+MgO)/(SiO2+Al2O3)",
                            Unit = "-"
                        },
                        new
                        {
                            ParameterId = 11,
                            Alias = "Ash in coke",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Содержание золы в коксе",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 12,
                            Alias = "Moisture  in coke",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Содержание влаги в коксе",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 13,
                            Alias = "Volatile  in coke",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Содержание летучих в коксе",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 14,
                            Alias = "Coke  M25",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Прочность кокса по М25",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 15,
                            Alias = "Abrasion to M10",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Истираемость кокса по М10",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 16,
                            Alias = "CSR",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "CSR",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 17,
                            Alias = "CRI",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "CRI",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 18,
                            Alias = "Gas consumption",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Расход природного газа",
                            Unit = "м3/т чугуна"
                        },
                        new
                        {
                            ParameterId = 19,
                            Alias = "HotBlastO2",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Содержание кислорода в дутье",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 20,
                            Alias = "TempHotBlast",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Температура горячего дутья",
                            Unit = "°С"
                        },
                        new
                        {
                            ParameterId = 21,
                            Alias = "TempKolGaz",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Средняя температура колошникового газа",
                            Unit = "°С"
                        },
                        new
                        {
                            ParameterId = 22,
                            Alias = "Degree of CO",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Степень использования СО",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 23,
                            Alias = "Degree of CO H2",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Степень использования Н2",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 24,
                            Alias = "Temperature peripheral",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Средняя температура периферийных газов",
                            Unit = "°С"
                        },
                        new
                        {
                            ParameterId = 25,
                            Alias = "Irregularity of gas temperature",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Окружная неравномерность температуры газа",
                            Unit = "°С"
                        },
                        new
                        {
                            ParameterId = 26,
                            Alias = "Irregularities  top gas",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Неравномерность T колошникового газа по газоотводам",
                            Unit = "°С"
                        },
                        new
                        {
                            ParameterId = 27,
                            Alias = "Ratio  Tcp of peripheral to Tcp of gas",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Отношение Tcр периферийных термопар к Tcр колошникового газа",
                            Unit = "ед"
                        },
                        new
                        {
                            ParameterId = 28,
                            Alias = "Reftemperatures 4th row",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Температура холодильников 4 ряд",
                            Unit = "°С"
                        },
                        new
                        {
                            ParameterId = 29,
                            Alias = "Theoretical  temperature",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Теоретическая температура горения",
                            Unit = "°С"
                        },
                        new
                        {
                            ParameterId = 30,
                            Alias = "Si content in cast iron",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Содержание в чугуне Si",
                            Unit = "%"
                        },
                        new
                        {
                            ParameterId = 31,
                            Alias = "Index of the bottom temperature ",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Индекс низа температурного поля",
                            Unit = "доли"
                        },
                        new
                        {
                            ParameterId = 32,
                            Alias = "Index of the top of the temperature ",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Индекс верха температурного поля",
                            Unit = "доли"
                        },
                        new
                        {
                            ParameterId = 33,
                            Alias = "Basicity_1",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Основность конечного шлака (CaO/(SiO2)",
                            Unit = "-"
                        },
                        new
                        {
                            ParameterId = 34,
                            Alias = "Basicity_2",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Основность конечного шлака (CaO+MgO)/(SiO2)",
                            Unit = " -"
                        },
                        new
                        {
                            ParameterId = 35,
                            Alias = "Basicity_3",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Основность конечного шлака (CaO+MgO)/(SiO2+Al2O3)",
                            Unit = " -"
                        },
                        new
                        {
                            ParameterId = 36,
                            Alias = "Sulfur distribution coefficient",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Коэффициент распределения серы",
                            Unit = "°доли"
                        },
                        new
                        {
                            ParameterId = 37,
                            Alias = "Viscosity_1400",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Вязкость конечного шлака при 1400 °С",
                            Unit = "Па∙с"
                        },
                        new
                        {
                            ParameterId = 38,
                            Alias = "Viscosity_1500",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Вязкость конечного шлака при 1500 °С",
                            Unit = "Па∙с"
                        },
                        new
                        {
                            ParameterId = 39,
                            Alias = "Viscosity_Tfin",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Вязкость конечного шлака при T конечной",
                            Unit = "Па∙с"
                        },
                        new
                        {
                            ParameterId = 40,
                            Alias = "Viscosity gradients at 1400–1500 °C",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Градиенты вязкости шлака при 1400–1500 °С ",
                            Unit = "Па∙с/°С"
                        },
                        new
                        {
                            ParameterId = 41,
                            Alias = "Slag viscosity gradients at 0.7–2.5 Pa∙s",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Градиенты вязкости шлака при 0,7–2,5 Па∙с",
                            Unit = "Па∙с/°С"
                        },
                        new
                        {
                            ParameterId = 42,
                            Alias = "P drop tuyere - top",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Перепад давления «фурмы – колошник»",
                            Unit = "атм"
                        },
                        new
                        {
                            ParameterId = 43,
                            Alias = "The degree  balancing by the gas flow",
                            MaxValue = 0.0,
                            MinValue = 0.0,
                            Name = "Степень уравновешивания шихты газовым потоком",
                            Unit = "%"
                        });
                });

            modelBuilder.Entity("BFStabilityEvaluation.Models.ParameterValue", b =>
                {
                    b.Property<int>("Npech")
                        .HasColumnType("int");

                    b.Property<int>("ParameterId")
                        .HasColumnType("int");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<int>("IdPValue")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Npech", "ParameterId", "Period");

                    b.HasIndex("ParameterId");

                    b.ToTable("ParameterValues");
                });

            modelBuilder.Entity("BFStabilityEvaluation.Models.StabilitySign", b =>
                {
                    b.Property<int>("StabSignId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("LimitDanger")
                        .HasColumnType("float");

                    b.Property<double>("LimitWarning")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("StabSignId");

                    b.ToTable("StabilitySigns");

                    b.HasData(
                        new
                        {
                            StabSignId = 1,
                            Alias = "TEIM",
                            LimitDanger = 0.0,
                            LimitWarning = 0.0,
                            Name = "Технико-экономический показатели плавки"
                        },
                        new
                        {
                            StabSignId = 2,
                            Alias = "Properties of raw materials",
                            LimitDanger = 0.0,
                            LimitWarning = 0.0,
                            Name = "Свойства сырья (железорудных материалов, кокса)."
                        },
                        new
                        {
                            StabSignId = 3,
                            Alias = "IBGDM",
                            LimitDanger = 0.0,
                            LimitWarning = 0.0,
                            Name = "Показатель дутьевого и газодинамического режима"
                        },
                        new
                        {
                            StabSignId = 4,
                            Alias = "Indicator of the thermal regime",
                            LimitDanger = 0.0,
                            LimitWarning = 0.0,
                            Name = "Показатель теплового режима"
                        },
                        new
                        {
                            StabSignId = 5,
                            Alias = "Indicator of the slag regime",
                            LimitDanger = 0.0,
                            LimitWarning = 0.0,
                            Name = "Показатель шлакового режима"
                        },
                        new
                        {
                            StabSignId = 6,
                            Alias = "IISF",
                            LimitDanger = 0.0,
                            LimitWarning = 0.0,
                            Name = "Интегральный показатель стабильности работы печи "
                        });
                });

            modelBuilder.Entity("BFStabilityEvaluation.Models.StabilitySignKriterium", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AcceptableDelta")
                        .HasColumnType("float");

                    b.Property<double>("ActionType")
                        .HasColumnType("float");

                    b.Property<int?>("IdstabPokazNavigationStabSignId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("Npech")
                        .HasColumnType("int");

                    b.Property<int>("ParameterId")
                        .HasColumnType("int");

                    b.Property<double>("Rang")
                        .HasColumnType("float");

                    b.Property<int>("StabSignId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("IdstabPokazNavigationStabSignId");

                    b.HasIndex("ParameterId");

                    b.ToTable("StabilitySignKriteria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 1,
                            Rang = 0.0,
                            StabSignId = 1
                        },
                        new
                        {
                            Id = 2,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 2,
                            Rang = 0.0,
                            StabSignId = 1
                        },
                        new
                        {
                            Id = 3,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 3,
                            Rang = 0.0,
                            StabSignId = 1
                        },
                        new
                        {
                            Id = 4,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 4,
                            Rang = 0.0,
                            StabSignId = 1
                        },
                        new
                        {
                            Id = 5,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 5,
                            Rang = 0.0,
                            StabSignId = 2
                        },
                        new
                        {
                            Id = 6,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 6,
                            Rang = 0.0,
                            StabSignId = 2
                        },
                        new
                        {
                            Id = 7,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 7,
                            Rang = 0.0,
                            StabSignId = 2
                        },
                        new
                        {
                            Id = 8,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 8,
                            Rang = 0.0,
                            StabSignId = 2
                        },
                        new
                        {
                            Id = 9,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 9,
                            Rang = 0.0,
                            StabSignId = 2
                        },
                        new
                        {
                            Id = 10,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 10,
                            Rang = 0.0,
                            StabSignId = 2
                        },
                        new
                        {
                            Id = 11,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 11,
                            Rang = 0.0,
                            StabSignId = 2
                        },
                        new
                        {
                            Id = 12,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 12,
                            Rang = 0.0,
                            StabSignId = 2
                        },
                        new
                        {
                            Id = 13,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 13,
                            Rang = 0.0,
                            StabSignId = 2
                        },
                        new
                        {
                            Id = 14,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 14,
                            Rang = 0.0,
                            StabSignId = 2
                        },
                        new
                        {
                            Id = 15,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 15,
                            Rang = 0.0,
                            StabSignId = 2
                        },
                        new
                        {
                            Id = 16,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 16,
                            Rang = 0.0,
                            StabSignId = 2
                        },
                        new
                        {
                            Id = 17,
                            AcceptableDelta = 0.0,
                            ActionType = 0.0,
                            ParameterId = 17,
                            Rang = 0.0,
                            StabSignId = 2
                        });
                });

            modelBuilder.Entity("BFStabilityEvaluation.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BFStabilityEvaluation.Models.ParameterValue", b =>
                {
                    b.HasOne("BFStabilityEvaluation.Models.Parameter", "Parameter")
                        .WithMany("ParameterValues")
                        .HasForeignKey("ParameterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parameter");
                });

            modelBuilder.Entity("BFStabilityEvaluation.Models.StabilitySignKriterium", b =>
                {
                    b.HasOne("BFStabilityEvaluation.Models.StabilitySign", "IdstabPokazNavigation")
                        .WithMany("StabilitySignKriteria")
                        .HasForeignKey("IdstabPokazNavigationStabSignId");

                    b.HasOne("BFStabilityEvaluation.Models.Parameter", "Parameter")
                        .WithMany("StabilitySignKriteria")
                        .HasForeignKey("ParameterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdstabPokazNavigation");

                    b.Navigation("Parameter");
                });

            modelBuilder.Entity("BFStabilityEvaluation.Models.Parameter", b =>
                {
                    b.Navigation("ParameterValues");

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
