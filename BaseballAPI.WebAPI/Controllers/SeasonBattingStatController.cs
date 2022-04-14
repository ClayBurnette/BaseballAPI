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
        public IHttpActionResult Get(int player, int year)
        {
            var service = new GameBattingStatService();
            var stats = service.GetSeasonBattingStat(player,year);
            return Ok(stats);
        }
    }
}
