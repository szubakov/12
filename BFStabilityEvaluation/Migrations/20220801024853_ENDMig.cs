using Microsoft.EntityFrameworkCore.Migrations;

namespace BFStabilityEvaluation.Migrations
{
    public partial class ENDMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parameters",
                columns: new[] { "ParameterId", "Alias", "MaxValue", "MinValue", "Name", "Unit" },
                values: new object[,]
                {
                    { 44, "Cold blast consumption", 0.0, 0.0, "Расход холодного дутья»", "м3/мин" },
                    { 45, "hot blast pressure", 0.0, 0.0, "Давление горячего дутья", "ати/(МПа)" },
                    { 46, "Gas T on the periphery", 0.0, 0.0, "Температура газа по радиусу колошника на периферии»", "°С" },
                    { 47, "Gas T  on the axis", 0.0, 0.0, "Температура газа по радиусу колошника на оси", "°С" }
                });

            migrationBuilder.InsertData(
                table: "StabilitySignKriteria",
                columns: new[] { "Id", "AcceptableDelta", "ActionType", "Name", "Npech", "ParameterId", "Rang", "StabSignId", "Unit" },
                values: new object[,]
                {
                    { 43, 0.0, 0.0, null, null, 40, 0.0, 5, null },
                    { 42, 0.0, 0.0, null, null, 39, 0.0, 5, null },
                    { 41, 0.0, 0.0, null, null, 38, 0.0, 5, null },
                    { 40, 0.0, 0.0, null, null, 37, 0.0, 5, null },
                    { 39, 0.0, 0.0, null, null, 35, 0.0, 5, null },
                    { 38, 0.0, 0.0, null, null, 34, 0.0, 5, null },
                    { 37, 0.0, 0.0, null, null, 33, 0.0, 5, null },
                    { 36, 0.0, 0.0, null, null, 28, 0.0, 4, null },
                    { 35, 0.0, 0.0, null, null, 24, 0.0, 4, null },
                    { 34, 0.0, 0.0, null, null, 21, 0.0, 4, null },
                    { 33, 0.0, 0.0, null, null, 32, 0.0, 4, null },
                    { 31, 0.0, 0.0, null, null, 29, 0.0, 4, null },
                    { 44, 0.0, 0.0, null, null, 41, 0.0, 5, null },
                    { 30, 0.0, 0.0, null, null, 30, 0.0, 4, null },
                    { 27, 0.0, 0.0, null, null, 26, 0.0, 3, null },
                    { 26, 0.0, 0.0, null, null, 25, 0.0, 3, null },
                    { 25, 0.0, 0.0, null, null, 22, 0.0, 3, null },
                    { 24, 0.0, 0.0, null, null, 43, 0.0, 3, null },
                    { 23, 0.0, 0.0, null, null, 42, 0.0, 3, null },
                    { 22, 0.0, 0.0, null, null, 20, 0.0, 3, null },
                    { 21, 0.0, 0.0, null, null, 19, 0.0, 3, null },
                    { 20, 0.0, 0.0, null, null, 18, 0.0, 3, null },
                    { 32, 0.0, 0.0, null, null, 31, 0.0, 4, null },
                    { 45, 0.0, 0.0, null, null, 36, 0.0, 5, null }
                });

            migrationBuilder.InsertData(
                table: "StabilitySignKriteria",
                columns: new[] { "Id", "AcceptableDelta", "ActionType", "Name", "Npech", "ParameterId", "Rang", "StabSignId", "Unit" },
                values: new object[,]
                {
                    { 18, 0.0, 0.0, null, null, 44, 0.0, 3, null },
                    { 19, 0.0, 0.0, null, null, 45, 0.0, 3, null },
                    { 28, 0.0, 0.0, null, null, 46, 0.0, 3, null },
                    { 29, 0.0, 0.0, null, null, 47, 0.0, 3, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 47);
        }
    }
}
