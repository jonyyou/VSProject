using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EduMS.Models
{
    //学院
    public class Department : BaseEntity
    {
        [Required,Key,StringLength(8),Column(TypeName ="varchar")]
        public string DepartmentId { get; set; }

        [Required,StringLength(20)]
        public string DepartmentName { get; set; }

        public virtual ICollection<Speciality> Speciality { get; set; }

        public virtual ICollection<OriginClass> OriginClass { get; set; }

    }
}
