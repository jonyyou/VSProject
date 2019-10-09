/// BLL层函数原型  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.IBLL
{
    public interface IUserManager
    {
        
        int Login(string userId, string pwd, string identity, out Guid id);
        Task ChangePwd(string userId, int identity, string oldPwd, string newPwd);
        Task ChangeUserInformaion(string userId, string stuName, string gender, string IDNumber, string pwd);
        Task<Dto.UserInfoDto> GetUserByUserId(string userId, int identity);
    }
}
