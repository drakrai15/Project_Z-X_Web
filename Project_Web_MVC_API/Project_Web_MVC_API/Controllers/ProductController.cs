using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Web_MVC_API.Models;

namespace Project_Web_MVC_API.Controllers
{
    public class ProductController : Controller
    {
        Z_XShopEntities db = new Z_XShopEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product_Details()
        {
            return PartialView();
        }
    }
}