using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AW.Framework;
using AW.Model;

namespace AW.TestHarness
{
    public partial class ShoppingCart : System.Web.UI.UserControl
    {

        double totalvalue = 0;
        static List<int> list4 = new List<int>();
        List<Double> list_total = new List<Double>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refresh_data();
            }
        }
        public void refresh_data()
        {
            Dictionary<int, int> myDictionary = (Dictionary<int, int>)Session["shoppingCart"];
            EntityManager<ProductListing> object1 = new EntityManager<ProductListing>();
            ProductListing mgr_productListing = new ProductListing();
            List<ProductListing> list2 = new List<ProductListing>();
            
            foreach (var pair in myDictionary)
            {
                mgr_productListing.ProductID = pair.Key;
                List<ProductListing> list3 = new List<ProductListing>();
                list3 = object1.Search(mgr_productListing);
                list4.Add(pair.Value);
                list2.AddRange(list3);
            }

            GridView1.DataSource = list2;
            GridView1.DataBind();
            double tt = list_total.Sum();
            lblTotalValue.Text = tt.ToString();

        }
        int count = 0;
        int no_of_quantite = 0;
        double totalvalue1 = 0;
        
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //&& count < list4.Count
            if (e.Row.RowType == DataControlRowType.DataRow )
            {

                totalvalue += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "ListPrice"));
                Label TestLabel = (Label)e.Row.FindControl("label1");
                TestLabel.Text = list4[count].ToString();

                Label price = (Label)e.Row.FindControl("lblPrice");
                no_of_quantite = list4[count];

              //  Label Price1 = (Label)e.Row.FindControl("Price");
        //         totalvalue1 += Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "Price"));

                Double  ListPrice1 = Convert.ToDouble(e.Row.Cells[5].Text);
                Double TotalVal = no_of_quantite * ListPrice1;
                list_total.Add(TotalVal);
                price.Text = TotalVal.ToString();

                
                count++;

            }
            if (e.Row.RowType == DataControlRowType.Footer)
            {
                Label lblamount = (Label)e.Row.FindControl("lblTotalValue");
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("Checkout.aspx");
        }
    }
}
