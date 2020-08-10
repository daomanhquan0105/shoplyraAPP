using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Helpers;
using ShopLyraAPP.Models;

namespace ShopLyraAPP.Controllers
{
    public class ProductCategoriesController : Controller
    {
        ShopLyraEntity db = new ShopLyraEntity();
        // GET: ProductCategories
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.listCategories = db.ProductCategories.ToList();
            return View();
        }
        [HttpGet]
        public ActionResult AddOrUpdateCategory(int? id)
        {
            ProductCategory productCategory = db.ProductCategories.SingleOrDefault(x => x.ID == id);
            if (id > 0 && productCategory==null)
            {
                return HttpNotFound();
            }
            return View(productCategory);
        }
        [HttpPost]
        public ActionResult AddOrUpdateCategory(ProductCategory productCategory)
        {
            if (ModelState.IsValid)
            {
                ProductCategory productCategory1 = new ProductCategory();
                try
                {
                    HttpPostedFileBase fileImg = Request.Files["Image"];
                    HttpPostedFileBase fileLogo = Request.Files["Logo"];
                    string imgfolder = "/images/productCategories/" + DateTime.Now.ToString("yyyy/MM/dd");
                    HtmlHelpers.CreateFolder(Server.MapPath(imgfolder));
                    if (productCategory.ID > 0 && productCategory.Modifiledate == null)
                        productCategory.Modifiledate = DateTime.Now;
                    if (productCategory.ID == 0 && productCategory.CreateDate == null)
                        productCategory.CreateDate = DateTime.Now;
                    
                    if (productCategory.ID == 0)
                    {
                        if (fileImg.ContentLength == 0 && fileLogo.ContentLength == 0 || fileLogo.ContentLength == 0 || fileImg.ContentLength == 0)
                        {
                            ViewBag.ThongBao = "Bạn chưa chọn ảnh";
                            return View(productCategory);
                        }    
                    }
                    if (fileImg.ContentLength > 0 && fileLogo.ContentLength > 0)
                    {
                        productCategory.Image = DateTime.Now.ToString("yyyy/MM/dd")+"/"+ fileImg.FileName;
                        fileImg.SaveAs(Path.Combine(Server.MapPath(imgfolder), fileImg.FileName));

                        productCategory.Logo = DateTime.Now.ToString("yyyy/MM/dd") + "/" + fileLogo.FileName;
                        fileLogo.SaveAs(Path.Combine(Server.MapPath(imgfolder), fileLogo.FileName));
                    }
                    else
                    {
                        productCategory1 = db.ProductCategories.Single(x => x.ID == productCategory.ID);
                        if (fileImg.ContentLength == 0 && fileLogo.ContentLength == 0)
                        {
                            if (productCategory.ID > 0)
                            {
                                productCategory.Image = productCategory1.Image;
                                productCategory.Logo = productCategory1.Logo;
                            }
                        }
                        else
                        {
                            if (fileImg.ContentLength > 0)
                            {
                                productCategory.Image = DateTime.Now.ToString("yyyy/MM/dd") + "/" + fileImg.FileName;
                                fileImg.SaveAs(Path.Combine(Server.MapPath(imgfolder), fileImg.FileName));
                                productCategory.Logo = productCategory1.Logo;
                            }
                            if(fileLogo.ContentLength > 0)
                            {
                                productCategory.Logo = DateTime.Now.ToString("yyyy/MM/dd") + "/" + fileLogo.FileName;
                                fileLogo.SaveAs(Path.Combine(Server.MapPath(imgfolder), fileLogo.FileName));
                                productCategory.Image = productCategory1.Image;
                            }
                        }
                    }
                    db.ProductCategories.AddOrUpdate(productCategory);
                    db.SaveChanges();
                    ModelState.AddModelError("", "Thành công");
                    return RedirectToAction("Index");
                }
                catch(Exception ex)
                {
                    return Json(ex.Message, JsonRequestBehavior.AllowGet);
                }
            }
            return View(productCategory);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductCategory productCategory)
        {
            if (ModelState.IsValid)
            {
                HttpPostedFileBase fileImg = Request.Files["Image"];                
                if (fileImg != null && fileImg.ContentLength > 0 && HtmlHelpers.IsImage(fileImg))
                {
                    if (!HtmlHelpers.CheckFileExt(fileImg.FileName, "jpg|jpeg|png|gif"))
                    {
                        ModelState.AddModelError("", @"Chỉ chấp nhận định dạng jpg, png, gif, jpeg");
                    }
                    else
                    {
                        if (fileImg.ContentLength > 4000 * 1024)
                        {
                            ModelState.AddModelError("", @"Dung lượng lớn hơn 4MB. Hãy thử lại");
                        }
                        else
                        {
                            var imgPath = "/images/categories/" + DateTime.Now.ToString("yyyy/MM/dd");
                            HtmlHelpers.CreateFolder(Server.MapPath(imgPath));
                            var imgFileName = DateTime.Now.ToFileTimeUtc() + "." + HtmlHelpers.GetExt(fileImg.FileName);

                            productCategory.Image = DateTime.Now.ToString("yyyy/MM/dd") + "/" + imgFileName;

                            var newImage = Image.FromStream(fileImg.InputStream);
                            var fixSizeImage = HtmlHelpers.FixedSize(newImage, 275, 560, false);
                            HtmlHelpers.SaveJpeg(Server.MapPath(Path.Combine(imgPath, imgFileName)), fixSizeImage, 90);
                        }
                    }
                }
                HttpPostedFileBase fileLogo = Request.Files["Logo"];
                if (fileLogo != null && fileLogo.ContentLength > 0 && HtmlHelpers.IsImage(fileLogo))
                {
                    if (!HtmlHelpers.CheckFileExt(fileLogo.FileName, "jpg|jpeg|png|gif"))
                    {
                        ModelState.AddModelError("", @"Chỉ chấp nhận định dạng jpg, png, gif, jpeg");
                    }
                    else
                    {
                        if (fileImg.ContentLength > 4000 * 1024)
                        {
                            ModelState.AddModelError("", @"Dung lượng lớn hơn 4MB. Hãy thử lại");
                        }
                        else
                        {
                            var imgPath = "/images/productCategories/" + DateTime.Now.ToString("yyyy/MM/dd");
                            HtmlHelpers.CreateFolder(Server.MapPath(imgPath));
                            var imgFileName = DateTime.Now.ToFileTimeUtc() + "." + HtmlHelpers.GetExt(fileImg.FileName);

                            productCategory.Image = DateTime.Now.ToString("yyyy/MM/dd") + "/" + imgFileName;

                            var newImage = Image.FromStream(fileImg.InputStream);
                            var fixSizeImage = HtmlHelpers.FixedSize(newImage, 275, 560, false);
                            HtmlHelpers.SaveJpeg(Server.MapPath(Path.Combine(imgPath, imgFileName)), fixSizeImage, 90);
                        }
                    }
                }
                return RedirectToAction("Index");
            }
            return View(productCategory);
        }

        [HttpPost]
        public JsonResult DeleteCategory(int? id)
        {
            ProductCategory productCategory = db.ProductCategories.SingleOrDefault(x => x.ID == id);
            if (productCategory == null) return Json(false, JsonRequestBehavior.AllowGet);

            List<TagCategory> listTag = db.TagCategories.Where(x => x.CategoryID == id).ToList();
            db.TagCategories.RemoveRange(listTag);
            db.ProductCategories.Remove(productCategory);
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteImage(int? id)
        {
            ProductCategory productCategory = db.ProductCategories.SingleOrDefault(x => x.ID == id);
            if (productCategory == null) return Json(false, JsonRequestBehavior.AllowGet);
            productCategory.Image = "";
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult DeleteLogo(int? id)
        {
            ProductCategory productCategory = db.ProductCategories.SingleOrDefault(x => x.ID == id);
            if (productCategory == null) return Json(false, JsonRequestBehavior.AllowGet);
            productCategory.Logo = "";
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult CreateProductCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProductCategory(ProductCategory productCategory)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var file = Request.Files["Image"];
                    //string urlFolder = "/images/productCategories" + DateTime.Now.ToString("yyyy/MM/dd");
                    //Directory.CreateDirectory(Server.MapPath(urlFolder));
                    if (file != null && file.ContentLength > 0)
                    {
                        productCategory.Image = DateTime.Now.ToString("yyyy/MM/dd") + "/" + file.FileName;

                        var filename = Path.Combine("/images/productCategories/", file.FileName);

                        file.SaveAs(Server.MapPath(filename));
                    }
                    else
                    {
                        ModelState.AddModelError("", "Bạn chưa chọn ảnh");
                        return View(productCategory);
                    }

                    //if(Logo != null)
                    //{
                    //    productCategory.Logo = DateTime.Now.ToString("yyyy/MM/dd") + "/" + Logo.FileName;
                    //    Logo.SaveAs(Path.Combine(Server.MapPath(urlFolder), Logo.FileName));
                    //}
                    //else
                    //{
                    //    ModelState.AddModelError("", "Bạn chưa chọn logo");
                    //    return View(productCategory);
                    //}

                    if (productCategory.CreateDate == null) productCategory.CreateDate = DateTime.Now;

                    db.ProductCategories.Add(productCategory);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(productCategory);
            }
            catch(Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (disposing)
                    db.Dispose();
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}