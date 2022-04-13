using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Data
{
    public class GameInfo
    {
        [Key]
        public int GameId { get; set; }

        //[Required]
        //public Guid OwnerId { get; set; }

        [ForeignKey(nameof(HomeTeam))]
        public int TeamId1 { get; set; }
        public virtual Team HomeTeam { get; set; }

        [ForeignKey(nameof(AwayTeam))]
        public int TeamId2 { get; set; }
        public virtual Team AwayTeam { get; set; }

        [Required]
        [Range(0, int.MaxValue) ]
        public int HomeScore { get; set; }

        [Required]
        [Range(0, int.MaxValue) ]
        public int AwayScore { get; set; }

        [Required]
        public double Innings { get; set; }

        [Required]
        public int SeasonYear { get; set; }

        

        public bool ExtraInnings
        {
            get
            {
                if (Innings > 9)
                    return true;
                return false;
            }

        }
    }
}
