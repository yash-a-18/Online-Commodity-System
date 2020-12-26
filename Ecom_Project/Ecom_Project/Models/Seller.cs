using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom_Project.Models
{
    public class Seller
    {
        public int SellerId { get; set; }
        [DisplayName("Seller Name")]
        public string sellerName { get; set; }
    }
}
