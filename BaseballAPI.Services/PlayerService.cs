using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseballAPI.Data;
using BaseballAPI.Models.PlayerModels;

namespace BaseballAPI.Services
{
    public class PlayerService
    {
        public bool CreatePlayer(PlayerCreate model)
        {
            var entity = new Player()
            {
                Name = model.Name,
                School = model.School,
                JerseyNumber = model.JerseyNumber,
                DateOfBirth = model.DateOfBirth,
                HomeTown = model.HomeTown,
                PlayerPosition = model.PlayerPostition,
                TeamId = model.TeamId,
            };
            using(var ctx = new ApplicationDbContext())
            {
                ctx.Players.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<PlayerListItem> GetPlayers()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var query = ctx.Players.Select(e => new PlayerListItem
                {
                    PlayerId = e.PlayerId,
                    Name = e.Name,
                    JeseryNumber = e.JerseyNumber,
                    TeamId = e.TeamId,
                    PlayerPosition = e.PlayerPosition
                }
                );
                return query.ToArray();
            }
        }
        public PlayerDetail GetPlayerById(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Players.Single(e => e.PlayerId == id);
                return
                    new PlayerDetail
                    {
                        PlayerId = entity.PlayerId,
                        Name = entity.Name,
                        Hometown = entity.HomeTown,
                        JeseryNumber = entity.JerseyNumber,
                        TeamId = entity.TeamId,
                        DateOfBirth = entity.DateOfBirth,
                        PlayerPosition = entity.PlayerPosition
                    };
            }
        }
        public IEnumerable<PlayerListItem> GetPlayerByPosition(Position enumNum)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var query = ctx.Players.Where(e => e.PlayerPosition == enumNum).Select(e => new PlayerListItem
                {
                    PlayerId = e.PlayerId,
                    Name = e.Name,
                    JeseryNumber = e.JerseyNumber,
                    TeamId = e.TeamId,
                    PlayerPosition = e.PlayerPosition
                }
                );
                return query.ToArray();
            }
        }
        public bool UpdatePlayer(PlayerEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Players.Single(e => e.PlayerId == model.PlayerId);
                entity.Name = model.Name;
                entity.JerseyNumber = model.JeseryNumber;
                entity.TeamId = model.TeamId;
                entity.PlayerPosition = model.PlayerPosition;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeletePlayer(int playerId)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.GameBattingStats.Where(s => s.PlayerId == playerId).ToArray();
                foreach(GameBattingStat stat in entity)
                {
                    ctx.GameBattingStats.Remove(stat);
                    ctx.SaveChanges();
                }
                var entity2 = ctx.Players.Single(e => e.PlayerId == playerId);
                ctx.Players.Remove(entity2);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
