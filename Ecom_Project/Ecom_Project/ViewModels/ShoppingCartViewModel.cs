using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace Ecom_Project.ViewModels
{
    public class ShoppingCartViewModel
    {
        [Key]

        public int  ShoppingCartId {get; set;}
        public List<Cart> CartItems { get; set; }
        public List<Item> Items { get; set; }
        public Double CartTotal { get; set; }
    }
}
