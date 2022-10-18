using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,Ativo,CategoriaId,DataCadastro,CadastroPor,DataAtualizacao,AtualizacaoPor) VALUES('Coca-Cola Diet','Refrigerante de Cola 350 ml',5.45,'cocacola.jpg',50,1,1,now(),'Belarmino',now(),'Belarmino')");
            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,Ativo,CategoriaId,DataCadastro,CadastroPor,DataAtualizacao,AtualizacaoPor) VALUES('Lanche de Atum','Lanche de Atum com maionese',8.50,'atum.jpg',10,1,2,now(),'Belarmino',now(),'Belarmino')");
            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,Ativo,CategoriaId,DataCadastro,CadastroPor,DataAtualizacao,AtualizacaoPor) VALUES('Pudim 100 g','Pudim de leite condensado 100g',6.75,'pudim.jpg',20,1,3,now(),'Belarmino',now(),'Belarmino')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
