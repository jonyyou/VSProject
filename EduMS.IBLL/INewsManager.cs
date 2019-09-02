using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduMS.Dto;

namespace EduMS.IBLL
{
    public interface INewsManager
    {
        Task AddNewsCategory(string newsCategoryName);
        //Task DeleteDepartment(string departmentId);
        Task AddNews(string title, string content, string categoryName);
        Task<List<NewsCategoryDto>> GetAllNewsCategory();
        Task<List<NewsDto>> GetAllNews();
    }
}
