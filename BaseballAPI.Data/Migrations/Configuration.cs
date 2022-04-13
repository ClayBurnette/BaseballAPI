namespace BaseballAPI.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BaseballAPI.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BaseballAPI.Data.ApplicationDbContext";
        }

        protected override void Seed(BaseballAPI.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Teams.AddOrUpdate(x => x.TeamId,
               new Team() { TeamId = 1, TeamName = "Arizona Diamondbacks", TeamLocation = "Phoenix, Arizona", TeamMascot = "Timmy", TeamStadium = "Phoenix Stadium" },
               new Team() { TeamId = 2, TeamName = "Atlanta Braves", TeamLocation = "Atlanta, GA", TeamMascot = "Homer", TeamStadium = "Sun Trust Stadium" }
                ) ;
            context.Players.AddOrUpdate(p => p.PlayerId, new Player()
            {
                PlayerId = 1,
                Name = "Chris",
                DateOfBirth = "06/28/1999",
                School = "IvyTech",
                PlayerPosition = Position.Catcher,
                JerseyNumber = 26,
                HomeTown = "Speedway",
                TeamId = 1
            }
            );
            context.Players.AddOrUpdate(p => p.PlayerId, new Player()
            {
                PlayerId = 2,
                Name = "Clay",
                DateOfBirth = "07/04/1776",
                School = "NotSure",
                PlayerPosition = Position.FirstBase,
                JerseyNumber = 20,
                HomeTown = "Bloomington",
                TeamId = 2
            }
            );
            context.Players.AddOrUpdate(p => p.PlayerId, new Player()
            {
                PlayerId = 3,
                Name = "William",
                DateOfBirth = "11/20/1526",
                School = "NotSureAgain",
                PlayerPosition = Position.Pitcher,
                JerseyNumber = 15,
                HomeTown = "SomeWhere",
                TeamId = 3
            }
            );
            context.Players.AddOrUpdate(p => p.PlayerId, new Player()
            {
                PlayerId = 4,
                Name = "Stephen",
                DateOfBirth = "08/05/1125",
                School = "NotSureOnceAgain",
                PlayerPosition = Position.ShortStop,
                JerseyNumber = 10,
                HomeTown = "SomeWhereElse",
                TeamId = 4
            }
            );
            context.Games.AddOrUpdate(x => x.GameId,
                new GameInfo() { GameId = 1, TeamId1 = 1, TeamId2 = 2, HomeScore = 6, AwayScore = 2, Innings = 9, SeasonYear = 2022 });
            context.GameBattingStats.AddOrUpdate(x => x.Id,
               new GameBattingStat() { Id = 1, PlayerId = 1, GameId = 1, AB = 4, R = 1, H = 2, RBI = 2, BB = 1, SO = 1, HR = 1, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 }
                );
            context.GameBattingStats.AddOrUpdate(x => x.Id,
               new GameBattingStat() { Id = 1, PlayerId = 2, GameId = 1, AB = 4, R = 0, H = 2, RBI = 1, BB = 0, SO = 0, HR = 0, Double = 1, Triple = 0, SAC = 0, HBP = 0, SB = 1, CS = 0 }
                );
            context.GameBattingStats.AddOrUpdate(x => x.Id,
               new GameBattingStat() { Id = 1, PlayerId = 3, GameId = 1, AB = 3, R = 1, H = 1, RBI = 2, BB = 1, SO = 0, HR = 1, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 }
                );
            context.GameBattingStats.AddOrUpdate(x => x.Id,
               new GameBattingStat() { Id = 1, PlayerId = 4, GameId = 1, AB = 3, R = 1, H = 1, RBI = 2, BB = 1, SO = 0, HR = 1, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 }
                );
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
