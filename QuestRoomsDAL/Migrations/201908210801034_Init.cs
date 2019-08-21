namespace QuestRoomsDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HouseNumber = c.Int(nullable: false),
                        City_Id = c.Int(),
                        Country_Id = c.Int(),
                        Street_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .ForeignKey("dbo.Streets", t => t.Street_Id)
                .Index(t => t.City_Id)
                .Index(t => t.Country_Id)
                .Index(t => t.Street_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        PassingTime = c.Time(nullable: false, precision: 7),
                        NumberPlayers = c.Int(nullable: false),
                        YearPlayers = c.Int(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                        Rating = c.Int(nullable: false),
                        LevelFear = c.Int(nullable: false),
                        LevelDifficulty = c.Int(nullable: false),
                        Logo = c.String(),
                        Images = c.String(),
                        Address_Id = c.Int(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Streets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "Street_Id", "dbo.Streets");
            DropForeignKey("dbo.Rooms", "Company_Id", "dbo.Companies");
            DropForeignKey("dbo.Rooms", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "City_Id", "dbo.Cities");
            DropIndex("dbo.Rooms", new[] { "Company_Id" });
            DropIndex("dbo.Rooms", new[] { "Address_Id" });
            DropIndex("dbo.Addresses", new[] { "Street_Id" });
            DropIndex("dbo.Addresses", new[] { "Country_Id" });
            DropIndex("dbo.Addresses", new[] { "City_Id" });
            DropTable("dbo.Streets");
            DropTable("dbo.Companies");
            DropTable("dbo.Rooms");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
        }
    }
}
