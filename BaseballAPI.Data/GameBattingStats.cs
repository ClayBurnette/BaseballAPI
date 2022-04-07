using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Data
{
    public class GameBattingStats
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Player))]
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }
        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        public virtual GameInfo Game { get; set; }
        [Required]
        public int AB { get; set; }
        [Required]
        public int R { get; set; }
        [Required]
        public int H { get; set; }
        [Required]
        public int RBI { get; set; }
        [Required]
        public int BB { get; set; }
        [Required]
        public int PA { get; set; }
        [Required]
        public int TB { get; set; }
        [Required]
        public int SO { get; set; }
        public int HR { get; set; }
        [Display(Name = "2B")]
        public int Double { get; set; }
        [Display(Name = "3B")]
        public int Triple { get; set; }
        public int SAC { get; set; }
        public int HBP { get; set; }
        public int SB { get; set; }
        public int CS { get; set; }
    }
}
