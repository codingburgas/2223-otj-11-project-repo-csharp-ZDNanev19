using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepillik.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public IEnumerable<Store> Stores { get; set; } = new HashSet<Store>();
        public IEnumerable<Warranty> Warranties { get; set; } = new HashSet<Warranty>();
    }
}
