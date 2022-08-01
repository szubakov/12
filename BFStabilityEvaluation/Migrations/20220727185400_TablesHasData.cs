using Microsoft.EntityFrameworkCore.Migrations;

namespace BFStabilityEvaluation.Migrations
{
    public partial class TablesHasData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 33,
                column: "Alias",
                value: "Basicity_1");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 34,
                column: "Alias",
                value: "Basicity_2");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 35,
                column: "Alias",
                value: "Basicity_3");

            migrationBuilder.InsertData(
                table: "StabilitySignKriteria",
                columns: new[] { "Id", "AcceptableDelta", "ActionType", "IdstabPokazNavigationStabSignId", "Name", "Npech", "ParameterId", "Rang", "StabSignId", "Unit" },
                values: new object[,]
                {
                    { 17, 0.0, 0.0, null, null, null, 17, 0.0, 2, null },
                    { 16, 0.0, 0.0, null, null, null, 16, 0.0, 2, null },
                    { 15, 0.0, 0.0, null, null, null, 15, 0.0, 2, null },
                    { 14, 0.0, 0.0, null, null, null, 14, 0.0, 2, null },
                    { 13, 0.0, 0.0, null, null, null, 13, 0.0, 2, null },
                    { 12, 0.0, 0.0, null, null, null, 12, 0.0, 2, null },
                    { 11, 0.0, 0.0, null, null, null, 11, 0.0, 2, null },
                    { 10, 0.0, 0.0, null, null, null, 10, 0.0, 2, null },
                    { 8, 0.0, 0.0, null, null, null, 8, 0.0, 2, null },
                    { 7, 0.0, 0.0, null, null, null, 7, 0.0, 2, null },
                    { 6, 0.0, 0.0, null, null, null, 6, 0.0, 2, null },
                    { 5, 0.0, 0.0, null, null, null, 5, 0.0, 2, null },
                    { 4, 0.0, 0.0, null, null, null, 4, 0.0, 1, null },
                    { 3, 0.0, 0.0, null, null, null, 3, 0.0, 1, null },
                    { 2, 0.0, 0.0, null, null, null, 2, 0.0, 1, null },
                    { 9, 0.0, 0.0, null, null, null, 9, 0.0, 2, null },
                    { 1, 0.0, 0.0, null, null, null, 1, 0.0, 1, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StabilitySignKriteria",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 33,
                column: "Alias",
                value: "Basicity of final slag (CaO/(SiO2)");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 34,
                column: "Alias",
                value: "Basicity of final slag (CaO+MgO)/(SiO2)");

            migrationBuilder.UpdateData(
                table: "Parameters",
                keyColumn: "ParameterId",
                keyValue: 35,
                column: "Alias",
                value: "Basicity of final slag (CaO+MgO)/(SiO2+Al2O3)");
        }
    }
}
