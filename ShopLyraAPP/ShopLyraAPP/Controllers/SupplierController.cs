using ShopLyraAPP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopLyraAPP.Controllers
{
    public class SupplierController : Controller
    {
        ShopLyraEntity db = new ShopLyraEntity();

        public ActionResult Index()
        {
            var listSupplier = db.Suppliers.ToList();
            return View(listSupplier);
        }
        [HttpGet]
        public ActionResult AddOrUpdateSupplier(int? id)
        {
            Supplier supplier = db.Suppliers.SingleOrDefault(x => x.ID == id);
            if(id>0 && supplier == null)
            {
                return HttpNotFound();
            }
            return View(supplier);
        }
        [HttpPost]
        public ActionResult AddOrUpdateSupplier(Supplier supplier,HttpPostedFileBase Image,HttpPostedFileBase Logo)
        {
            Supplier supplier1 = new Supplier();
            if (ModelState.IsValid)
            {
                string imgfolder = "/images/Supplier/" + DateTime.Now.ToString("yyyy/MM/dd") + "/";
                Directory.CreateDirectory(Server.MapPath(imgfolder));
                if (supplier.ID > 0)
                {
                    supplier1 = db.Suppliers.SingleOrDefault(x => x.ID == supplier.ID);
                    supplier.Location = supplier1.Location;
                }
                if (Image !=null)
                {
                    //Path.GetFileNameWithoutExtension(Image.FileName) + Path.GetExtension(Image.FileName);
                    supplier.Location = imgfolder;
                    string fileName1 = Image.FileName;
                    Image.SaveAs(Path.Combine(Server.MapPath(imgfolder), fileName1));
                    supplier.Image = fileName1;
                }
                else
                {
                    supplier.Image = supplier1.Image;
                }

                if (Logo != null)
                {
                    //Path.GetFileNameWithoutExtension(Logo.FileName) + Path.GetExtension(Logo.FileName);
                    supplier.Location = imgfolder;
                    string fileName2 = Logo.FileName;
                    Logo.SaveAs(Path.Combine(Server.MapPath(imgfolder), fileName2));
                    supplier.Logo = fileName2;
                }
                else supplier.Logo = supplier1.Logo; 
               
                db.Suppliers.AddOrUpdate(supplier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(supplier);
        }

        [HttpPost]
        public JsonResult DeleteSupplier(int id)
        {
            Supplier supplier = db.Suppliers.SingleOrDefault(x => x.ID == id);
            if (supplier == null) return Json(false, JsonRequestBehavior.AllowGet);
            db.Suppliers.Remove(supplier);
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteImg(int id)
        {
            Supplier supplier = db.Suppliers.SingleOrDefault(x => x.ID == id);
            if (supplier == null) return Json(false, JsonRequestBehavior.AllowGet);
            supplier.Image = "";
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteLogo(int id)
        {
            Supplier supplier = db.Suppliers.SingleOrDefault(x => x.ID == id);
            if (supplier == null) return Json(false, JsonRequestBehavior.AllowGet);
            supplier.Logo = "";
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}