using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Data
{
    public enum TeamName
    {
        [Display(Name = "Arizona Diamondbacks")]
        ArizonaDiamondbacks = 1,
        [Display(Name = "Atlanta Braves")]
        AtlantaBraves = 2,
        [Display(Name = "Baltimore Orioles")]
        BaltimoreOrioles = 3,
        [Display(Name = "Boston Red Sox")]
        BostonRedSox = 4,
        [Display(Name = "Chicago White Sox")]
        ChicagoWhiteSox = 5,
        [Display(Name = "Chicago Cubs")]
        ChicagoCubs = 6,
        [Display(Name = "Cincinnati Reds")]
        CincinnatiReds = 7,
        [Display(Name = "Cleveland Indians")]
        ClevelandIndians = 8,
        [Display(Name = "Colorado Rockies")]
        ColoradoRockies = 9,
        [Display(Name = "Detroit Tigers")]
        DetroitTigers = 10,
        [Display(Name = "Houston Astros")]
        HoustonAstros = 11,
        [Display(Name = "Kansas City Royals")]
        KansasCityRoyals = 12,
        [Display(Name = "Los Angeles Angels")]
        LosAngelesAngels = 13,
        [Display(Name = "Los Angeles Dodgers")]
        LosAngelesDodgers = 14,
        [Display(Name = "Miami Marlins")]
        MiamiMarlins = 15,
        [Display(Name = "Milwaukee Brewers")]
        MilwaukeeBrewers = 16,
        [Display(Name = "Minnesota Twins")]
        MinnesotaTwins = 17,
        [Display(Name = "New York Yankees")]
        NewYorkYankees = 18,
        [Display(Name = "New York Mets")]
        NewYorkMets = 19,
        [Display(Name = "Oakland Athletics")]
        OaklandAthletics = 20,
        [Display(Name = "Philadelphia Phillies")]
        PhiladelphiaPhillies = 21,
        [Display(Name = "Pittsburgh Pirates")]
        PittsburghPirates = 22,
        [Display(Name = "San Diego Padres")]
        SanDiegoPadres = 23,
        [Display(Name = "San Francisco Giants")]
        SanFranciscoGiants = 24,
        [Display(Name = "Seattle Mariners")]
        SeattleMariners = 25,
        [Display(Name = "St Louis Cardinals")]
        StLouisCardinals = 26,
        [Display(Name = "Tampa Bay Rays")]
        TampaBayRays = 27,
        [Display(Name = "Texas Rangers")]
        TexasRangers = 28,
        [Display(Name = "Toronto Blue Jays")]
        TorontoBlueJays = 29,
        [Display(Name = "Washington Nationals")]
        WashingtonNationals = 30,
    }
    public enum TeamLocation
    {
        [Display(Name = "Phoenix Arizona")]
        PhoenixArizona = 1,
        [Display(Name = "Cumberland Georgia")]
        CumberlandGeorgia = 2,
        [Display(Name = "Baltimore Maryland")]
        BaltimoreMaryland = 3,
        [Display(Name = "Boston Massachussetts")]
        BostonMassachussetts = 4,
        [Display(Name = "Chicago Illinois")]
        ChicagoIllinois = 5,
        [Display(Name = "Chicago Illinois")]
        ChicagoIllinoisUSA = 6,
        [Display(Name = "Cincinnati Ohio")]
        CincinnatiOhio = 7,
        [Display(Name = "Cleveland Ohio")]
        ClevelandOhio = 8,
        [Display(Name = "Denver Colorado")]
        DenverColorado = 9,
        [Display(Name = "Detroit Michigan")]
        DetroitMichigan = 10,
        [Display(Name = "Houston Texas")]
        HoustonTexas = 11,
        [Display(Name = "Kansas City Missouri")]
        KansasCityMissouri = 12,
        [Display(Name = "Los Angeles California")]
        LosAngelesCalifornia = 13,
        [Display(Name = "Los Angeles California")]
        LosAngelesCaliforniaUSA = 14,
        [Display(Name = "Miami Florida")]
        MiamiFlorida = 15,
        [Display(Name = "Milwaukee Wisconsin")]
        MilwaukeeWisconsin = 16,
        [Display(Name = "Minneapolis Minnesota")]
        MinneapolisMinnesota = 17,
        [Display(Name = "Bronx New York")]
        BronxNewYork = 18,
        [Display(Name = "Queens New York")]
        QueensNewYork = 19,
        [Display(Name = "Oakland California")]
        OaklandCalifornia = 20,
        [Display(Name = "Philadelphia Pennsylvania")]
        PhiladelphiaPennsylvania = 21,
        [Display(Name = "Pittsburgh Pennsylvanie")]
        PittsburghPennsylvanie = 22,
        [Display(Name = "San Diego California")]
        SanDiegoCalifornia = 23,
        [Display(Name = "San Francisco California")]
        SanFranciscoCalifornia = 24,
        [Display(Name = "Seattle Washington")]
        SeattleWashington = 25,
        [Display(Name = "St Louis Missouri")]
        StLouisMissouri = 26,
        [Display(Name = "St Petersburg Florida")]
        StPetersburgFlorida = 27,
        [Display(Name = "Arlington Texas")]
        ArlingtonTexas = 28,
        [Display(Name = "Toronto Ontario")]
        TorontoOntario = 29,
        [Display(Name = "Washington DC")]
        WashingtonDC = 30,
    }
    public enum TeamStadium
    {
        [Display(Name = "Chase Field")]
        ChaseField = 1,
        [Display(Name = "Suntrust Park")]
        SuntrustPark = 2,
        [Display(Name = "Oriole Park At Camden Yards")]
        OrioleParkAtCamdenYards = 3,
        [Display(Name = "Fenway Park")]
        FenwayPark = 4,
        [Display(Name = "Guranteed Rate Field")]
        GuranteedRateField = 5,
        [Display(Name = "Wrigley Field")]
        WrigleyField = 6,
        [Display(Name = "Great American Ball Park")]
        GreatAmericanBallPark = 7,
        [Display(Name = "Progressive Field")]
        ProgressiveField = 8,
        [Display(Name = "Coors Field")]
        CoorsField = 9,
        [Display(Name = "Comerica Park")]
        ComericaPark = 10,
        [Display(Name = "Minute Maid Park")]
        MinuteMaidPark = 11,
        [Display(Name = "Kaufman Stadium")]
        KaufmanStadium = 12,
        [Display(Name = "Angels Stadium")]
        AngelsStadium = 13,
        [Display(Name = "Dodgers Stadium")]
        DodgersStadium = 14,
        [Display(Name = "Marlins Park")]
        MarlinsPark = 15,
        [Display(Name = "Miller Park")]
        MillerPark = 16,
        [Display(Name = "Target Field")]
        TargetField = 17,
        [Display(Name = "Yankee Stadium")]
        YankeeStadium = 18,
        [Display(Name = "Citi Field")]
        CitiField = 19,
        [Display(Name = "Ring Central Coliseum")]
        RingCentralColiseum = 20,
        [Display(Name = "Citizens Bank Park")]
        CitizensBankPark = 21,
        [Display(Name = "PNC Park")]
        PNCPark = 22,
        [Display(Name = "Petco Park")]
        PetcoPark = 23,
        [Display(Name = "Oracle Park")]
        OraclePark = 24,
        [Display(Name = "TMobile Park")]
        TMobilePark = 25,
        [Display(Name = "Busch Stadium")]
        BuschStadium = 26,
        [Display(Name = "Tropicana Field")]
        TropicanaField = 27,
        [Display(Name = "Globe Life Field")]
        GlobeLifeField = 28,
        [Display(Name = "Rogers Centre")]
        RogersCentre = 29,
        [Display(Name = "Nationals Park")]
        NationalsPark = 30,
    }
    public enum TeamMascot
    {
        [Display(Name = "Baxter And Bobcat")]
        BaxterAndBobcat = 1,
        [Display(Name = "Homer")]
        Homer = 2,
        [Display(Name = "The Bird")]
        TheBird = 3,
        [Display(Name = "Wally The Green Monster")]
        WallyTheGreenMonster = 4,
        [Display(Name = "Southpaw")]
        Southpaw = 5,
        [Display(Name = "Clark")]
        Clark = 6,
        [Display(Name = "Gapper")]
        Gapper = 7,
        [Display(Name = "Slider")]
        Slider = 8,
        [Display(Name = "Dinger")]
        Dinger = 9,
        [Display(Name = "Paws")]
        Paws = 10,
        [Display(Name = "Junction Jack")]
        JunctionJack = 11,
        [Display(Name = "Slugerrr")]
        Sluggerrr = 12,
        [Display(Name = "Rally Monkey")]
        RallyMonkey = 13,
        [Display(Name = "Brooklyn And Brix")]
        BrooklynAndBrix = 14,
        [Display(Name = "Billy The Marlin")]
        BillyTheMarlin = 15,
        [Display(Name = "Barrelman")]
        Barrelman = 16,
        [Display(Name = "TCBear")]
        TCBear = 17,
        [Display(Name = "Dandy")]
        Dandy = 18,
        [Display(Name = "Mr Met")]
        MrMet = 19,
        [Display(Name = "Stomper")]
        Stomper = 20,
        [Display(Name = "Phillie Phanatic")]
        PhilliePhanatic = 21,
        [Display(Name = "Pirate Parrot")]
        PirateParrot = 22,
        [Display(Name = "Swinging Friar")]
        SwingingFriar = 23,
        [Display(Name = "Lou Seal")]
        LouSeal = 24,
        [Display(Name = "Mariner Moose")]
        MarinerMoose = 25,
        [Display(Name = "Fredbird")]
        Fredbird = 26,
        [Display(Name = "Raymond")]
        Raymond = 27,
        [Display(Name = "Rangers Captain")]
        RangersCaptain = 28,
        [Display(Name = "Junior")]
        Junior = 29,
        [Display(Name = "The Presidents")]
        ThePresidents = 30,
    }
    public class Team
    {
        public Team() { }
        [Key]
        public int TeamId { get; set; }
        [Required]
        public string TeamName { get; set; }
        [Required]
        public string TeamLocation { get; set; }
        public string TeamMascot { get; set; }
        public string TeamStadium { get; set; }
        public int Wins
        {
            get
            {
                int wins = Games.Where(w => w.HomeTeamID == TeamId && w.HomeScore > w.AwayScore/* || w.AwayTeamID == TeamId && w.AwayScore > w.HomeScore*/).Count();
                int winstwo = Games.Where(w => w.AwayTeamID == TeamId && w.AwayScore > w.HomeScore).Count();
                return wins+winstwo;
            }
        }
        public int Losses
        {
            get
            {
                int losses = Games.Where(l => l.HomeTeamID == TeamId && l.HomeScore > l.AwayScore || l.AwayTeamID == TeamId && l.AwayScore > l.HomeScore).Count();
                return losses;
            }
        }
        public TeamName Name { get; set; }
        public TeamLocation Location { get; set; }
        public TeamStadium Stadium { get; set; }
        public TeamMascot Mascot { get; set; }
        public virtual List<Player> Players { get; set; } = new List<Player>();
        public virtual List<GameInfo> Games { get; set; } = new List<GameInfo>();
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
        public Team(TeamName name, TeamLocation location, TeamStadium stadium, TeamMascot mascot)
        {
            Name = name;
            Location = location;
            Stadium = stadium;
            Mascot = mascot;
        }
    }
}