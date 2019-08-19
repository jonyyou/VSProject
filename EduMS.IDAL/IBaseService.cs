using EduMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EduMS.IDAL
{
    public interface IBaseService<T> : IDisposable where T : BaseEntity
    {
        Task CreateAsync(T model, bool saved = true);
        Task EditAsync(T model, bool saved = true);
        Task RemoveAsync(Guid id, bool saved = true);
        Task RemoveAsync(T model, bool saved = true);

        Task Save();

        Task<T> GetOneByIdAsync(Guid id);
        IQueryable<T> GetAllAsync();

        /// <summary>
        /// 分页
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAllByPageAsync(int pageSize = 10, int pageIndex = 0);

        IQueryable<T> GetAllOrderAsync(bool asc = true);
        IQueryable<T> GetAllByPageOrder(int pageSize = 10, int pageIndex = 0, bool asc = true);
    }
}
