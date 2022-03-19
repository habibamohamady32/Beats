using Beatss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Beatss.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;


        public HomeController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {

            return View();

        }

        public ActionResult About()
        {

            return View();
        }


        public ActionResult HomePage()
        {

            return View();
        }

        public ActionResult Profile()
        {

            return View();
        }

        public ActionResult Songs()
        {
            return View();
        }

        public ActionResult Albums()
        {
            return View();
        }

        public ActionResult Artists()
        {
            return View();
        }

        public ActionResult Liked()
        {
            return View();
        }
    
}
}