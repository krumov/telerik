using System;

class Print52CardNames
{
    // Print all 52 cards from the deck

    static void Main(string[] args)
    {
        string[] cards = new string[13] { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};
        string[] cardSigns = new string[4] {"Clubs","Diamonds","Hearts","Spades"};
        for (int i = 0; i < cardSigns.Length; i++)
        {
            
            for (int j = 0; j < cards.Length; j++)
            {
                Console.WriteLine("{0} of {1}", cards[j], cardSigns[i]);
            }
            Console.WriteLine();
        }
    }
}

