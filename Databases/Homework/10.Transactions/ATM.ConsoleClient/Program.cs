using ATMDatabase;
using ATMDatabase.Context;
using ATMDatabase.Context.Migrations;
using System;
using System.Data.Entity;

namespace ATM.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<ATMContext, Configuration>());

            ATMActions.ShowCards();

            int pin = 2222;
            int cardNumber = 1222222222;
            decimal moneyToWithdraw = 300m;

            using (ATMContext db = new ATMContext())
            {
                if (ATMActions.WithdrawMoney(pin, cardNumber, moneyToWithdraw, db))
                {
                    Console.WriteLine("Money withdrawn");
                }
                else
                {
                    Console.WriteLine("Money not withdrawn");
                }
            }


            Console.WriteLine("\nNew cards: ");
            ATMActions.ShowCards();
        }
    }
}
