using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloASP.UserControls
{
    public partial class ProductView_Details : System.Web.UI.UserControl
    {
        string ConStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public int ProductId
        {
            get;
            set;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ProductId"] != null)
            {
                ProductId = Convert.ToInt32(Request.QueryString["ProductId"]);
            }

            BindRepeater(ProductId);
        }

        private void BindRepeater(int productId)
        {
            SqlConnection con = new SqlConnection(ConStr);
            SqlDataAdapter da = new SqlDataAdapter("Select * From [SalesLT].[Product] where ProductID = " + productId, ConStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "FriendsTable");
            productDetailsRepeater.DataSource = ds;
            productDetailsRepeater.DataBind();
        }
    }
}