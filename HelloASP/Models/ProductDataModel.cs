using HelloASP.Data.Entity;
using HelloASP.Integrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloASP.Models {
    public class ProductDataModel : Product {

        public ProductDataModel(Product product) {
            this.Id = product.Id;
            this.Name = product.Name;
            this.ProductNumber = product.ProductNumber;
            this.ListPrice = product.ListPrice;
        }
        public string ListPriceInWords {
            get {
                return NumericService.NumberToWords(ListPrice);
            }
        }
    }
}