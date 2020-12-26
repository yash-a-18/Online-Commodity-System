using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom_Project.Models
{
    public class Cart
    {
        [Key]
        [DisplayName("Record Id")]
        public int RecordId { get; set; }
        [DisplayName("Email")]
        public string CartId { get; set; }
        [DisplayName("Item Id")]
        public int ItemId {get; set; }
        [DisplayName("Quantity")]
        public int Count { get; set; }

        public System.DateTime DateCreated { get; set; }

        public virtual Item Item { get; set; }

    }
}
