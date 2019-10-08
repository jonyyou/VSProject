using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EduMS.IBLL;
using EduMS.Models;
using EduMS.Dto;

namespace EduMS.BLL
{
    public class TeacherManager : ITeacherManager
    {
        public async Task AddTeacher(string teaId, string teaName, string gender, string telephone, string IDNumber, string pwd, string DepartmentId)
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
                    Pwd = pwd,
                    DepartmentId= DepartmentId

                });
            }
        }

        public Task<List<TeacherInfoDto>> GetAllTeachers()
        {
            throw new NotImplementedException();
        }

        public async Task<List<TeacherInfoDto>> GetTeacherByDepId(string depId)
        {
            using(IDAL.ITeacherService teaSvc = new DAL.TeacherService())
            {
                return await teaSvc.GetAllAsync().Where(m=>m.DepartmentId==depId).Select(m => new Dto.TeacherInfoDto()
                {
                    TeaId = m.TeaId,
                    TeaName = m.TeaName
                }).ToListAsync();
            }
        }
    }
}
