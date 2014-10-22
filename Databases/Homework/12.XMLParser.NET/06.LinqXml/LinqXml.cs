using System;
using System.Linq;
using System.Xml.Linq;

class LinqXml
{
    //Write a program, which using LINQ and XDocument extracts all song titles from catalog.xml.

    static void Main()
    {
        XDocument xmlDoc = XDocument.Load(@"..\..\..\01.catalog.xml");
        
        var allSongs =
            from songs in xmlDoc.Descendants("title")
            select songs.Value;

        foreach (var song in allSongs)
        {
            Console.WriteLine(song);
        }
    }
}
