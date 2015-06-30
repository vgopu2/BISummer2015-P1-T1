using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AW.TestHarness
{
    public partial class ProductBrowser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // RefreshData();
        }
        public void RefreshData(List<int> productTypes = null)
        {
            string str = @"SELECT [Name], [ProductID], [ProductNumber], [Color], [StandardCost] FROM [SalesLT].[vProductListing]";


            if (productTypes != null)
            {
                string adding = "";
                foreach (int i in productTypes)
                {
                    adding += i + ",";
                }
                adding = adding.Trim(',');
                string qry = "where ProductID in (" + adding + ")";
                str = str + qry;
            }
            string connString = ConfigurationManager.ConnectionStrings["AdventureWorksLT2008ConnectionString2"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "VehiclesTable");
            dlProducts.DataSource = ds;
            dlProducts.DataBind();
        }
    }
}