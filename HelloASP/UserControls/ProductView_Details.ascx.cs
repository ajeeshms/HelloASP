using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HelloASP.UserControls {
    public partial class ProductView_Details : System.Web.UI.UserControl {
        string ConStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public int ProductId {
            get;
            set;
        }

        protected void Page_Load(object sender, EventArgs e) {
            if (Request.QueryString["ProductId"] != null) {
                ProductId = Convert.ToInt32(Request.QueryString["ProductId"]);
            }

            BindRepeater(ProductId);
        }

        private void BindRepeater(int productId) {
            SqlConnection con = new SqlConnection(ConStr);
            SqlDataAdapter da = new SqlDataAdapter("Select * From [SalesLT].[Product] where ProductID = " + productId, ConStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "FriendsTable");
            productDetailsRepeater.DataSource = ds;
            productDetailsRepeater.DataBind();
        }
    }
}