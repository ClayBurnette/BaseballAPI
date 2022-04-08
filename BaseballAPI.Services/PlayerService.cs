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
        private readonly Guid _userId;
        public PlayerService(Guid userid)
        {
            _userId = userid;
        }
        public bool CreatePlayer(PlayerCreate model)
        {
            var entity = new Player()
            {
                OwnerId = _userId,
                Name = model.Name,
                School = model.School,
                JeseryNumber = model.JerseyNumber,
                DateOfBirth = model.DateOfBirth,
                HomeTown = model.HomeTown,
                PlayerPosition = (Position)model.PlayerPostition,
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
                var query = ctx.Players.Where(e => e.OwnerId == _userId).Select(e => new PlayerListItem
                {
                    PlayerId = e.PlayerId,
                    Name = e.Name,
                    JeseryNumber = e.JeseryNumber,
                    TeamId = e.TeamId
                }
                );
                return query.ToArray();
            }
        }
        public PlayerDetail GetPlayerById(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Players.Single(e => e.PlayerId == id && e.OwnerId == _userId);
                return
                    new PlayerDetail
                    {
                        PlayerId = entity.PlayerId,
                        Name = entity.Name,
                        Hometown = entity.HomeTown,
                        JeseryNumber = entity.JeseryNumber,
                        TeamId = entity.TeamId,
                        DateOfBirth = entity.DateOfBirth
                    };
            }
        }
        public bool UpdatePlayer(PLayerEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Players.Single(e => e.PlayerId == model.PlayerId && e.OwnerId == _userId);
                entity.Name = model.Name;
                entity.JeseryNumber = model.JeseryNumber;
                entity.TeamId = model.TeamId;
                entity.PlayerPosition = (Position)model.PlayerPosition;
                return ctx.SaveChanges() == 1;

            }
        }
        public bool DeletePlayer(int playerId)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Players.Single(e => e.PlayerId == playerId && e.OwnerId == _userId);
                ctx.Players.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
