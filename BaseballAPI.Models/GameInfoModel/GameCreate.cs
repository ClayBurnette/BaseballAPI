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
        public int HomeTeamID { get; set; }

        [Required]
        public int AwayTeamID { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int HomeScore { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int AwayScore { get; set; }

        [Required]
        public double Innings { get; set; }

        
        [Required]
        public int SeasonYear { get; set; }


    }
}
