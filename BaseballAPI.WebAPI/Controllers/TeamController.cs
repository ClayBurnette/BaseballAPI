using BaseballAPI.Models;
using BaseballAPI.Models.TeamModels;
using BaseballAPI.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaseballAPI.WebAPI.Controllers
{
    [Authorize]
    public class TeamController : ApiController
    {
        // Get api /documentation
        /// <summary>
        /// This will get all teams.
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult Get()
        {
            TeamService teamService = CreateTeamService();
            var teams = teamService.GetTeams();
            return Ok(teams);
        }
        // Get api /documentation
        /// <summary>
        /// Thgis will get all teams by ID numbers.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Get(int id)
        {
            TeamService teamService = CreateTeamService();
            var teams = teamService.GetTeamById(id);
            return Ok(teams);
        }
        // Post api /documentation
        /// <summary>
        /// This will post a teams information.
        /// </summary>
        /// <param name="team"></param>
        /// <returns></returns>
        public IHttpActionResult Post(TeamCreate team)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateTeamService();

            if (!service.CreateTeam(team))
                return InternalServerError();

            return Ok();
        }
        // Put api /documentation
        /// <summary>
        /// This will put changed information into the team you want to edit.
        /// </summary>
        /// <param name="team"></param>
        /// <returns></returns>
        public IHttpActionResult Put(TeamEdit team)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateTeamService();

            if (!service.UpdateTeam(team))
                return InternalServerError();

            return Ok();
        }
        // Delete api /documentation
        /// <summary>
        /// This will delete a team.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Delete(int id)
        {
            var service = CreateTeamService();

            if (!service.DeleteTeam(id))
                return InternalServerError();

            return Ok();
        }
        private TeamService CreateTeamService()
        {
            //var userId = Guid.Parse(User.Identity.GetUserId());
            var teamService = new TeamService();
            return teamService;
        }
    }
}