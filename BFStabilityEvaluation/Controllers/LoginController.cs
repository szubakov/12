
using BFStabilityEvaluation.Models;
using BFStabilityEvaluation.Models.LoginViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BFStabilityEvaluation.Controllers
{
    public class LoginController : Controller
    {

        private PraktiContext _context;
        public LoginController(PraktiContext context)
            {
            _context = context;
            }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)      
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = _context.Users.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);
            if (user == null)
            {
                return View();
            }
            // auth

            await Authenticate(user);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Register(LoginRegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

       
            if (_context.Users.Any(x => x.Username == model.Username))
            {
                return View();
            }

            var user = new User
            {
                Username = model.Username,
                Password = model.Password,
                Role = (byte)UserRole.User
            };
            _context.Users.Add(user);
            _context.SaveChanges();
         
            await Authenticate(user);
            return RedirectToAction("Index", "Home");
        }
        //public async Task<IActionResult> Register(LoginRegisterViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }
        //    if (_context.Users.Any(x => x.Username == model.Username))
        //    {
        //        return View();
        //    }

        //var user = new User
        //{
        //    Username = model.Username,
        //    Password=model.Password,
        //    Role=UserRole.User
        //};

        //_context.Users.Add(user);
        //await Authenticate(user);
        //return RedirectToAction("Index", "Home");


        public IActionResult Register()
        {
            //
            return View();
        }
        public async Task <IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }



        private async Task Authenticate(User user)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Username),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.ToString())
            };

            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аунт куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }


    }
}