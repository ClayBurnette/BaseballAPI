using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Data
{
    public class GameInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public int TeamId1 { get; set; }

        [Required]
        public int TeamId2 { get; set; }

        [Required]
        public int HomeScore { get; set; }

        [Required]
        public int AwayScore { get; set; }

        [Required]
        public double Innings { get; set; }

        

        [Required]
        public int SeasonYear { get; set; }

        

       
        
        
        public bool ExtraInings
        {
           if(Innings > 9) 
            return true;

        }

        








    }
}
