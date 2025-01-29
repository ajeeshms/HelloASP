using HelloASP.Data.Repository;
using HelloASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace HelloASP.Services {
    /// <summary>
    /// Summary description for ProductService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductService : System.Web.Services.WebService {

        [WebMethod]
        public IEnumerable<ProductDataModel> GetProducts(int page, int count) {
            var repo = new ProductRepository();
            var data = repo.Get(page, count).ToList();
            var dataModel = data.Select(x => new ProductDataModel(x));
            return dataModel;
        }
    }
}
