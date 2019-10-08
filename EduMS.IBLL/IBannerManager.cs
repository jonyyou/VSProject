using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduMS.IDAL;
using EduMS.Models;
using EduMS.Dto;

namespace EduMS.IBLL
{
    public interface IBannerManager
    {
        Task AddBanner(int bannerId, string bannerImage, string url, string remark);
        Task DeleteBanner(Guid bannerId);
        Task<List<BannerInfoDto>> GetAllBanners();
    }
}
