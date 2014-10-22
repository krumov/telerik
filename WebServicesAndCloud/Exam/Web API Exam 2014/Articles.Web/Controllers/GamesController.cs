namespace Articles.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using Microsoft.AspNet.Identity;

    using Articles.Data;
    using Articles.Models;
    using Articles.Web.DataModels;

    public class GamesController : BaseApiController
    {
        public GamesController(IArticlesData data)
            : base(data)
        {
        }

        [HttpPost]
        [Authorize]
        public IHttpActionResult Create(CreateGameModel model)
        {
            var currentUserID = this.User.Identity.GetUserId();

            var game = new Game
            {
                Name = model.Name,
                RedUserId = currentUserID,
                RedUser = this.data.Users.Find(currentUserID),
                RedNumber = model.Number,
                DateCreated = DateTime.Now,
                GameState = GameState.WaitingForOpponent
            };

            this.data.Games.Add(game);
            this.data.SaveChanges();

            var gameModel = new GameDataModel
            {
                ID = game.ID,
                Name = game.Name,
                Red = game.RedUser.UserName,
                Blue = "No blue player yet",
                GameState = game.GameState,
                DateCreated = game.DateCreated
            };


            return Ok(gameModel);
        }

        [HttpPut]
        [Authorize]
        public IHttpActionResult Put(int id, CreateGameModel model)
        {
            var currentUserID = this.User.Identity.GetUserId();

            var game = this.data.Games.Find(id);
            game.BlueUserId = currentUserID;
            game.BlueUser = this.data.Users.Find(currentUserID);
            game.BlueNumber = model.Number;
            game.GameState = GameState.BlueTurn;
            this.data.SaveChanges();


            return Ok(new {result = string.Format( "You joined game \"{0}\"", game.Name) });
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            return this.All(0);
        }

        [HttpGet]
        public IHttpActionResult All(int page)
        {
            var currentUserID = this.User.Identity.GetUserId();

            if (this.User.Identity.IsAuthenticated)
            {
                var gamesAuth = this.GetAllOrdered()
                .Where(g => g.GameState == GameState.WaitingForOpponent || ((g.GameState == GameState.BlueTurn || g.GameState == GameState.RedTurn) &&
                    (g.RedUserId == currentUserID || g.BlueUserId == currentUserID)))
                  .Skip(10 * page)
                  .Take(10)
                  .Select(GameDataModel.FromGame).ToList();

                return Ok(gamesAuth);
            }
            else
            {
                var games = this.GetAllOrdered().Where(g => g.GameState == GameState.WaitingForOpponent)
                      .Skip(10 * page)
                      .Take(10)
                      .Select(GameDataModel.FromGame).ToList();

                return Ok(games);
            }
        }

        [HttpGet]
        [Authorize]
        public IHttpActionResult GameDetails(int id)
        {
            var game = this.data.Games.Find(id);

            var currentUserID = this.User.Identity.GetUserId();

            string opponentId;

            if (currentUserID == game.RedUserId)
	        {
		        opponentId = game.BlueUserId;
	        }
            else
	        {
                opponentId = game.RedUserId;
	        }

            var gameDetails = new GameDetailsDataModel(game, currentUserID, opponentId);

            return Ok(gameDetails);
        }

        private IQueryable<Game> GetAllOrdered()
        {
            return this.data.Games.All()
                .OrderBy(g => g.GameState).ThenBy(g => g.Name).ThenBy(g => g.DateCreated).ThenBy(g => g.RedUser.UserName);
        }

    }
}
