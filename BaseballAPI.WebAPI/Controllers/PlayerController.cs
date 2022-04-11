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
    public class PlayerController : ApiController
    {
        //Create
        private PlayerService CreatePlayerService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var playerService = new PlayerService(userId);
            return playerService;
        }
        //Get All
        public IHttpActionResult Get()
        {
            PlayerService playerService = CreatePlayerService();
            var player = playerService.GetPlayers();
            return Ok(player);
        }
        //Post
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
            return Ok();
        }
        //Get By Id
        public IHttpActionResult Get(int id)
        {
            PlayerService playerService = CreatePlayerService();
            var player = playerService.GetPlayerById(id);
            return Ok(player);
        }
        //Get By Position
        public IHttpActionResult GetByPosition(int positionNum)
        {
            PlayerService playerService = CreatePlayerService();
            var player = playerService.GetPlayerByPosition(positionNum);
            return Ok(player);
        }
        //Put
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
            return Ok();
        }
        //Delete
        public IHttpActionResult Delete(int id)
        {
            var service = CreatePlayerService();
            if (!service.DeletePlayer(id))
            {
                return InternalServerError();
            }
            return Ok();
        }
    }
}
