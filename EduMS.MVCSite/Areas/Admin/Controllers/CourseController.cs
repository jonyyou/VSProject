using EduMS.BLL;
using EduMS.Dto;
using EduMS.MVCSite.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EduMS.MVCSite.Areas.Admin.Controllers
{
    public class CourseController : Controller
    {
        // GET: Admin/Course
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View(await new CourseManager().GetAllCourses());
        }

        // GET: Admin/Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Course/Create   创建课程
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CourseViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            IBLL.ICourseManager Manager = new CourseManager();
            await Manager.AddCourse(model.CourseId,model.CourseName,model.Credits,model.Hours,model.CourseSpecialty, model.Description);
            return Content("添加成功");
        }

        [HttpGet]
        public async Task<ActionResult> AddCaltivatePlan()
        {

            IBLL.IDepart_SpeManager Mnger = new Depart_SpeManager();
            List<DepartmentInfoDto> departmentList = await Mnger.GetAllDepartments(); ;
            ViewBag.DepartmentList = departmentList;

            IBLL.ICourseManager Mnger2 = new CourseManager();
            List<CourseInfoDto> courseList = await Mnger2.GetAllCourses(); ;
            ViewBag.CourseList = courseList;

            var semesterList = new List<SelectListItem>() {
                new SelectListItem() { Value = "1-1", Text = "大一上" },
                new SelectListItem() { Value = "1-2", Text = "大一下" },
                new SelectListItem() { Value = "2-1", Text = "大二上" },
                new SelectListItem() { Value = "2-2", Text = "大二下" },
                new SelectListItem() { Value = "3-1", Text = "大三上" },
                new SelectListItem() { Value = "3-2", Text = "大三下" },
                new SelectListItem() { Value = "4-1", Text = "大四上" },
                new SelectListItem() { Value = "4-2", Text = "大四下" }

            };

            ViewBag.SemesterList = semesterList;
            return View();
        }

        // POST: Admin/Course/Create   创建课程
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddCaltivatePlan(CaltivatePlanViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            IBLL.ICourseManager Manager = new CourseManager();
            await Manager.AddCaltivatePlan(model.Semester, model.CourseId,model.DepartmentId);
            return Content("添加成功");
        }

        [HttpGet]
        public async Task<ActionResult> CaltivatePlanList(string departmentId, string semester)
        {
            IBLL.IDepart_SpeManager Mnger = new Depart_SpeManager();
            List<String> departmentList = await Mnger.GetAllDepartmentId();
            ViewBag.DepartmentList = new SelectList(departmentList);
           
            var semesterList = new List<SelectListItem>() {
                new SelectListItem() { Value = "1-1", Text = "大一上" },
                new SelectListItem() { Value = "1-2", Text = "大一下" },
                new SelectListItem() { Value = "2-1", Text = "大二上" },
                new SelectListItem() { Value = "2-2", Text = "大二下" },
                new SelectListItem() { Value = "3-1", Text = "大三上" },
                new SelectListItem() { Value = "3-2", Text = "大三下" },
                new SelectListItem() { Value = "4-1", Text = "大四上" },
                new SelectListItem() { Value = "4-2", Text = "大四下" }

            };

            ViewBag.SemesterList = semesterList;

            IBLL.ICourseManager Manager = new CourseManager();
            List<CaltivatePlanDto> caltivatePlanList = await Manager.GetAllCoursesByDepart(departmentId, semester);
            return View(caltivatePlanList);
        }


        /*public async Task<ActionResult> ShowCourseInCalPlan*/

        // GET: Admin/Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Course/Edit/5
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

        // GET: Admin/Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Course/Delete/5
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
