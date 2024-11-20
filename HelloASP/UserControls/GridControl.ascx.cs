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

        public string GridType { get; set; }
        protected void Page_Load(object sender, EventArgs e) {
            
            try {
                BindGrid();
                ViewState["Message"] = string.Empty;
            }
            catch (Exception ex) {
                
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

            var repo = new ProductRepository();
            var product = new Product { Id = id, Name = name, ListPrice = price };
            var result = repo.Update(product);
            ViewState["Message"] = result ? "Data updated" : "Failed to update data";

            //var products = ViewState["Products"] as List<Product>;
            //var index = products.FindIndex(p=> p.Id == id);
            //products.ElementAt(index).ListPrice = price;

            //ViewState["Products"] = products;
            theGrid.EditIndex = -1;
            BindGrid();
        }

        protected void theGrid_RowCancellingEdit(object sender, GridViewCancelEditEventArgs e) {
            theGrid.EditIndex = -1;
            BindGrid();
        }

        protected void BindGrid() {
            if (this.GridType == "PRODUCTS") {
                var repo = new ProductRepository();
                var data = repo.Get(1, 10).ToList();
                theGrid.DataSource = data;
                ViewState["GridTitle"] = "Products";
                theGrid.DataBind();
            }
            else if (this.GridType == "PRODUCTMODELS") {
                var repo = new ProductModelRepository();
                var data = repo.Get(1, 10).ToList();
                productModelGrid.DataSource = data;
                ViewState["GridTitle"] = "Product Models";
                productModelGrid.DataBind();
            }
            
        }

    }
}