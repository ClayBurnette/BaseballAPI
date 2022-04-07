using BaseballAPI.Data;
using BaseballAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Services
{
    public class TeamService
    {
        private readonly Guid _userId;
        public TeamService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateTeam(TeamCreate model)
        {
            var entity =
                new Team()
                {
                    OwnerId = _userId,
                    TeamName = model.TeamName,
                    TeamMascot = model.TeamMascot,
                    TeamLocation = model.TeamLocation,
                    TeamStadium = model.TeamStadium,
                    CreatedUtc = DateTimeOffset.Now
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Teams.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteTeams(int teamId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Teams
                    .Single(e => e.TeamId == teamId && e.OwnerId == _userId);

                ctx.Teams.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<TeamListItem> GetTeamListsItem()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Teams
                    .Where(e => e.OwnerId == _userId)
                    .Select(e => new TeamListItem
                    {
                        TeamId = e.TeamId,
                        Name = e.Name,
                        CreatedUtc = e.CreatedUtc
                    }
            );
                return query.ToArray();
            }
        }
    }

}
