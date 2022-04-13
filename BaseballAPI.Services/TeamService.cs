using BaseballAPI.Data;
using BaseballAPI.Models;
using BaseballAPI.Models.TeamModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Services
{
    public class TeamService
    {
        /*private readonly Guid _userId;
        public TeamService(Guid userId)
        {
            _userId = userId;
        }*/
        public bool CreateTeam(TeamCreate model)
        {
            var entity =
                new Team()
                {
                    //OwnerId = _userId,
                    TeamName = model.TeamName,
                    TeamMascot = model.TeamMascot,
                    TeamLocation = model.TeamLocation,
                    TeamStadium = model.TeamStadium,
                    Wins = model.Wins,
                    Losses = model.Losses,
                    CreatedUtc = DateTimeOffset.Now
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Teams.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public bool UpdateTeam(TeamEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Teams
                    .Single(e => e.TeamId == model.TeamId /*&& e.OwnerId == _userId*/);

                entity.TeamId = model.TeamId;
                entity.TeamName = model.TeamName;
                entity.TeamLocation = model.TeamLocation;
                entity.TeamStadium = model.TeamStadium;
                entity.TeamMascot = model.TeamMascot;
                entity.Wins = model.Wins;
                entity.Losses = model.Losses;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteTeam(int teamId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Teams
                    .Single(e => e.TeamId == teamId /*&& e.OwnerId == _userId*/);

                ctx.Teams.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
        public TeamDetail GetTeamById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Teams
                    .Single(e => e.TeamId == id /*&& e.OwnerId == _userId*/);
                return
                    new TeamDetail
                    {
                        TeamId = entity.TeamId,
                        TeamName = entity.TeamName,
                        TeamLocation = entity.TeamLocation,
                        TeamStadium = entity.TeamStadium,
                        TeamMascot = entity.TeamMascot,
                        Wins = entity.Wins,
                        Losses = entity.Losses,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
        public IEnumerable<TeamListItem> GetTeams()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Teams
                    //.Where(e => e.OwnerId == _userId)
                    .Select(e => new TeamListItem
                    {
                        TeamId = e.TeamId,
                        Name = e.Name,
                        Location = e.Location,
                        Stadium = e.Stadium,
                        Mascot = e.Mascot,
                        CreatedUtc = e.CreatedUtc
                    }
            );
                return query.ToArray();
            }
        }
    }
}