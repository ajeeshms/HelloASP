using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloASP
{
    public partial class ProductList : System.Web.UI.Page
    {
        string ConStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRepeater();
            }
        }

        private void BindRepeater()
        {
            SqlConnection con = new SqlConnection(ConStr);
            SqlDataAdapter da = new SqlDataAdapter("Select top 10 ProductID, Name as ProductName, ProductNumber From [SalesLT].[Product]", ConStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "ProductList");
            gridViewProductList.DataSource = ds;
            gridViewProductList.DataBind();
        }

        protected void btnViewDetails_Click(object sender, EventArgs e)
        {
            int selectedIndex = gridViewProductList.SelectedIndex;
            GridViewRow gridViewRow = gridViewProductList.SelectedRow;

            string productID = gridViewProductList.Rows[selectedIndex].Cells[0].Text;

        }

        protected void gridViewProductList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = gridViewProductList.Rows[rowIndex];

            string productID = row.Cells[0].Text;

            Response.Redirect("~/Product/ProductDetails.aspx?ProductId=" + productID);
        }
    }
}