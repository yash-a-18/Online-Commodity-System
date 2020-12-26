using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ecom_Project.Models;
using Ecom_Project.ViewModels;
using System.Web;
using Ecom_Project.Data;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Ecom_Project.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApplicationDbContext cartDb;
        public ShoppingCartController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager, ApplicationDbContext context)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.cartDb = context;
        }
        public async Task<IActionResult> Index()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext,cartDb);
            List<Item> tempCartItems = new List<Item>();
            foreach (var item in cart.GetCartItems(cartDb))
            {
                //Console.WriteLine(item.ItemId);
                var tempItem= await cartDb.Item.FindAsync(item.ItemId);
                tempCartItems.Add(tempItem);
                //Console.WriteLine(tempItem.Title);
            }
            
            var viewModel = new ShoppingCartViewModel
            {
                CartItems = cart.GetCartItems(cartDb),
                Items=tempCartItems,
                CartTotal = cart.GetTotal(cartDb)
            };
            return View(viewModel);
        }

        public IActionResult AddToCart(int id)
        {

            var addedItem = cartDb.Item
                .Single(item => item.ItemId == id);
            var cart = ShoppingCart.GetCart(this.HttpContext,cartDb);

            cart.AddToCart(addedItem,cartDb);


            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult RemoveFromCart(int id)
        {
            var cart = ShoppingCart.GetCart(this.HttpContext,cartDb);


            //string itemName = cartDb.Cart
                //.Single(item => item.RecordId == id).Item.Title;


            int itemCount = cart.RemoveFromCart(id,cartDb);


            var results = new ShoppingCartRemoveViewModel
            {
                Message =//= HtmlEncoder.Default.Encode(itemName) +
                    " has been removed from your shopping cart.",
                CartTotal = cart.GetTotal(cartDb),
                CartCount = cart.GetCount(cartDb),
                ItemCount = itemCount,
                DeleteId = id
            };
            ViewBag.Message = "Removed From the cart";
            return RedirectToAction("Index","ShoppingCart");
        }

        
        public IActionResult CartSummary()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext,cartDb);

            ViewData["CartCount"] = cart.GetCount(cartDb);
            return PartialView("CartSummary");
        }
    }
}
