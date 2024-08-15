using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TIKO_task
{
    public class Manager:Abclass,CommonEMPman
    {
        private int YearlySalary { get; set; }
        private int YearStarted { get; set; }
        private string EmpoleeList { get; set; }
        public virtual string GetFullName()
        {
            string nickname = Convert.ToString(surname);
            return nickname + "  " + name + "  " + surname;

        }
        public int GetAmountPaid(int CurrentYear)
        {
            int paid = (CurrentYear - YearStarted - 1) * YearStarted;
            return paid;
        }
        public  int GetMaxVacationAmount(int CurrentYear)
        {
            int amount = (CurrentYear - YearStarted - 1) * 28;
            return amount;


        }
        public int GetEmployeeCount()
        {

        }
}
}
