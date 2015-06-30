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
    public partial class ProductDescription : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int a = 9;
           // refreshdata_desc(a);
        }

        public void refreshdata_desc(int val)
        {
            EntityManager<ProductListing> object1 = new EntityManager<ProductListing>();
           ProductListing mgr_productListing = new ProductListing  ();
           mgr_productListing.ProductID = val;

            List<ProductListing> list2 = object1.Search(mgr_productListing);
            Label1.Text = list2[0].Description;

        }
    }
}