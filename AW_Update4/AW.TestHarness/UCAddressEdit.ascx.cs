using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AW.Model;
using AW.Framework;

namespace AW.TestHarness
{
    public partial class UCAddressEdit : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = 9;
            refreshdata_edit(a);
            
        }
        public void refreshdata_edit(int val)
        {
            
            EntityManager<Address> mgrProduct = new EntityManager<Address>();
            Address obj = new Address();
            obj.AddressID = val;
            List<Address> list2 = mgrProduct.Search(obj);
            string x = list2[0].AddressLine1;
            lbEdit.Text = x;
           
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            txtEDit.Text = lbEdit.Text;
            txtEDit.Focus();
        }
    }
}