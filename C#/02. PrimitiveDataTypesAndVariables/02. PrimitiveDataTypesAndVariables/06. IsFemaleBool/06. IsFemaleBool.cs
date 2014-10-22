using System;

class IsFemaleBool
{
    static void Main(string[] args)
    {
        // The task is to create a bool variable called isFemale and assign it a value corresponding to my gander (to the user's gander) 

        bool isFemale;
        Console.WriteLine("What is your gender (male/female)");
        string myGander = Console.ReadLine();

        if (myGander == "female")
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;

        }
        Console.WriteLine("You are female= " + isFemale);
    }
}
