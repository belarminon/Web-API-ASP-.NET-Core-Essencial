using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categorias(ImagemUrl,CategoriaName) values('bebidas.jpg','Bebidas')");
            mb.Sql("Insert into Categorias(ImagemUrl,CategoriaName) values('lanches.jpg','Lanches')");
            mb.Sql("Insert into Categorias(ImagemUrl,CategoriaName) values('sobremesas.jpg','Sobremesas')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
        }
    }
}
