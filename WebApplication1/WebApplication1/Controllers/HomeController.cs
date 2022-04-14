using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly FiorellaDbContext _context;
        public HomeController(FiorellaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> slider = _context.Sliders.ToList();
            List<Category> categories = _context.Categories.ToList();
            List<Product> products = _context.Products.Include(p=>p.Category).ToList();

            HomeVM homeVM = new HomeVM
            {
                Slider = slider,
                Category = categories,
                Product = products
            };

            return View(homeVM);
        }
        public async Task<IActionResult> AddToCookie(int? id)
        {
            if (id == null) return BadRequest();
            Product product = await _context.Products.FirstOrDefaultAsync(p=>p.Id == id);
            if (product == null) return NotFound();

            List<Product> products = new List<Product>();
            string cookie = HttpContext.Request.Cookies["basket"];

            if (cookie == null)
            {
                products.Add(product);
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<Product>>(cookie);
                products.Add(product);
            }

            string myProduct = JsonConvert.SerializeObject(products);
            HttpContext.Response.Cookies.Append("basket", myProduct);

            foreach (Product item in products)
            {
                item.CategoryId = _context.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == item.Id).Category.Id;
                item.Image = _context.Products.FirstOrDefault(p => p.Id == item.Id).Image;
                item.Name = _context.Products.FirstOrDefault(p => p.Id == item.Id).Name;
                item.Price = _context.Products.FirstOrDefault(p => p.Id == item.Id).Price;
                item.Category = _context.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == item.Id).Category;
            }
            return PartialView("_BasketTablePartial", products);
        }
    }
}
