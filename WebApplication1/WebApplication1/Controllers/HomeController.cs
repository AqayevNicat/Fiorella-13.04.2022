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
        public IActionResult AddToCookie(int? id)
        {
            if (id == null) return BadRequest();
            Product product = _context.Products.FirstOrDefault(p=>p.Id == id);
            if (product == null) return NotFound();

            string myProduct = JsonConvert.SerializeObject(product);

            HttpContext.Response.Cookies.Append(product.Id.ToString(), myProduct);


            HomeVM homeVM = new HomeVM
            {
                Slider = _context.Sliders.ToList(),
                Category = _context.Categories.ToList(),
                Product = _context.Products.Include(p => p.Category).ToList()
            };

            return RedirectToAction("Index");
        }
    }
}
