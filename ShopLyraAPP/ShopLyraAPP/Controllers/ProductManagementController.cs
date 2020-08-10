using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Helpers;
using Microsoft.Ajax.Utilities;
using ShopLyraAPP.Models;
using ShopLyraAPP.ViewModel;

namespace ShopLyraAPP.Controllers
{
    public class ProductManagementController : Controller
    {
        // GET: ProductManagement
        ShopLyraEntity db = new ShopLyraEntity();
        public ActionResult Index()
        {
            ListProductViewModel model = new ListProductViewModel();
            model.listProduct = db.Products.Where(x => x.Remove == false).OrderBy(x => x.DisplayOrder).ToList();

            model.listCategory = db.ProductCategories.OrderBy(x => x.ID).ToList();
            model.listTag = db.TagCategories.ToList();

            model.listSupplier = db.Suppliers.ToList();
            return View(model);
        }
        [HttpGet]
        public ActionResult CreateProduct()
        {
            using (var db = new ShopLyraEntity())
            {
                ViewBag.ProductCategories = db.ProductCategories.ToList();
                ViewBag.Suppliers = db.Suppliers.ToList();
                ViewBag.Colors = db.Colors.ToList();
                ViewBag.Sizes = db.Sizes.ToList();
                return View();
            }
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult CreateProduct(Product productNew, List<int> categories, List<HttpPostedFileBase> selectImages, List<string> image)
        {
            using (var db = new ShopLyraEntity())
            {
                ViewBag.ProductCategories = db.ProductCategories.ToList();
                ViewBag.Suppliers = db.Suppliers.ToList();
                ViewBag.Colors = db.Colors.ToList();
                ViewBag.Sizes = db.Sizes.ToList();
                if (productNew == null)
                {
                    return View(productNew);
                }
                //db.Products.Add(productNew);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult EditProduct(int? id = 0)
        {
            using (var db = new ShopLyraEntity())
            {
                ViewBag.ProductCategories = new SelectList(db.ProductCategories, "ID", "Name");
                ViewBag.Suppliers = new SelectList(db.Suppliers, "ID", "Name");
                ViewBag.Colors = new SelectList(db.Colors, "ID", "Color");
                ViewBag.Sizes = new SelectList(db.Sizes, "ID", "Size");
                if (id == 0)
                {
                    return HttpNotFound();
                }
                Product productEdit = db.Products.SingleOrDefault(x => x.ID == id);
                if (productEdit == null)
                {
                    return HttpNotFound();
                }
                //db.Products.AddOrUpdate(productEdit);
                //db.SaveChanges();

                return View(productEdit);
            }
        }
        [HttpPost]
        public ActionResult EditProduct(Product productEdit)
        {
            using (var db = new ShopLyraEntity())
            {
                ViewBag.ProductCategories = new SelectList(db.ProductCategories, "ID", "Name");
                ViewBag.Suppliers = new SelectList(db.Suppliers, "ID", "Name");
                ViewBag.Colors = new SelectList(db.Colors, "ID", "Color");
                ViewBag.Sizes = new SelectList(db.Sizes, "ID", "Size");
                if (ModelState.IsValid)
                {
                    db.Products.AddOrUpdate(productEdit);
                    db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(productEdit);
            }
        }
        [HttpPost]
        public ActionResult DeleteProduct(int? id = 0)
        {
            using (var db = new ShopLyraEntity())
            {
                if (id == 0)
                {
                    return HttpNotFound();
                }
                Product productDelete = db.Products.SingleOrDefault(x => x.ID == id);
                Boolean res = false;
                if (productDelete == null)
                {
                    return HttpNotFound();
                }
                List<TagCategory> listTag = db.TagCategories.Where(x => x.ProductID == id).ToList();
                db.TagCategories.RemoveRange(listTag);
                db.Products.Remove(productDelete);
                db.SaveChanges();
                res = true;
                return Json(res, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult AddOrUpdateProduct(int? id)
        {
            ListProductViewModel model = new ListProductViewModel();
            model.listProduct = db.Products.Where(x => x.Remove == false).OrderBy(x => x.DisplayOrder).ToList();
            model.listCategory = db.ProductCategories.OrderBy(x => x.ID).ToList();
            model.listTag = db.TagCategories.ToList();
            model.listSupplier = db.Suppliers.ToList();
            ViewBag.ViewModel = model;

            Product product = db.Products.SingleOrDefault(x => x.ID == id);
            if (product == null && id > 0) return HttpNotFound();
            return View(product);
        }

        [HttpPost]
        public ActionResult AddOrUpdateProduct(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    return RedirectToAction("Index");
                }
                return View(product);
            }
            catch(Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }
    }
}