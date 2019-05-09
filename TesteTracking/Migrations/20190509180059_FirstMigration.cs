using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteTracking.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
             name: "ProdutoGrupo",
             columns: table => new
             {
                 Id = table.Column<Guid>(nullable: false),
                 NomeGrupo = table.Column<string>(maxLength: 150, nullable: false)
             },
             constraints: table =>
             {
                 table.PrimaryKey("PK_ProdutoGrupo", x => x.Id);
             });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoGrupo");
        }
    }
}
