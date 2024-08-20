using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIKO_task.BaseClass;
using TIKO_task.Interfaces;

namespace TIKO_task
{
    public class Employee : AbstractPerson,ICommonEmployeeManager
    {
       
        private int EmployeeYearlySalary { get; set; }
        private int EmployeeYearStarted { get; set; }
        private Manager Manager { get; set; }
        
        // GetFullName();

        public int GetAmountPaid(int EmployeeCurrentYear)
        {
            return (EmployeeCurrentYear - EmployeeYearStarted - 1) * EmployeeYearStarted;
        }
        public int GetMaxVacationAmount(int EmployeeCurrentYear)
        {
            return (EmployeeCurrentYear - EmployeeYearStarted - 1) * 28;


        }
        public string GetManagerFullName()
        {
            return Manager.GetFullName();   //look here (composition)
        }
    }
}
