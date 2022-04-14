using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        private readonly FiorellaDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public AccountController(FiorellaDbContext context,UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser appUser = await _userManager.FindByEmailAsync(registerVM.UserName);
            if(appUser != null)
            {
                ModelState.AddModelError("", "This username already exists ");
                return View();
            }
            appUser.Name = registerVM.Name;
            appUser.SurName = registerVM.Surname;
            appUser.Email = registerVM.Email;
            appUser.UserName = registerVM.UserName;

            IdentityResult identityResult =  await _userManager.CreateAsync(appUser, registerVM.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }

            return RedirectToAction("Index","home");
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
