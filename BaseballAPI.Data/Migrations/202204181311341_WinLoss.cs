namespace BaseballAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WinLoss : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Team", "Wins");
            DropColumn("dbo.Team", "Losses");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Team", "Losses", c => c.Int(nullable: false));
            AddColumn("dbo.Team", "Wins", c => c.Int(nullable: false));
        }
    }
}
