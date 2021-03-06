﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW.Model
{
    public class Order
    {
        public int ProductID{get; set;}
        public int ProductCategoryID { get; set; }
        public int ProductModelID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public double StandardCost { get; set; }
        public double ListPrice { get; set; }
        public string Size { get; set; }
        public decimal Weight { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime SellEndDate { get; set; }
        public DateTime DiscontinuedDate { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
        public string ModelName { get; set; }
        public string CategoryName { get; set; }
        public int ParentProductCategoryID { get; set; }
        public int SalesOrderID { get; set; }
        public int SalesOrderDetailID { get; set; }
        public int OrderQty { get; set; }
        public double UnitPrice { get; set; }
        public double UnitPriceDiscount { get; set; }
        public double LineTotal { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ShipDate { get; set; }
        public string Status { get; set; }
        public int CustomerID { get; set; }

    }
}
