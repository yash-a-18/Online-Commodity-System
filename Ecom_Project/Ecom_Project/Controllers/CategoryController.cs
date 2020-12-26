using Ecom_Project.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ecom_Project.Models;
using Microsoft.AspNetCore.Authorization;

namespace Ecom_Project.Controllers
{
    public class CategoryController : Controller
    {
        ApplicationDbContext categoryDb;
        public string currentCategoryName;
        public string currentSellerName;
        public CategoryController(ApplicationDbContext context)
        {
            categoryDb = context;
        }
        public IActionResult Index()
        {
            var categories = categoryDb.Category.ToList();
            return View(categories);
        }
        public IActionResult Browse(string category)
        {
            var categoryModel = categoryDb.Category.FirstOrDefault(c => c.categoryName == category);
            ViewBag.categoryName = category;
            currentCategoryName = category;
            ViewBag.id=categoryModel.CatgeoryId;
            var Items = categoryDb.Item.ToList();
            return View(Items);
        }
        public IActionResult Details(int id)
        {
            var item = categoryDb.Item.Include(i => i.category)
                .Include(i => i.seller).First(i=>i.ItemId == id);
            return View(item);
        }
    }
}
