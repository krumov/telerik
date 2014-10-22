namespace ATMDatabase.Context.Migrations
{
    using ATMDatabase.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<ATMDatabase.Context.ATMContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "ATMDatabase.Context.ATMContext";
        }

        protected override void Seed(ATMContext context)
        {
            context.CardAccounts.AddOrUpdate(x => x.CardNumber,
                 new CardAccount() { CardCash = 1000, CardNumber = 1234567890, CardPIN = 4444 },
                 new CardAccount() { CardCash = 2000, CardNumber = 1111111111, CardPIN = 1111 },
                 new CardAccount() { CardCash = 4000, CardNumber = 1222222222, CardPIN = 2222 },
                 new CardAccount() { CardCash = 10000, CardNumber = 1333333333, CardPIN = 3333 }
                 );
        }
    }
}
