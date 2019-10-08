using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduMS.IDAL;
using EduMS.Models;

namespace EduMS.DAL
{
    public class NewsCategoryService:BaseService<Models.NewsCategory>, INewsCategoryService
    {
        public NewsCategoryService()
            :base(new EduContext())
        {

        }

        public async Task<NewsCategory> GetOneByName(string categoryName)
        {
            return await GetAllAsync().FirstAsync(m => m.CategoryName== categoryName);
        }
    }
}
