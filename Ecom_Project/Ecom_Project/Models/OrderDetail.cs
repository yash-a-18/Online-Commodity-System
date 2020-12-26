using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom_Project.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        [DisplayName("Order Id")]
        public int OrderId { get; set; }
        [DisplayName("Item Id")]
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        [DisplayName("Price (each)")]
        public double unitPrice { get; set; }
        [DisplayName("Email")]
        public string username { get; set; }
        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
        
    }
}
