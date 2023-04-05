﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SpryStore.EntityLayer.Concrete;
using SpryStore.PresentationLayer.Models;
using System.Threading.Tasks;

namespace SpryStore.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel registerViewModel)
        {
            AppUser appUser = new AppUser()
            {
                Name = registerViewModel.Name,
                SurName = registerViewModel.Surname,
                Email = registerViewModel.EMail,
                UserName = registerViewModel.Username,
                City = registerViewModel.City
            };
            var result=await _userManager.CreateAsync(appUser,registerViewModel.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            else
            {
                return View();
            }
        }
    }
}
