using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EduMS.MVCSite.Models.Admin
{
    public class PublishCourseViewModel
    {
        public string DepartmentId { get; set; }

        public string CourseId { get; set; }

        public string CourseName { get; set; }

        public string TeaId { get; set; }
    }
}