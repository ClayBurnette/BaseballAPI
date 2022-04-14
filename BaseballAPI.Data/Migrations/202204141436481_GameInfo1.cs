namespace BaseballAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameInfo1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.GameInfo", name: "TeamId2", newName: "AwayTeamID");
            RenameColumn(table: "dbo.GameInfo", name: "TeamId1", newName: "HomeTeamID");
            RenameIndex(table: "dbo.GameInfo", name: "IX_TeamId1", newName: "IX_HomeTeamID");
            RenameIndex(table: "dbo.GameInfo", name: "IX_TeamId2", newName: "IX_AwayTeamID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.GameInfo", name: "IX_AwayTeamID", newName: "IX_TeamId2");
            RenameIndex(table: "dbo.GameInfo", name: "IX_HomeTeamID", newName: "IX_TeamId1");
            RenameColumn(table: "dbo.GameInfo", name: "HomeTeamID", newName: "TeamId1");
            RenameColumn(table: "dbo.GameInfo", name: "AwayTeamID", newName: "TeamId2");
        }
    }
}
