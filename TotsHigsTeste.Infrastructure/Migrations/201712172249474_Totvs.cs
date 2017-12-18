namespace TotsHigsTeste.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Totvs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Guid(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                        Cpf = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.ClienteId)
                .Index(t => t.Cpf, unique: true, name: "IX_CPF");
            
            CreateTable(
                "dbo.Desconto",
                c => new
                    {
                        DescontoId = c.Guid(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150),
                        ProgramaDeDesconto_ProgramaDeDescontoId = c.Guid(),
                    })
                .PrimaryKey(t => t.DescontoId)
                .ForeignKey("dbo.ProgramaDeDesconto", t => t.ProgramaDeDesconto_ProgramaDeDescontoId)
                .Index(t => t.ProgramaDeDesconto_ProgramaDeDescontoId);
            
            CreateTable(
                "dbo.ProgramaDeDesconto",
                c => new
                    {
                        ProgramaDeDescontoId = c.Guid(nullable: false, identity: true),
                        CodigoConsultor = c.Int(nullable: false),
                        Cliente_ClienteId = c.Guid(nullable: false),
                        Desconto_DescontoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ProgramaDeDescontoId)
                .ForeignKey("dbo.Cliente", t => t.Cliente_ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Desconto", t => t.Desconto_DescontoId, cascadeDelete: true)
                .Index(t => t.Cliente_ClienteId)
                .Index(t => t.Desconto_DescontoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Desconto", "ProgramaDeDesconto_ProgramaDeDescontoId", "dbo.ProgramaDeDesconto");
            DropForeignKey("dbo.ProgramaDeDesconto", "Desconto_DescontoId", "dbo.Desconto");
            DropForeignKey("dbo.ProgramaDeDesconto", "Cliente_ClienteId", "dbo.Cliente");
            DropIndex("dbo.ProgramaDeDesconto", new[] { "Desconto_DescontoId" });
            DropIndex("dbo.ProgramaDeDesconto", new[] { "Cliente_ClienteId" });
            DropIndex("dbo.Desconto", new[] { "ProgramaDeDesconto_ProgramaDeDescontoId" });
            DropIndex("dbo.Cliente", "IX_CPF");
            DropTable("dbo.ProgramaDeDesconto");
            DropTable("dbo.Desconto");
            DropTable("dbo.Cliente");
        }
    }
}
