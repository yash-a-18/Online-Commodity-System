using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom_Project.Models
{
    public class Category
    {
        [Key]
        [DisplayName("Category Id")]
        public int CatgeoryId { get; set; }
        [DisplayName("Category Name")]
        public string categoryName { get; set; }
        [DisplayName("Description")]
        public string descripion { get; set; }

        public List<Item> items { get; set; }
    }
}
