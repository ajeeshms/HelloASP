using HelloASP.Data.Entity;
using HelloASP.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloASP.UserControls {
    public partial class GridControl : System.Web.UI.UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            var repo = new ProductRepository();
            try {
                ViewState["Products"] = repo.Get(1, 10).ToList();
                BindGrid();
            }
            catch (Exception ex) {
                ViewState["Products"] = new List<Product>();
            }
        }

        protected void thrGrid_RowEditing(object sender, GridViewEditEventArgs e) {
            try {
                theGrid.EditIndex = e.NewEditIndex;
                BindGrid();
            }
            catch (Exception) {
                throw;
            }
        }

        protected void theGrid_RowCancellingEdit(object sender, GridViewCancelEditEventArgs e) {
            BindGrid();
        }

        protected void BindGrid() {
            theGrid.DataSource = ViewState["Products"];
            theGrid.DataBind();
        }
    }
}