using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Myself()
        {
            return View();
        }
        public ViewResult Results()
        {
            return View();
        }
    }
}