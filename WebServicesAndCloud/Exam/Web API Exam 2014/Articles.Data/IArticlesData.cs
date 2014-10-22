﻿namespace Articles.Data
{
    using Articles.Data.Repositories;
    using Articles.Models;

    public interface IArticlesData
    {
        IRepository<ApplicationUser> Users { get; }

        IRepository<Game> Games { get; }

        IRepository<Guess> Guesses { get; }

        IRepository<Notification> Notifications { get; }


        int SaveChanges();
    }
}
