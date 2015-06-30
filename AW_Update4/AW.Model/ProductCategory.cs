using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW.model
{
    public class ProductCategory
    {
        public int ProductCategoryID { get; set; }
        public int ParentProductCategoryID { get; set; }
        public string name { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
        
    }
}
