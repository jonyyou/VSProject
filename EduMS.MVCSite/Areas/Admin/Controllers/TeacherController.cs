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
    public class TeacherController : Controller
    {
        // GET: Admin/Teacher
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }


        [HttpGet]       //请求指定页面的信息，并返回实体主体
        public ActionResult CreateTeacher()
        {
            return View();
        }

        [HttpPost]      //向指定资源提交数据进行处理请求
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateTeacher(TeacherViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            IBLL.ITeacherManager Manager = new TeacherManager();
            await Manager.AddTeacher(model.TeaId, model.TeaName,model.TeaGender,model.TeaTele,model.TeaIDNumber,model.Teapwd,model.TeaDepartment);
            return Content("添加成功");
        }
    }
}
