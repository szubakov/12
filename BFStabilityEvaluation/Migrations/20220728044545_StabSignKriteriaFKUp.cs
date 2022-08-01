using Microsoft.EntityFrameworkCore.Migrations;

namespace BFStabilityEvaluation.Migrations
{
    public partial class StabSignKriteriaFKUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StabilitySignKriteria_StabilitySigns_IdstabPokazNavigationStabSignId",
                table: "StabilitySignKriteria");

            migrationBuilder.DropIndex(
                name: "IX_StabilitySignKriteria_IdstabPokazNavigationStabSignId",
                table: "StabilitySignKriteria");

            migrationBuilder.DropColumn(
                name: "IdstabPokazNavigationStabSignId",
                table: "StabilitySignKriteria");

            migrationBuilder.CreateIndex(
                name: "IX_StabilitySignKriteria_StabSignId",
                table: "StabilitySignKriteria",
                column: "StabSignId");

            migrationBuilder.AddForeignKey(
                name: "FK_StabilitySignKriteria_StabilitySigns_StabSignId",
                table: "StabilitySignKriteria",
                column: "StabSignId",
                principalTable: "StabilitySigns",
                principalColumn: "StabSignId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StabilitySignKriteria_StabilitySigns_StabSignId",
                table: "StabilitySignKriteria");

            migrationBuilder.DropIndex(
                name: "IX_StabilitySignKriteria_StabSignId",
                table: "StabilitySignKriteria");

            migrationBuilder.AddColumn<int>(
                name: "IdstabPokazNavigationStabSignId",
                table: "StabilitySignKriteria",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StabilitySignKriteria_IdstabPokazNavigationStabSignId",
                table: "StabilitySignKriteria",
                column: "IdstabPokazNavigationStabSignId");

            migrationBuilder.AddForeignKey(
                name: "FK_StabilitySignKriteria_StabilitySigns_IdstabPokazNavigationStabSignId",
                table: "StabilitySignKriteria",
                column: "IdstabPokazNavigationStabSignId",
                principalTable: "StabilitySigns",
                principalColumn: "StabSignId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
