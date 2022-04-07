using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Models
{
    public class TeamCreate
    {   [Required]
        [MinLength(5, ErrorMessage = "Please Enter At Least 5 Characters.")]
        [MaxLength(100, ErrorMessage ="There Are Too Many Characters In This Field.")]
        public string TeamName { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Please Enter At Least 5 Characters.")]
        [MaxLength(100, ErrorMessage = "There Are Too Many Characters In This Field.")]
        public string TeamLocation { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Please Enter At Least 5 Characters.")]
        [MaxLength(100, ErrorMessage = "There Are Too Many Characters In This Field.")]
        public string TeamMascot { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Please Enter At Least 5 Characters.")]
        [MaxLength(100, ErrorMessage = "There Are Too Many Characters In This Field.")]
        public string TeamStadium { get; set; }
    }
}
