using System;
using System.Xml;

class AlbumPrice
{
    //Using the DOM parser write a program to delete from catalog.xml 
    //all albums having price > 20.

    static void Main()
    {
        XmlDocument doc = new XmlDocument();
        string fileLocation = @"..\..\..\01.catalog.xml";
        doc.Load(fileLocation);
        Console.WriteLine("Document Loaded");

        XmlNode rootNode = doc.DocumentElement;
        foreach (XmlNode node in rootNode.ChildNodes)
        {
            double currentPrice = double.Parse(node["price"].InnerText.Trim());
            if (currentPrice > 20)
            {
                rootNode.RemoveChild(node);
            }
        }

        doc.Save("../../../04.newCatalog.xml");
    }
}