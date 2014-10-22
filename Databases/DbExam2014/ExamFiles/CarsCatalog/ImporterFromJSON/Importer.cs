using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsCatalog.Data;
using CarsCatalog.Model;
using System.IO;
using Newtonsoft.Json;

using Newtonsoft.Json.Linq;

namespace ImporterFromJSON
{
    class Importer
    {
        static void Main(string[] args)
        {
            var db = new CarsCatalogDbContext();
            db.Cars.Any();
            db.SaveChanges();

            using (StreamReader reader = new StreamReader(@"..\..\..\data.0.json"))
            {
                var data = reader.ReadToEnd();
                var cars = JArray.Parse(data);
                
                    foreach (var car in cars)
                    {
                        var year = car["Year"].ToString();
                        Console.WriteLine(year);

                      //  ... to be continued
                    }
                
            }
        }
    }
}
