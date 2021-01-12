namespace DoudouMons.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Character",
                c => new
                    {
                        IdCharacter = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        costume = c.String(),
                        ExplicationRole = c.String(),
                        NomArmes = c.String(),
                    })
                .PrimaryKey(t => t.IdCharacter);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        idCustomer = c.Int(nullable: false, identity: true),
                        lastName = c.String(),
                        firstName = c.String(),
                        email = c.String(),
                        password = c.String(),
                        adresse = c.String(),
                        numero = c.Int(nullable: false),
                        cp = c.Int(nullable: false),
                        ville = c.String(),
                    })
                .PrimaryKey(t => t.idCustomer);
            
            CreateTable(
                "dbo.Shopping",
                c => new
                    {
                        idShopping = c.Int(nullable: false, identity: true),
                        idCustomer = c.Int(nullable: false),
                        idProduct = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idShopping)
                .ForeignKey("dbo.Customer", t => t.idCustomer, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.idProduct, cascadeDelete: true)
                .Index(t => t.idCustomer)
                .Index(t => t.idProduct);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        idProduct = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        Desc = c.String(),
                        prix = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.idProduct);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shopping", "idProduct", "dbo.Product");
            DropForeignKey("dbo.Shopping", "idCustomer", "dbo.Customer");
            DropIndex("dbo.Shopping", new[] { "idProduct" });
            DropIndex("dbo.Shopping", new[] { "idCustomer" });
            DropTable("dbo.Product");
            DropTable("dbo.Shopping");
            DropTable("dbo.Customer");
            DropTable("dbo.Character");
        }
    }
}
