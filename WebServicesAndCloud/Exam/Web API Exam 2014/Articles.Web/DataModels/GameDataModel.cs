namespace Articles.Web.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web.Mvc;

    using Articles.Models;

    public class GameDataModel
    {

        public static Expression<Func<Game, GameDataModel>> FromGame
        {
            get
            {
                return a => new GameDataModel
                {
                    ID = a.ID,
                    Name = a.Name,
                    Red = a.RedUser.UserName,
                    Blue = a.BlueUser.UserName,
                    DateCreated = a.DateCreated,
                };
            }
        }


        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string Red { get; set; }

        public string Blue { get; set; }

        public GameState GameState { get; set; }

        public DateTime DateCreated { get; set; }

    }
}