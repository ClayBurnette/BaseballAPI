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
        public string Name { get; set; }
        public string Location { get; set; }
        public string Stadium { get; set; }
        public string Mascot { get; set; }
        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}