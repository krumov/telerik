using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

using Microsoft.AspNet.Identity;

using Articles.Data;
using Articles.Models;
using Articles.Web.DataModels;

namespace Articles.Web.Controllers
{
    public class GuessController : BaseApiController
    {
        public GuessController(IArticlesData data)
            : base(data)
        {
        }

       
        [HttpPost]
        [Authorize]
        public IHttpActionResult Guess(int id , CreateGameModel model)
        {
            var currentUserID = this.User.Identity.GetUserId();
            int cowsCount = 0;
            int bullsCount = 0;

            var guess = new Guess
            {
                    
                UserId = currentUserID,
                User = this.data.Users.Find(currentUserID),
                GameId = id,
                Number = model.Number,
                DateCreated = DateTime.Now,
                CowsCount = cowsCount ,
                BullsCount = bullsCount

            };

            this.data.Guesses.Add(guess);
            this.data.SaveChanges();



            var guessModel = new GuessDataModel
            {
                ID = guess.ID,
                UserId = guess.UserId,
                Username = guess.User.UserName,
                GameId = guess.GameId,
                Number = guess.Number,
                DateMade = guess.DateCreated,
                CowsCount = guess.CowsCount,
                BullsCount = guess.BullsCount

            };

            return Ok(guessModel);
        }

    }
}
