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
       
        static double totalvalue = 0;
        static List<int> list4 = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
                Dictionary<int, int> myDictionary = (Dictionary<int, int>)Session["shoppingCart"];
                // foreach (var my in myDictionary) { }
                EntityManager<ProductListing> object1 = new EntityManager<ProductListing>();
                ProductListing mgr_productListing = new ProductListing();
                List<ProductListing> list2 = new List<ProductListing>();
                // myDictionary.Add(984, 1);
                
                foreach (var pair in myDictionary)
                {

                    mgr_productListing.ProductID = pair.Key;
                    List<ProductListing> list3 = new List<ProductListing>();
                    list3 = object1.Search(mgr_productListing);
                    list4.Add(pair.Value);
                    list2.AddRange(list3);
                }
                if (!IsPostBack)
                {
                    GridView1.DataSource = list2;
                    GridView1.DataBind();
                    lblTotalValue.Text = totalvalue.ToString();
                }
           }
          int  count=0;
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
               
                if (e.Row.RowType == DataControlRowType.DataRow && count <list4.Count)
                {
                        totalvalue += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "ListPrice"));
                        
                        Label TestLabel = (Label)e.Row.FindControl("label1");
                        TestLabel.Text = list4[count].ToString();
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
