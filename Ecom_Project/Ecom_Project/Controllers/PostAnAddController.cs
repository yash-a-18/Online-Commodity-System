using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ecom_Project.Data;
using Ecom_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Ecom_Project.Controllers
{
    [Authorize]
    public class PostAnAddController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public PostAnAddController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager, ApplicationDbContext context,IWebHostEnvironment hostEnvironment)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this._context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: PostAnAdd
        public async Task<IActionResult> Index()
        {
            var OwnerEmail = User.Identity.Name;
            //var OwnerName = _context.User.FirstOrDefault(u => u.Email == User.Identity.Name).FullName;
            var applicationDbContext = _context.Item.Where(o=>o.OwnerEmail==OwnerEmail).Include(i => i.category).Include(i => i.seller);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PostAnAdd/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item
                .Include(i => i.category)
                .Include(i => i.seller)
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: PostAnAdd/Create
        public IActionResult Create()
        {
            if (signInManager.IsSignedIn(User))
            {
                ViewData["OwnerEmail"] = User.Identity.Name;
                ViewData["OwnerName"] = _context.User.FirstOrDefault(u => u.Email == User.Identity.Name).FullName;
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CatgeoryId", "categoryName");
            ViewData["SellerId"] = new SelectList(_context.Seller, "SellerId", "sellerName");
            return View();
        }

        // POST: PostAnAdd/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemId,CategoryId,SellerId,price,ImageFile,Title,OwnerEmail,OwnerName")] Item item)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(item.ImageFile.FileName);
                string extension = Path.GetExtension(item.ImageFile.FileName);
                item.itemURl=fileName=fileName+DateTime.Now.ToString("yymmssfff")+extension;
                string path = Path.Combine(wwwRootPath + "/Images/",fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await item.ImageFile.CopyToAsync(fileStream);
                }

                item.OwnerEmail = User.Identity.Name;
                item.OwnerName = _context.User.FirstOrDefault(u => u.Email == User.Identity.Name).FullName;
                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OwnerEmail"] = User.Identity.Name;
            ViewData["OwnerName"] = _context.User.FirstOrDefault(u => u.Email == User.Identity.Name).FullName;
            ViewData["CategoryId"] = new SelectList(_context.Category, "CatgeoryId", "categoryName", item.CategoryId);
            ViewData["SellerId"] = new SelectList(_context.Seller, "SellerId", "sellerName", item.SellerId);
            return View(item);
        }

        // GET: PostAnAdd/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            if (signInManager.IsSignedIn(User))
            {
                ViewData["OwnerEmail"] = User.Identity.Name;
                ViewData["OwnerName"] = _context.User.FirstOrDefault(u => u.Email == User.Identity.Name).FullName;
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CatgeoryId", "categoryName", item.CategoryId);
            ViewData["SellerId"] = new SelectList(_context.Seller, "SellerId", "sellerName", item.SellerId);
            return View(item);
        }

        // POST: PostAnAdd/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemId,CategoryId,SellerId,price,itemURl,Title,OwnerEmail,OwnerName")] Item item)
        {
            if (id != item.ItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.ItemId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["OwnerEmail"] = User.Identity.Name;
            ViewData["OwnerName"] = _context.User.FirstOrDefault(u => u.Email == User.Identity.Name).FullName;
            ViewData["CategoryId"] = new SelectList(_context.Category, "CatgeoryId", "categoryName", item.CategoryId);
            ViewData["SellerId"] = new SelectList(_context.Seller, "SellerId", "sellerName", item.SellerId);
            return View(item);
        }

        // GET: PostAnAdd/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item
                .Include(i => i.category)
                .Include(i => i.seller)
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: PostAnAdd/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Item.FindAsync(id);

            var imagePath = Path.Combine(_hostEnvironment.WebRootPath,"Images",item.itemURl);
            if(System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }

            _context.Item.Remove(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemExists(int id)
        {
            return _context.Item.Any(e => e.ItemId == id);
        }
    }
}
