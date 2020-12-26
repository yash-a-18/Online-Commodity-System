using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Ecom_Project.Models;
//using Ecom_Project.ViewModels;

namespace Ecom_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Ecom_Project.Models.User> User { get; set; }
        public DbSet<Ecom_Project.Models.Category> Category { get; set; }
        public DbSet<Ecom_Project.Models.Item> Item { get; set; }

        public DbSet<Ecom_Project.Models.Seller> Seller { get; set; }

        public DbSet<Ecom_Project.Models.Cart> Cart { get; set; }

        public DbSet<Ecom_Project.Models.Order> Order { get; set; }

        public DbSet<Ecom_Project.Models.OrderDetail> OrderDetails { get; set; } 

        //public DbSet<Ecom_Project.ViewModels.ShoppingCartViewModel> ShoppingCartViewModel { get; set; }
    }
}
