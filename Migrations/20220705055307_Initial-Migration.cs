using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arthes2022.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "REVISTAS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tema = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroEdicao = table.Column<int>(type: "int", nullable: false),
                    MesEdicao = table.Column<int>(type: "int", nullable: false),
                    AnoEdicao = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REVISTAS", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "REVISTAS");
        }
    }
}
