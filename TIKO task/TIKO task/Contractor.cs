using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TIKO_task.BaseClass;
using TIKO_task.Interfaces;
using System;
using System.Threading;
using System.Diagnostics.Contracts;

namespace TIKO_task
{
    public class Contractor:AbstractPerson, ICommonEmployeeContractor
    {
        private Contractor Contract { get; set; }
        private Manager Manager { get; set; }

        //GetFullName();
        public string GetContractInfo(int Summary)
        {
        string Sum = Convert.ToString(Summary);
            return Sum;

        }
        public string GetManagerFullName ()
    {
            return Manager.GetFullName();
    }
       
    }
}
