namespace EFAutoMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
                    })
                .PrimaryKey(t => t.Rendszam);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.autok");
        }
    }
}
