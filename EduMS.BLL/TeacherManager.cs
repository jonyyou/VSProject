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
    }
}
