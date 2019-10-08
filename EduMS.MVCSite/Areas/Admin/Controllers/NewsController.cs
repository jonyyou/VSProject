using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EduMS.Dto;
using EduMS.BLL;
using System.Threading.Tasks;
using EduMS.MVCSite.Models.Admin;

namespace EduMS.MVCSite.Areas.Admin.Controllers
{
    public class NewsController : Controller
    {
        // GET: Admin/News   新闻管理
        public async Task<ActionResult> Index()
        {
            return View(await new NewsManager().GetAllNews());
        }

        [HttpGet]
        public async Task<ActionResult> NewsCategoryList()
        {
            return View(await new NewsManager().GetAllNewsCategory());
        }

        [HttpGet]
        public ActionResult AddNewsCategory()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddNewsCategory(NewsCategoryViewModel model)
        {
            if(!ModelState.IsValid)
                return View(model);
            IBLL.INewsManager Manager = new NewsManager();
            await Manager.AddNewsCategory(model.CategoryId,model.CategoryName);
            return Content("添加成功");
        }

        [HttpGet]
        public async Task<ActionResult> AddNews()
        {
            IBLL.INewsManager Mnger = new NewsManager();
            List<NewsCategoryDto> newsCategoryList = await Mnger.GetAllNewsCategory(); ;
            ViewBag.NewsCategoryList = newsCategoryList;
            return View();
          
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddNews(NewsViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            IBLL.INewsManager Manager = new NewsManager();
            await Manager.AddNews(model.Title, model.Content, model.CategoryId);
            return Content("添加成功");
        }


    }
}
