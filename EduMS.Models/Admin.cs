using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.Models
{
    public class Admin:BaseEntity
    {
        [Required, Key, StringLength(12), Column(TypeName = "varchar")]
        public string AdminId { get; set; }


        [Required, StringLength(30)]
        public string AdminName { get; set; }


        [Required]
        public string Gender { get; set; }


        [Required, StringLength(11), Column(TypeName = "varchar")]
        public string Telephone { get; set; }


        [Required, StringLength(18), Column(TypeName = "varchar")]
        public string IDNumber { get; set; }

        [Required, StringLength(12), Column(TypeName = "varchar")]
        public string Pwd { get; set; }
    }
}
