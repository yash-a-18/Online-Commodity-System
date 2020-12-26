using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom_Project.Models
{
    //[Bind(include:  "ItemId")]
    public class Item
    {
        //[ScaffoldColumn(false)]
        public int ItemId { get; set; }
        [DisplayName("Category")]
        public int CategoryId { get; set; }

        [DisplayName("Seller")]
        public int SellerId { get; set; }

        [DisplayName("Price")]
        //[Required(ErrorMessage = "Price is required")]
        public double price { get; set; }

        [DisplayName("Item URL Path")]
        //[Required(ErrorMessage = "Image is required")]
        public string itemURl { get; set; }

        //[Required(ErrorMessage ="An Item Name/Title is required")]
        [StringLength(100)]
        public string Title { get; set; }

        [DisplayName("Owner Email")]
        public string OwnerEmail { get; set; }
        [DisplayName("Owner Name")]
        public string OwnerName { get; set; }
        public virtual Category category { get; set; }

        public virtual Seller seller { get; set; }
        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile ImageFile { get; set; }
    }
}
