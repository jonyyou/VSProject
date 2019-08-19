using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.Models
{
    public class Teacher : BaseEntity
    {
        [Required, Key, StringLength(12), Column(TypeName = "varchar")]
        public string TeaId { get; set; }


        [Required, StringLength(30)]
        public string TeaName { get; set; }


        [Required]
        public string Gender { get; set; }

        [Required, StringLength(11), Column(TypeName = "varchar")]
        public string Telephone { get; set; }

        [Required, StringLength(18), Column(TypeName = "varchar")]
        public string IDNumber { get; set; }

        [Required, StringLength(12), Column(TypeName = "varchar")]
        public string Pwd { get; set; }

        /// <summary>
        /// 院系外键
        /// </summary>
        [ForeignKey(nameof(Department))]
        public string DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
