using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SentMailProject.Models.Context;
using SentMailProject.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentMailProject.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpModel userSignUpModel)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser();
                appUser.UserName = userSignUpModel.UserName;
                appUser.Email = userSignUpModel.Mail;
                appUser.Name = userSignUpModel.Name;
                appUser.Surname = userSignUpModel.Surname;

                var result = await _userManager.CreateAsync(appUser, userSignUpModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }

    }
}
