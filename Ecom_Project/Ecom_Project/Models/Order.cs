  using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom_Project.Models
{
    public  partial class Order
    {
        [DisplayName("Order Id")]
        public int OrderId { get; set; }
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }
        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        [DisplayName("Total Bill")]
        public double Total { get; set; }

        [DisplayName("Order Date")]
        public string OrderDate { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
