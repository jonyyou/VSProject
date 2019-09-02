using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduMS.Dto;
using EduMS.IBLL;
using EduMS.Models;
using EduMS.IDAL;
using System.Data.Entity;

namespace EduMS.BLL
{
    public class NewsManager : INewsManager
    {
        public async Task AddNews(string title, string content, string categoryName)
        {
            NewsCategory newsCategory= new NewsCategory();
            using (INewsCategoryService svc = new DAL.NewsCategoryService())
            {
                newsCategory = await svc.GetOneByName(categoryName);
            }

            using (IDAL.INewsService Svc = new DAL.NewsService())
            {
                await Svc.CreateAsync(new News()
                {
                    ModifyTime = DateTime.Now,
                    Title = title,
                    Content = content,
                    NewsCategory = newsCategory
                });
            }
        }

        public async Task AddNewsCategory(string newsCategoryName)
        {
            using (IDAL.INewsCategoryService Svc = new DAL.NewsCategoryService())
            {
                await Svc.CreateAsync(new NewsCategory()
                {
                    ModifyTime = DateTime.Now,
                    CategoryName = newsCategoryName
                });
            }
        }

        public async Task<List<NewsCategoryDto>> GetAllNewsCategory()
        {
            using (IDAL.INewsCategoryService Svc = new DAL.NewsCategoryService())
            {
                return await Svc.GetAllAsync().Select(m => new Dto.NewsCategoryDto()
                {
                    CategoryName = m.CategoryName
                }).ToListAsync();
            }
        }

        public async Task<List<NewsDto>> GetAllNews()
        {
            using (IDAL.INewsService Svc = new DAL.NewsService())
            {
                return await Svc.GetAllAsync().Select(m => new Dto.NewsDto()
                {
                    Title = m.Title,
                    Content = m.Content,
                    CategoryName = m.NewsCategory.CategoryName
                }).ToListAsync();
            }
        }
    }
}
