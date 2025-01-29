using System;

namespace HelloASP.Data.Entity {

    [Serializable]
    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }

        public decimal ListPrice { get; set; }
    }
}
