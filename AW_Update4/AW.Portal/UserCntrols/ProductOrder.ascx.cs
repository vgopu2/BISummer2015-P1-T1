using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AW.Model;
using AW.Framework;
using System.Data;

namespace AW.Portal.UserCntrols
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
       
 

        
      
        
    }
}