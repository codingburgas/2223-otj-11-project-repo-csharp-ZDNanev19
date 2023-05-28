using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepillik.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public IEnumerable<User> Users { get; set; } = new HashSet<User>();

        public IEnumerable<Product> Products { get; set; } = new HashSet<Product>();
    }
}
