using BaseballAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Models
{
    public class TeamListItem
    {
        public int TeamId { get; set; }
        public TeamName Name { get; set; }
        public TeamLocation Location { get; set; }
        public TeamStadium Stadium { get; set; }
        public TeamMascot Mascot { get; set; }
        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}