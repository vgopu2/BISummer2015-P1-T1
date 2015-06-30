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
            refreshdata_desc();
        }

        public void refreshdata_desc()
        {
            EntityManager<ProductListing> object1 =new EntityManager<ProductListing>();
            ProductListing mgr_productListing = new ProductListing();
            mgr_productListing.

            //List<Address> list2 = mgrProduct.Search(obj);
            //lbl.Text = list2[0].AddressLine1;

        }
    }
}