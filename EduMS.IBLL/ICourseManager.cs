using EduMS.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.IBLL
{
    public interface ICourseManager
    {
        Task AddCourse(string courseId, string courseName, double credits, int hours, string courseSpecialty, string description);
        Task<List<CourseInfoDto>> GetAllCourses();
        Task AddCaltivatePlan(string semester, string courseId, string departmentId);
        Task<List<CaltivatePlanDto>> GetAllCoursesByDepart(string departmentId, string semester);
    }
}
