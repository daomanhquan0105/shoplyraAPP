using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using ShopLyraAPP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace ShopLyraAPP.Controllers
{
    public class SizeColorController : Controller
    {
        // index
        public ActionResult IndexSizesColor()
        {
            using(var db=new ShopLyraEntity())
            {
                ViewBag.listSize = db.Sizes.ToList();
                ViewBag.listColor = db.Colors.ToList();
                return View();
            }    
        }

        //add or update size
        [HttpGet]
        public JsonResult getSize(int sizeID)
        {
            using(var db=new ShopLyraEntity())
            {
                Size size = db.Sizes.SingleOrDefault(x => x.ID == sizeID);
                string value = string.Empty;
                value = JsonConvert.SerializeObject(size, Formatting.Indented, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
                return Json(value, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public JsonResult SaveDataSize(Size size)
        {
            using (var db = new ShopLyraEntity())
            {
                bool result = false;
                if(size!=null)
                {
                    db.Sizes.AddOrUpdate(size);
                    db.SaveChanges();
                    result = true;
                    return Json(result, JsonRequestBehavior.AllowGet);
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }
        //delete size
        [HttpPost]
        public JsonResult DeleteSize(int? id)
        {
            using (var db = new ShopLyraEntity())
            {
                Size size = db.Sizes.SingleOrDefault(x => x.ID == id);
                db.Sizes.Remove(size);
                db.SaveChanges();
                return Json(true,JsonRequestBehavior.AllowGet);
            }
        }
        //add or update color
        [HttpGet]
        public JsonResult getColor(int colorID)
        {
            using(var db=new ShopLyraEntity())
            {
                Color color = db.Colors.SingleOrDefault(x => x.ID == colorID);
                string value = string.Empty;
                value=JsonConvert.SerializeObject(color,Formatting.Indented,new JsonSerializerSettings
                {
                    ReferenceLoopHandling=ReferenceLoopHandling.Ignore
                });
                return Json(value, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public JsonResult SaveDataColor(Color color)
        {
            using(var db=new ShopLyraEntity())
            {
                db.Colors.AddOrUpdate(color);
                db.SaveChanges();
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }
        //Delete color
        [HttpPost]
        public JsonResult DeleteColor(int id)
        {
            using (var db = new ShopLyraEntity())
            {
                Color color = db.Colors.SingleOrDefault(x => x.ID == id);
                if (color == null) return null;
                db.Colors.AddOrUpdate(color);
                db.SaveChanges();
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }
    }
}