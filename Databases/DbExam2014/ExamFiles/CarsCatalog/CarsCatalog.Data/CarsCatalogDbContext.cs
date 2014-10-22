using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsCatalog.Model;
using CarsCatalog.Data.Migrations;

namespace CarsCatalog.Data
{
    public class CarsCatalogDbContext:DbContext
    {
        public CarsCatalogDbContext():base("CarsDatabase")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarsCatalogDbContext, Configuration>());
        }

        public IDbSet<Car> Cars { get; set; }
        public IDbSet<City> Citys { get; set; }
        public IDbSet<Dealer> Dealers { get; set; }
        public IDbSet<Manufacturer> Manufacturers { get; set; }
    }
}
