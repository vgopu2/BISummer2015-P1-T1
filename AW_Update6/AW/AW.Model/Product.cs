using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW
{
    class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public int StandardCost { get; set; }
        public int ListPrice { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }
        public int ProductCategoryID { get; set; }
        public int ProductModelID { get; set; }
        
        public DateTime SellStartDate { get; set; }
        public DateTime SellEndDate { get; set; }
        public DateTime DiscontinuedDate { get; set; }
        public byte[] ThumbNailPhoto { get; set; }
        public string ThumbNailPhotoFileName { get; set; }

    }
}
