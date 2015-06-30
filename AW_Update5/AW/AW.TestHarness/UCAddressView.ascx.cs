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
    public partial class UCAddressView : System.Web.UI.UserControl
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshdata(); 
        }
        public  void refreshdata()
        {
            EntityManager<Address> mgrProduct = new EntityManager<Address>();
            Address obj = new Address();
            obj.AddressID = 9;
            List<Address> list2 = mgrProduct.Search(obj);
            lbl.Text = list2[0].AddressLine1;
            
        }
    }
}