namespace BaseballAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GameBattingStat", "GameId", "dbo.GameInfo");
            DropForeignKey("dbo.GameBattingStat", "PlayerId", "dbo.Player");
            AddColumn("dbo.Team", "TeamName", c => c.String(nullable: false));
            AddColumn("dbo.Team", "TeamLocation", c => c.String(nullable: false));
            AddColumn("dbo.Team", "TeamMascot", c => c.String());
            AddColumn("dbo.Team", "TeamStadium", c => c.String());
            AddForeignKey("dbo.GameBattingStat", "GameId", "dbo.GameInfo", "GameId");
            AddForeignKey("dbo.GameBattingStat", "PlayerId", "dbo.Player", "PlayerId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GameBattingStat", "PlayerId", "dbo.Player");
            DropForeignKey("dbo.GameBattingStat", "GameId", "dbo.GameInfo");
            DropColumn("dbo.Team", "TeamStadium");
            DropColumn("dbo.Team", "TeamMascot");
            DropColumn("dbo.Team", "TeamLocation");
            DropColumn("dbo.Team", "TeamName");
            AddForeignKey("dbo.GameBattingStat", "PlayerId", "dbo.Player", "PlayerId", cascadeDelete: true);
            AddForeignKey("dbo.GameBattingStat", "GameId", "dbo.GameInfo", "GameId", cascadeDelete: true);
        }
    }
}
