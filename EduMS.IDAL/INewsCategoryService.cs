using EduMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.IDAL
{
    public interface INewsCategoryService : IBaseService<Models.NewsCategory>
    {
        Task<NewsCategory> GetOneByName(string categoryName);
    }
}
