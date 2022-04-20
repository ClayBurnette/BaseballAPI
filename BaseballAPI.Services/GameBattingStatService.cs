using BaseballAPI.Data;
using BaseballAPI.Models.GameBattingStatModels;
using BaseballAPI.Models.GameBattingStatsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Services
{
    public class GameBattingStatService
    {
        public bool CreateGameBattingStat(GameBattingStatCreate model)
        {
            GameBattingStat entity = new GameBattingStat(model.PlayerId, model.GameId, model.AB, model.R, model.H, model.RBI, model.BB, model.SO, model.HR, model.Double, model.Triple, model.SAC, model.HBP, model.SB, model.CS);
            using (var ctx = new ApplicationDbContext())
            {
                ctx.GameBattingStats.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        
           //This method could be used to speed up the process of inputting data into the API
           public bool CreateGameBattingStatXtreme(string[] allStats)
        {
            GameBattingStatCreate model = new GameBattingStatCreate(allStats);
            GameBattingStat entity = new GameBattingStat(model.PlayerId, model.GameId, model.AB, model.R, model.H, model.RBI, model.BB, model.SO, model.HR, model.Double, model.Triple, model.SAC, model.HBP, model.SB, model.CS);
            using (var ctx = new ApplicationDbContext())
            {
                ctx.GameBattingStats.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        
        public IEnumerable<GameBattingStatListItem> GetAllGameBattingStats()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.GameBattingStats.Select(e => new GameBattingStatListItem
                {
                    Id = e.Id,
                    PlayerId = e.PlayerId,
                    GameId = e.GameId,
                    PlayerName = e.Player.Name,
                    AB = e.AB,
                    R = e.R,
                    H = e.H,
                    RBI = e.RBI,
                    BB = e.BB,
                    SO = e.SO,
                    HR = e.HR,
                    Double = e.Double
                }
                );
                return query.ToArray();
            }
        }
        public GameBattingStatDetail GetGameBattingStat(int gbs)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.GameBattingStats.Single(e => e.Id == gbs);
                return
                    new GameBattingStatDetail
                    {
                        Id = entity.Id,
                        PlayerId = entity.PlayerId,
                        GameId = entity.GameId,
                        PlayerName = entity.Player.Name,
                        AB = entity.AB,
                        R = entity.R,
                        H = entity.H,
                        RBI = entity.RBI,
                        BB = entity.BB,
                        SO = entity.SO,
                        HR = entity.HR,
                        Double = entity.Double,
                        Triple = entity.Triple,
                        SAC = entity.SAC,
                        HBP = entity.HBP,
                        SB = entity.SB,
                        CS = entity.CS
                    };
            }
        }
        public SeasonBattingStat GetSeasonBattingStat(int player, int season)
        {
            using (var ctx = new ApplicationDbContext())
            {
                List<GameBattingStat> query = new List<GameBattingStat>();
                if (season == 0)
                {
                    query.AddRange(ctx.GameBattingStats.Where(e => e.PlayerId == player).ToList());
                }
                else
                {
                    query.AddRange(ctx.GameBattingStats.Where(e => e.PlayerId == player && e.Game.SeasonYear == season).ToList());
                }
                var entity = new SeasonBattingStat
                {
                    PlayerId = player,
                    Season = season,
                    PlayerName = query.First().Player.Name,
                    AB = query.Sum(s => s.AB),
                    R = query.Sum(s => s.R),
                    H = query.Sum(s => s.H),
                    RBI = query.Sum(s => s.RBI),
                    BB = query.Sum(s => s.BB),
                    SO = query.Sum(s => s.SO),
                    HR = query.Sum(s => s.HR),
                    Double = query.Sum(s => s.Double),
                    Triple = query.Sum(s => s.Triple),
                    SAC = query.Sum(s => s.SAC),
                    HBP = query.Sum(s => s.HBP),
                    SB = query.Sum(s => s.SB),
                    CS = query.Sum(s => s.CS)
                };
                return entity;
            }
        }
        public IEnumerable<GameBattingStatListItem> GetGBSListByPlayerId(int playerId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.GameBattingStats.Where(e => e.PlayerId == playerId).Select(e => new GameBattingStatListItem
                {
                    Id = e.Id,
                    PlayerId = e.PlayerId,
                    GameId = e.GameId,
                    PlayerName = e.Player.Name,
                    AB = e.AB,
                    R = e.R,
                    H = e.H,
                    RBI = e.RBI,
                    BB = e.BB,
                    SO = e.SO,
                    HR = e.HR,
                    Double = e.Double
                }
                );
                return query.ToArray();
            }
        }
        public IEnumerable<GameBattingStatListItem> GetGBSListByGameId(int gameId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.GameBattingStats.Where(e => e.GameId == gameId).Select(e => new GameBattingStatListItem
                {
                    Id = e.Id,
                    PlayerId = e.PlayerId,
                    GameId = e.GameId,
                    PlayerName = e.Player.Name,
                    AB = e.AB,
                    R = e.R,
                    H = e.H,
                    RBI = e.RBI,
                    BB = e.BB,
                    SO = e.SO,
                    HR = e.HR,
                    Double = e.Double
                }
                );
                return query.ToArray();
            }
        }
        public bool UpdateGameBattingStat(GameBattingStatEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.GameBattingStats.Single(e => e.Id == model.Id);
                entity.PlayerId = model.PlayerId;
                entity.GameId = model.GameId;
                entity.AB = model.AB;
                entity.R = model.R;
                entity.H = model.H;
                entity.RBI = model.RBI;
                entity.BB = model.BB;
                entity.SO = model.SO;
                entity.HR = model.HR;
                entity.Double = model.Double;
                entity.Triple = model.Triple;
                entity.SAC = model.SAC;
                entity.HBP = model.HBP;
                entity.SB = model.SB;
                entity.CS = model.CS;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteGameBattingStat(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.GameBattingStats.Single(e => e.Id == id);
                ctx.GameBattingStats.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
