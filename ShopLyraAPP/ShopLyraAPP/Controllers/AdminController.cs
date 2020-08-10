using ShopLyraAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopLyraAPP.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult abcdef()
        {
            return View();
        }
        [HttpPost]
        public ActionResult abcdef(Product product)
        {
            if(ModelState.IsValid)
            {
                product.Location = "a";
            }    
            return View();
        }
    }
}