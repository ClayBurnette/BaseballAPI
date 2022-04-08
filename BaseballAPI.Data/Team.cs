using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Data
{
    public enum TeamName
    {
        ArizonaDiamondbacks = 1,
        AtlantaBraves = 2,
        BaltimoreOrioles = 3,
        BostonRedSox = 4,
        ChicagoWhiteSox = 5,
        ChicagoCubs = 6,
        CincinnatiReds = 7,
        ClevelandIndians = 8,
        ColoradoRockies = 9,
        DetroitTigers = 10,
        HoustonAstros = 11,
        KansasCityRoyals = 12,
        LosAngelesAngels = 13,
        LosAngelesDodgers = 14,
        MiamiMarlins = 15,
        MilwaukeeBrewers = 16,
        MinnesotaTwins = 17,
        NewYorkYankees = 18,
        NewYorkMets = 19,
        OaklandAthletics = 20,
        PhiladelphiaPhillies = 21,
        PittsburghPirates = 22,
        SanDiegoPadres = 23,
        SanFranciscoGiants = 24,
        SeattleMariners = 25,
        StLouisCardinals = 26,
        TampaBayRays = 27,
        TexasRangers = 28,
        TorontoBlueJays = 29,
        WashingtonNationals = 30,
    }
    public enum TeamLocation
    {
        PhoenixArizona = 1,
        CumberlandGeorgia = 2,
        BaltimoreMaryland = 3,
        BostonMassachussetts = 4,
        ChicagoIllinois = 5,
        ChicagoIllinoisUSA = 6,
        CincinnatiOhio = 7,
        ClevelandOhio = 8,
        DenverColorado = 9,
        DetroitMichigan = 10,
        HoustonTexas = 11,
        KansasCityMissouri = 12,
        LosAngelesCalifornia = 13,
        LosAngelesCaliforniaUSA = 14,
        MiamiFlorida = 15,
        MilwaukeeWisconsin = 16,
        MinneapolisMinnesota = 17,
        BronxNewYork = 18,
        QueensNewYork = 19,
        OaklandCalifornia = 20,
        PhiladelphiaPennsylvania = 21,
        PittsburghPennsylvanie = 22,
        SanDiegoCalifornia = 23,
        SanFranciscoCalifornia = 24,
        SeattleWashington = 25,
        StLouisMissouri = 26,
        StPetersburgFlorida = 27,
        ArlingtonTexas = 28,
        TorontoOntario = 29,
        WashingtonDC = 30,
    }
    public enum TeamMascot
    {
        BaxterAndBobcat = 1,
        Homer = 2,
        TheBird = 3,
        WallyTheGreenMonster = 4,
        Southpaw = 5,
        Clark = 6,
        Gapper = 7,
        Slider = 8,
        Dinger = 9,
        Paws = 10,
        JunctionJack = 11,
        Sluggerrr = 12,
        RallyMonkey = 13,
        BrooklynAndBrix = 14,
        BillyTheMarlin = 15,
        Barrelman = 16,
        TCBear = 17,
        Dandy = 18,
        MrMet = 19,
        Stomper = 20,
        PhilliePhanatic = 21,
        PirateParrot = 22,
        SwingingFriar = 23,
        LouSeal = 24,
        MarinerMoose = 25,
        Fredbird = 26,
        Raymond = 27,
        RangersCaptain = 28,
        Junior = 29,
        ThePresidents = 30,
    }
    public enum TeamStadium
    {
        ChaseField = 1,
        SuntrustPark = 2,
        OrioleParkAtCamdenYards = 3,
        FenwayPark = 4,
        GuranteedRateField = 5,
        WrigleyField = 6,
        GreatAmericanBallPark = 7,
        ProgressiveField = 8,
        CoorsField = 9,
        ComericaPark = 10,
        MinuteMaidPark = 11,
        KaufmanStadium = 12,
        AngelsStadium = 13,
        DodgersStadium = 14,
        MarlinsPark = 15,
        MillerPark = 16,
        TargetField = 17,
        YankeeStadium = 18,
        CitiField = 19,
        RingCentralColiseum = 20,
        CitizensBankPark = 21,
        PNCPark = 22,
        PetcoPark = 23,
        OraclePark = 24,
        TMobilePark = 25,
        BuschStadium = 26,
        TropicanaField = 27,
        GlobeLifeField = 28,
        RogersCentre = 29,
        NationalsPark = 30,
    }
    public class Team
    {
        public Team() { }
        [Key]
        public int TeamId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string TeamName { get; set; }
        [Required]
        public string TeamLocation { get; set; }
        public string TeamMascot { get; set; }
        public string TeamStadium { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public TeamName Name { get; set; }
        public TeamLocation Location { get; set; }
        public TeamMascot Mascot { get; set; }
        public TeamStadium Stadium { get; set; }
        public virtual List<Player> Players { get; set; } = new List<Player>();
        public virtual List<GameInfo> Games { get; set; } = new List<GameInfo>();
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}