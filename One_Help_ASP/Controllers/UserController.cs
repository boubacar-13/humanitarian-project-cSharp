using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using One_Help_ASP.Data;
using One_Help_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace One_Help_ASP.Controllers
{
    public class UserController : Controller
    {
        private readonly MyDbContext _context;

        public UserController(MyDbContext context)
        {
            _context = context;
        }
        //get name
        public IActionResult Index()
        {
            string userName = HttpContext.User.Identity.Name;
            return View(userName);
        }

        //get login
        public IActionResult Login()
        {
            return View();
        }

        //Post login
        [HttpPost]
        public IActionResult Login(User user)
        {
            var usr = _context.User.Where(x=> x.Email==user.Email && x.Password==user.Password );
            if (usr.Count() != 0)
            {
                HttpContext.Session.SetString("email", user.Email);
                //HttpContext.Session.SetString("statu", user.Statu);

               
                return RedirectToAction("Index", "Home");
               
            }
            else
            {
                TempData["msg"] = "Email/password  incorrect";
            }
            return View();

        }



        public IActionResult Logout()
        {  
            HttpContext.Session.Clear();
            return View("Login");
        }
    }
}
