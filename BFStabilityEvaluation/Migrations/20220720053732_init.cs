using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BFStabilityEvaluation.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parameter",
                columns: table => new
                {
                    ID_param = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Alias = table.Column<int>(type: "int", nullable: false),
                    Unit_ = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    MinValue_ = table.Column<double>(type: "float", nullable: false),
                    MaxValue = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paramete__FD2AA0F98CC29996", x => x.ID_param);
                });

            migrationBuilder.CreateTable(
                name: "StabilitySign",
                columns: table => new
                {
                    IDstabPokaz = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    Alias = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    LimitWarning = table.Column<double>(type: "float", nullable: false),
                    LimitDanger = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Stabilit__1EEBF21482C3EADF", x => x.IDstabPokaz);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    CodeUser = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
                    Role = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.CodeUser);
                });

            migrationBuilder.CreateTable(
                name: "ParameterValue",
                columns: table => new
                {
                    NPech_ = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "date", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false),
                    ID_param = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__Parameter__ID_pa__1273C1CD",
                        column: x => x.ID_param,
                        principalTable: "Parameter",
                        principalColumn: "ID_param",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "_StabilitySignKriteria",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    NPech_ = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    Unit_ = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    AcceptableDelta = table.Column<double>(type: "float", nullable: false),
                    Rang_ = table.Column<double>(type: "float", nullable: false),
                    ActionType = table.Column<double>(type: "float", nullable: false),
                    IDstabPokaz = table.Column<int>(type: "int", nullable: false),
                    ID_param = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StabilitySignKriteria", x => x.ID);
                    table.ForeignKey(
                        name: "FK___Stabilit__ID_pa__182C9B23",
                        column: x => x.ID_param,
                        principalTable: "Parameter",
                        principalColumn: "ID_param",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK___Stabilit__IDsta__173876EA",
                        column: x => x.IDstabPokaz,
                        principalTable: "StabilitySign",
                        principalColumn: "IDstabPokaz",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX__StabilitySignKriteria_ID_param",
                table: "_StabilitySignKriteria",
                column: "ID_param");

            migrationBuilder.CreateIndex(
                name: "IX__StabilitySignKriteria_IDstabPokaz",
                table: "_StabilitySignKriteria",
                column: "IDstabPokaz");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterValue_ID_param",
                table: "ParameterValue",
                column: "ID_param");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_StabilitySignKriteria");

            migrationBuilder.DropTable(
                name: "ParameterValue");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "StabilitySign");

            migrationBuilder.DropTable(
                name: "Parameter");
        }
    }
}
