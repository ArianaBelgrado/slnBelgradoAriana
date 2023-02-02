using Microsoft.EntityFrameworkCore.Migrations;

namespace slnBelgradoAriana.Migrations
{
    public partial class uno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Recetas",
                table: "Recetas");

            migrationBuilder.RenameTable(
                name: "Recetas",
                newName: "Receta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Receta",
                table: "Receta",
                column: "RecetaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Receta",
                table: "Receta");

            migrationBuilder.RenameTable(
                name: "Receta",
                newName: "Recetas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recetas",
                table: "Recetas",
                column: "RecetaId");
        }
    }
}
