namespace Conectando_BDO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableVinhos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vinhos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vinhos");
        }
    }
}
