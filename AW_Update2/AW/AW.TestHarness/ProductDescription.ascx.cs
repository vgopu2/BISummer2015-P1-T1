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
    public partial class ProductDescription1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a=4;
            ProductDescription1 p_d = new ProductDescription1(a);
        }

        public ProductDescription1()
        { 
        
        }


        public ProductDescription1(int val)
        {
            EntityManager<ProductDescription> mgrproduct = new EntityManager<ProductDescription>();
            ProductDescription p_dd = new ProductDescription();
            //p_d.ProductDescriptionID = 4;
            p_dd.ProductDescriptionID = val;
            List<ProductDescription> list1 = mgrproduct.Search(p_dd);
            Textbox1.Text = list1[0].Description.ToString();
            
        }
    }
}