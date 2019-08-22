///使用人员   逻辑判断

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EduMS.IBLL;
using EduMS.Models;

namespace EduMS.BLL
{
    public class UserManager : IUserManager
    {
        public async Task AddStudent(string stuId, string stuName, string gender, string telephone, string IDNumber, string pwd, string major, string classId)
        {
            using (IDAL.IStudentService stuSvc = new DAL.StudentService())
            {
                await stuSvc.CreateAsync(new Student()
                {
                    ModifyTime = DateTime.Now,
                    StuId = stuId,
                    StuName = stuName,
                    Gender = gender,
                    Telephone = telephone,
                    IDNumber = IDNumber,
                    Pwd = pwd,
                    Major = major,
                    ClassId = classId

                }) ;
            }
        }

        public async Task AddTeacher(string teaId, string teaName, string gender, string telephone, string IDNumber, string pwd)
        {
            using (IDAL.ITeacherService teaSvc = new DAL.TeacherService())
            {
                await teaSvc.CreateAsync(new Teacher()
                {
                    TeaId = teaId,
                    TeaName = teaName,
                    Gender = gender,
                    Telephone = telephone,
                    IDNumber = IDNumber,
                    Pwd = pwd

                });
            }
        }

        public async Task AddAdmin(string adminId, string adminName, string gender, string telephone, string IDNumber, string pwd)
        {
            using (IDAL.IAdminService adminSvc = new DAL.AdminService())
            {
                await adminSvc.CreateAsync(new Admin()
                {
                    AdminId = adminId,
                    AdminName = adminName,
                    Gender = gender,
                    Telephone = telephone,
                    IDNumber = IDNumber,
                    Pwd = pwd

                });
            }
        }

        public bool Login(string userId, string pwd, int identity, out Guid id)
        {
            if (identity == 0)  //学生
            {
                using (IDAL.IStudentService userSvc = new DAL.StudentService())
                {
                    var user = userSvc.GetAllAsync().FirstOrDefaultAsync(m => m.StuId == userId && m.Pwd == pwd);
                    user.Wait();
                    var data = user.Result;
                    if (data == null)
                    {
                        id = new Guid();
                        return false;
                    }
                    else
                    {
                        id = data.Id;
                        return true;
                    }

                }

            }
            else if (identity == 1)   //教师
            {
                using (IDAL.ITeacherService userSvc = new DAL.TeacherService())
                {
                    var user = userSvc.GetAllAsync().FirstOrDefaultAsync(m => m.TeaId == userId && m.Pwd == pwd);
                    user.Wait();
                    var data = user.Result;
                    if (data == null)
                    {
                        id = new Guid();
                        return false;
                    }
                    else
                    {
                        id = data.Id;
                        return true;
                    }

                }

            }
            else if (identity == 2)   //管理员
            {
                using (IDAL.IAdminService userSvc = new DAL.AdminService())
                {
                    var user = userSvc.GetAllAsync().FirstOrDefaultAsync(m => m.AdminId == userId && m.Pwd == pwd);
                    user.Wait();
                    var data = user.Result;
                    if (data == null)
                    {
                        id = new Guid();
                        return false;
                    }
                    else
                    {
                        id = data.Id;
                        return true;
                    }

                }
            }
            id = new Guid();
            return false;

        }

        public async Task ChangePwd(string userId, int identity, string oldPwd, string newPwd)
        {
            if (identity == 0)
            {
                using (IDAL.IStudentService userSvc = new DAL.StudentService())
                {
                    if (await userSvc.GetAllAsync().AnyAsync(m => m.StuId == userId && m.Pwd == oldPwd))
                    {
                        var user = await userSvc.GetAllAsync().FirstAsync(m => m.StuId == userId);
                        user.Pwd = newPwd;
                        await userSvc.EditAsync(user);
                    }
                }

            }
            else if (identity == 1)
            {
                using (IDAL.ITeacherService userSvc = new DAL.TeacherService())
                {
                    if (await userSvc.GetAllAsync().AnyAsync(m => m.TeaId == userId && m.Pwd == oldPwd))
                    {
                        var user = await userSvc.GetAllAsync().FirstAsync(m => m.TeaId == userId);
                        user.Pwd = newPwd;
                        await userSvc.EditAsync(user);
                    }
                }

            }
            else if (identity == 2)
            {
                using (IDAL.IAdminService userSvc = new DAL.AdminService())
                {
                    if (await userSvc.GetAllAsync().AnyAsync(m => m.AdminId == userId && m.Pwd == oldPwd))
                    {
                        var user = await userSvc.GetAllAsync().FirstAsync(m => m.AdminId == userId);
                        user.Pwd = newPwd;
                        await userSvc.EditAsync(user);
                    }
                }
            }

        }

        public Task ChangeUserInformaion(string userId, string stuName, string gender, string IDNumber, string pwd)
        {
            throw new NotImplementedException();
        }

        public async Task<Dto.UserInfoDto> GetUserByUserId(string userId, int identity)
        {
            if (identity == 0)
            {
                using (IDAL.IStudentService userSvc = new DAL.StudentService())
                {
                    if (await userSvc.GetAllAsync().AnyAsync(m => m.StuId == userId))
                    {
                        return await userSvc.GetAllAsync().Where(m => m.StuId == userId).Select(m =>
                        new Dto.UserInfoDto()
                        {
                            Id = m.Id,
                            UserId = m.StuId,
                            Identity = identity,
                            Gender = m.Gender,
                            IDNumber = m.IDNumber
                        }).FirstAsync();
                    }
                }

            }
            else if (identity == 1)
            {
                using (IDAL.ITeacherService userSvc = new DAL.TeacherService())
                {
                    if (await userSvc.GetAllAsync().AnyAsync(m => m.TeaId == userId))
                    {
                        return await userSvc.GetAllAsync().Where(m => m.TeaId == userId).Select(m =>
                        new Dto.UserInfoDto()
                        {
                            Id = m.Id,
                            UserId = m.TeaId,
                            Identity = identity,
                            Gender = m.Gender,
                            IDNumber = m.IDNumber
                        }).FirstAsync();
                    }
                }

            }
            else if (identity == 2)
            {
                using (IDAL.IAdminService userSvc = new DAL.AdminService())
                {
                    if (await userSvc.GetAllAsync().AnyAsync(m => m.AdminId == userId))
                    {
                        return await userSvc.GetAllAsync().Where(m => m.AdminId == userId).Select(m =>
                        new Dto.UserInfoDto()
                        {
                            Id = m.Id,
                            UserId = m.AdminId,
                            Identity = identity,
                            Gender = m.Gender,
                            IDNumber = m.IDNumber
                        }).FirstAsync();
                    }
                }
            }
            else
            {
                throw new ArgumentException("账号不存在");
            }
            return null;

        }
    }
}
