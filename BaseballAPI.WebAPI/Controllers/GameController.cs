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

        public IHttpActionResult GetAllGameInfo()
        {
            GameInfoService gameService = CreateGameInfoService();
            var games = gameService.GetAllGameInfo();
            return Ok(games);

        }

        public IHttpActionResult GetGameInfoById(int id)
        {
            GameInfoService gameService = CreateGameInfoService();
            var game = gameService.GetGameById(id);
            return Ok(game);
        }

        public IHttpActionResult GamePost(GameCreate game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var gameService = CreateGameInfoService();

            if (!gameService.CreateGameInfo(game))
                return InternalServerError();
            return Ok();
        }

        public IHttpActionResult PutGameInfo(GameEdit game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var gameService = CreateGameInfoService();

            if (!gameService.UpdateGameInfo(game))
                return InternalServerError();
            return Ok();
        }

        public IHttpActionResult DeleteGame(int id)
        {
            var gameService = CreateGameInfoService();
            if (!gameService.DeleteGame(id))
                return InternalServerError();
            return Ok();
        }



    }
}
