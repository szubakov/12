using Microsoft.EntityFrameworkCore.Migrations;

namespace BFStabilityEvaluation.Migrations
{
    public partial class _08mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 1,
                column: "Name",
                value: "Удельная производительность, т/м3");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 2,
                column: "Name",
                value: "Удельный расход кокса, кг/т чугуна");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 3,
                column: "Name",
                value: "Текущие простои, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 4,
                column: "Name",
                value: "Тихий ход, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 5,
                column: "Name",
                value: "Доля окатышей в шихте, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 6,
                column: "Name",
                value: "Доля агломерата в шихте, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 7,
                column: "Name",
                value: "Содержание Fe в доменной шихте, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 11,
                column: "Name",
                value: "Содержание золы в коксе, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 12,
                column: "Name",
                value: "Содержание влаги в коксе, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 13,
                column: "Name",
                value: "Содержание летучих в коксе, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 14,
                column: "Name",
                value: "Прочность кокса по М25, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 15,
                column: "Name",
                value: "Истираемость кокса по М10, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 16,
                column: "Name",
                value: "CSR, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 17,
                column: "Name",
                value: "CRI, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 18,
                column: "Name",
                value: "Расход природного газа, м3/т чугуна");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 19,
                column: "Name",
                value: "Содержание кислорода в дутье, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 20,
                column: "Name",
                value: "Температура горячего дутья, °С");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 21,
                column: "Name",
                value: "Средняя температура колошникового газа, °С");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 22,
                column: "Name",
                value: "Степень использования СО, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 23,
                column: "Name",
                value: "Степень использования Н2, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 24,
                column: "Name",
                value: "Средняя температура периферийных газов, °С");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 25,
                column: "Name",
                value: "Окружная неравномерность температуры газа, °С");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 26,
                column: "Name",
                value: "Неравномерность T колошникового газа по газоотводам, °С");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 27,
                column: "Name",
                value: "Отношение Tcр периферийных термопар к Tcр колошникового газа, ед");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 28,
                column: "Name",
                value: "Температура холодильников 4 ряд, °С");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 29,
                column: "Name",
                value: "Теоретическая температура горения, °С");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 30,
                column: "Name",
                value: "Содержание в чугуне Si, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 31,
                column: "Name",
                value: "Индекс низа температурного поля, доли");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 32,
                column: "Name",
                value: "Индекс верха температурного поля, доли");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 36,
                column: "Name",
                value: "Коэффициент распределения серы, доли");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 37,
                column: "Name",
                value: "Вязкость конечного шлака при 1400 °С, Па∙с");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 38,
                column: "Name",
                value: "Вязкость конечного шлака при 1500 °С, Па∙с");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 39,
                column: "Name",
                value: "Вязкость конечного шлака при T конечной, Па∙с");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 40,
                column: "Name",
                value: "Градиенты вязкости шлака при 1400–1500 °С, Па∙с");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 41,
                column: "Name",
                value: "Градиенты вязкости шлака при 0,7–2,5 Па∙с, Па∙с");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 42,
                column: "Name",
                value: "Перепад давления «фурмы – колошник», атм");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 43,
                column: "Name",
                value: "Степень уравновешивания шихты газовым потоком, %");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 44,
                column: "Name",
                value: "Расход холодного дутья, м3/мин»");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 45,
                columns: new[] { "Name", "Unit" },
                values: new object[] { "Давление горячего дутья, атм/(МПа)", "атм/(МПа)" });

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 46,
                column: "Name",
                value: "Температура газа по радиусу колошника на периферии», °С");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 47,
                column: "Name",
                value: "Температура газа по радиусу колошника на оси, °С");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 1,
                column: "Name",
                value: "Удельная производительность");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 2,
                column: "Name",
                value: "Удельный расход кокса");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 3,
                column: "Name",
                value: "Текущие простои");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 4,
                column: "Name",
                value: "Тихий ход");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 5,
                column: "Name",
                value: "Доля окатышей в шихте");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 6,
                column: "Name",
                value: "Доля агломерата в шихте");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 7,
                column: "Name",
                value: "Содержание Fe в доменной шихте");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 11,
                column: "Name",
                value: "Содержание золы в коксе");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 12,
                column: "Name",
                value: "Содержание влаги в коксе");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 13,
                column: "Name",
                value: "Содержание летучих в коксе");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 14,
                column: "Name",
                value: "Прочность кокса по М25");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 15,
                column: "Name",
                value: "Истираемость кокса по М10");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 16,
                column: "Name",
                value: "CSR");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 17,
                column: "Name",
                value: "CRI");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 18,
                column: "Name",
                value: "Расход природного газа");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 19,
                column: "Name",
                value: "Содержание кислорода в дутье");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 20,
                column: "Name",
                value: "Температура горячего дутья");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 21,
                column: "Name",
                value: "Средняя температура колошникового газа");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 22,
                column: "Name",
                value: "Степень использования СО");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 23,
                column: "Name",
                value: "Степень использования Н2");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 24,
                column: "Name",
                value: "Средняя температура периферийных газов");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 25,
                column: "Name",
                value: "Окружная неравномерность температуры газа");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 26,
                column: "Name",
                value: "Неравномерность T колошникового газа по газоотводам");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 27,
                column: "Name",
                value: "Отношение Tcр периферийных термопар к Tcр колошникового газа");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 28,
                column: "Name",
                value: "Температура холодильников 4 ряд");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 29,
                column: "Name",
                value: "Теоретическая температура горения");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 30,
                column: "Name",
                value: "Содержание в чугуне Si");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 31,
                column: "Name",
                value: "Индекс низа температурного поля");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 32,
                column: "Name",
                value: "Индекс верха температурного поля");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 36,
                column: "Name",
                value: "Коэффициент распределения серы");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 37,
                column: "Name",
                value: "Вязкость конечного шлака при 1400 °С");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 38,
                column: "Name",
                value: "Вязкость конечного шлака при 1500 °С");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 39,
                column: "Name",
                value: "Вязкость конечного шлака при T конечной");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 40,
                column: "Name",
                value: "Градиенты вязкости шлака при 1400–1500 °С ");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 41,
                column: "Name",
                value: "Градиенты вязкости шлака при 0,7–2,5 Па∙с");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 42,
                column: "Name",
                value: "Перепад давления «фурмы – колошник»");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 43,
                column: "Name",
                value: "Степень уравновешивания шихты газовым потоком");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 44,
                column: "Name",
                value: "Расход холодного дутья»");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 45,
                columns: new[] { "Name", "Unit" },
                values: new object[] { "Давление горячего дутья", "ати/(МПа)" });

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 46,
                column: "Name",
                value: "Температура газа по радиусу колошника на периферии»");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 47,
                column: "Name",
                value: "Температура газа по радиусу колошника на оси");
        }
    }
}
