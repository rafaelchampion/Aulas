namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        DataInsert = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPessoa = c.Int(nullable: false),
                        DataInsert = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.IdPessoa, cascadeDelete: true)
                .Index(t => t.IdPessoa);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Telefone = c.String(unicode: false),
                        CPF = c.String(unicode: false),
                        Logradouro = c.String(unicode: false),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(unicode: false),
                        Bairro = c.String(unicode: false),
                        IdCidade = c.Int(nullable: false),
                        DataNascimento = c.DateTime(nullable: false, precision: 0),
                        DataInsert = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cidade", t => t.IdCidade, cascadeDelete: true)
                .Index(t => t.IdCidade);
            
            CreateTable(
                "dbo.Colaborador",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPessoa = c.Int(nullable: false),
                        DataInsert = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.IdPessoa, cascadeDelete: true)
                .Index(t => t.IdPessoa);
            
            CreateTable(
                "dbo.Comanda",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdCliente = c.Int(nullable: false),
                        IdColaborador = c.Int(nullable: false),
                        DataInsert = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.IdCliente, cascadeDelete: true)
                .ForeignKey("dbo.Colaborador", t => t.IdColaborador, cascadeDelete: true)
                .Index(t => t.IdCliente)
                .Index(t => t.IdColaborador);
            
            CreateTable(
                "dbo.ItemComanda",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdComanda = c.Int(nullable: false),
                        IdTratamento = c.Int(nullable: false),
                        DataInsert = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comanda", t => t.IdComanda, cascadeDelete: true)
                .ForeignKey("dbo.Tratamento", t => t.IdTratamento, cascadeDelete: true)
                .Index(t => t.IdComanda)
                .Index(t => t.IdTratamento);
            
            CreateTable(
                "dbo.Tratamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataInsert = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemComanda", "IdTratamento", "dbo.Tratamento");
            DropForeignKey("dbo.ItemComanda", "IdComanda", "dbo.Comanda");
            DropForeignKey("dbo.Comanda", "IdColaborador", "dbo.Colaborador");
            DropForeignKey("dbo.Comanda", "IdCliente", "dbo.Cliente");
            DropForeignKey("dbo.Cliente", "IdPessoa", "dbo.Pessoa");
            DropForeignKey("dbo.Colaborador", "IdPessoa", "dbo.Pessoa");
            DropForeignKey("dbo.Pessoa", "IdCidade", "dbo.Cidade");
            DropIndex("dbo.ItemComanda", new[] { "IdTratamento" });
            DropIndex("dbo.ItemComanda", new[] { "IdComanda" });
            DropIndex("dbo.Comanda", new[] { "IdColaborador" });
            DropIndex("dbo.Comanda", new[] { "IdCliente" });
            DropIndex("dbo.Colaborador", new[] { "IdPessoa" });
            DropIndex("dbo.Pessoa", new[] { "IdCidade" });
            DropIndex("dbo.Cliente", new[] { "IdPessoa" });
            DropTable("dbo.Tratamento");
            DropTable("dbo.ItemComanda");
            DropTable("dbo.Comanda");
            DropTable("dbo.Colaborador");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Cliente");
            DropTable("dbo.Cidade");
        }
    }
}
