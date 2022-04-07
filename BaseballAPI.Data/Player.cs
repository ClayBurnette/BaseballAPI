using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Data
{
    public enum Position { Catcher, FirstBase, SecondBase, ThirdBase, ShortStop, LeftFielder, CenterFielder, RightFielder}
    public enum SecondPosition { Catcher, FirstBase, SecondBase, ThirdBase, ShortStop, LeftFielder, CenterFielder, RightFielder }
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTimeOffset DateTimeOffset { get; set; }
        [Required]
        public string School { get; set; }
        [Required]
        public Position PlayerPosition { get; set; }
        public SecondPosition PlayerPosition2 { get; set; }
        [Required]
        public int JeseryNumber { get; set; }
        [Required]
        public string HomeTown { get; set; }
        [ForeignKey(nameof(team))]
        public int TeamId { get; set; }
        public virtual Team team { get; set; }
        public virtual List<GameBattingStats> stats { get; set; }
    }
}
