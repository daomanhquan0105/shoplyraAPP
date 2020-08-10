using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using ShopLyraAPP.Models;

namespace ShopLyraAPP.Controllers
{
    public class PostCategoriesController : Controller
    {
        ShopLyraEntity db = new ShopLyraEntity();
        // GET: PostCategories
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.listCategories = db.PostCategories.ToList();
            PostCategory postCategory = new PostCategory();
            return View(postCategory);
        }
        
        [HttpGet]
        public ActionResult AddOrUpdate(int? id)
        {
            PostCategory postCategory = db.PostCategories.SingleOrDefault(x => x.ID == id);
            if (id > 0 && postCategory == null) return HttpNotFound();
            return PartialView(postCategory);
        }
        [HttpPost]
        public ActionResult AddOrUpdate(PostCategory postCategory)
        {
            if (postCategory == null) return Json(false, JsonRequestBehavior.AllowGet);
            if(ModelState.IsValid)
            {
                if (postCategory.ID == 0)
                {
                    if (postCategory.CreateDate == null) postCategory.CreateDate = DateTime.Now;
                }
                else if(postCategory.CreateDate == null) postCategory.Modifiledate = DateTime.Now;

                db.PostCategories.AddOrUpdate(postCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(postCategory);
        }
        [HttpPost]
        public JsonResult DeleteCategory(int id)
        {
            PostCategory postCategory = db.PostCategories.SingleOrDefault(x => x.ID == id);
            if (postCategory == null) return Json(false, JsonRequestBehavior.AllowGet);
            List<TagPost> tagPosts = db.TagPosts.Where(x => x.CategoryID == id).ToList();
            db.TagPosts.RemoveRange(tagPosts);
            db.PostCategories.Remove(postCategory);
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}