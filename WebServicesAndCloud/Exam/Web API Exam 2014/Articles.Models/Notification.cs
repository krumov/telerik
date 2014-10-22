using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Models
{
    public class Notification
    {
        public int ID { get; set; }

        public string Message { get; set; }

        public DateTime DateCreated { get; set; }

        public NotificationType Type { get; set; }

        public NotificationState State { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

    }
}
