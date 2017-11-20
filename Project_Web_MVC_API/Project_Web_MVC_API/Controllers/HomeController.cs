using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Web_MVC_API.Models;
namespace Project_Web_MVC_API.Controllers
{
    public class HomeController : Controller
    {
        Z_XShopEntities db = new Z_XShopEntities();
        public List<Product> ProductList(int count)
        {
            return db.Products.OrderByDescending(p => p.ProductDate).Take(count).ToList();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Features()
        {
            return PartialView();
        }
        public ActionResult BestProduct()
        {
            return PartialView();
        }
        public ActionResult Exemples()
        {
            var list = ProductList(3);
            return PartialView(list);
        }
        public ActionResult Gallery()
        {
            return PartialView();
        }
        public ActionResult Contact()
        {
            return PartialView();
        }
    }
}