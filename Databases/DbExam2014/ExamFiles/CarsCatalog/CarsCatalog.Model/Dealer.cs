using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsCatalog.Model
{
    public class Dealer
    {
        private ICollection<Car> cars;
        public Dealer()
        {
            this.cars = new HashSet<Car>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        public int CityId { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<Car> Cars
        {
            get { return this.cars; }
            set { this.cars = value; }
        }
    }
}
