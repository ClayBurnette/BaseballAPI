using BaseballAPI.Models.GameInfoModel;
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
    public class GameController : ApiController
    {
        private GameInfoService CreateGameInfoService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var gameService = new GameInfoService(userId);
            return gameService;
        }

        
        //Get api/documentation
        /// <summary>
        /// This will get all the games info in chronological order
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAllGameInfo()
        {
            GameInfoService gameService = CreateGameInfoService();
            var games = gameService.GetAllGameInfo();
            return Ok(games);

        }

        //Get api/documentation
        /// <summary>
        /// This will give a single game info by giving an existing id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult GetGameInfoById(int id)
        {
            GameInfoService gameService = CreateGameInfoService();
            var game = gameService.GetGameById(id);
            return Ok(game);
        }

        //Get api/documentation
        /// <summary>
        /// This will display a team's game infos when they are the home team
        /// </summary>
        /// <param name="homeTeamId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GameInfo/homeTeamId", Name = "GetByHomeTeamId")]
        public IHttpActionResult GetGameInfoByHomeTeamId(int homeTeamId)
        {
            GameInfoService gameService = CreateGameInfoService();
            var game = gameService.GetGameByHomeTeamId(homeTeamId);
            return Ok(game);
        }

        //Get api/documentation
        /// <summary>
        /// This will display a team's game infos when they are the away team
        /// </summary>
        /// <param name="awayTeamId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GameInfo/awayTeamId", Name = "GetByAwayTeamId")]
        public IHttpActionResult GetGameInfoByAwayTeamId(int awayTeamId)
        {
            GameInfoService gameService = CreateGameInfoService();
            var game = gameService.GetGameByAwayTeamId(awayTeamId);
            return Ok(game);
        }

        //Post api/documentation
        /// <summary>
        /// This allow you to create a game; you will need two existing team ids
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        public IHttpActionResult GamePost(GameCreate game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var gameService = CreateGameInfoService();

            if (!gameService.CreateGameInfo(game))
                return InternalServerError();
            return Ok();
        }

        //Put api/documentation
        /// <summary>
        /// This will allow you to update a game
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        public IHttpActionResult PutGameInfo(GameEdit game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var gameService = CreateGameInfoService();

            if (!gameService.UpdateGameInfo(game))
                return InternalServerError();
            return Ok();
        }

        //Delete api/documentation
        /// <summary>
        /// This will allow you to delete a game; just need existing game id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult DeleteGame(int id)
        {
            var gameService = CreateGameInfoService();
            if (!gameService.DeleteGame(id))
                return InternalServerError();
            return Ok();
        }



    }
}
