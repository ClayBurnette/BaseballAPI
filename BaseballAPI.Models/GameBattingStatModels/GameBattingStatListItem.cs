using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Models.GameBattingStatsModels
{
    public class GameBattingStatListItem
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public int AB { get; set; }
        public int R { get; set; }
        public int H { get; set; }
        public int RBI { get; set; }
        public int BB { get; set; }
        public int SO { get; set; }
        public int HR { get; set; }
        public int Double { get; set; }
        public GameBattingStatListItem() { }
        public GameBattingStatListItem(int id, int playerId, int gameId, int ab, int r, int h, int rbi, int bb, int so, int hr, int doub)
        {
            Id = id;
            PlayerId = playerId;
            GameId = gameId;
            AB = ab;
            R = r;
            H = h;
            RBI = rbi;
            BB = bb;
            SO = so;
            HR = hr;
            Double = doub;
        }
    }
}
