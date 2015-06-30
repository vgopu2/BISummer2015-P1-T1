using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AW.TestHarness;
using AW.Framework;
using AW.DataAccessLayer;
using AW.Model;


namespace AW.TestHarness
{
    public partial class ProductBrowser : System.Web.UI.Page
    {
        int age = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
          RefreshData();
        
        }
        public void  RefreshData(List<int> productTypes = null)
        {
            string str = "SELECT [Name], [ProductID], [ProductNumber], [Color], [StandardCost] FROM [SalesLT].[vProductListing]";

            string connString = ConfigurationManager.ConnectionStrings["AdventureWorksLT2008ConnectionString2"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter adapter = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "VehiclesTable");
            DataTable dt = new DataTable();
           
           // Int32 First = Convert.ToInt32(ds.Tables[0].Rows[0]["ProductID"].ToString());
            dlProducts.DataSource = ds;
            dlProducts.DataBind();
            
        }
       
        protected void DataList1_Command(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "view")
            {
                age = Convert.ToInt32(dlProducts.DataKeys[e.Item.ItemIndex]);
                ProductDescri.refreshdata_desc(age);
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup();", true);
            }
            else
            {
                age = Convert.ToInt32(dlProducts.DataKeys[e.Item.ItemIndex]);

                ProductOrd.refreshdata(age);
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup1();", true);
            }
        }
       
    }
}