using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopLyraAPP.Models;
namespace ShopLyraAPP.Controllers
{
    public class LoadImageController : Controller
    {
        // GET: LoadImage
        List<TestImage> listImg = new List<TestImage>();
        public ActionResult Index()
        {
            
            return View(listImg);
        }
        [HttpGet]
        public ActionResult CreateImg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateImg(TestImage testImage)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var flieName = Request.Files["Image"];
                    if(flieName !=null && flieName.ContentLength > 0)
                    {
                        testImage.Image = flieName.FileName;

                        var filename = Path.Combine("/images/test/", flieName.FileName);

                        flieName.SaveAs(Server.MapPath(filename));
                    }
                    listImg.Add(testImage);
                    return RedirectToAction("Index");
                }
                return View(testImage);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }
    }
}