namespace BaseballAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameBattingStat",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerId = c.Int(nullable: false),
                        GameId = c.Int(nullable: false),
                        AB = c.Int(nullable: false),
                        R = c.Int(nullable: false),
                        H = c.Int(nullable: false),
                        RBI = c.Int(nullable: false),
                        BB = c.Int(nullable: false),
                        SO = c.Int(nullable: false),
                        HR = c.Int(nullable: false),
                        Double = c.Int(nullable: false),
                        Triple = c.Int(nullable: false),
                        SAC = c.Int(nullable: false),
                        HBP = c.Int(nullable: false),
                        SB = c.Int(nullable: false),
                        CS = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GameInfo", t => t.GameId)
                .ForeignKey("dbo.Player", t => t.PlayerId)
                .Index(t => t.PlayerId)
                .Index(t => t.GameId);
            
            CreateTable(
                "dbo.GameInfo",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        HomeTeamID = c.Int(nullable: false),
                        AwayTeamID = c.Int(nullable: false),
                        HomeScore = c.Int(nullable: false),
                        AwayScore = c.Int(nullable: false),
                        Innings = c.Double(nullable: false),
                        SeasonYear = c.Int(nullable: false),
                        Team_TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.GameId)
                .ForeignKey("dbo.Team", t => t.Team_TeamId)
                .ForeignKey("dbo.Team", t => t.AwayTeamID)
                .ForeignKey("dbo.Team", t => t.HomeTeamID)
                .Index(t => t.HomeTeamID)
                .Index(t => t.AwayTeamID)
                .Index(t => t.Team_TeamId);
            
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        TeamName = c.String(nullable: false),
                        TeamLocation = c.String(nullable: false),
                        TeamMascot = c.String(),
                        TeamStadium = c.String(),
                        Name = c.Int(nullable: false),
                        Location = c.Int(nullable: false),
                        Stadium = c.Int(nullable: false),
                        Mascot = c.Int(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.TeamId);
            
            CreateTable(
                "dbo.Player",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DateOfBirth = c.String(nullable: false),
                        School = c.String(nullable: false),
                        PlayerPosition = c.Int(nullable: false),
                        JerseyNumber = c.Int(nullable: false),
                        HomeTown = c.String(nullable: false),
                        TeamId = c.Int(nullable: false),
                        Team_TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.Team", t => t.TeamId)
                .ForeignKey("dbo.Team", t => t.Team_TeamId)
                .Index(t => t.TeamId)
                .Index(t => t.Team_TeamId);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.ApplicationUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.GameBattingStat", "PlayerId", "dbo.Player");
            DropForeignKey("dbo.GameBattingStat", "GameId", "dbo.GameInfo");
            DropForeignKey("dbo.GameInfo", "HomeTeamID", "dbo.Team");
            DropForeignKey("dbo.GameInfo", "AwayTeamID", "dbo.Team");
            DropForeignKey("dbo.Player", "Team_TeamId", "dbo.Team");
            DropForeignKey("dbo.Player", "TeamId", "dbo.Team");
            DropForeignKey("dbo.GameInfo", "Team_TeamId", "dbo.Team");
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.Player", new[] { "Team_TeamId" });
            DropIndex("dbo.Player", new[] { "TeamId" });
            DropIndex("dbo.GameInfo", new[] { "Team_TeamId" });
            DropIndex("dbo.GameInfo", new[] { "AwayTeamID" });
            DropIndex("dbo.GameInfo", new[] { "HomeTeamID" });
            DropIndex("dbo.GameBattingStat", new[] { "GameId" });
            DropIndex("dbo.GameBattingStat", new[] { "PlayerId" });
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.Player");
            DropTable("dbo.Team");
            DropTable("dbo.GameInfo");
            DropTable("dbo.GameBattingStat");
        }
    }
}
