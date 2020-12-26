using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom_Project.Data;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace Ecom_Project.Models
{
    public class ShoppingCart
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApplicationDbContext cartDb;

        public ShoppingCart(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager, ApplicationDbContext context)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.cartDb = context;
        }
        public ShoppingCart()
        {

        }
        string ShoppingCartId { get; set; }
        public const string CartSessionKey = "CartId";
        public static ShoppingCart GetCart(HttpContext context, ApplicationDbContext cartDb)
        {
            var cart = new ShoppingCart();
            cart.ShoppingCartId = cart.GetCartId(context,cartDb);
            cart.ShoppingCartId = context.User.Identity.Name;
            //cart.ShoppingCartId = cartDb.Cart.First(o => o.CartId == Name).CartId;
            return cart;
        }

        public static ShoppingCart GetCart(Controller controller, ApplicationDbContext cartDb)
        {
            return GetCart(controller.HttpContext,cartDb);
        }
        public void AddToCart(Item Item, ApplicationDbContext cartDb)
        {
            var cartItem = cartDb.Cart.SingleOrDefault(
                c => c.CartId == ShoppingCartId && c.ItemId == Item.ItemId);

            if (cartItem == null)
            {
                cartItem = new Cart
                {
                    ItemId = Item.ItemId,
                    CartId = ShoppingCartId,
                    Count = 1,
                    DateCreated = DateTime.Now
                };
                cartDb.Cart.Add(cartItem);
            }
            else
            {
                cartItem.Count++;
            }
            cartDb.SaveChanges();
        }
        public int RemoveFromCart(int id, ApplicationDbContext cartDb)
        {
            var cartItem = cartDb.Cart.Single(
                cart => cart.CartId == ShoppingCartId && cart.RecordId == id);

            int itemCount = 0;
             if(cartItem != null)
            {
                if(cartItem.Count > 1)
                {
                    cartItem.Count--;
                    itemCount = cartItem.Count;
                }
                else
                {
                    cartDb.Cart.Remove(cartItem);
                }
                cartDb.SaveChanges();
            }
            return itemCount;
        }

        public void EmptyCart(ApplicationDbContext cartDb)
        {
            var cartItems = cartDb.Cart.Where(
                cart => cart.CartId == ShoppingCartId);

            foreach( var cartItem in cartItems)
            {
                cartDb.Cart.Remove(cartItem);
            }
            cartDb.SaveChanges();
        }

        public List<Cart> GetCartItems(ApplicationDbContext cartDb)
        {
            //return cartDb.Cart.ToList();
            Console.WriteLine("Getting called");
            return cartDb.Cart.Where(
                cart => cart.CartId == ShoppingCartId).ToList();
        }

        public int GetCount(ApplicationDbContext cartDb)
        {
            int? count = (from cartItems in cartDb.Cart
                          where cartItems.CartId == ShoppingCartId
                          select (int?)cartItems.Count).Sum();

            return count ?? 0;
        }

        public double GetTotal(ApplicationDbContext cartDb)
        {
            double? total = (double?)(from cartItems in cartDb.Cart
                              where cartItems.CartId == ShoppingCartId
                               select (int?)cartItems.Count *
                               cartItems.Item.price).Sum();

            return total ?? 0;
        }

        public int CreateOrder(Order order, ApplicationDbContext cartDb, HttpContext context)
        {
            double orderTotal = 0;

            var cartItems = GetCartItems(cartDb);
            Console.WriteLine(cartItems.Count());
            Console.WriteLine(order.OrderId);
            foreach (var item in cartItems)
            {
                Console.WriteLine("start");
                Console.WriteLine(item.ItemId);
                Console.WriteLine(order.OrderId);
                var price_temp = cartDb.Item.Find(item.ItemId).price;
                Console.WriteLine(price_temp);
                Console.WriteLine(item.Count);
                var orderDetail = new OrderDetail
                {
                    ItemId = item.ItemId,
                    OrderId = order.OrderId,
                    unitPrice = (double)item.Item.price,
                    Quantity = item.Count,
                    username= context.User.Identity.Name
                };

                orderTotal = orderTotal + ((double)(item.Count * item.Item.price));

                cartDb.OrderDetails.Add(orderDetail);

            }

            order.Total = orderTotal;


            cartDb.SaveChanges();

            EmptyCart(cartDb);

            return order.OrderId;
        }

        public string GetCartId(HttpContext context, ApplicationDbContext cartDb)
        {
            if (context.Session.GetString(CartSessionKey) == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session.SetString(CartSessionKey,
                        context.User.Identity.Name);
                }
                else
                {

                    Guid tempCartId = Guid.NewGuid();

                    context.Session.SetString(CartSessionKey , tempCartId.ToString());
                }
            }
            return context.Session.GetString(CartSessionKey);
        }

        public void MigrateCart(string Email, ApplicationDbContext cartDb)
        {
            var shoppingCart = cartDb.Cart.Where(
                c => c.CartId == ShoppingCartId);

            foreach (Cart item in shoppingCart)
            {
                item.CartId = Email;
            }
            cartDb.SaveChanges();
        }

    }
}
