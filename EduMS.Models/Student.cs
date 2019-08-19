using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.Models
{
    public class Student : BaseEntity
    {

        [Required, Key, StringLength(12), Column(TypeName = "varchar")]
        public string StuId { get; set; }


        [Required, StringLength(30)]
        public string StuName { get; set; }


        [Required]
        public string Gender { get; set; }


        [Required, StringLength(11), Column(TypeName = "varchar")]
        public string Telephone { get; set; }


        [Required, StringLength(18), Column(TypeName = "varchar")]
        public string IDNumber { get; set; }

        [Required, StringLength(12, MinimumLength = 6), Column(TypeName = "varchar")]
        public string Pwd { get; set; }

        [Required]
        public string Major { get; set; }

        /// <summary>
        /// 班级外键
        /// </summary>

        [ForeignKey(nameof(OriginClass))]
        public string ClassId { get; set; }
        public OriginClass OriginClass { get; set; }

        /// <summary>
        /// 院系外键
        /// </summary>
        [ForeignKey(nameof(Department))]
        public string DepartmentId { get; set; }
        public Department Department { get; set; }



    }
}
