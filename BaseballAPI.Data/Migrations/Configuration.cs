﻿namespace BaseballAPI.Data.Migrations
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
               new Team() { TeamId = 1 , TeamName = "Arizona Diamondbacks", TeamLocation = "Phoenix Arizona", TeamStadium = "Chase Field", TeamMascot = "Baxter And Bobcat" }
                );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 2, TeamName = "Atlanta Braves", TeamLocation = "Cumberland Georgia", TeamStadium = "Suntrust Park", TeamMascot = "Homer" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 3, TeamName = "Baltimore Orioles", TeamLocation = "Baltimore Maryland", TeamStadium = "Oriole Park At Camden Yards", TeamMascot = "The Bird" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 4, TeamName = "Boston Red Sox", TeamLocation = "Boston Massachussetts", TeamStadium = "Fenway Park", TeamMascot = "Wally The Green Monster" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 5, TeamName = "Chicago White Sox", TeamLocation = "Chicago Illinois", TeamStadium = "Guranteed Rate Field", TeamMascot = "Southpaw" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 6, TeamName = "Chicago Cubs", TeamLocation = "Chicago Illinois", TeamStadium = "Wrigley Field", TeamMascot = "Clark" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 7, TeamName = "Cincinnati Reds", TeamLocation = "Cincinnati Ohio", TeamStadium = "Great American Ball Park", TeamMascot = "Gapper" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 8, TeamName = "Cleveland Indians", TeamLocation = "Cleveland Ohio", TeamStadium = "Progressive Field", TeamMascot = "Slider" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 9, TeamName = "Colorado Rockies", TeamLocation = "Denver Colorado", TeamStadium = "Coors Field", TeamMascot = "Dinger" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 10, TeamName = "Detroit Tigers", TeamLocation = "Detroit Michigan", TeamStadium = "Comerica Park", TeamMascot = "Paws" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 11, TeamName = "Houston Astros", TeamLocation = "Houston Texas", TeamStadium = "Minute Maid Park", TeamMascot = "Junction Jack" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 12, TeamName = "Kansas City Royals", TeamLocation = "Kansas City Missouri", TeamStadium = "Kaufman Stadium", TeamMascot = "Slugerrr" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 13, TeamName = "Los Angeles Angels", TeamLocation = "Los Angeles California", TeamStadium = "Angels Stadium", TeamMascot = "Rally Monkey" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 14, TeamName = "Los Angeles Dodgers", TeamLocation = "Los Angeles California", TeamStadium = "Dodgers Stadium", TeamMascot = "Brooklyn And Brix" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 15, TeamName = "Miami Marlins", TeamLocation = "Miami Florida", TeamStadium = "Marlins Park", TeamMascot = "Billy The Marlin" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 16, TeamName = "Milwaukee Brewers", TeamLocation = "Milwaukee Wisconsin", TeamStadium = "Miller Park", TeamMascot = "Barrelman" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 17, TeamName = "Minnesota Twins", TeamLocation = "Minneapolis Minnesota", TeamStadium = "Target Field", TeamMascot = "TCBear" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 18, TeamName = "New York Yankees", TeamLocation = "Bronx New York", TeamStadium = "Yankee Stadium", TeamMascot = "Dandy" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 19, TeamName = "New York Mets", TeamLocation = "Queens New York", TeamStadium = "Citi Field", TeamMascot = "Mr Met" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 20, TeamName = "Oakland Athletics", TeamLocation = "Oakland California", TeamStadium = "Ring Central Coliseum", TeamMascot = "Stomper" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 21, TeamName = "Philadelphia Phillies", TeamLocation = "Philadelphia Pennsylvania", TeamStadium = "Citizens Bank Park", TeamMascot = "Phillie Phanatic" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 22, TeamName = "Pittsburgh Pirates", TeamLocation = "Pittsburgh Pennsylvania", TeamStadium = "PNC Park", TeamMascot = "Pirate Parrot" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 23, TeamName = "San Diego Padres", TeamLocation = "San Diego California", TeamStadium = "Petco Park", TeamMascot = "Swinging Friar" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 24, TeamName = "San Francisco Giants", TeamLocation = "San Francisco California", TeamStadium = "Oracle Park", TeamMascot = "Lou Seal" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 25, TeamName = "Seattle Mariners", TeamLocation = "Seattle Washington", TeamStadium = "TMobile Park", TeamMascot = "Mariner Moose" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 26, TeamName = "St Louis Cardinals", TeamLocation = "St Louis Missouri", TeamStadium = "Busch Stadium", TeamMascot = "Fredbird" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 27, TeamName = "Tampa Bay Rays", TeamLocation = "St Petersburg Florida", TeamStadium = "Tropicana Field", TeamMascot = "Raymond" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 28, TeamName = "Texas Rangers", TeamLocation = "Arlington Texas", TeamStadium = "Globe Life Field", TeamMascot = "Rangers Captain" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 29, TeamName = "Toronto Blue Jays", TeamLocation = "Toronto Ontario", TeamStadium = "Rogers Centre", TeamMascot = "Junior" }
               );
            context.Teams.AddOrUpdate(x => x.TeamId,
              new Team() { TeamId = 30, TeamName = "Washington Nationals", TeamLocation = "Washington DC", TeamStadium = "Nationals Park", TeamMascot = "The Presidents" }
               );
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}