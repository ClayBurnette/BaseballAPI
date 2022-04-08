using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Models.PlayerModels
{
    public class PlayerCreate
    {
        [Required]
        [MaxLength(50, ErrorMessage = "There are too many characters in this field.")]
        public string Name { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Please enter at least six characters in the field.")]
        public string School { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "Please enter at least one number in the field.")]
        [MaxLength(2, ErrorMessage = "There are too many characters in this field.")]
        public int JerseyNumber { get; set; }
        [Required]
        public string HomeTown { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public int PlayerPostition { get; set; }
        public int TeamId { get; set; }
    }
}
