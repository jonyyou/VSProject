using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EduMS.MVCSite.Models.Admin;
using EduMS.BLL;
using EduMS.Dto;
using System.Threading.Tasks;

namespace EduMS.MVCSite.Areas.Admin.Controllers
{
    public class OriginClassController : Controller
    {
        // GET: Admin/OriginClass, 自然班级的列表
        /// 从数据库到页面
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View(await new OriginClassManager().GetAllOriginClasses());
        }

        [HttpGet]
        public async Task<ActionResult> StudentList(string classId)
        {
            return View(await new OriginClassManager().GetAllStudents(classId));
        }

        

        // GET: Admin/OriginClass/CreateOriginClass
        [HttpGet]
        public async Task<ActionResult> CreateOriginClass()
        {
            IBLL.IDepart_SpeManager Mnger = new Depart_SpeManager();
            List<DepartmentInfoDto> departmentList = await Mnger.GetAllDepartments(); ;
            ViewBag.DepartmentList = departmentList;
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
        public async Task<ActionResult> CreateStudents()
        {
            IBLL.IDepart_SpeManager Mnger = new Depart_SpeManager();
            List<DepartmentInfoDto> departmentList = await Mnger.GetAllDepartments(); 
            ViewBag.DepartmentList = departmentList;


            IBLL.IOriginClassManager Mnger2 = new OriginClassManager();
            List<OriginClassDto> classList = await Mnger2.GetAllOriginClasses(); 
            ViewBag.classList = classList;
            return View();
        }

        // POST: Admin/OriginClass/CreateStudents
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateStudents(StudentViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            IBLL.IOriginClassManager Manager = new OriginClassManager();
            await Manager.AddStudents(model.DepartmentId, model.ClassId, model.StuId, model.StuName, model.Gender, model.Telephone, model.IDNumber, model.Pwd, model.Major);
            return Content("添加成功");
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
