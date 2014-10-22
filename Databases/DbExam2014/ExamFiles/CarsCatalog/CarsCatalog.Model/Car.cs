using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsCatalog.Model
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public TransmissionType TransmissionType { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int ManufacturerId { get; set; }

        [ForeignKey("ManufacturerId")]
        public  Manufacturer Manufacturer { get; set; }

        public int DealerId { get; set; }

        public virtual Dealer Dealer { get; set; }

    }
}
