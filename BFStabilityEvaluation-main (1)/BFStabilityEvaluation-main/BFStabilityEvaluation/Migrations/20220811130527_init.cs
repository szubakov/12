using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BFStabilityEvaluation.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Indicators",
                columns: table => new
                {
                    IndicatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Alias = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    LimitWarning = table.Column<double>(type: "float", nullable: false),
                    LimitDanger = table.Column<double>(type: "float", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicators", x => x.IndicatorId);
                });

            migrationBuilder.CreateTable(
                name: "Parameters",
                columns: table => new
                {
                    ParameterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Alias = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    MinValue = table.Column<double>(type: "float", nullable: false),
                    MaxValue = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameters", x => x.ParameterId);
                });

            migrationBuilder.CreateTable(
                name: "Pechi",
                columns: table => new
                {
                    NPech = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pechi", x => x.NPech);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Role = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ComplexCriterions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Npech = table.Column<int>(type: "int", nullable: true),
                    Rang = table.Column<double>(type: "float", nullable: false),
                    IndicatorId = table.Column<int>(type: "int", nullable: false),
                    СalculatedIndicatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplexCriterions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplexCriterions_Indicators_IndicatorId",
                        column: x => x.IndicatorId,
                        principalTable: "Indicators",
                        principalColumn: "IndicatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParameterValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Npech = table.Column<int>(type: "int", nullable: false),
                    TimeStampStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeStampEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false),
                    ParameterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParameterValues_Parameters_ParameterId",
                        column: x => x.ParameterId,
                        principalTable: "Parameters",
                        principalColumn: "ParameterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SimpleCriterions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Npech = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    AcceptableDelta = table.Column<double>(type: "float", nullable: false),
                    Rang = table.Column<double>(type: "float", nullable: false),
                    ActionType = table.Column<int>(type: "int", nullable: false),
                    IndicatorId = table.Column<int>(type: "int", nullable: false),
                    ParameterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleCriterions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SimpleCriterions_Indicators_IndicatorId",
                        column: x => x.IndicatorId,
                        principalTable: "Indicators",
                        principalColumn: "IndicatorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SimpleCriterions_Parameters_ParameterId",
                        column: x => x.ParameterId,
                        principalTable: "Parameters",
                        principalColumn: "ParameterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Indicators",
                columns: new[] { "IndicatorId", "Alias", "LimitDanger", "LimitWarning", "Name", "Order", "Type" },
                values: new object[,]
                {
                    { 1, "TEIM", 0.0, 0.0, "Технико-экономические показатели плавки", 1, 1 },
                    { 2, "Properties of raw materials", 0.0, 0.0, "Свойства сырья", 2, 1 },
                    { 3, "GazDinMode", 0.0, 0.0, "Дутьевой и газодинамический режим", 3, 1 },
                    { 4, "ThermalMode", 0.0, 0.0, "Тепловой режим", 4, 1 },
                    { 5, "SlagMode", 0.0, 0.0, "Шлаковый режим", 5, 1 },
                    { 6, "IISF", 0.0, 0.0, "Интегральный показатель стабильности работы печи", 6, 2 },
                    { 7, "", 0.0, 0.0, "Интегральный показатель стабильности свойств сырья и работы печи", 7, 2 }
                });

            migrationBuilder.InsertData(
                table: "Parameters",
                columns: new[] { "ParameterId", "Alias", "MaxValue", "MinValue", "Name", "Unit" },
                values: new object[,]
                {
                    { 33, "Basicity_1", 1.1499999999999999, 0.98999999999999999, "Основность конечного шлака (CaO/(SiO2)", "-" },
                    { 32, "Index of the top of the temperature ", 0.36299999999999999, 0.29699999999999999, "Индекс верха", "ед." },
                    { 31, "Index of the bottom temperature ", 0.55000000000000004, 0.45000000000000001, "Индекс низа", "ед." },
                    { 30, "Si content in cast iron", 1.0, 0.40000000000000002, "Содержание Si в чугуне", "%" },
                    { 27, "Ratio  Tcp of peripheral to Tcp of gas", 0.33000000000000002, 0.27000000000000002, "Отношение Tcр периферийных термопар к Tcр колошникового газа, ед", "ед" },
                    { 28, "Reftemperatures 4th row", 330.0, 270.0, "Температура холодильников 4 ряд", "°С" },
                    { 34, "Basicity_2", 1.375, 1.125, "Основность конечного шлака (CaO+MgO)/(SiO2)", " -" },
                    { 26, "Irregularities  top gas", 165.0, 135.0, "Неравномерность T колошникового газа по газоотводам, °С", "°С" },
                    { 29, "Theoretical  temperature", 2100.0, 1900.0, "Теоретическая температура горения", "°С" },
                    { 35, "Basicity_3", 1.1000000000000001, 0.90000000000000002, "Основность конечного шлака (CaO+MgO)/(SiO2+Al2O3)", " -" },
                    { 38, "Viscosity_1500", 0.40699999999999997, 0.33300000000000002, "Вязкость конечного шлака при 1500 °С", "Па∙с" },
                    { 37, "Viscosity_1400", 0.495, 0.40500000000000003, "Вязкость конечного шлака при 1400 °С", "Па∙с" },
                    { 25, "Irregularity of gas temperature", 143.0, 117.0, "Окружная неравномерность температуры газа, °С", "°С" },
                    { 39, "Viscosity_Tfin", 0.253, 0.20699999999999999, "Вязкость конечного шлака при T конечной", "Па∙с" },
                    { 40, "Viscosity gradients at 1400–1500 °C", 0.021999999999999999, 0.017999999999999999, "Градиенты вязкости шлака при 1400–1500 °С", "Па∙с/°С" },
                    { 41, "Slag viscosity gradients at 0.7–2.5 Pa∙s", 0.099000000000000005, 0.081000000000000003, "Градиенты вязкости шлака при 0,7–2,5 Па∙с", "Па∙с/°С" },
                    { 42, "P drop tuyere - top", 2.0, 1.0, "Перепад давления «фурмы – колошник»", "атм" },
                    { 43, "The degree  balancing by the gas flow", 50.0, 40.0, "Степень уравновешивания шихты газовым потоком", "%" },
                    { 44, "Cold blast consumption", 2896.3000000000002, 2369.6999999999998, "Расход холодного дутья", "м3/мин" },
                    { 45, "hot blast pressure", 2.7829999999999999, 2.2770000000000001, "Давление горячего дутья, атм/(МПа)", "атм/(МПа)" },
                    { 36, "Sulfur distribution coefficient", 0.5, 0.29999999999999999, "Коэффициент распределения серы", "доли" },
                    { 24, "Temperature peripheral", 792.0, 648.0, "Средняя температура периферийных газов, °С", "°С" },
                    { 20, "TempHotBlast", 1300.0, 900.0, "Температура горячего дутья", "°С" },
                    { 22, "Degree of CO", 48.0, 39.0, "Степень использования СО", "%" },
                    { 1, "SpecPerformance", 2.6000000000000001, 2.1299999999999999, "Удельная производительность", "т/м3" },
                    { 2, "Spec Сonsumption coke", 550.0, 450.0, "Удельный расход кокса", "кг/т чугуна" },
                    { 3, "Current downtime", 1.1000000000000001, 0.90000000000000002, "Текущие простои", "%" },
                    { 4, "Quiet running", 1.6499999999999999, 1.3500000000000001, "Тихий ход", "%" },
                    { 5, "The proportion of pellets", 40.0, 25.0, "Доля окатышей в шихте", "%" },
                    { 6, "Share of sinter", 75.0, 60.0, "Доля агломерата в шихте", "%" },
                    { 7, "Fe content", 63.0, 52.0, "Содержание Fe в доменной шихте", "%" },
                    { 8, "Basicity  CaO/Sio2", 1.1100000000000001, 0.91000000000000003, "Основность ЖРМ CaO/SiO2", "-" },
                    { 9, "Basicity  (CaO+MgO)/(SiO2)", 1.3300000000000001, 1.0900000000000001, "Основность ЖРМ (CaO+MgO)/(SiO2)", "-" },
                    { 10, "Basicity (CaO+MgO)/(SiO2+Al2O3)", 1.1100000000000001, 0.91000000000000003, "Основность ЖРМ (CaO+MgO)/(SiO2+Al2O3)", "-" },
                    { 11, "Ash in coke", 13.0, 11.0, "Содержание золы в коксе", "%" }
                });

            migrationBuilder.InsertData(
                table: "Parameters",
                columns: new[] { "ParameterId", "Alias", "MaxValue", "MinValue", "Name", "Unit" },
                values: new object[,]
                {
                    { 12, "Moisture  in coke", 5.0, 1.0, "Содержание влаги в коксе", "%" },
                    { 13, "Volatile  in coke", 13.199999999999999, 10.800000000000001, "Содержание летучих в коксе", "%" },
                    { 14, "Coke  M25", 94.599999999999994, 77.299999999999997, "Прочность кокса по М25", "%" },
                    { 15, "Abrasion to M10", 8.9100000000000001, 7.29, "Истираемость кокса по М10", "%" },
                    { 16, "CSR", 42.0, 34.0, "CSR", "%" },
                    { 17, "CRI", 41.0, 33.0, "CRI", "%" },
                    { 18, "Gas consumption", 150.0, 100.0, "Расход природного газа", "м3/т чугуна" },
                    { 19, "HotBlastO2", 30.0, 21.0, "Содержание кислорода в дутье", "%" },
                    { 46, "Gas T on the periphery", 308.0, 252.0, "Температура газа по радиусу колошника на периферии", "°С" },
                    { 21, "TempKolGaz", 350.0, 80.0, "Средняя температура колошникового газа", "°С" },
                    { 23, "Degree of CO H2", 9.9000000000000004, 8.0999999999999996, "Степень использования Н2", "%" },
                    { 47, "Gas T  on the axis", 302.5, 247.5, "Температура газа по радиусу колошника на оси", "°С" }
                });

            migrationBuilder.InsertData(
                table: "ComplexCriterions",
                columns: new[] { "Id", "IndicatorId", "Npech", "Rang", "СalculatedIndicatorId" },
                values: new object[,]
                {
                    { 4, 1, null, 1.0, 7 },
                    { 5, 2, null, 1.0, 7 },
                    { 1, 3, null, 1.0, 6 },
                    { 6, 3, null, 1.0, 7 },
                    { 2, 4, null, 1.0, 6 },
                    { 7, 4, null, 1.0, 7 },
                    { 3, 5, null, 1.0, 6 },
                    { 8, 5, null, 1.0, 7 }
                });

            migrationBuilder.InsertData(
                table: "SimpleCriterions",
                columns: new[] { "Id", "AcceptableDelta", "ActionType", "IndicatorId", "Name", "Npech", "ParameterId", "Rang", "Unit" },
                values: new object[,]
                {
                    { 37, 0.0, 0, 5, null, null, 33, 1.0, null },
                    { 33, 0.0, 0, 4, null, null, 32, 1.0, null },
                    { 32, 0.0, 0, 4, null, null, 31, 1.0, null },
                    { 27, 0.0, 0, 3, null, null, 26, 1.0, null },
                    { 31, 0.0, 0, 4, null, null, 29, 1.0, null },
                    { 36, 0.0, 0, 4, null, null, 28, 1.0, null },
                    { 38, 0.0, 0, 5, null, null, 34, 1.0, null },
                    { 30, 0.0, 0, 4, null, null, 30, 1.0, null },
                    { 39, 0.0, 0, 5, null, null, 35, 1.0, null },
                    { 42, 0.0, 0, 5, null, null, 39, 1.0, null },
                    { 40, 0.0, 0, 5, null, null, 37, 1.0, null },
                    { 41, 0.0, 0, 5, null, null, 38, 1.0, null },
                    { 26, 0.0, 0, 3, null, null, 25, 1.0, null },
                    { 43, 0.0, 0, 5, null, null, 40, 1.0, null },
                    { 44, 0.0, 0, 5, null, null, 41, 1.0, null },
                    { 23, 0.0, 0, 3, null, null, 42, 1.0, null },
                    { 24, 0.0, 0, 3, null, null, 43, 1.0, null },
                    { 18, 0.0, 0, 3, null, null, 44, 1.0, null },
                    { 19, 0.0, 0, 3, null, null, 45, 1.0, null },
                    { 45, 0.0, 0, 5, null, null, 36, 1.0, null },
                    { 35, 0.0, 0, 4, null, null, 24, 1.0, null },
                    { 21, 0.0, 0, 3, null, null, 19, 1.0, null },
                    { 34, 0.0, 0, 4, null, null, 21, 1.0, null },
                    { 1, 0.0, 0, 1, null, null, 1, 1.0, null },
                    { 2, 0.0, 0, 1, null, null, 2, 1.0, null },
                    { 3, 0.0, 0, 1, null, null, 3, 1.0, null },
                    { 4, 0.0, 0, 1, null, null, 4, 1.0, null },
                    { 5, 0.0, 0, 2, null, null, 5, 1.0, null },
                    { 6, 0.0, 0, 2, null, null, 6, 1.0, null },
                    { 7, 0.0, 0, 2, null, null, 7, 1.0, null },
                    { 8, 0.0, 0, 2, null, null, 8, 1.0, null },
                    { 9, 0.0, 0, 2, null, null, 9, 1.0, null },
                    { 25, 0.0, 0, 3, null, null, 22, 1.0, null },
                    { 10, 0.0, 0, 2, null, null, 10, 1.0, null }
                });

            migrationBuilder.InsertData(
                table: "SimpleCriterions",
                columns: new[] { "Id", "AcceptableDelta", "ActionType", "IndicatorId", "Name", "Npech", "ParameterId", "Rang", "Unit" },
                values: new object[,]
                {
                    { 12, 0.0, 0, 2, null, null, 12, 1.0, null },
                    { 13, 0.0, 0, 2, null, null, 13, 1.0, null },
                    { 14, 0.0, 0, 2, null, null, 14, 1.0, null },
                    { 15, 0.0, 0, 2, null, null, 15, 1.0, null },
                    { 16, 0.0, 0, 2, null, null, 16, 1.0, null },
                    { 17, 0.0, 0, 2, null, null, 17, 1.0, null },
                    { 20, 0.0, 0, 3, null, null, 18, 1.0, null },
                    { 28, 0.0, 0, 3, null, null, 46, 1.0, null },
                    { 22, 0.0, 0, 3, null, null, 20, 1.0, null },
                    { 11, 0.0, 0, 2, null, null, 11, 1.0, null },
                    { 29, 0.0, 0, 3, null, null, 47, 1.0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComplexCriterions_IndicatorId",
                table: "ComplexCriterions",
                column: "IndicatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterValues_ParameterId",
                table: "ParameterValues",
                column: "ParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_SimpleCriterions_IndicatorId",
                table: "SimpleCriterions",
                column: "IndicatorId");

            migrationBuilder.CreateIndex(
                name: "IX_SimpleCriterions_ParameterId",
                table: "SimpleCriterions",
                column: "ParameterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComplexCriterions");

            migrationBuilder.DropTable(
                name: "ParameterValues");

            migrationBuilder.DropTable(
                name: "Pechi");

            migrationBuilder.DropTable(
                name: "SimpleCriterions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Indicators");

            migrationBuilder.DropTable(
                name: "Parameters");
        }
    }
}
