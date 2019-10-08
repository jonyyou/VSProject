using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.Models
{
    public enum Grade
    {
        A,B,C,D,F
    }
    public class Enrollment
    {
        [Required, Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Course))]
        public string CourseId { get; set; }
        [ForeignKey(nameof(Student))]
        public string StuId { get; set; }
        public int Score { get; set; }  //百分制成绩
        public Grade? Grade { get; set; } //等级
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
