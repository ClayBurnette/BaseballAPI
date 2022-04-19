using BaseballAPI.Models.GameBattingStatsModels;
using BaseballAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaseballAPI.WebAPI.Controllers
{
    [Authorize]
    public class GameBattingStatController : ApiController
    {
        // Post Documentation
        /// <summary>
        /// This will create a new batting stat log for a player in a specific game.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IHttpActionResult Post(GameBattingStatCreate model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = new GameBattingStatService();
            if (!service.CreateGameBattingStat(model))
                return InternalServerError();
            return Ok();
        }

        /*public IHttpActionResult Post(string allStats)
        {
            string[] statArray = allStats.Split('/');
            if (statArray.Length != 15)
                return BadRequest("Requires 15 int inputs");
            var service = new GameBattingStatService();
            if (!service.CreateGameBattingStatXtreme(statArray))
                return InternalServerError();
            return Ok();
        }*/

        // Get API Documentation
        /// <summary>
        /// This will get a list of all batting stat logs in the database.
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult Get()
        {
            var service = new GameBattingStatService();
            var stats = service.GetAllGameBattingStats();
            return Ok(stats);
        }

        // Get(string, id) API Documentation
        /// <summary>
        /// This has 3 different search options depending on the keyword used.<br/>
        /// STAT: Returns an individual listing of a game batting stat from the database.<br/>
        /// PLAYER: Returns a list of all stat logs for a specific player.<br/>
        /// GAME: Returns a list of all the stat logs recorded for an individual game.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Get(string type, int id)
        {
            var service = new GameBattingStatService();
            if (type.ToLower() == "stat")
            {
                var stats = service.GetGameBattingStat(id);
                return Ok(stats);
            }
            if (type.ToLower() == "game")
            {
                var stats = service.GetGBSListByGameId(id);
                return Ok(stats);
            }
            if (type.ToLower() == "player")
            {
                var stats = service.GetGBSListByPlayerId(id);
                return Ok(stats);
            }
            return BadRequest("Invalid query type (stat, game, player)");
        }

        //Put API Documentation
        /// <summary>
        /// This allows you to update an existing batting stat log.
        /// </summary>
        /// <param name="stat"></param>
        /// <returns></returns>
        public IHttpActionResult Put(GameBattingStatEdit stat)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = new GameBattingStatService();
            if (!service.UpdateGameBattingStat(stat))
                return InternalServerError();
            return Ok();
        }

        //Delete API Documentation
        /// <summary>
        /// This allows you to delete a recorded batting stat log.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Delete(int id)
        {
            var service = new GameBattingStatService();
            if (!service.DeleteGameBattingStat(id))
                return InternalServerError();
            return Ok();
        }
    }
}
