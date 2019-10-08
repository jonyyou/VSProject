using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using EduMS.BLL;
using EduMS.Dto;
using EduMS.MVCSite.Models.Admin;

namespace EduMS.MVCSite.Areas.Admin.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Admin/Department ,获取院系列表
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View(await new Depart_SpeManager().GetAllDepartments());
        }

        [HttpGet]
        public async  Task<ActionResult> SpecialityList(string departmentId)
        {
            return View(await new Depart_SpeManager().GetAllSpecialitys(departmentId));
        }

        // GET: Admin/Department/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Department/CreateDepartment
        [HttpGet]
        public ActionResult CreateDepartment()
        {
            return View();
        }

        // POST: Admin/Department/CreateDepartment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateDepartment(DepartmentViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            IBLL.IDepart_SpeManager Manager = new Depart_SpeManager();
            await Manager.AddDepartment(model.DepartmentId, model.DepartmentName);
            return Content("添加成功");
        }

        // GET: Admin/Department/CreateSpeciality
        [HttpGet]
        public async Task<ActionResult> CreateSpeciality()
        {
            IBLL.IDepart_SpeManager Mnger = new Depart_SpeManager();
            List<DepartmentInfoDto> departmentList = await Mnger.GetAllDepartments(); ;
            ViewBag.DepartmentList = departmentList;
            return View();
        }

        // POST: Admin/Department/CreateSpeciality
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateSpeciality(SpecialityViewModel model)
        {
            
            if (!ModelState.IsValid) return View(model);
            IBLL.IDepart_SpeManager Manager = new Depart_SpeManager();
            await Manager.AddSpeciality(model.SpecialityId, model.SpecialityName, model.DepartmentId);
            return Content("添加成功");
        }





        // GET: Admin/Department/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Department/Edit/5
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

        // GET: Admin/Department/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Department/Delete/5
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
