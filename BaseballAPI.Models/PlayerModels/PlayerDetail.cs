using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseballAPI.Data;

namespace BaseballAPI.Models.PlayerModels
{
    public class PlayerDetail
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Hometown { get; set; }
        public int JeseryNumber { get; set; }
        public int TeamId { get; set; }
        public Position PlayerPosition { get; set; }
        public string DateOfBirth { get; set; }
    }
}
