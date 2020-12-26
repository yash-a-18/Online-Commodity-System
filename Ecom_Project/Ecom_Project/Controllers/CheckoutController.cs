using Ecom_Project.Data;
using Ecom_Project.Models;
using Ecom_Project.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom_Project.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApplicationDbContext _context;
        public CheckoutController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager, ApplicationDbContext context)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this._context = context;
        }
        public IActionResult Index()
        {
            Order order = new Order();
            var cart = ShoppingCart.GetCart(this.HttpContext, _context);
            if (signInManager.IsSignedIn(User))
            {
                //Console.WriteLine(User.Identity.Name);
                //Console.WriteLine(_context.User.FirstOrDefault(u => u.Email == User.Identity.Name).FullName);
                var u = _context.User.FirstOrDefault(u => u.Email == User.Identity.Name);
                var o = _context.Cart.Where(u => u.CartId == User.Identity.Name).ToList();
                var total = cart.GetTotal(_context);
                //Console.WriteLine(total);
                OrderViewModel orderViewModel = new OrderViewModel
                {
                    user =u,
                    //order = order,
                    Total=total
                };
                var src = DateTime.Now;
                ViewBag.datetime = new DateTime(src.Year, src.Month, src.Day, src.Hour, src.Minute,0);
                return View(orderViewModel);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(OrderViewModel orderViewModel)
        {
            _context.Add(orderViewModel.order);
            await _context.SaveChangesAsync();
            var cart = ShoppingCart.GetCart(this.HttpContext, _context);
            var orderId = cart.CreateOrder(orderViewModel.order, _context,this.HttpContext);
            return RedirectToAction("OrderDetails", new { orderId = orderId });
        }
        public IActionResult OrderDetails(int orderId)
        {
            var orderDetails = _context.OrderDetails
                .Include("Item")
                .Include("Order")
                .ToList();
            List<OrderDetail> OD = new List<OrderDetail>();
            foreach (var o in orderDetails)
            {
                if(o.username==User.Identity.Name)
                {
                    OD.Add(o);
                }
            }
            ViewBag.orderId = orderId;
            return View(OD);
        }
        public IActionResult OrderHistory()
        {
            var orderDetails = _context.OrderDetails
                .Include("Item")
                .Include("Order")
                .ToList();
            List<OrderDetail> OD = new List<OrderDetail>();
            foreach (var o in orderDetails)
            {
                if (o.username == User.Identity.Name)
                {
                    OD.Add(o);
                }
            }
            return View(OD);
        }
    }
}
