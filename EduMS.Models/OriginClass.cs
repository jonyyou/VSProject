using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.Models
{
    public class OriginClass : BaseEntity
    {
        [Required, Key, StringLength(10), Column(TypeName = "varchar")]
        public string ClassId { get; set; }


        [StringLength(30)]
        public string ClassName { get; set; }

        [StringLength(12)]
        public string MonitorId { get; set; }

        public virtual ICollection<Student> Student { get; set; }

        /// <summary>
        /// 院系外键
        /// </summary>
        [ForeignKey(nameof(Department))]
        public string DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
