using Ecom_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom_Project.ViewModels
{
    public class OrderViewModel
    {
        public User user { get; set; }
        public Order order { get; set; }
        public double Total { get; set; }
    }
}
