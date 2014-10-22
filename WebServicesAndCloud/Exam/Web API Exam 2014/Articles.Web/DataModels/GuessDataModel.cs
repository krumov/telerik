using Articles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Articles.Web.DataModels
{
    public class GuessDataModel
    {
        public static Expression<Func<Guess, GuessDataModel>> FromGuess
        {
            get
            {
                return guess => new GuessDataModel
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
            }
        }



        public int ID { get; set; }

        public string UserId { get; set; }

        public string Username { get; set; }

        public int GameId { get; set; }

        public int Number { get; set; }

        public DateTime DateMade { get; set; }

        public int CowsCount { get; set; }

        public int BullsCount { get; set; }

    }
}