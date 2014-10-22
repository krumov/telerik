namespace Articles.Web.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web.Mvc;

    using Articles.Models;

    public class CreateGameModel
    {
        
        [Required]
        public int Number { get; set; }

        public string Name { get; set; }


    }
}