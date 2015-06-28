using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW.Model
{
   public class Address
    {
      public int  AddressId { get; set; }
      public string AddressLine1 { get; set; }
      public string City { get; set; }
      public string StateProvince { get; set; }
      public string CountryRegion { get; set; }
        
    }
}
