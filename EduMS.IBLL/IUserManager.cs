using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.IBLL
{
    public interface IUserManager
    {
        Task AddStudent(string stuId, string stuName, string gender, string telephone, string IDNumber, string pwd, string major, string classId);
        Task AddTeacher(string teaId, string teaName, string gender, string telephone, string IDNumber, string pwd);
        Task AddAdmin(string adminId, string adminName, string gender, string telephone, string IDNumber, string pwd);
        bool Login(string userId, string pwd, int identity, out Guid id);
        Task ChangePwd(string userId, int identity, string oldPwd, string newPwd);
        Task ChangeUserInformaion(string userId, string stuName, string gender, string IDNumber, string pwd);
        Task<Dto.UserInfoDto> GetUserByUserId(string userId, int identity);
    }
}
