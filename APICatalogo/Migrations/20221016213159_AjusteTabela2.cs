using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class AjusteTabela2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
               name: "CadastroPor",
               table: "Produtos",
               type: "varchar(20)",
               maxLength: 20,
               nullable: false,
               oldClrType: typeof(string),
               oldType: "longtext",
               oldNullable: true)
               .Annotation("MySql:CharSet", "utf8mb4")
               .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
              name: "AtualizacaoPor",
              table: "Produtos",
              type: "varchar(20)",
              maxLength: 20,
              nullable: false,
              oldClrType: typeof(string),
              oldType: "longtext",
              oldNullable: true)
              .Annotation("MySql:CharSet", "utf8mb4")
              .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CadastroPor",
                table: "Produtos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "AtualizacaoPor",
                table: "Produtos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
