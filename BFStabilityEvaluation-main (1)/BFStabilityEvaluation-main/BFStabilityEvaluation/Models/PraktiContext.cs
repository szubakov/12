using System;
using BFStabilityEvaluation.Models.Entities;
using BFStabilityEvaluation.Models.Enums;
using Microsoft.EntityFrameworkCore; 

#nullable disable

namespace BFStabilityEvaluation.Models
{
    public partial class PraktiContext : DbContext
    {
        public PraktiContext(DbContextOptions<PraktiContext> options) : base(options)
        {
        }

        public DbSet<Parameter> Parameters { get; set; }

        public DbSet<ParameterValue> ParameterValues { get; set; }

        public DbSet<Pech> Pechi { get; set; }

        public DbSet<Indicator> Indicators { get; set; }

        public DbSet<ComplexCriterion> ComplexCriterions { get; set; }

        public DbSet<SimpleCriterion> SimpleCriterions { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ParameterValue>().HasKey(u => new { u.Npech, u.ParameterId, u.Period });

            modelBuilder.Entity<Parameter>().HasData(

                new Parameter { ParameterId = 1, Name = "Удельная производительность", Alias = "SpecPerformance", Unit = "т/м3", MinValue = 2.13, MaxValue = 2.6 },
                new Parameter { ParameterId = 2, Name = "Удельный расход кокса", Alias = "Spec Сonsumption coke", Unit = "кг/т чугуна", MinValue = 450, MaxValue = 550 },
                new Parameter { ParameterId = 3, Name = "Текущие простои", Alias = "Current downtime", Unit = "%", MinValue = 0.9, MaxValue = 1.1 },
                new Parameter { ParameterId = 4, Name = "Тихий ход", Alias = "Quiet running", Unit = "%", MinValue = 1.35, MaxValue = 1.65 },
                new Parameter { ParameterId = 5, Name = "Доля окатышей в шихте", Alias = "The proportion of pellets", Unit = "%", MinValue = 25, MaxValue = 40 },
                new Parameter { ParameterId = 6, Name = "Доля агломерата в шихте", Alias = "Share of sinter", Unit = "%", MinValue = 60, MaxValue = 75 },
                new Parameter { ParameterId = 7, Name = "Содержание Fe в доменной шихте", Alias = "Fe content", Unit = "%", MinValue = 52, MaxValue = 63 },
                new Parameter { ParameterId = 8, Name = "Основность ЖРМ CaO/SiO2", Alias = "Basicity  CaO/Sio2", Unit = "-", MinValue = 0.91, MaxValue = 1.11 },
                new Parameter { ParameterId = 9, Name = "Основность ЖРМ (CaO+MgO)/(SiO2)", Alias = "Basicity  (CaO+MgO)/(SiO2)", Unit = "-", MinValue = 1.09, MaxValue = 1.33 },
                new Parameter { ParameterId = 10, Name = "Основность ЖРМ (CaO+MgO)/(SiO2+Al2O3)", Alias = "Basicity (CaO+MgO)/(SiO2+Al2O3)", Unit = "-", MinValue = 0.91, MaxValue = 1.11 },
                new Parameter { ParameterId = 11, Name = "Содержание золы в коксе", Alias = "Ash in coke", Unit = "%", MinValue = 11, MaxValue = 13 },
                new Parameter { ParameterId = 12, Name = "Содержание влаги в коксе", Alias = "Moisture  in coke", Unit = "%", MinValue = 1, MaxValue = 5 },
                new Parameter { ParameterId = 13, Name = "Содержание летучих в коксе", Alias = "Volatile  in coke", Unit = "%", MinValue = 10.8, MaxValue = 13.2 },
                new Parameter { ParameterId = 14, Name = "Прочность кокса по М25", Alias = "Coke  M25", Unit = "%", MinValue = 77.3, MaxValue = 94.6 },
                new Parameter { ParameterId = 15, Name = "Истираемость кокса по М10", Alias = "Abrasion to M10", Unit = "%", MinValue = 7.29, MaxValue = 8.91 },
                new Parameter { ParameterId = 16, Name = "CSR", Alias = "CSR", Unit = "%", MinValue = 34, MaxValue = 42 },
                new Parameter { ParameterId = 17, Name = "CRI", Alias = "CRI", Unit = "%", MinValue = 33, MaxValue = 41 },
                new Parameter { ParameterId = 18, Name = "Расход природного газа", Alias = "Gas consumption", Unit = "м3/т чугуна", MinValue = 100, MaxValue = 150 },
                new Parameter { ParameterId = 19, Name = "Содержание кислорода в дутье", Alias = "HotBlastO2", Unit = "%", MinValue = 21, MaxValue = 30 },
                new Parameter { ParameterId = 20, Name = "Температура горячего дутья", Alias = "TempHotBlast", Unit = "°С", MinValue = 900, MaxValue = 1300 },
                new Parameter { ParameterId = 21, Name = "Средняя температура колошникового газа", Alias = "TempKolGaz", Unit = "°С", MinValue = 80, MaxValue = 350 },
                new Parameter { ParameterId = 22, Name = "Степень использования СО", Alias = "Degree of CO", Unit = "%", MinValue = 39, MaxValue = 48 },
                new Parameter { ParameterId = 23, Name = "Степень использования Н2", Alias = "Degree of CO H2", Unit = "%", MinValue = 8.1, MaxValue = 9.9 },
                new Parameter { ParameterId = 24, Name = "Средняя температура периферийных газов, °С", Alias = "Temperature peripheral", Unit = "°С", MinValue = 648, MaxValue = 792 },
                new Parameter { ParameterId = 25, Name = "Окружная неравномерность температуры газа, °С", Alias = "Irregularity of gas temperature", Unit = "°С", MinValue = 117, MaxValue = 143 },
                new Parameter { ParameterId = 26, Name = "Неравномерность T колошникового газа по газоотводам, °С", Alias = "Irregularities  top gas", Unit = "°С", MinValue = 135, MaxValue = 165 },
                new Parameter { ParameterId = 27, Name = "Отношение Tcр периферийных термопар к Tcр колошникового газа, ед", Alias = "Ratio  Tcp of peripheral to Tcp of gas", Unit = "ед", MinValue = 0.27, MaxValue = 0.33 },
                new Parameter { ParameterId = 28, Name = "Температура холодильников 4 ряд", Alias = "Reftemperatures 4th row", Unit = "°С", MinValue = 270, MaxValue = 330 },
                new Parameter { ParameterId = 29, Name = "Теоретическая температура горения", Alias = "Theoretical  temperature", Unit = "°С", MinValue = 1900, MaxValue = 2100 },
                new Parameter { ParameterId = 30, Name = "Содержание Si в чугуне", Alias = "Si content in cast iron", Unit = "%", MinValue = 0.4, MaxValue = 1.0 },
                new Parameter { ParameterId = 31, Name = "Индекс низа", Alias = "Index of the bottom temperature ", Unit = "ед.", MinValue = 0.45, MaxValue = 0.55 },
                new Parameter { ParameterId = 32, Name = "Индекс верха", Alias = "Index of the top of the temperature ", Unit = "ед.", MinValue = 0.297, MaxValue = 0.363 },
                new Parameter { ParameterId = 33, Name = "Основность конечного шлака (CaO/(SiO2)", Alias = "Basicity_1", Unit = "-", MinValue = 0.99, MaxValue = 1.15 },
                new Parameter { ParameterId = 34, Name = "Основность конечного шлака (CaO+MgO)/(SiO2)", Alias = "Basicity_2", Unit = " -", MinValue = 1.125, MaxValue = 1.375 },
                new Parameter { ParameterId = 35, Name = "Основность конечного шлака (CaO+MgO)/(SiO2+Al2O3)", Alias = "Basicity_3", Unit = " -", MinValue = 0.9, MaxValue = 1.1 },
                new Parameter { ParameterId = 36, Name = "Коэффициент распределения серы", Alias = "Sulfur distribution coefficient", Unit = "доли", MinValue = 0.3, MaxValue = 0.5 },
                new Parameter { ParameterId = 37, Name = "Вязкость конечного шлака при 1400 °С", Alias = "Viscosity_1400", Unit = "Па∙с", MinValue = 0.405, MaxValue = 0.495 },
                new Parameter { ParameterId = 38, Name = "Вязкость конечного шлака при 1500 °С", Alias = "Viscosity_1500", Unit = "Па∙с", MinValue = 0.333, MaxValue = 0.407 },
                new Parameter { ParameterId = 39, Name = "Вязкость конечного шлака при T конечной", Alias = "Viscosity_Tfin", Unit = "Па∙с", MinValue = 0.207, MaxValue = 0.253 },
                new Parameter { ParameterId = 40, Name = "Градиенты вязкости шлака при 1400–1500 °С", Alias = "Viscosity gradients at 1400–1500 °C", Unit = "Па∙с/°С", MinValue = 0.018, MaxValue = 0.022 },
                new Parameter { ParameterId = 41, Name = "Градиенты вязкости шлака при 0,7–2,5 Па∙с", Alias = "Slag viscosity gradients at 0.7–2.5 Pa∙s", Unit = "Па∙с/°С", MinValue = 0.081, MaxValue = 0.099 },
                new Parameter { ParameterId = 42, Name = "Перепад давления «фурмы – колошник»", Alias = "P drop tuyere - top", Unit = "атм", MinValue = 1, MaxValue = 2 },
                new Parameter { ParameterId = 43, Name = "Степень уравновешивания шихты газовым потоком", Alias = "The degree  balancing by the gas flow", Unit = "%", MinValue = 40, MaxValue = 50 },
                new Parameter { ParameterId = 44, Name = "Расход холодного дутья", Alias = "Cold blast consumption", Unit = "м3/мин", MinValue = 2369.7, MaxValue = 2896.3 },
                new Parameter { ParameterId = 45, Name = "Давление горячего дутья, атм/(МПа)", Alias = "hot blast pressure", Unit = "атм/(МПа)", MinValue = 2.277, MaxValue = 2.783 },
                new Parameter { ParameterId = 46, Name = "Температура газа по радиусу колошника на периферии", Alias = "Gas T on the periphery", Unit = "°С", MinValue = 252, MaxValue = 308 },
                new Parameter { ParameterId = 47, Name = "Температура газа по радиусу колошника на оси", Alias = "Gas T  on the axis", Unit = "°С", MinValue = 247.5, MaxValue = 302.5 }

                );

            modelBuilder.Entity<Indicator>().HasData(
                 new Indicator {
                     IndicatorId = 1,
                     Name = "Технико-экономические показатели плавки",
                     Type = IndicatorType.Simple,
                     Alias = "TEIM",
                     LimitWarning = 0,
                     LimitDanger = 0,
                     Order = 1
                 },
                 new Indicator {
                     IndicatorId = 2,
                     Name = "Свойства сырья",
                     Type = IndicatorType.Simple,
                     Alias = "Properties of raw materials",
                     LimitWarning = 0,
                     LimitDanger = 0,
                     Order = 2
                 },
                 new Indicator {
                     IndicatorId = 3,
                     Name = "Дутьевой и газодинамический режим",
                     Type = IndicatorType.Simple,
                     Alias = "GazDinMode",
                     LimitWarning = 0,
                     LimitDanger = 0,
                     Order = 3
                 },
                 new Indicator {
                     IndicatorId = 4,
                     Name = "Тепловой режим",
                     Type = IndicatorType.Simple,
                     Alias = "ThermalMode",
                     LimitWarning = 0,
                     LimitDanger = 0,
                     Order = 4
                 },
                 new Indicator {
                     IndicatorId = 5,
                     Name = "Шлаковый режим",
                     Type = IndicatorType.Simple,
                     Alias = "SlagMode",
                     LimitWarning = 0,
                     LimitDanger = 0,
                     Order = 5
                 },
                 new Indicator {
                     IndicatorId = 6,
                     Name = "Интегральный показатель стабильности работы печи",
                     Type = IndicatorType.Complex,
                     Alias = "IISF",
                     LimitWarning = 0,
                     LimitDanger = 0,
                     Order = 6
                 },
                 new Indicator
                 {
                     IndicatorId = 7,
                     Name = "Интегральный показатель стабильности свойств сырья и работы печи",
                     Type = IndicatorType.Complex,
                     Alias = "",
                     LimitWarning = 0,
                     LimitDanger = 0,
                     Order = 7
                 });

            modelBuilder.Entity<ComplexCriterion>().HasData(
               // Интегральный показатель стабильности работы печи
               new ComplexCriterion { Id = 1, СalculatedIndicatorId = 6, IndicatorId = 3, Rang = 1 },
               new ComplexCriterion { Id = 2, СalculatedIndicatorId = 6, IndicatorId = 4, Rang = 1 },
               new ComplexCriterion { Id = 3, СalculatedIndicatorId = 6, IndicatorId = 5, Rang = 1 },
               // Интегральный показатель стабильности свойств сырья и работы печи
               new ComplexCriterion { Id = 4, СalculatedIndicatorId = 7, IndicatorId = 1, Rang = 1 },
               new ComplexCriterion { Id = 5, СalculatedIndicatorId = 7, IndicatorId = 2, Rang = 1 },
               new ComplexCriterion { Id = 6, СalculatedIndicatorId = 7, IndicatorId = 3, Rang = 1 },
               new ComplexCriterion { Id = 7, СalculatedIndicatorId = 7, IndicatorId = 4, Rang = 1 },
               new ComplexCriterion { Id = 8, СalculatedIndicatorId = 7, IndicatorId = 5, Rang = 1 }
               );

           modelBuilder.Entity<SimpleCriterion>().HasData(
                // Технико-экономический показатели плавки
                new SimpleCriterion { Id = 1, IndicatorId = 1, ParameterId = 1, Rang = 1 },
                new SimpleCriterion { Id = 2, IndicatorId = 1, ParameterId = 2, Rang = 1 },
                new SimpleCriterion { Id = 3, IndicatorId = 1, ParameterId = 3, Rang = 1 },
                new SimpleCriterion { Id = 4, IndicatorId = 1, ParameterId = 4, Rang = 1 },
                // Распознавания оценки стабильности свойств сырья
                new SimpleCriterion { Id = 5, IndicatorId = 2, ParameterId = 5, Rang = 1 },
                new SimpleCriterion { Id = 6, IndicatorId = 2, ParameterId = 6, Rang = 1 },
                new SimpleCriterion { Id = 7, IndicatorId = 2, ParameterId = 7, Rang = 1 },
                new SimpleCriterion { Id = 8, IndicatorId = 2, ParameterId = 8, Rang = 1 },
                new SimpleCriterion { Id = 9, IndicatorId = 2, ParameterId = 9, Rang = 1 },
                new SimpleCriterion { Id = 10, IndicatorId = 2, ParameterId = 10, Rang = 1 },
                new SimpleCriterion { Id = 11, IndicatorId = 2, ParameterId = 11, Rang = 1 },
                new SimpleCriterion { Id = 12, IndicatorId = 2, ParameterId = 12, Rang = 1 },
                new SimpleCriterion { Id = 13, IndicatorId = 2, ParameterId = 13, Rang = 1 },
                new SimpleCriterion { Id = 14, IndicatorId = 2, ParameterId = 14, Rang = 1 },
                new SimpleCriterion { Id = 15, IndicatorId = 2, ParameterId = 15, Rang = 1 },
                new SimpleCriterion { Id = 16, IndicatorId = 2, ParameterId = 16, Rang = 1 },
                new SimpleCriterion { Id = 17, IndicatorId = 2, ParameterId = 17, Rang = 1 },
                // Оценка стабильности дутьевого и газодинамического режима
                new SimpleCriterion { Id = 18, IndicatorId = 3, ParameterId = 44, Rang = 1 },
                new SimpleCriterion { Id = 19, IndicatorId = 3, ParameterId = 45, Rang = 1 },
                new SimpleCriterion { Id = 20, IndicatorId = 3, ParameterId = 18, Rang = 1 },
                new SimpleCriterion { Id = 21, IndicatorId = 3, ParameterId = 19, Rang = 1 },
                new SimpleCriterion { Id = 22, IndicatorId = 3, ParameterId = 20, Rang = 1 },
                new SimpleCriterion { Id = 23, IndicatorId = 3, ParameterId = 42, Rang = 1 },
                new SimpleCriterion { Id = 24, IndicatorId = 3, ParameterId = 43, Rang = 1 },
                new SimpleCriterion { Id = 25, IndicatorId = 3, ParameterId = 22, Rang = 1 },
                new SimpleCriterion { Id = 26, IndicatorId = 3, ParameterId = 25, Rang = 1 },
                new SimpleCriterion { Id = 27, IndicatorId = 3, ParameterId = 26, Rang = 1 },
                new SimpleCriterion { Id = 28, IndicatorId = 3, ParameterId = 46, Rang = 1 },
                new SimpleCriterion { Id = 29, IndicatorId = 3, ParameterId = 47, Rang = 1 },
                // Оценка стабильности теплового режима
                new SimpleCriterion { Id = 30, IndicatorId = 4, ParameterId = 30, Rang = 1 },
                new SimpleCriterion { Id = 31, IndicatorId = 4, ParameterId = 29, Rang = 1 },
                new SimpleCriterion { Id = 32, IndicatorId = 4, ParameterId = 31, Rang = 1 },
                new SimpleCriterion { Id = 33, IndicatorId = 4, ParameterId = 32, Rang = 1 },
                new SimpleCriterion { Id = 34, IndicatorId = 4, ParameterId = 21, Rang = 1 },
                new SimpleCriterion { Id = 35, IndicatorId = 4, ParameterId = 24, Rang = 1 },
                new SimpleCriterion { Id = 36, IndicatorId = 4, ParameterId = 28, Rang = 1 },
                // Оценка стабильности шлакового режима
                new SimpleCriterion { Id = 37, IndicatorId = 5, ParameterId = 33, Rang = 1 },
                new SimpleCriterion { Id = 38, IndicatorId = 5, ParameterId = 34, Rang = 1 },
                new SimpleCriterion { Id = 39, IndicatorId = 5, ParameterId = 35, Rang = 1 },
                new SimpleCriterion { Id = 40, IndicatorId = 5, ParameterId = 37, Rang = 1 },
                new SimpleCriterion { Id = 41, IndicatorId = 5, ParameterId = 38, Rang = 1 },
                new SimpleCriterion { Id = 42, IndicatorId = 5, ParameterId = 39, Rang = 1 },
                new SimpleCriterion { Id = 43, IndicatorId = 5, ParameterId = 40, Rang = 1 },
                new SimpleCriterion { Id = 44, IndicatorId = 5, ParameterId = 41, Rang = 1 },
                new SimpleCriterion { Id = 45, IndicatorId = 5, ParameterId = 36, Rang = 1 }
            );
        }

        //internal void Save()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
