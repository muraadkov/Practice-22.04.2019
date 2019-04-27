namespace Practice22._04._2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMband1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Songs", new[] { "MusicBand_Id" });
            RenameColumn(table: "dbo.MusicBands", name: "MusicBand_Id", newName: "Songs_Id");
            CreateIndex("dbo.MusicBands", "Songs_Id");
            DropColumn("dbo.Songs", "MusicBand_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Songs", "MusicBand_Id", c => c.Guid());
            DropIndex("dbo.MusicBands", new[] { "Songs_Id" });
            RenameColumn(table: "dbo.MusicBands", name: "Songs_Id", newName: "MusicBand_Id");
            CreateIndex("dbo.Songs", "MusicBand_Id");
        }
    }
}
