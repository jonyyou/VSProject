using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.Dto
{
    public class UserInfoDto
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public int Identity { get; set; }
        public string Gender { get; set; }
        public string IDNumber { get; set; }
    }
}
