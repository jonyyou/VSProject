using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduMS.IBLL;
using EduMS.Models;
using EduMS.IDAL;
using EduMS.DAL;
using EduMS.Dto;
using System.Data.Entity;

namespace EduMS.BLL
{
    public class BannerManager : IBannerManager
    {
        public async Task AddBanner(int bannerId, string bannerImage, string url, string remark)
        {
            
            using (IDAL.IBannerService Svc = new BannerService())
            {
                await Svc.CreateAsync(new Banner
                {
                    ModifyTime = DateTime.Now,
                    BannerId = bannerId,
                    Image = bannerImage,
                    Url = url,
                    Remark = remark
                });
            }
        }

        public async Task DeleteBanner(Guid bannerId)
        {
            using (IDAL.IBannerService Svc = new BannerService())
            {
                await Svc.RemoveAsync(bannerId);
            }
        }

        public async Task<List<BannerInfoDto>> GetAllBanners()
        {
            using (IDAL.IBannerService Svc = new BannerService())
            {
                return await Svc.GetAllAsync().Select(m => new Dto.BannerInfoDto()
                {
                    BannerId = m.BannerId,
                    Image = m.Image,
                    Url = m.Url,
                    Remark = m.Remark,
                    CreateTime = m.CreateTime
                }).ToListAsync();
            }
            
        }
    }
}
