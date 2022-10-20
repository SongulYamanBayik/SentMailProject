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
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignInModel userSignInModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(userSignInModel.UserName, userSignInModel.Password, false, true);

                if (result.Succeeded)
                {

                    return RedirectToAction("Index", "Profile");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}
