using Beatss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Beatss.ViewModels;
namespace Beatss.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext _context;
        public UserController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Register()
        {
            var user = new User();
            var viewmodel = new NewUserViewModel
            {
                user = user
            };
            return View(viewmodel);
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            _context.user.Add(user);
            _context.SaveChanges();
            return RedirectToAction("HomePage", "Home");
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Check(User user)
        {
            if (!ModelState.IsValid)
                ViewBag.error = "Login failed";
            var userInDb = _context.user.SingleOrDefault(u => u.Email == user.Email && u.Password == user.Password);
            if (userInDb == null)
                return RedirectToAction("Login", "User");
            return RedirectToAction("HomePage", "Home");

        }
    }
}