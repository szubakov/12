using Microsoft.EntityFrameworkCore.Migrations;

namespace BFStabilityEvaluation.Migrations
{
    public partial class TableKriteriaNameNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Npech",
                table: "StabilitySignKriteria",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Parameters",
                columns: new[] { "ParameterId", "Alias", "MaxValue", "MinValue", "Name", "Unit" },
                values: new object[,]
                {
                    { 2, "Spec Сonsumption coke", 0.0, 0.0, "Удельный расход кокса", "кг/т чугуна" },
                    { 26, "Irregularities  top gas", 0.0, 0.0, "Неравномерность T колошникового газа по газоотводам", "°С" },
                    { 27, "Ratio  Tcp of peripheral to Tcp of gas", 0.0, 0.0, "Отношение Tcр периферийных термопар к Tcр колошникового газа", "ед" },
                    { 28, "Reftemperatures 4th row", 0.0, 0.0, "Температура холодильников 4 ряд", "°С" },
                    { 29, "Theoretical  temperature", 0.0, 0.0, "Теоретическая температура горения", "°С" },
                    { 30, "Si content in cast iron", 0.0, 0.0, "Содержание в чугуне Si", "%" },
                    { 31, "Index of the bottom temperature ", 0.0, 0.0, "Индекс низа температурного поля", "доли" },
                    { 32, "Index of the top of the temperature ", 0.0, 0.0, "Индекс верха температурного поля", "доли" },
                    { 33, "Basicity of final slag (CaO/(SiO2)", 0.0, 0.0, "Основность конечного шлака (CaO/(SiO2)", "-" },
                    { 24, "Temperature peripheral", 0.0, 0.0, "Средняя температура периферийных газов", "°С" },
                    { 34, "Basicity of final slag (CaO+MgO)/(SiO2)", 0.0, 0.0, "Основность конечного шлака (CaO+MgO)/(SiO2)", " -" },
                    { 36, "Sulfur distribution coefficient", 0.0, 0.0, "Коэффициент распределения серы", "°доли" },
                    { 37, "Viscosity_1400", 0.0, 0.0, "Вязкость конечного шлака при 1400 °С", "Па∙с" },
                    { 38, "Viscosity_1500", 0.0, 0.0, "Вязкость конечного шлака при 1500 °С", "Па∙с" },
                    { 39, "Viscosity_Tfin", 0.0, 0.0, "Вязкость конечного шлака при T конечной", "Па∙с" },
                    { 40, "Viscosity gradients at 1400–1500 °C", 0.0, 0.0, "Градиенты вязкости шлака при 1400–1500 °С ", "Па∙с/°С" },
                    { 41, "Slag viscosity gradients at 0.7–2.5 Pa∙s", 0.0, 0.0, "Градиенты вязкости шлака при 0,7–2,5 Па∙с", "Па∙с/°С" },
                    { 42, "P drop tuyere - top", 0.0, 0.0, "Перепад давления «фурмы – колошник»", "атм" },
                    { 43, "The degree  balancing by the gas flow", 0.0, 0.0, "Степень уравновешивания шихты газовым потоком", "%" },
                    { 35, "Basicity of final slag (CaO+MgO)/(SiO2+Al2O3)", 0.0, 0.0, "Основность конечного шлака (CaO+MgO)/(SiO2+Al2O3)", " -" },
                    { 23, "Degree of CO H2", 0.0, 0.0, "Степень использования Н2", "%" },
                    { 25, "Irregularity of gas temperature", 0.0, 0.0, "Окружная неравномерность температуры газа", "°С" },
                    { 21, "TempKolGaz", 0.0, 0.0, "Средняя температура колошникового газа", "°С" },
                    { 3, "Current downtime", 0.0, 0.0, "Текущие простои", "%" },
                    { 4, "Quiet running", 0.0, 0.0, "Тихий ход", "%" },
                    { 5, "The proportion of pellets", 0.0, 0.0, "Доля окатышей в шихте", "%" },
                    { 6, "Share of sinter", 0.0, 0.0, "Доля агломерата в шихте", "%" },
                    { 7, "Fe content", 0.0, 0.0, "Содержание Fe в доменной шихте", "%" },
                    { 8, "Basicity  CaO/Sio2", 0.0, 0.0, "Основность ЖРМ CaO/Sio2", "-" },
                    { 9, "Basicity  (CaO+MgO)/(SiO2)", 0.0, 0.0, "Основность ЖРМ (CaO+MgO)/(SiO2)", "-" },
                    { 22, "Degree of CO", 0.0, 0.0, "Степень использования СО", "%" },
                    { 11, "Ash in coke", 0.0, 0.0, "Содержание золы в коксе", "%" },
                    { 10, "Basicity (CaO+MgO)/(SiO2+Al2O3)", 0.0, 0.0, "Основность ЖРМ (CaO+MgO)/(SiO2+Al2O3)", "-" },
                    { 13, "Volatile  in coke", 0.0, 0.0, "Содержание летучих в коксе", "%" },
                    { 14, "Coke  M25", 0.0, 0.0, "Прочность кокса по М25", "%" },
                    { 15, "Abrasion to M10", 0.0, 0.0, "Истираемость кокса по М10", "%" },
                    { 16, "CSR", 0.0, 0.0, "CSR", "%" },
                    { 17, "CRI", 0.0, 0.0, "CRI", "%" },
                    { 18, "Gas consumption", 0.0, 0.0, "Расход природного газа", "м3/т чугуна" },
                    { 19, "HotBlastO2", 0.0, 0.0, "Содержание кислорода в дутье", "%" },
                    { 20, "TempHotBlast", 0.0, 0.0, "Температура горячего дутья", "°С" },
                    { 12, "Moisture  in coke", 0.0, 0.0, "Содержание влаги в коксе", "%" }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "StabilitySigns",
                keyColumn: "StabSignId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StabilitySigns",
                keyColumn: "StabSignId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StabilitySigns",
                keyColumn: "StabSignId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StabilitySigns",
                keyColumn: "StabSignId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StabilitySigns",
                keyColumn: "StabSignId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StabilitySigns",
                keyColumn: "StabSignId",
                keyValue: 6);

            migrationBuilder.AlterColumn<int>(
                name: "Npech",
                table: "StabilitySignKriteria",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
