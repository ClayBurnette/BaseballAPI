using BaseballAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaseballAPI.WebAPI.Controllers
{
    public class SeasonBattingStatController : ApiController
    {
        //Get API Documentation
        /// <summary>
        /// This will return the season stats for an player using the player's ID.<br/>
        /// To get the careet stats for a player, use '0' for the year.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IHttpActionResult Get(int player, int year)
        {
            var service = new GameBattingStatService();
            var stats = service.GetSeasonBattingStat(player,year);
            return Ok(stats);
        }
    }
}
