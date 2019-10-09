using EduMS.IBLL;
using EduMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduMS.Models;

namespace EduMS.BLL
{
    public class CtrlCodeManager : ICtrlCodeManager
    {
        public async Task StartSelection()
        {
            ControlCode model = new ControlCode
            {
                IfSelectCourse = "1"
            };
            using (IDAL.IControlCodeService Svc = new ControlCodeService())
            {
                await Svc.EditAsync(model);
                
            }
        }

        public async Task StopSelection()
        {
            ControlCode model = new ControlCode
            {
                IfSelectCourse = "0"
            };
            using (IDAL.IControlCodeService Svc = new ControlCodeService())
            {
                await Svc.EditAsync(model);

            }
        }
    }
}
