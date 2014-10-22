using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;

class ExtractArtists
{
    //Write program that extracts all different artists which 
    //are found in the catalog.xml. 
    //For each author you should print the number of albums 
    //in the catalogue. Use the DOM parser and a hash-table

    static void Main()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(@"..\..\..\01.catalog.xml");
        Console.WriteLine("Document Loaded");

        XmlNode rootNode = doc.DocumentElement;
        Console.WriteLine("Root node is: {0}", rootNode.Name);

        Dictionary<string, int> artists = new Dictionary<string, int>();

        foreach (XmlNode node in rootNode.ChildNodes)
        {
            string currentArtist = node["artist"].InnerText;
            if (artists.Keys.Contains(currentArtist))
            {
                artists[currentArtist]++;
            }
            else
            {
                artists.Add(currentArtist, 1);
            }
        }

        foreach (var artist in artists)
        {
            Console.WriteLine("Artist: {0} has {1} albums", artist.Key, artist.Value);
        }
    }
}