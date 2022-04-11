using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Data
{
    public enum Position {Pitcher = 1, Catcher, FirstBase, SecondBase, ThirdBase, ShortStop, LeftFielder, CenterFielder, RightFielder, DesignatedHitter}
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        
        public Guid OwnerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        [Required]
        public string School { get; set; }
        [Required]
        public Position PlayerPosition { get; set; }
        public List<Position> SecondaryPositions { get; set; } = new List<Position>();
        [Required]
        public int JerseyNumber { get; set; }
        [Required]
        public string HomeTown { get; set; }
        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        

        /*public Player (int position, List<int> pos2)
        {
            PlayerPosition = (Position)position;
            foreach(int pos in pos2)
            {
                Position secondary = (Position)pos;
                SecondaryPositions.Add(secondary);
            }
        }*/
    }
}
