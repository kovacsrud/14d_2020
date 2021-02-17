namespace EFAutoMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tulaj : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tulaj",
                c => new
                    {
                        TulajId = c.Int(nullable: false, identity: true),
                        Nev = c.String(),
                        Telefonszam = c.String(),
                    })
                .PrimaryKey(t => t.TulajId);
            
            AddColumn("dbo.autok", "TulajId", c => c.Int(nullable: false));
            CreateIndex("dbo.autok", "TulajId");
            AddForeignKey("dbo.autok", "TulajId", "dbo.tulaj", "TulajId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.autok", "TulajId", "dbo.tulaj");
            DropIndex("dbo.autok", new[] { "TulajId" });
            DropColumn("dbo.autok", "TulajId");
            DropTable("dbo.tulaj");
        }
    }
}
