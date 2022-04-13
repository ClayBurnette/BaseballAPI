﻿namespace BaseballAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Player", "OwnerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Player", "OwnerId", c => c.Guid(nullable: false));
        }
    }
}
