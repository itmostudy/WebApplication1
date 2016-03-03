using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class FilmsController : Controller
    {
        // GET: Films
        public ActionResult Index()
         
        {
            var film = FilmFactory.CreateFilm();
            return View(film);
        }
    }
}