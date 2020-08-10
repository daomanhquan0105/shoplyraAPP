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
    public class ConfigController : Controller
    {
        ShopLyraEntity db = new ShopLyraEntity();
        #region About
        public ActionResult About()
        {
            List<About> listAbout = db.Abouts.ToList();
            return View(listAbout);
        }
        [HttpPost]
        public JsonResult DeleteAbout(int id)
        {
            About ab = db.Abouts.SingleOrDefault(x => x.ID == id);
            if (ab == null) return Json(false, JsonRequestBehavior.AllowGet);
            db.Abouts.Remove(ab);
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult AddOrUpdateAbout(int? id)
        {
            About about = db.Abouts.SingleOrDefault(x => x.ID == id);
            if (id > 0 && about == null) return HttpNotFound();
            return View(about);
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult AddOrUpdateAbout(About about)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Abouts.AddOrUpdate(about);
                    db.SaveChanges();
                    return RedirectToAction("About");
                }
                return View();
            }
            catch(Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }
        #endregion
        #region Slider
        public ActionResult Slider()
        {
            var listSlider = db.Sliders.ToList();
            return View(listSlider);
        }
        [HttpPost]
        public JsonResult Deleteslider(int id)
        {
            Slider slider = db.Sliders.SingleOrDefault(x => x.ID == id);
            if (slider == null) return Json(false, JsonRequestBehavior.AllowGet);
            db.Sliders.Remove(slider);
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult AddOrUpdateSlider(int? id)
        {
            Slider slider = db.Sliders.SingleOrDefault(x => x.ID == id);
            if (id > 0 && slider == null) return HttpNotFound();
            return View(slider);
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult AddOrUpdateSlider(Slider slider,HttpPostedFileBase Image)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (slider.ID == 0 && Image == null) return View(slider);
                    string imgfolder = "/images/Slider/" + DateTime.Now.ToString("yyyy/MM/dd");
                    Directory.CreateDirectory(Server.MapPath(imgfolder));
                    
                    if(Image!=null)
                    {
                        if (Image.ContentLength > 0)
                        {
                            slider.Image = DateTime.Now.ToString("yyyy/MM/dd") + "/" + Image.FileName;
                            Image.SaveAs(Path.Combine(Server.MapPath(imgfolder), Image.FileName));
                        }
                    }
                    else
                    {
                        if (slider.ID > 0)
                        {
                            Slider slider1 = db.Sliders.SingleOrDefault(x => x.ID == slider.ID);
                            slider.Image = slider1.Image;
                        }
                    }

                    if (slider.ID == 0 && slider.CreateDate == null) slider.CreateDate = DateTime.Now;
                    if (slider.ID > 0 && slider.Modifiledate == null) slider.Modifiledate = DateTime.Now;
                    db.Sliders.AddOrUpdate(slider);
                    db.SaveChanges();
                    return RedirectToAction("Slider");
                }
                return View(slider);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            } 
        }

        [HttpPost]
        public JsonResult deleteImageSlider(int id)
        {
            Slider slider = db.Sliders.SingleOrDefault(x => x.ID == id);
            if (slider == null) return Json(false, JsonRequestBehavior.AllowGet);
            slider.Image = "1";
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #region Feedback
        public ActionResult ListFeedBack()
        {
            List<FeedBack> feedBacks = db.FeedBacks.ToList();
            return View(feedBacks);
        }
        [HttpPost]
        public JsonResult DeletefeedBack(int id)
        {
            FeedBack feedBack = db.FeedBacks.SingleOrDefault(x => x.ID == id);
            if (feedBack == null) return Json(false, JsonRequestBehavior.AllowGet);
            db.FeedBacks.Remove(feedBack);
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult AddOrUpdateFeedBack(int? id)
        {
            FeedBack feddBack = db.FeedBacks.SingleOrDefault(x => x.ID == id);
            if (feddBack == null && id > 0) return HttpNotFound();
            return View(feddBack);
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult AddOrUpdateFeedBack(FeedBack feedBack,HttpPostedFileBase Image)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string imgfolder = "/images/FeedBack/" + DateTime.Now.ToString("yyyy/MM/dd");
                    Directory.CreateDirectory(Server.MapPath(imgfolder));

                    if (Image != null)
                    {
                        if (Image.ContentLength > 0)
                        {
                            feedBack.Image = DateTime.Now.ToString("yyyy/MM/dd") + "/" + Image.FileName;
                            Image.SaveAs(Path.Combine(Server.MapPath(imgfolder), Image.FileName));
                        }
                    }
                    else
                    {
                        if (feedBack.ID > 0)
                        {
                            FeedBack feedBack1 = db.FeedBacks.SingleOrDefault(x => x.ID == feedBack.ID);
                            feedBack.Image = feedBack1.Image;
                        }
                    }
                    db.FeedBacks.AddOrUpdate(feedBack);
                    db.SaveChanges();
                    return RedirectToAction("ListFeedBack");
                }
                return View(feedBack);
            }
            catch(Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult DeleteImageFeedBack(int id)
        {
            FeedBack feedBack = db.FeedBacks.SingleOrDefault(x => x.ID == id);
            if (feedBack == null) return Json(false, JsonRequestBehavior.AllowGet);
            feedBack.Image = "";
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #region configuration
        public ActionResult Configuration()
        {
            List<Config> configs = db.Configs.ToList();
            return View(configs);
        }
        [HttpPost]
        public JsonResult DeleteConfig(int id)
        {
            Config config = db.Configs.SingleOrDefault(x => x.ID == id);
            if (config == null) return Json(false, JsonRequestBehavior.AllowGet);
            db.Configs.Remove(config);
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult AddOrUpdateConfig(int? id)
        {
            Config config = db.Configs.SingleOrDefault(x => x.ID == id);
            if (id > 0 && config == null) return HttpNotFound();
            return View(config);
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult AddOrUpdateConfig(Config config)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (config.ID == 0 && config.CreateDate == null) config.CreateDate = DateTime.Now;
                    if (config.ID > 0 && config.ModifileDate == null) config.ModifileDate = DateTime.Now;
                    db.Configs.AddOrUpdate(config);
                    db.SaveChanges();
                    return RedirectToAction("Configuration");
                }
                return View(config);
            }
            catch(Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }
        #endregion
    }
}