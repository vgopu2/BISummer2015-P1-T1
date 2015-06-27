using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AW.Framework;
using AW.model;


namespace AW.TestHarness
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EntityManager<ProductDescription> mgrProduct = new EntityManager<ProductDescription>();
            List<ProductDescription> list1 = mgrProduct.GetAll();
           
            GridView1.DataSource = list1;
            GridView1.DataBind();
        }
    }
}