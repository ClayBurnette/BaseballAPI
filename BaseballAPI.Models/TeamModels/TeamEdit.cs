using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Models.TeamModels
{
    public class TeamEdit
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamLocation { get; set; }
        public string TeamStadium { get; set; }
        public string TeamMascot { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
    }
}