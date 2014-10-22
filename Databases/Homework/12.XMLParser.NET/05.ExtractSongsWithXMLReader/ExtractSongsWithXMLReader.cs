using System;
using System.Xml;

class ExtractSongsWithXMLReader
{
    //Write a program, which using XmlReader extracts all song titles from catalog.xml

    static void Main()
    {
        Console.WriteLine("Songs in the catalog:");
        using (XmlReader reader = XmlReader.Create("../../../01.Catalog.xml"))
        {
            while (reader.Read())
            {

                if ((reader.NodeType == XmlNodeType.Element) &&
                    (reader.Name == "title"))
                {
                    Console.WriteLine(reader.ReadElementString());
                }
            }
        }        
    }
}