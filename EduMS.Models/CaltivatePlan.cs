using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.Models
{
    public class CaltivatePlan:BaseEntity
    {
        [Required,Key]
        public string Semester { get; set; }

        [ForeignKey(nameof(Department))]
        public string DepartmentId { get; set; }
        public Department Department { get; set; }

        [ForeignKey(nameof(Course))]
        public string CourseId { get; set; }
        public Course Course { get; set; }

    }
}
