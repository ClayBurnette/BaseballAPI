using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Models.TeamModels
{
    public class TeamDetail
    {
        [Required]
        public int TeamId { get; set; }
        [Required]
        public string TeamName { get; set; }
        [Required]
        public string TeamLocation { get; set; }
        public string TeamStadium { get; set; }
        public string TeamMascot { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}