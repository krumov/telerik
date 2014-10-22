using Articles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Models
{
    public class Guess
    {
        public int ID { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int GameId { get; set; }

        public virtual Game Game { get; set; }

        public DateTime DateCreated { get; set; }

        public int Number { get; set; }

        public int CowsCount { get; set; }

        public int BullsCount { get; set; }

    }
}
