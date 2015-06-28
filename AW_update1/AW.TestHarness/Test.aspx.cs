using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AW.Framework;
using AW.Model;
using AW.model;

namespace AW.TestHarness
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EntityManager<Order> mgrproductorder = new EntityManager<Order>();
            List<Order> productorder = mgrproductorder.GetAll();
            GridView1.DataSource = productorder;
            GridView1.DataBind();
        }
    }
}