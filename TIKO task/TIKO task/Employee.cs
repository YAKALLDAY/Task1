using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIKO_task.BaseClass;
using TIKO_task.Interfaces;

namespace TIKO_task
{
    public class Employee : BaseAbstractClass,ICommonEmpMan
    {
       
        private int YearlySalary { get; set; }
        private int YearStarted { get; set; }
        private int Manager;

        public virtual string GetFullName()
        {
            string NickName = Convert.ToString(Gender);
            return NickName + "  " + Name + "  " + Surname;

        }
        public int GetAmountPaid(int CurrentYear)
        {
            int Paid = (CurrentYear - YearStarted - 1) * YearStarted;
            return Paid;
        }
        public int GetMaxVacationAmount(int CurrentYear)
        {
            int Amount = (CurrentYear - YearStarted - 1) * 28;
            return Amount;


        }
        public string GetManagerFullName(string ManagerName)
        {
            return ManagerName;
        }
    }
}
