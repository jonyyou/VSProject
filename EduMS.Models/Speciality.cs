using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EduMS.Models
{
    //院系下的专业
    public class Speciality:BaseEntity
    {
        [Required,StringLength(8),Column(TypeName = "varchar")]
        public string SpecialityId { get; set; }

        [Required, StringLength(20)]
        public string SpecialityName { get; set; }

        /// <summary>
        /// 院系外键
        /// </summary>
        [ForeignKey(nameof(Department))]
        public string DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
