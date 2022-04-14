using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            string cookie = HttpContext.Request.Cookies["basket"];
            if (cookie != null){

            }
            return View();
        }
    }
}
