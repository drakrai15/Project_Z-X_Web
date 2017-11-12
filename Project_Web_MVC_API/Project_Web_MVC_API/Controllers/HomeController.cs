using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Web_MVC_API.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Features()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Exemples()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}