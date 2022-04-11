using BaseballAPI.Data;
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
        public IEnumerable<GameBattingStatListItem> GetAllGameBattingStats()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.GameBattingStats.Select(e => new GameBattingStatListItem
                {
                    Id = e.Id,
                    PlayerId = e.PlayerId,
                    GameId = e.GameId,
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
        public IEnumerable<GameBattingStatListItem> GetGBSListByPlayerId(int playerId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.GameBattingStats.Where(e => e.PlayerId == playerId).Select(e => new GameBattingStatListItem
                {
                    Id = e.Id,
                    PlayerId = e.PlayerId,
                    GameId = e.GameId,
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
