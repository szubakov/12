using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BFStabilityEvaluation.Migrations
{
    public partial class GEN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "StabilitySigns",
                columns: table => new
                {
                    StabSignId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Alias = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LimitWarning = table.Column<double>(type: "float", nullable: false),
                    LimitDanger = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StabilitySigns", x => x.StabSignId);
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
                name: "StabilitySignKriteria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Npech = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    AcceptableDelta = table.Column<double>(type: "float", nullable: false),
                    Rang = table.Column<double>(type: "float", nullable: false),
                    ActionType = table.Column<double>(type: "float", nullable: false),
                    StabSignId = table.Column<int>(type: "int", nullable: false),
                    ParameterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StabilitySignKriteria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StabilitySignKriteria_Parameters_ParameterId",
                        column: x => x.ParameterId,
                        principalTable: "Parameters",
                        principalColumn: "ParameterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StabilitySignKriteria_StabilitySigns_StabSignId",
                        column: x => x.StabSignId,
                        principalTable: "StabilitySigns",
                        principalColumn: "StabSignId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Parameters",
                columns: new[] { "ParameterId", "Alias", "MaxValue", "MinValue", "Name", "Unit" },
                values: new object[,]
                {
                    { 1, "SpecPerformance", 0.0, 0.0, "Удельная производительность", "т/м3" },
                    { 28, "Reftemperatures 4th row", 0.0, 0.0, "Температура холодильников 4 ряд", "°С" },
                    { 29, "Theoretical  temperature", 0.0, 0.0, "Теоретическая температура горения", "°С" },
                    { 30, "Si content in cast iron", 0.0, 0.0, "Содержание в чугуне Si", "%" },
                    { 31, "Index of the bottom temperature ", 0.0, 0.0, "Индекс низа температурного поля", "доли" },
                    { 32, "Index of the top of the temperature ", 0.0, 0.0, "Индекс верха температурного поля", "доли" },
                    { 33, "Basicity_1", 0.0, 0.0, "Основность конечного шлака (CaO/(SiO2)", "-" },
                    { 34, "Basicity_2", 0.0, 0.0, "Основность конечного шлака (CaO+MgO)/(SiO2)", " -" },
                    { 35, "Basicity_3", 0.0, 0.0, "Основность конечного шлака (CaO+MgO)/(SiO2+Al2O3)", " -" },
                    { 36, "Sulfur distribution coefficient", 0.0, 0.0, "Коэффициент распределения серы", "°доли" },
                    { 26, "Irregularities  top gas", 0.0, 0.0, "Неравномерность T колошникового газа по газоотводам", "°С" },
                    { 37, "Viscosity_1400", 0.0, 0.0, "Вязкость конечного шлака при 1400 °С", "Па∙с" },
                    { 39, "Viscosity_Tfin", 0.0, 0.0, "Вязкость конечного шлака при T конечной", "Па∙с" },
                    { 40, "Viscosity gradients at 1400–1500 °C", 0.0, 0.0, "Градиенты вязкости шлака при 1400–1500 °С ", "Па∙с/°С" },
                    { 41, "Slag viscosity gradients at 0.7–2.5 Pa∙s", 0.0, 0.0, "Градиенты вязкости шлака при 0,7–2,5 Па∙с", "Па∙с/°С" },
                    { 42, "P drop tuyere - top", 0.0, 0.0, "Перепад давления «фурмы – колошник»", "атм" },
                    { 43, "The degree  balancing by the gas flow", 0.0, 0.0, "Степень уравновешивания шихты газовым потоком", "%" },
                    { 44, "Cold blast consumption", 0.0, 0.0, "Расход холодного дутья»", "м3/мин" },
                    { 45, "hot blast pressure", 0.0, 0.0, "Давление горячего дутья", "ати/(МПа)" },
                    { 46, "Gas T on the periphery", 0.0, 0.0, "Температура газа по радиусу колошника на периферии»", "°С" },
                    { 47, "Gas T  on the axis", 0.0, 0.0, "Температура газа по радиусу колошника на оси", "°С" },
                    { 38, "Viscosity_1500", 0.0, 0.0, "Вязкость конечного шлака при 1500 °С", "Па∙с" },
                    { 25, "Irregularity of gas temperature", 0.0, 0.0, "Окружная неравномерность температуры газа", "°С" },
                    { 27, "Ratio  Tcp of peripheral to Tcp of gas", 0.0, 0.0, "Отношение Tcр периферийных термопар к Tcр колошникового газа", "ед" },
                    { 23, "Degree of CO H2", 0.0, 0.0, "Степень использования Н2", "%" },
                    { 2, "Spec Сonsumption coke", 0.0, 0.0, "Удельный расход кокса", "кг/т чугуна" },
                    { 3, "Current downtime", 0.0, 0.0, "Текущие простои", "%" },
                    { 4, "Quiet running", 0.0, 0.0, "Тихий ход", "%" },
                    { 5, "The proportion of pellets", 0.0, 0.0, "Доля окатышей в шихте", "%" },
                    { 6, "Share of sinter", 0.0, 0.0, "Доля агломерата в шихте", "%" },
                    { 7, "Fe content", 0.0, 0.0, "Содержание Fe в доменной шихте", "%" },
                    { 8, "Basicity  CaO/Sio2", 0.0, 0.0, "Основность ЖРМ CaO/Sio2", "-" },
                    { 9, "Basicity  (CaO+MgO)/(SiO2)", 0.0, 0.0, "Основность ЖРМ (CaO+MgO)/(SiO2)", "-" },
                    { 24, "Temperature peripheral", 0.0, 0.0, "Средняя температура периферийных газов", "°С" },
                    { 11, "Ash in coke", 0.0, 0.0, "Содержание золы в коксе", "%" },
                    { 12, "Moisture  in coke", 0.0, 0.0, "Содержание влаги в коксе", "%" },
                    { 10, "Basicity (CaO+MgO)/(SiO2+Al2O3)", 0.0, 0.0, "Основность ЖРМ (CaO+MgO)/(SiO2+Al2O3)", "-" },
                    { 14, "Coke  M25", 0.0, 0.0, "Прочность кокса по М25", "%" },
                    { 15, "Abrasion to M10", 0.0, 0.0, "Истираемость кокса по М10", "%" },
                    { 16, "CSR", 0.0, 0.0, "CSR", "%" },
                    { 17, "CRI", 0.0, 0.0, "CRI", "%" },
                    { 18, "Gas consumption", 0.0, 0.0, "Расход природного газа", "м3/т чугуна" }
                });

            migrationBuilder.InsertData(
                table: "Parameters",
                columns: new[] { "ParameterId", "Alias", "MaxValue", "MinValue", "Name", "Unit" },
                values: new object[,]
                {
                    { 19, "HotBlastO2", 0.0, 0.0, "Содержание кислорода в дутье", "%" },
                    { 20, "TempHotBlast", 0.0, 0.0, "Температура горячего дутья", "°С" },
                    { 21, "TempKolGaz", 0.0, 0.0, "Средняя температура колошникового газа", "°С" },
                    { 22, "Degree of CO", 0.0, 0.0, "Степень использования СО", "%" },
                    { 13, "Volatile  in coke", 0.0, 0.0, "Содержание летучих в коксе", "%" }
                });

            migrationBuilder.InsertData(
                table: "StabilitySigns",
                columns: new[] { "StabSignId", "Alias", "LimitDanger", "LimitWarning", "Name" },
                values: new object[,]
                {
                    { 5, "Indicator of the slag regime", 0.0, 0.0, "Показатель шлакового режима" },
                    { 1, "TEIM", 0.0, 0.0, "Технико-экономический показатели плавки" },
                    { 2, "Properties of raw materials", 0.0, 0.0, "Свойства сырья (железорудных материалов, кокса)." },
                    { 3, "IBGDM", 0.0, 0.0, "Показатель дутьевого и газодинамического режима" },
                    { 4, "Indicator of the thermal regime", 0.0, 0.0, "Показатель теплового режима" },
                    { 6, "IISF", 0.0, 0.0, "Интегральный показатель стабильности работы печи " }
                });

            migrationBuilder.InsertData(
                table: "StabilitySignKriteria",
                columns: new[] { "Id", "AcceptableDelta", "ActionType", "Name", "Npech", "ParameterId", "Rang", "StabSignId", "Unit" },
                values: new object[,]
                {
                    { 1, 0.0, 0.0, null, null, 1, 0.0, 1, null },
                    { 25, 0.0, 0.0, null, null, 22, 0.0, 3, null },
                    { 26, 0.0, 0.0, null, null, 25, 0.0, 3, null },
                    { 27, 0.0, 0.0, null, null, 26, 0.0, 3, null },
                    { 28, 0.0, 0.0, null, null, 46, 0.0, 3, null },
                    { 29, 0.0, 0.0, null, null, 47, 0.0, 3, null },
                    { 30, 0.0, 0.0, null, null, 30, 0.0, 4, null },
                    { 31, 0.0, 0.0, null, null, 29, 0.0, 4, null },
                    { 32, 0.0, 0.0, null, null, 31, 0.0, 4, null },
                    { 33, 0.0, 0.0, null, null, 32, 0.0, 4, null },
                    { 34, 0.0, 0.0, null, null, 21, 0.0, 4, null },
                    { 35, 0.0, 0.0, null, null, 24, 0.0, 4, null },
                    { 36, 0.0, 0.0, null, null, 28, 0.0, 4, null },
                    { 37, 0.0, 0.0, null, null, 33, 0.0, 5, null },
                    { 38, 0.0, 0.0, null, null, 34, 0.0, 5, null },
                    { 39, 0.0, 0.0, null, null, 35, 0.0, 5, null },
                    { 40, 0.0, 0.0, null, null, 37, 0.0, 5, null },
                    { 41, 0.0, 0.0, null, null, 38, 0.0, 5, null },
                    { 42, 0.0, 0.0, null, null, 39, 0.0, 5, null },
                    { 43, 0.0, 0.0, null, null, 40, 0.0, 5, null },
                    { 24, 0.0, 0.0, null, null, 43, 0.0, 3, null },
                    { 44, 0.0, 0.0, null, null, 41, 0.0, 5, null },
                    { 23, 0.0, 0.0, null, null, 42, 0.0, 3, null },
                    { 21, 0.0, 0.0, null, null, 19, 0.0, 3, null },
                    { 2, 0.0, 0.0, null, null, 2, 0.0, 1, null },
                    { 3, 0.0, 0.0, null, null, 3, 0.0, 1, null },
                    { 4, 0.0, 0.0, null, null, 4, 0.0, 1, null },
                    { 5, 0.0, 0.0, null, null, 5, 0.0, 2, null },
                    { 6, 0.0, 0.0, null, null, 6, 0.0, 2, null },
                    { 7, 0.0, 0.0, null, null, 7, 0.0, 2, null },
                    { 8, 0.0, 0.0, null, null, 8, 0.0, 2, null },
                    { 9, 0.0, 0.0, null, null, 9, 0.0, 2, null },
                    { 10, 0.0, 0.0, null, null, 10, 0.0, 2, null },
                    { 11, 0.0, 0.0, null, null, 11, 0.0, 2, null },
                    { 12, 0.0, 0.0, null, null, 12, 0.0, 2, null },
                    { 13, 0.0, 0.0, null, null, 13, 0.0, 2, null },
                    { 14, 0.0, 0.0, null, null, 14, 0.0, 2, null },
                    { 15, 0.0, 0.0, null, null, 15, 0.0, 2, null },
                    { 16, 0.0, 0.0, null, null, 16, 0.0, 2, null },
                    { 17, 0.0, 0.0, null, null, 17, 0.0, 2, null },
                    { 18, 0.0, 0.0, null, null, 44, 0.0, 3, null },
                    { 19, 0.0, 0.0, null, null, 45, 0.0, 3, null }
                });

            migrationBuilder.InsertData(
                table: "StabilitySignKriteria",
                columns: new[] { "Id", "AcceptableDelta", "ActionType", "Name", "Npech", "ParameterId", "Rang", "StabSignId", "Unit" },
                values: new object[] { 20, 0.0, 0.0, null, null, 18, 0.0, 3, null });

            migrationBuilder.InsertData(
                table: "StabilitySignKriteria",
                columns: new[] { "Id", "AcceptableDelta", "ActionType", "Name", "Npech", "ParameterId", "Rang", "StabSignId", "Unit" },
                values: new object[] { 22, 0.0, 0.0, null, null, 20, 0.0, 3, null });

            migrationBuilder.InsertData(
                table: "StabilitySignKriteria",
                columns: new[] { "Id", "AcceptableDelta", "ActionType", "Name", "Npech", "ParameterId", "Rang", "StabSignId", "Unit" },
                values: new object[] { 45, 0.0, 0.0, null, null, 36, 0.0, 5, null });

            migrationBuilder.CreateIndex(
                name: "IX_ParameterValues_ParameterId",
                table: "ParameterValues",
                column: "ParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_StabilitySignKriteria_ParameterId",
                table: "StabilitySignKriteria",
                column: "ParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_StabilitySignKriteria_StabSignId",
                table: "StabilitySignKriteria",
                column: "StabSignId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParameterValues");

            migrationBuilder.DropTable(
                name: "StabilitySignKriteria");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Parameters");

            migrationBuilder.DropTable(
                name: "StabilitySigns");
        }
    }
}
