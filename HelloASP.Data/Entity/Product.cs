using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloASP.Data.Entity {
    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }

        public decimal ListPrice { get; set; }
    }
}
