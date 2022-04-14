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
        public IHttpActionResult Get()
        {
            var service = new GameBattingStatService();
            var stats = service.GetAllGameBattingStats();
            return Ok(stats);
        }
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
        public IHttpActionResult Put(GameBattingStatEdit stat)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = new GameBattingStatService();
            if (!service.UpdateGameBattingStat(stat))
                return InternalServerError();
            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = new GameBattingStatService();
            if (!service.DeleteGameBattingStat(id))
                return InternalServerError();
            return Ok();
        }
    }
}
