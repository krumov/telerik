using ATMDatabase.Model;
using System.Data.Entity;

namespace ATMDatabase.Context
{
    public class ATMContext : DbContext
    {
        public ATMContext()
            : base("ATM")
        {

        }

        public DbSet<CardAccount> CardAccounts { get; set; }
        public DbSet<TransactionHistory> TransactionsHistory { get; set; }
    }
}
