using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Webbutveckling.Migrations
{
    public partial class AddedSomeColsAndNulls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kurskod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ämne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skola = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Betyg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivning = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Länk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumKursAvslutad = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Poäng = table.Column<double>(type: "float", nullable: false),
                    PoängTyp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kurs");
        }
    }
}
