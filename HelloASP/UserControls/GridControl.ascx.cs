using HelloASP.Data.Entity;
using HelloASP.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloASP.UserControls {
    public partial class GridControl : System.Web.UI.UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            var repo = new ProductRepository();
            try {
                ViewState["Products"] = repo.Get(1, 10);
            }
            catch (Exception ex) {
                ViewState["Products"] = new List<Product>();
            }
        }
    }
}