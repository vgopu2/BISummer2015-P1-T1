using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AW.TestHarness
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btn_Checkout_Click(object sender, EventArgs e)
        {
            addressview.Visible = true;
            btn_Checkout.Visible = false;
        }

        protected void btn_Edit_Click(object sender, EventArgs e)
        {
            btn_Checkout.Visible = false;
            addressview.Visible = false;
            Div2.Visible = true;
            
           
        }
    }
}