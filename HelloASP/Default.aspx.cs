using System;
using System.Web.UI;

namespace HelloASP {
    public partial class _Default : Page {
        protected void Page_Load(object sender, EventArgs e) {
            ViewState["GridType"] = "PRODUCTS";
        }
    }
}