namespace BaseballAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GameBattingStat", "GameId", "dbo.GameInfo");
            DropForeignKey("dbo.GameBattingStat", "PlayerId", "dbo.Player");
            DropForeignKey("dbo.GameInfo", "TeamId2", "dbo.Team");
            DropForeignKey("dbo.GameInfo", "TeamId1", "dbo.Team");
            DropForeignKey("dbo.Player", "TeamId", "dbo.Team");
            AddForeignKey("dbo.GameBattingStat", "GameId", "dbo.GameInfo", "GameId");
            AddForeignKey("dbo.GameBattingStat", "PlayerId", "dbo.Player", "PlayerId");
            AddForeignKey("dbo.GameInfo", "TeamId2", "dbo.Team", "TeamId");
            AddForeignKey("dbo.GameInfo", "TeamId1", "dbo.Team", "TeamId");
            AddForeignKey("dbo.Player", "TeamId", "dbo.Team", "TeamId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Player", "TeamId", "dbo.Team");
            DropForeignKey("dbo.GameInfo", "TeamId1", "dbo.Team");
            DropForeignKey("dbo.GameInfo", "TeamId2", "dbo.Team");
            DropForeignKey("dbo.GameBattingStat", "PlayerId", "dbo.Player");
            DropForeignKey("dbo.GameBattingStat", "GameId", "dbo.GameInfo");
            AddForeignKey("dbo.Player", "TeamId", "dbo.Team", "TeamId", cascadeDelete: true);
            AddForeignKey("dbo.GameInfo", "TeamId1", "dbo.Team", "TeamId", cascadeDelete: true);
            AddForeignKey("dbo.GameInfo", "TeamId2", "dbo.Team", "TeamId", cascadeDelete: true);
            AddForeignKey("dbo.GameBattingStat", "PlayerId", "dbo.Player", "PlayerId", cascadeDelete: true);
            AddForeignKey("dbo.GameBattingStat", "GameId", "dbo.GameInfo", "GameId", cascadeDelete: true);
        }
    }
}
