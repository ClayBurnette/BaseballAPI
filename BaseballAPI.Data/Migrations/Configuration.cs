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
                TeamId = 2
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
                TeamId = 1
            }
            );
            context.Games.AddOrUpdate(x => x.GameId,
                new GameInfo() { GameId = 1, TeamId1 = 1, TeamId2 = 2, HomeScore = 6, AwayScore = 2, Innings = 9, SeasonYear = 2022 });
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
