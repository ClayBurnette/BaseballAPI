﻿using BaseballAPI.Data;
using BaseballAPI.Models.GameInfoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAPI.Services
{
    public class GameInfoService
    {
        private readonly Guid _userId;

        public GameInfoService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateGameInfo(GameCreate game)
        {
            var gameEntity = new GameInfo()
            {
                //OwnerId = _userId,
                HomeTeamID = game.HomeTeamID,
                AwayTeamID = game.AwayTeamID,
                HomeScore = game.HomeScore,
                AwayScore = game.AwayScore,
                Innings = game.Innings,
                SeasonYear = game.SeasonYear

            };

            using(var gameCTX = new ApplicationDbContext())
            {
                gameCTX.Games.Add(gameEntity);
                return gameCTX.SaveChanges() == 1;
            }
        }

        public IEnumerable<GameListAll> GetAllGameInfo()
        {
            using(var gameCTX = new ApplicationDbContext())
            {
                var gameQuery =
                    gameCTX
                            .Games
                            //.Where(g => g.OwnerId == _userId)
                            .Select(
                             g =>
                                new GameListAll
                                {
                                    GameId = g.GameId,
                                    HomeTeamID = g.HomeTeamID,
                                    AwayTeamID = g.AwayTeamID,
                                    HomeScore = g.HomeScore,
                                    AwayScore = g.AwayScore,
                                    Innings = g.Innings,
                                    SeasonYear = g.SeasonYear
                                }

                               );

                return gameQuery.ToArray();
            }
        }

        public GameDetail GetGameById(int id)
        {
            using(var gameCTX = new ApplicationDbContext())
            {
                var gameEntity =
                    gameCTX
                            .Games
                            .Single(g => g.GameId == id);
                return
                    new GameDetail
                    {
                        GameId = gameEntity.GameId,
                        HomeTeamID = gameEntity.HomeTeamID,
                        AwayTeamID = gameEntity.AwayTeamID,
                        HomeScore = gameEntity.HomeScore,
                        AwayScore = gameEntity.AwayScore,
                        Innings = gameEntity.Innings,
                        SeasonYear = gameEntity.SeasonYear
                    };
            }
        }

        public bool UpdateGameInfo(GameEdit game)
        {
            using(var gameCTX = new ApplicationDbContext())
            {
                var gameEntity =
                   gameCTX
                            .Games
                            .Single(g => g.GameId == game.GameId);

                gameEntity.HomeTeamID = game.HomeTeamID;
                gameEntity.AwayTeamID = game.AwayTeamID;
                gameEntity.HomeScore = game.HomeScore;
                gameEntity.AwayScore = game.AwayScore;
                gameEntity.Innings = game.Innings;
                gameEntity.SeasonYear = game.SeasonYear;

                return gameCTX.SaveChanges() == 1;

            }
        }

        public bool DeleteGame(int gameID)
        {
            using(var gameCTX = new ApplicationDbContext())
            {
                var gameEntity =
                    gameCTX
                            .Games
                            .Single(g => g.GameId == gameID);
                gameCTX.Games.Remove(gameEntity);
                return gameCTX.SaveChanges() == 1;
            }
        }

    }
}
