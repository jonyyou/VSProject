﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.IBLL
{
    public interface ICtrlCodeManager
    {
        Task StartSelection();
        Task StopSelection();
    }
}