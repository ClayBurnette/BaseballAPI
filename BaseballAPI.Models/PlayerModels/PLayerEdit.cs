using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseballAPI.Data;

namespace BaseballAPI.Models.PlayerModels
{
    public class PlayerEdit
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int JeseryNumber { get; set; }
        public int TeamId { get; set; }
        public Position PlayerPosition { get; set; }
    }
}
