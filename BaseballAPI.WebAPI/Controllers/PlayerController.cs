using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BaseballAPI.Data;
using BaseballAPI.Models.PlayerModels;
using BaseballAPI.Services;
using Microsoft.AspNet.Identity;

namespace BaseballAPI.WebAPI.Controllers
{
    [Authorize]
    public class PlayerController : ApiController
    {
        //Create
        private PlayerService CreatePlayerService()
        {
            //var userId = Guid.Parse(User.Identity.GetUserId());
            var playerService = new PlayerService();
            return playerService;
        }
        //Get api/documentation
        /// <summary>
        /// This will get all players in the database.
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult Get()
        {
            PlayerService playerService = CreatePlayerService();
            var player = playerService.GetPlayers();
            return Ok(player);
        }
        //Post api/documentation
        /// <summary>
        /// This will allow you to add a new player to the database.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public IHttpActionResult Post(PlayerCreate player)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var service = CreatePlayerService();

            if (!service.CreatePlayer(player))
            {
                return InternalServerError();
            }
            return Ok($"{player.Name} was successfully added to the list!");
        }
        //Get By Id api/documentation
        /// <summary>
        /// Here you can search for a specific player by their id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult GetById(int id)
        {
            PlayerService playerService = CreatePlayerService();
            var player = playerService.GetPlayerById(id);
            return Ok(player);
        }
        //Get By Position api/documentation
        /// <summary>
        /// Here you can search for all players in a specific position.
        /// </summary>
        /// <param name="positionNum"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Player/positionNum", Name = "GetByPosition")]
        public IHttpActionResult GetByPosition(Position positionNum)
        {
            PlayerService playerService = CreatePlayerService();
            var player = playerService.GetPlayerByPosition(positionNum);
            return Ok(player);
        }
        //Put api/documentation
        /// <summary>
        /// This will allow you to update each player.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public IHttpActionResult Put(PlayerEdit player)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var service = CreatePlayerService();
            if (!service.UpdatePlayer(player))
            {
                return InternalServerError();
            }
            return Ok($"{player.Name} was successfully updated!");
        }
        //Delete api/documentation
        /// <summary>
        /// This is used to delete a player by their id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Delete(int id)
        {
            var service = CreatePlayerService();
            var player = service.GetPlayerById(id);
            if (!service.DeletePlayer(id))
            {
                return InternalServerError();
            }
            return Ok($"{player.Name} was successfully deleted!");
        }
    }
}
