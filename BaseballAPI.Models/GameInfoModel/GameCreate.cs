using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Models.GameInfoModel
{
    public class GameCreate
    {
        [Required]
        public int TeamId1 { get; set; }

        [Required]
        public int TeamId2 { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int HomeScore { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int AwayScore { get; set; }

        [Required]
        public double Innings { get; set; }

        public bool ExtraInnings
        {
            get
            {
                if(Innings > 9)
                    return true;
                return false;
            }
        }

        [Required]
        public int SeasonYear { get; set; }


    }
}
