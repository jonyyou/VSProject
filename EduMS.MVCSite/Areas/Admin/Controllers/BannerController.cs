using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using EduMS.BLL;
using EduMS.MVCSite.Models.Admin;

namespace EduMS.MVCSite.Areas.Admin.Controllers
{
    public class BannerController : Controller
    {
        // GET: Admin/Banner
        public async Task<ActionResult> Index()
        {
            return View(await new BannerManager().GetAllBanners());
        }

        [HttpGet]
        public ActionResult AddBanner()
        {
            return View();
        }

        [HttpPost]
        public  ActionResult AddBanner(HttpPostedFileBase file)
        {
            if (file == null)
                return Content("请选择图片上传","text/plain");

            string extension = Path.GetExtension(file.FileName);
            string[] fileTypes = new string[] { ".gif", ".jpg", ".jpeg", ".png", ".bmp" };
            if (fileTypes.Contains(extension.ToLower()))
            {
                string webRootPath = Server.MapPath("/");
                string relativePath = "\\Banners";
                string absolutePath = webRootPath + relativePath;
                
                if (!Directory.Exists(absolutePath))
                    Directory.CreateDirectory(absolutePath);

                string fileName = Path.GetFileName(file.FileName) + extension;
                var filePath = absolutePath + "\\" + fileName;
                try
                {
                    file.SaveAs(filePath);
                }
                catch
                {
                    return Content("上传异常", "text/plain");
                }
            }
            return Content("请上传图片(.gif, .jpg,.jpeg, .png, .bmp格式)", "text/plain");
            
            

           

            
            

        }

        // GET: Admin/Banner/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Banner/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Banner/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Banner/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Banner/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Banner/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Banner/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
