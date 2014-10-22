namespace Articles.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Game
    {
        private ICollection<Guess> guesses;

        public Game()
        {
            this.guesses = new HashSet<Guess>();
        }

        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string BlueUserId { get; set; }

        public virtual ApplicationUser BlueUser { get; set; }

        [Required]
        public string RedUserId { get; set; }

        [Required]
        public virtual ApplicationUser RedUser { get; set; }

        [Required]
        public int RedNumber { get; set; }

        public int BlueNumber { get; set; }

        [Required]
        public GameState GameState { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public virtual ICollection<Guess> Guesses
        {
            get
            {
                return this.guesses;
            }
            set
            {
                this.guesses = value;
            }
        }
    }
}
