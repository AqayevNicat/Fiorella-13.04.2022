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
    public class BasketController : Controller
    {
        private readonly FiorellaDbContext _context;
        public BasketController(FiorellaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<BasketVM> basketVMs = new List<BasketVM>();
            string cookie = HttpContext.Request.Cookies["basket"];
            if (cookie != null){
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookie);
            }
            foreach (BasketVM item in basketVMs)
            {
                item.Category = _context.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == item.Id).Category;
                item.CategoryId = _context.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == item.Id).Category.Id;
                item.Image = _context.Products.FirstOrDefault(P => P.Id == item.Id).Image;
                item.Name = _context.Products.FirstOrDefault(P => P.Id == item.Id).Name;
                item.Price = _context.Products.FirstOrDefault(P => P.Id == item.Id).Price;
                item.Count = basketVMs.FirstOrDefault(b => b.Id == item.Id).Count;
            }
            return View(basketVMs);
        }
    }
}
