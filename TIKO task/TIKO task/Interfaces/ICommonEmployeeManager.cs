﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIKO_task
{
    internal interface ICommonEmployeeManager
    {
        int GetAmountPaid(int CurrentYear);
        int GetMaxVacationAmount(int CurrentYear);
    }
}
