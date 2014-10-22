namespace Articles.Data
{
    using System.Data.Entity;

    using Microsoft.AspNet.Identity.EntityFramework;

    using Articles.Data.Migrations;
    using Articles.Models;

    public class ArticlesDbContext : IdentityDbContext<ApplicationUser>
    {
        public ArticlesDbContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ArticlesDbContext, Configuration>());
        }

        public static ArticlesDbContext Create()
        {
            return new ArticlesDbContext();
        }

        public IDbSet<Game> Games { get; set; }

        public IDbSet<Guess> Guesses { get; set; }

        public IDbSet<Notification> Notifications { get; set; }

    }
}
