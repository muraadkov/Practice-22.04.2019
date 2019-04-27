namespace Practice22._04._2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMband : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MusicBands",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Words = c.String(),
                        DuringSounding = c.String(),
                        Rating = c.Int(nullable: false),
                        MusicBand_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MusicBands", t => t.MusicBand_Id)
                .Index(t => t.MusicBand_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "MusicBand_Id", "dbo.MusicBands");
            DropIndex("dbo.Songs", new[] { "MusicBand_Id" });
            DropTable("dbo.Songs");
            DropTable("dbo.MusicBands");
        }
    }
}
