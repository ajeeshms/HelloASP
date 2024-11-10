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
            
            try {
                var repo = new ProductRepository();
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

        protected void theGrid_RowUpdating(object sender, GridViewUpdateEventArgs e) {
            var id = Convert.ToInt32(((HiddenField)theGrid.Rows[e.RowIndex].FindControl("hdnId")).Value);
            var name = ((TextBox)theGrid.Rows[e.RowIndex].FindControl("txtName")).Text;
            var price = Convert.ToDecimal(((TextBox)theGrid.Rows[e.RowIndex].FindControl("txtlistPrice")).Text);
            
            var products = ViewState["Products"] as List<Product>;
            var index = products.FindIndex(p=> p.Id == id);
            products.ElementAt(index).ListPrice = price;
            
            ViewState["Products"] = products;
            theGrid.EditIndex = -1;
            BindGrid();
        }

        protected void theGrid_RowCancellingEdit(object sender, GridViewCancelEditEventArgs e) {
            theGrid.EditIndex = -1;
            BindGrid();
        }

        protected void BindGrid() {
            theGrid.DataSource = ViewState["Products"];
            theGrid.DataBind();
        }

    }
}