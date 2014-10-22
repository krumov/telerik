namespace Articles.Web.DataModels
{
    using Articles.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class GameDetailsDataModel
    {
        public GameDetailsDataModel(Game game, string myUserId, string opponentUserId)
        {
            this.ID = game.ID;
            this.Name = game.Name;
            this.RedNumber = game.RedNumber;
            this.BlueNumber = game.BlueNumber;
            this.GameState = game.GameState;
            this.DateCreated = game.DateCreated;
            this.YourGuesses = game.Guesses.AsQueryable().Where(g => g.GameId == game.ID && g.UserId == myUserId).Select(GuessDataModel.FromGuess).ToList();
            this.OpponentGuesses = game.Guesses.AsQueryable().Where(g => g.GameId == game.ID && g.UserId == opponentUserId).Select(GuessDataModel.FromGuess).ToList();
        }


        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int RedNumber { get; set; }

        public int BlueNumber { get; set; }

        public string Red { get; set; }

        public string Blue { get; set; }

        public GameState GameState { get; set; }

        public DateTime DateCreated { get; set; }

        public ICollection<GuessDataModel> YourGuesses { get; set; }

        public ICollection<GuessDataModel> OpponentGuesses { get; set; }
    }
}