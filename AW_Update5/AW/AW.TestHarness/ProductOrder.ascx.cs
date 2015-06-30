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
        protected void Page_Load(object sender, EventArgs e)
        {
            EntityManager<Order> mgrproductorder = new EntityManager<Order>();
            List<Order> productorder = mgrproductorder.GetAll();

            GridView1.DataSource = productorder;
            GridView1.DataBind();
            

        }
        
        public void refreshdata(int val)
        {
            EntityManager<ProductListing> object1 = new EntityManager<ProductListing>();
           ProductListing mgr_productListing = new ProductListing  ();
           mgr_productListing.ProductID = val;

            List<ProductListing> list2 = object1.Search(mgr_productListing);
            GridView1.DataSource = list2;
            GridView1.DataBind();

        }
    }
}