using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TIKO_task.BaseClass;
using TIKO_task.Interfaces;

namespace TIKO_task
{
    public class Manager:AbstractPerson,ICommonEmployeeManager
    {
        //Manager() : base() { }
        private int ManagerYearlySalary { get; set; }
        private int ManagerYearStarted { get; set; }
        private Employee EmpoleeList { get; set; }
        
        //public string GetFullName()
       
        public int GetAmountPaid(int ManagerCurrentYear)
        {
            return (ManagerCurrentYear - ManagerYearStarted - 1) * ManagerYearStarted;
        }
        public  int GetMaxVacationAmount(int ManagerCurrentYear)
        {
            return (ManagerCurrentYear - ManagerYearStarted - 1) * 28;


        }
        public List<Employee> GetEmployeeCount = new List<Employee>(); //stex el nayi

        

        
}
}
