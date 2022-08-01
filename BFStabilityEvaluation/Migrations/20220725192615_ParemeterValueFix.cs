using Microsoft.EntityFrameworkCore.Migrations;

namespace BFStabilityEvaluation.Migrations
{
    public partial class ParemeterValueFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParameterValues_Parameters_ParameterId",
                table: "ParameterValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParameterValues",
                table: "ParameterValues");

            migrationBuilder.DropColumn(
                name: "IdParam",
                table: "ParameterValues");

            migrationBuilder.AlterColumn<int>(
                name: "ParameterId",
                table: "ParameterValues",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParameterValues",
                table: "ParameterValues",
                columns: new[] { "Npech", "ParameterId", "Period" });

            migrationBuilder.AddForeignKey(
                name: "FK_ParameterValues_Parameters_ParameterId",
                table: "ParameterValues",
                column: "ParameterId",
                principalTable: "Parameters",
                principalColumn: "ParameterId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParameterValues_Parameters_ParameterId",
                table: "ParameterValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParameterValues",
                table: "ParameterValues");

            migrationBuilder.AlterColumn<int>(
                name: "ParameterId",
                table: "ParameterValues",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdParam",
                table: "ParameterValues",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParameterValues",
                table: "ParameterValues",
                columns: new[] { "Npech", "IdParam", "Period" });

            migrationBuilder.AddForeignKey(
                name: "FK_ParameterValues_Parameters_ParameterId",
                table: "ParameterValues",
                column: "ParameterId",
                principalTable: "Parameters",
                principalColumn: "ParameterId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
