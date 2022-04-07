using BaseballAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Models
{
    public class TeamListItem
    {
        public int TeamId { get; set; }
        public TeamName Name { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
