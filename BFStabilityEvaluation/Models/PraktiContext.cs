using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BFStabilityEvaluation.Models
{
    public partial class PraktiContext : DbContext
    {
        public PraktiContext(DbContextOptions<PraktiContext> options)
            : base(options)
        {
        }

        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<ParameterValue> ParameterValues { get; set; }
        public DbSet<StabilitySign> StabilitySigns { get; set; }
        public DbSet<StabilitySignKriterium> StabilitySignKriteria { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParameterValue>().HasKey(u => new { u.Npech, u.ParameterId, u.Period });
            modelBuilder.Entity<Parameter>().HasData(

                new Parameter { ParameterId = 1, Name = "Удельная производительность", Alias = "SpecPerformance", Unit = "т/м3", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 2, Name = "Удельный расход кокса", Alias = "Spec Сonsumption coke", Unit = "кг/т чугуна", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 3, Name = "Текущие простои", Alias = "Current downtime", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 4, Name = "Тихий ход", Alias = "Quiet running", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 5, Name = "Доля окатышей в шихте", Alias = "The proportion of pellets", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 6, Name = "Доля агломерата в шихте", Alias = "Share of sinter", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 7, Name = "Содержание Fe в доменной шихте", Alias = "Fe content", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 8, Name = "Основность ЖРМ CaO/Sio2", Alias = "Basicity  CaO/Sio2", Unit = "-", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 9, Name = "Основность ЖРМ (CaO+MgO)/(SiO2)", Alias = "Basicity  (CaO+MgO)/(SiO2)", Unit = "-", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 10, Name = "Основность ЖРМ (CaO+MgO)/(SiO2+Al2O3)", Alias = "Basicity (CaO+MgO)/(SiO2+Al2O3)", Unit = "-", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 11, Name = "Содержание золы в коксе", Alias = "Ash in coke", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 12, Name = "Содержание влаги в коксе", Alias = "Moisture  in coke", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 13, Name = "Содержание летучих в коксе", Alias = "Volatile  in coke", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 14, Name = "Прочность кокса по М25", Alias = "Coke  M25", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 15, Name = "Истираемость кокса по М10", Alias = "Abrasion to M10", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 16, Name = "CSR", Alias = "CSR", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 17, Name = "CRI", Alias = "CRI", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 18, Name = "Расход природного газа", Alias = "Gas consumption", Unit = "м3/т чугуна", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 19, Name = "Содержание кислорода в дутье", Alias = "HotBlastO2", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 20, Name = "Температура горячего дутья", Alias = "TempHotBlast", Unit = "°С", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 21, Name = "Средняя температура колошникового газа", Alias = "TempKolGaz", Unit = "°С", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 22, Name = "Степень использования СО", Alias = "Degree of CO", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 23, Name = "Степень использования Н2", Alias = "Degree of CO H2", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 24, Name = "Средняя температура периферийных газов", Alias = "Temperature peripheral", Unit = "°С", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 25, Name = "Окружная неравномерность температуры газа", Alias = "Irregularity of gas temperature", Unit = "°С", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 26, Name = "Неравномерность T колошникового газа по газоотводам", Alias = "Irregularities  top gas", Unit = "°С", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 27, Name = "Отношение Tcр периферийных термопар к Tcр колошникового газа", Alias = "Ratio  Tcp of peripheral to Tcp of gas", Unit = "ед", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 28, Name = "Температура холодильников 4 ряд", Alias = "Reftemperatures 4th row", Unit = "°С", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 29, Name = "Теоретическая температура горения", Alias = "Theoretical  temperature", Unit = "°С", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 30, Name = "Содержание в чугуне Si", Alias = "Si content in cast iron", Unit = "%", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 31, Name = "Индекс низа температурного поля", Alias = "Index of the bottom temperature ", Unit = "доли", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 32, Name = "Индекс верха температурного поля", Alias = "Index of the top of the temperature ", Unit = "доли", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 33, Name = "Основность конечного шлака (CaO/(SiO2)", Alias = "Basicity_1", Unit = "-", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 34, Name = "Основность конечного шлака (CaO+MgO)/(SiO2)", Alias = "Basicity_2", Unit = " -", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 35, Name = "Основность конечного шлака (CaO+MgO)/(SiO2+Al2O3)", Alias = "Basicity_3", Unit = " -", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 36, Name = "Коэффициент распределения серы", Alias = "Sulfur distribution coefficient", Unit = "°доли", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 37, Name = "Вязкость конечного шлака при 1400 °С", Alias = "Viscosity_1400", Unit = "Па∙с", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 38, Name = "Вязкость конечного шлака при 1500 °С", Alias = "Viscosity_1500", Unit = "Па∙с", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 39, Name = "Вязкость конечного шлака при T конечной", Alias = "Viscosity_Tfin", Unit = "Па∙с", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 40, Name = "Градиенты вязкости шлака при 1400–1500 °С ", Alias = "Viscosity gradients at 1400–1500 °C", Unit = "Па∙с/°С", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 41, Name = "Градиенты вязкости шлака при 0,7–2,5 Па∙с", Alias = "Slag viscosity gradients at 0.7–2.5 Pa∙s", Unit = "Па∙с/°С", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 42, Name = "Перепад давления «фурмы – колошник»", Alias = "P drop tuyere - top", Unit = "атм", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 43, Name = "Степень уравновешивания шихты газовым потоком", Alias = "The degree  balancing by the gas flow", Unit = "%", MinValue = 0, MaxValue = 0 },
                 new Parameter { ParameterId = 44, Name = "Расход холодного дутья»", Alias = "Cold blast consumption", Unit = "м3/мин", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 45, Name = "Давление горячего дутья", Alias = "hot blast pressure", Unit = "ати/(МПа)", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 46, Name = "Температура газа по радиусу колошника на периферии»", Alias = "Gas T on the periphery", Unit = "°С", MinValue = 0, MaxValue = 0 },
                new Parameter { ParameterId = 47, Name = "Температура газа по радиусу колошника на оси", Alias = "Gas T  on the axis", Unit = "°С", MinValue = 0, MaxValue = 0 }

                );

            modelBuilder.Entity<StabilitySign>().HasData(

                 new StabilitySign { StabSignId = 1, Name = "Технико-экономический показатели плавки", Alias = "TEIM", LimitWarning = 0, LimitDanger = 0 },
                 new StabilitySign { StabSignId = 2, Name = "Свойства сырья (железорудных материалов, кокса).", Alias = "Properties of raw materials", LimitWarning = 0, LimitDanger = 0 },
                 new StabilitySign { StabSignId = 3, Name = "Показатель дутьевого и газодинамического режима", Alias = "IBGDM", LimitWarning = 0, LimitDanger = 0 },
                 new StabilitySign { StabSignId = 4, Name = "Показатель теплового режима", Alias = "Indicator of the thermal regime", LimitWarning = 0, LimitDanger = 0 },
                 new StabilitySign { StabSignId = 5, Name = "Показатель шлакового режима", Alias = "Indicator of the slag regime", LimitWarning = 0, LimitDanger = 0 },
                 new StabilitySign { StabSignId = 6, Name = "Интегральный показатель стабильности работы печи ", Alias = "IISF", LimitWarning = 0, LimitDanger = 0 }

                );

            modelBuilder.Entity<StabilitySignKriterium>().HasData(
                // Технико-экономический показатели плавки
                new StabilitySignKriterium { Id = 1, StabSignId = 1, ParameterId = 1 },
                new StabilitySignKriterium { Id = 2, StabSignId = 1, ParameterId = 2 },
                new StabilitySignKriterium { Id = 3, StabSignId = 1, ParameterId = 3 },
                new StabilitySignKriterium { Id = 4, StabSignId = 1, ParameterId = 4 },
                // Распознавания оценки стабильности свойств сырья
                new StabilitySignKriterium { Id = 5, StabSignId = 2, ParameterId = 5 },
                new StabilitySignKriterium { Id = 6, StabSignId = 2, ParameterId = 6 },
                new StabilitySignKriterium { Id = 7, StabSignId = 2, ParameterId = 7 },
                new StabilitySignKriterium { Id = 8, StabSignId = 2, ParameterId = 8 },
                new StabilitySignKriterium { Id = 9, StabSignId = 2, ParameterId = 9 },
                new StabilitySignKriterium { Id = 10, StabSignId = 2, ParameterId = 10 },
                new StabilitySignKriterium { Id = 11, StabSignId = 2, ParameterId = 11 },
                new StabilitySignKriterium { Id = 12, StabSignId = 2, ParameterId = 12 },
                new StabilitySignKriterium { Id = 13, StabSignId = 2, ParameterId = 13 },
                new StabilitySignKriterium { Id = 14, StabSignId = 2, ParameterId = 14 },
                new StabilitySignKriterium { Id = 15, StabSignId = 2, ParameterId = 15 },
                new StabilitySignKriterium { Id = 16, StabSignId = 2, ParameterId = 16 },
                new StabilitySignKriterium { Id = 17, StabSignId = 2, ParameterId = 17 },
                // Оценка стабильности дутьевого и газодинамического режима
                 new StabilitySignKriterium { Id = 18, StabSignId = 3, ParameterId = 44 },
                new StabilitySignKriterium { Id = 19, StabSignId = 3, ParameterId = 45 },
                new StabilitySignKriterium { Id = 20, StabSignId = 3, ParameterId = 18 },
                new StabilitySignKriterium { Id = 21, StabSignId = 3, ParameterId = 19 },
                new StabilitySignKriterium { Id = 22, StabSignId = 3, ParameterId = 20 },
                new StabilitySignKriterium { Id = 23, StabSignId = 3, ParameterId = 42 },
                new StabilitySignKriterium { Id = 24, StabSignId = 3, ParameterId = 43 },
                new StabilitySignKriterium { Id = 25, StabSignId = 3, ParameterId = 22 },
                new StabilitySignKriterium { Id = 26, StabSignId = 3, ParameterId = 25 },
                new StabilitySignKriterium { Id = 27, StabSignId = 3, ParameterId = 26 },
                new StabilitySignKriterium { Id = 28, StabSignId = 3, ParameterId = 46 },
                new StabilitySignKriterium { Id = 29, StabSignId = 3, ParameterId = 47 },

                 // Оценка стабильности теплового режима
                 new StabilitySignKriterium { Id = 30, StabSignId = 4, ParameterId = 30 },
                new StabilitySignKriterium { Id = 31, StabSignId = 4, ParameterId = 29 },
                new StabilitySignKriterium { Id = 32, StabSignId = 4, ParameterId = 31 },
                new StabilitySignKriterium { Id = 33, StabSignId = 4, ParameterId = 32 },
                new StabilitySignKriterium { Id = 34, StabSignId = 4, ParameterId = 21 },
                new StabilitySignKriterium { Id = 35, StabSignId = 4, ParameterId = 24 },
                new StabilitySignKriterium { Id = 36, StabSignId = 4, ParameterId = 28 },
                // Оценка стабильности шлакового режима
                new StabilitySignKriterium { Id = 37, StabSignId = 5, ParameterId = 33 },
                new StabilitySignKriterium { Id = 38, StabSignId = 5, ParameterId = 34 },
                new StabilitySignKriterium { Id = 39, StabSignId = 5, ParameterId = 35 },
                new StabilitySignKriterium { Id = 40, StabSignId = 5, ParameterId = 37 },
                new StabilitySignKriterium { Id = 41, StabSignId = 5, ParameterId = 38 },
                new StabilitySignKriterium { Id = 42, StabSignId = 5, ParameterId = 39 },
                new StabilitySignKriterium { Id = 43, StabSignId = 5, ParameterId = 40 },
                new StabilitySignKriterium { Id = 44, StabSignId = 5, ParameterId = 41 },
                new StabilitySignKriterium { Id = 45, StabSignId = 5, ParameterId = 36 }
            );
        }

        internal void Save()
        {
            throw new NotImplementedException();
        }
    }
}
