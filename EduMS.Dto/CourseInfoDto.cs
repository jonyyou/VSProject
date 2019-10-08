using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.Dto
{
    public class CourseInfoDto
    {
        
        public string CourseId { get; set; }

        
        public string CourseName { get; set; }

        
        public double Credits { get; set; }    //学分

       
        public int Hours { get; set; }      //学时

        
        public string CourseSpecialty { get; set; }   //0表示选修课，1表示必修课 

        public string Description { get; set; }
    }
}
