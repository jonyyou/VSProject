using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EduMS.IBLL;
using EduMS.BLL;
using EduMS.MVCSite.Models;
using System.Threading.Tasks;

namespace EduMS.MVCSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password, string identity)
        {
            IBLL.IUserManager manager = new UserManager();
            Guid uid=new Guid();
            int returnCode = manager.Login(username, password, identity, out uid);
            if(returnCode==0)
            {
                return RedirectToAction("Index","Student");
            }
            else if(returnCode==1)
            {
                return RedirectToAction("Index", "Teacher");
            }
            else
            {
                return Content("<script>alert('用户名或密码错误！');history.go(-1);</script>");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       
    }
}