﻿using EduMS.DAL;
using EduMS.Dto;
using EduMS.IBLL;
using EduMS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.BLL
{
    public class CourseManager : ICourseManager
    {
        public async Task AddCourse(string courseId, string courseName, double credits, int hours, string courseSpecialty, string description)
        {
            using (IDAL.ICourseService Svc = new DAL.CourseService())
            {
                await Svc.CreateAsync(new Course()
                {
                    ModifyTime = DateTime.Now,
                    CourseId = courseId,
                    CourseName = courseName,
                    Credits = credits,
                    Hours = hours,
                    CourseSpecialty = courseSpecialty,
                    Description = description
                });
            }
        }

        public async Task<List<CourseInfoDto>> GetAllCourses()
        {
            using (IDAL.ICourseService Service = new CourseService())
            {
                return await Service.GetAllAsync().Select(m => new Dto.CourseInfoDto()
                {
                    CourseId = m.CourseId,
                    CourseName = m.CourseName,
                    Credits = m.Credits,
                    Hours = m.Hours,
                    CourseSpecialty = m.CourseSpecialty,
                    Description = m.Description
                }).ToListAsync();
            }
        }

        public async Task AddCaltivatePlan(string semester, string courseId, string departmentId)
        {
            using (IDAL.ICaltivatePlanService Svc = new DAL.CaltivatePlanService())
            {
                await Svc.CreateAsync(new CaltivatePlan()
                {
                    ModifyTime = DateTime.Now,
                    Semester = semester,
                    CourseId = courseId,
                    DepartmentId = departmentId
                });
            }
        }

        public async Task<List<CaltivatePlanDto>> GetAllCoursesByDepart(string departmentId, string semester)
        {
            using (IDAL.ICaltivatePlanService Service = new CaltivatePlanService())
            {
                return await Service.GetAllAsync().Where(m=> m.DepartmentId == departmentId&&m.Semester == semester).Select(m => new Dto.CaltivatePlanDto()
                {
                    CourseId = m.CourseId,
                    CourseName = m.Course.CourseName
                }).ToListAsync();
            }
        }
    }
}
