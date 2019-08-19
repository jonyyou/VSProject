using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EduMS.MVCSite.Models.Admin;
using EduMS.BLL;
using System.Threading.Tasks;

namespace EduMS.MVCSite.Areas.Admin.Controllers
{
    public class OriginClassController : Controller
    {
        // GET: Admin/OriginClass
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/OriginClass/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/OriginClass/CreateOriginClass
        [HttpGet]
        public ActionResult CreateOriginClass()
        {
            return View();
        }

        // POST: Admin/OriginClass/CreateOriginClass
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateOriginClass(OriginClassViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            IBLL.IOriginClassManager Manager = new OriginClassManager();
            await Manager.AddClass(model.DepartmentId, model.ClassId,model.ClassName,model.MonitorId);
            return Content("添加成功");
        }


        // GET: Admin/OriginClass/CreateStudents
        [HttpGet]
        public ActionResult CreateStudents()
        {
            return View();
        }

        // POST: Admin/OriginClass/CreateStudents
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateStudents(FormCollection collection)
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
        /*// GET: Admin/OriginClass/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/OriginClass/Edit/5
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

        // GET: Admin/OriginClass/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/OriginClass/Delete/5
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
        }*/
    }
}
