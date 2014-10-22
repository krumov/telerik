using System;

class CompanyWorkersInfo
    //*A company has name, address, phone number, fax number, web site and manager. 
    //The manager has first name, last name, age and a phone number. 
    //Write a program that reads the information about a company and its manager and prints them on the console.

{
    static void Main(string[] args)
    {
        Console.WriteLine("Plese write all the requred information");
        Console.WriteLine("Company name:");
        string CompanyName = Console.ReadLine();
        Console.WriteLine("Company adress:");
        string CompanyAdress = Console.ReadLine();
        Console.WriteLine("Company phone number:");
        string CompanyPhone = Console.ReadLine();
        Console.WriteLine("Company fax number:");
        string CompanyFax = Console.ReadLine();
        Console.WriteLine("Company website:");
        string CompanyWebsite = Console.ReadLine();
        Console.WriteLine("Company manager first name: ");
        string ManagerFirstName = Console.ReadLine();
        Console.WriteLine("Company manager last name: ");
        string ManagerLastName = Console.ReadLine();
        Console.WriteLine("Company manager age: ");
        byte ManagerAge = byte.Parse(Console.ReadLine());
        Console.WriteLine("Company manager phone number: ");
        string ManagerPhoneNumber = Console.ReadLine();

        Console.WriteLine("You work at {0}, at adress {1}, with phone number: {2}, fax number: {3} and website: {4}", CompanyName,CompanyAdress,CompanyPhone,CompanyFax,CompanyWebsite);
        Console.WriteLine("Your boss is {0} {1}, he is {2} years old, and his phone number is {3}",ManagerFirstName,ManagerLastName,ManagerAge,ManagerPhoneNumber);
    }
}
