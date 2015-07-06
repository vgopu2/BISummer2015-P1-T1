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
    public partial class ProductOrder : System.Web.UI.UserControl
    {
        static int global_productId = 0;
      
        protected void Page_Load(object sender, EventArgs e)
        {
            //EntityManager<Order> mgrproductorder = new EntityManager<Order>();
            //List<Order> productorder = mgrproductorder.GetAll();

            //GridView1.DataSource = productorder;
            //GridView1.DataBind();
            

        }
        
        public void refreshdata(int val)
        {
            global_productId = val;
            EntityManager<ProductListing> object1 = new EntityManager<ProductListing>();
            ProductListing mgr_productListing = new ProductListing  ();
            mgr_productListing.ProductID = val;
            
            List<ProductListing> list2 = object1.Search(mgr_productListing);
            GridView1.DataSource = list2;
             
            GridView1.DataBind();
            GridView1.Columns[2].ItemStyle.Width = Unit.Pixel(400);

        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Dictionary<int, int> cartitems1 ;
            var ddl = GridView1.Rows[0].FindControl("ddlquantity") as DropDownList;
            
            //object selectedValue = ddlquantity.SelectedValue;
           int  value1 = Convert.ToInt32(ddl.SelectedItem.Value);
           int value2 = 0;

            if (Session["shoppingCart"] == null)
            {
                cartitems1 = new Dictionary<int, int>();
                cartitems1.Add(global_productId, value1);
                Session.Add("shoppingCart", cartitems1);
            }
            else 
            {
                cartitems1 = (Dictionary<int, int>)Session["shoppingCart"];
               // if (cartitems1.Keys.Contains(global_productId))
                    if(cartitems1.TryGetValue(global_productId,out value2))
                {
                    cartitems1[global_productId] = value1;
                }
                else
                {
                    cartitems1.Add(global_productId, value1);
                }
                Session["shoppingCart"] = cartitems1;
            }
            Response.Redirect("ProductBrowser.aspx");
          
        }
      
       
       
    }
}