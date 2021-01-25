namespace EFAutoMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tulaj_telefon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.autok",
                c => new
                    {
                        Rendszam = c.String(nullable: false, maxLength: 128),
                        Gyartmany = c.String(nullable: false),
                        Tipus = c.String(nullable: false),
                        GyartasiEv = c.Int(nullable: false),
                        Alvazszam = c.Int(nullable: false),
                        TulajId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Rendszam)
                .ForeignKey("dbo.tulaj", t => t.TulajId, cascadeDelete: true)
                .Index(t => t.TulajId);
            
            CreateTable(
                "dbo.tulaj",
                c => new
                    {
                        TulajId = c.Int(nullable: false, identity: true),
                        Nev = c.String(),
                        Telefonszam = c.String(),
                    })
                .PrimaryKey(t => t.TulajId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.autok", "TulajId", "dbo.tulaj");
            DropIndex("dbo.autok", new[] { "TulajId" });
            DropTable("dbo.tulaj");
            DropTable("dbo.autok");
        }
    }
}
