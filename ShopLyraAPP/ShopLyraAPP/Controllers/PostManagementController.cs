using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Helpers;
using ShopLyraAPP.Models;

namespace ShopLyraAPP.Controllers
{
    public class PostManagementController : Controller
    {
        ShopLyraEntity db = new ShopLyraEntity();
        public ActionResult Index()
        {
            List<Post> listPosts = db.Posts.Where(x => x.Remove == false).ToList();
            ViewBag.listTagPosts = db.TagPosts.ToList();
            ViewBag.listPostCategory = db.PostCategories.ToList();
            return View(listPosts);
            
        }
        [HttpGet]
        public ActionResult AddOrUpdatePost(int? id)
        {
            ViewBag.listPostCategory = db.PostCategories.ToList();
            ViewBag.listTagPost = db.TagPosts.Where(x => x.PostID == id).ToList();
            Post post = db.Posts.SingleOrDefault(x => x.ID == id);
            if(id>0 && post==null)
            {
                return HttpNotFound();
            }
            return View(post);
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult AddOrUpdatePost(Post post,List<int> categories,HttpPostedFileBase Images)
        {
            ViewBag.listPostCategory = db.PostCategories.ToList();
            ViewBag.listTagPost = db.TagPosts.Where(x => x.PostID == post.ID).ToList();
            Post post1 = db.Posts.SingleOrDefault(x => x.ID == post.ID);
            if (ModelState.IsValid)
            {
                post.Remove = false;
                if (post.CreateDate == null) post.CreateDate = DateTime.Now;
                if (Images != null)
                {
                    post.Images = Images.FileName;
                    post.Location = PostImages(Images, "post");
                }
                else
                {
                    if(post1!=null)
                    {
                        post.Location = post1.Location;
                        post.Images = post1.Images;
                    }    
                }

                db.Posts.AddOrUpdate(post);
                if (post.ID == 0)
                {
                    post1 = post;
                    db.SaveChanges();
                }
                else db.Posts.AddOrUpdate(post);
                if(categories.Count>0)
                {
                    addTag(post.ID, categories);
                }    
                ViewBag.Context = "thành công";
                return RedirectToAction("Index");
            }
            return View(post);
        }
        private void addTag(long id,List<int> tag)
        {
            if (id > 0)
            {
                List<TagPost> listTag = db.TagPosts.Where(x => x.PostID == id).ToList();
                db.TagPosts.RemoveRange(listTag);
                db.SaveChanges();
            }
            foreach (int i in tag)
            {
                TagPost tagPost = new TagPost()
                {
                    CategoryID = i,
                    PostID = id
                };
                db.TagPosts.Add(tagPost);
            }
            db.SaveChanges();
        }
        public string PostImages(HttpPostedFileBase fileData, string folder)
        {
            //create folder
            string imgfolder = "/images/" + folder + "/" + DateTime.Now.ToString("yyyy/MM/dd") + "/";
            HtmlHelpers.CreateFolder(Server.MapPath(imgfolder));
            //đường dẫn
            string fileName = Path.GetFileNameWithoutExtension(fileData.FileName) + Path.GetExtension(fileData.FileName);
            fileData.SaveAs(Path.Combine(Server.MapPath(imgfolder), fileName));
            return imgfolder;
        }
        [HttpPost]
        public JsonResult DeletePost(int? id)
        {
            Post post = db.Posts.SingleOrDefault(x => x.ID == id);
            if(post == null)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            HtmlHelpers.DeleteFile(post.Location +""+ post.Images);
            List<TagPost> listTag = db.TagPosts.Where(x => x.PostID == id).ToList();
            db.TagPosts.RemoveRange(listTag);
            db.Posts.Remove(post);
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult deleteImage(int id)
        {
            if (id == 0) return Json(false, JsonRequestBehavior.AllowGet);
            Post post = db.Posts.SingleOrDefault(x => x.ID == id);
            post.Images = "";
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult CreatePost()
        {
            ViewBag.listPostCategory = db.PostCategories.ToList();
            return View();
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult CreatePost(Post post, List<int> categories, HttpPostedFileBase Images)
        {
            ViewBag.listPostCategory = db.PostCategories.ToList();
            if (ModelState.IsValid)
            {
                post.Remove = false;
                if (post.CreateDate == null) post.CreateDate = DateTime.Now;
                if (Images != null)
                {
                    post.Images = Images.FileName;
                    post.Location = PostImages(Images, "post");
                }
                db.Posts.Add(post);
                db.SaveChanges();
                addTag(post.ID, categories);
                return RedirectToAction("Index");
            }
            return View(post);
        }
    }
}