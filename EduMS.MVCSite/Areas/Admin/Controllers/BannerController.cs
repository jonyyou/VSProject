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
        public  ActionResult AddBannerPost()
        {
            HttpPostedFileBase file = Request.Files["picture"];
            if(file!=null)
            {
                string fileName = file.FileName;
                string str = fileName.Substring(fileName.LastIndexOf("\\") + 1);
                string path = "/Banner/" + Guid.NewGuid() + str;
                file.SaveAs(Server.MapPath(path));
                return Content("上传成功");
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
