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
        }

        protected override void Seed(BaseballAPI.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Teams.AddOrUpdate(x => x.TeamId,
            new Team() { TeamId = 1, TeamName = "Arizona Diamondbacks", TeamLocation = "Phoenix Arizona", TeamStadium = "Chase Field", TeamMascot = "Baxter And Bobcat" }
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
            context.Players.AddOrUpdate(p => p.PlayerId, new Player()
            {
                PlayerId = 1,
                Name = "Juan Soto",
                DateOfBirth = "10/25/1998",
                School = "International",
                PlayerPosition = Position.RightFielder,
                JerseyNumber = 22,
                HomeTown = "Santo Domingo, Dominican Republic",
                TeamId = 30
            },
            new Player()
            {
                PlayerId = 2,
                Name = "Seiya Suzuki",
                DateOfBirth = "08/18/1994",
                School = "International",
                PlayerPosition = Position.RightFielder,
                JerseyNumber = 27,
                HomeTown = "Arakawa, Japan",
                TeamId = 6
            },
            new Player()
            {
                PlayerId = 3,
                Name = "Javier Baez",
                DateOfBirth = "12/01/1992",
                School = "Arlington County Day School",
                PlayerPosition = Position.ShortStop,
                JerseyNumber = 28,
                HomeTown = "Bayamon, Puerto Rico",
                TeamId = 10
            },
             new Player()
             {
                 PlayerId = 4,
                 Name = "Luis Robert",
                 DateOfBirth = "08/03/1997",
                 School = "International",
                 PlayerPosition = Position.CenterFielder,
                 JerseyNumber = 88,
                 HomeTown = "Ciego de Avila, Cuba",
                 TeamId = 5
             },
             new Player()
             {
                 PlayerId = 5,
                 Name = "Wander Franco",
                 DateOfBirth = "03/01/2001",
                 School = "International",
                 PlayerPosition = Position.ShortStop,
                 JerseyNumber = 5,
                 HomeTown = "Bani, Dominican Republic",
                 TeamId = 27
             }
            );
            context.Games.AddOrUpdate(x => x.GameId,
                new GameInfo() { GameId = 1, HomeTeamID = 6, AwayTeamID = 16, HomeScore = 5, AwayScore = 4, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 2, HomeTeamID = 6, AwayTeamID = 16, HomeScore = 9, AwayScore = 0, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 3, HomeTeamID = 6, AwayTeamID = 16, HomeScore = 4, AwayScore = 5, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 4, HomeTeamID = 22, AwayTeamID = 6, HomeScore = 1, AwayScore = 2, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 5, HomeTeamID = 22, AwayTeamID = 6, HomeScore = 6, AwayScore = 2, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 6, HomeTeamID = 30, AwayTeamID = 19, HomeScore = 1, AwayScore = 5, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 7, HomeTeamID = 30, AwayTeamID = 19, HomeScore = 3, AwayScore = 7, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 8, HomeTeamID = 30, AwayTeamID = 19, HomeScore = 0, AwayScore = 5, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 9, HomeTeamID = 30, AwayTeamID = 19, HomeScore = 4, AwayScore = 2, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 10, HomeTeamID = 2, AwayTeamID = 30, HomeScore = 11, AwayScore = 2, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 11, HomeTeamID = 2, AwayTeamID = 30, HomeScore = 4, AwayScore = 16, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 12, HomeTeamID = 2, AwayTeamID = 30, HomeScore = 3, AwayScore = 1, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 13, HomeTeamID = 10, AwayTeamID = 5, HomeScore = 5, AwayScore = 4, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 14, HomeTeamID = 10, AwayTeamID = 5, HomeScore = 2, AwayScore = 5, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 15, HomeTeamID = 10, AwayTeamID = 5, HomeScore = 1, AwayScore = 10, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 16, HomeTeamID = 5, AwayTeamID = 25, HomeScore = 3, AwayScore = 2, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 17, HomeTeamID = 5, AwayTeamID = 25, HomeScore = 6, AwayScore = 4, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 18, HomeTeamID = 10, AwayTeamID = 4, HomeScore = 3, AwayScore = 1, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 19, HomeTeamID = 10, AwayTeamID = 4, HomeScore = 3, AwayScore = 5, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 20, HomeTeamID = 10, AwayTeamID = 4, HomeScore = 7, AwayScore = 9, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 21, HomeTeamID = 27, AwayTeamID = 3, HomeScore = 2, AwayScore = 1, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 22, HomeTeamID = 27, AwayTeamID = 3, HomeScore = 5, AwayScore = 3, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 23, HomeTeamID = 27, AwayTeamID = 3, HomeScore = 8, AwayScore = 0, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 24, HomeTeamID = 27, AwayTeamID = 20, HomeScore = 2, AwayScore = 13, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 25, HomeTeamID = 27, AwayTeamID = 20, HomeScore = 9, AwayScore = 8, Innings = 10, SeasonYear = 2022 },
                new GameInfo() { GameId = 26, HomeTeamID = 27, AwayTeamID = 20, HomeScore = 2, AwayScore = 4, Innings = 9, SeasonYear = 2022 },
                new GameInfo() { GameId = 27, HomeTeamID = 7, AwayTeamID = 30, HomeScore = 2, AwayScore = 3, Innings = 9, SeasonYear = 2021 }
                );
            context.GameBattingStats.AddOrUpdate(x => x.Id,
               new GameBattingStat() { Id = 1, PlayerId = 2, GameId = 1, AB = 2, R = 1, H = 1, RBI = 0, BB = 2, SO = 1, HR = 0, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 2, PlayerId = 2, GameId = 2, AB = 3, R = 0, H = 1, RBI = 3, BB = 1, SO = 2, HR = 0, Double = 0, Triple = 0, SAC = 1, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 3, PlayerId = 2, GameId = 3, AB = 3, R = 1, H = 1, RBI = 3, BB = 1, SO = 1, HR = 1, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 4, PlayerId = 2, GameId = 4, AB = 4, R = 2, H = 2, RBI = 2, BB = 0, SO = 1, HR = 2, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 5, PlayerId = 2, GameId = 5, AB = 3, R = 0, H = 1, RBI = 1, BB = 1, SO = 0, HR = 0, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 6, PlayerId = 1, GameId = 6, AB = 3, R = 1, H = 1, RBI = 1, BB = 1, SO = 1, HR = 1, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 7, PlayerId = 1, GameId = 7, AB = 3, R = 0, H = 0, RBI = 0, BB = 1, SO = 0, HR = 0, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 8, PlayerId = 1, GameId = 8, AB = 4, R = 0, H = 2, RBI = 0, BB = 0, SO = 1, HR = 0, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 9, PlayerId = 1, GameId = 9, AB = 4, R = 0, H = 0, RBI = 0, BB = 0, SO = 0, HR = 0, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 10, PlayerId = 1, GameId = 10, AB = 4, R = 1, H = 1, RBI = 0, BB = 2, SO = 0, HR = 0, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 11, PlayerId = 1, GameId = 11, AB = 3, R = 1, H = 2, RBI = 1, BB = 1, SO = 0, HR = 1, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 12, PlayerId = 1, GameId = 12, AB = 4, R = 1, H = 1, RBI = 0, BB = 0, SO = 1, HR = 0, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 13, PlayerId = 3, GameId = 13, AB = 5, R = 0, H = 2, RBI = 1, BB = 0, SO = 2, HR = 0, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 14, PlayerId = 3, GameId = 14, AB = 4, R = 0, H = 2, RBI = 0, BB = 0, SO = 1, HR = 0, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 15, PlayerId = 3, GameId = 15, AB = 3, R = 0, H = 0, RBI = 0, BB = 0, SO = 0, HR = 0, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 16, PlayerId = 3, GameId = 18, AB = 3, R = 1, H = 1, RBI = 2, BB = 1, SO = 0, HR = 1, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 17, PlayerId = 3, GameId = 19, AB = 4, R = 0, H = 1, RBI = 1, BB = 0, SO = 1, HR = 0, Double = 1, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 18, PlayerId = 4, GameId = 13, AB = 4, R = 0, H = 2, RBI = 1, BB = 0, SO = 0, HR = 0, Double = 1, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 19, PlayerId = 4, GameId = 14, AB = 4, R = 1, H = 2, RBI = 0, BB = 0, SO = 0, HR = 0, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 1, CS = 0 },
               new GameBattingStat() { Id = 20, PlayerId = 4, GameId = 15, AB = 5, R = 2, H = 1, RBI = 0, BB = 0, SO = 0, HR = 0, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 1, CS = 0 },
               new GameBattingStat() { Id = 21, PlayerId = 4, GameId = 16, AB = 3, R = 2, H = 1, RBI = 1, BB = 1, SO = 1, HR = 1, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 2, CS = 0 },
               new GameBattingStat() { Id = 22, PlayerId = 4, GameId = 17, AB = 4, R = 1, H = 1, RBI = 1, BB = 0, SO = 0, HR = 1, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 23, PlayerId = 5, GameId = 21, AB = 4, R = 0, H = 3, RBI = 0, BB = 0, SO = 0, HR = 0, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 24, PlayerId = 5, GameId = 22, AB = 3, R = 0, H = 0, RBI = 1, BB = 0, SO = 1, HR = 0, Double = 0, Triple = 0, SAC = 1, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 25, PlayerId = 5, GameId = 23, AB = 4, R = 1, H = 3, RBI = 2, BB = 0, SO = 1, HR = 0, Double = 1, Triple = 0, SAC = 0, HBP = 0, SB = 1, CS = 0 },
               new GameBattingStat() { Id = 26, PlayerId = 5, GameId = 24, AB = 4, R = 2, H = 3, RBI = 0, BB = 0, SO = 0, HR = 0, Double = 1, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 27, PlayerId = 5, GameId = 25, AB = 5, R = 2, H = 2, RBI = 1, BB = 1, SO = 1, HR = 0, Double = 1, Triple = 1, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 28, PlayerId = 5, GameId = 26, AB = 5, R = 0, H = 0, RBI = 0, BB = 0, SO = 0, HR = 0, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 },
               new GameBattingStat() { Id = 29, PlayerId = 1, GameId = 27, AB = 3, R = 2, H = 3, RBI = 2, BB = 1, SO = 0, HR = 2, Double = 0, Triple = 0, SAC = 0, HBP = 0, SB = 0, CS = 0 }
                );
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
