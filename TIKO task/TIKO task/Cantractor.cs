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
    public class Cantractor:BaseAbstractClass, ICommonEMpCon
    {
        private string Manager { get; set; }
        private string Contract { get; set; }

        public virtual string GetFullName()
        {
            string nickname = Convert.ToString(Gender);    // tikoooooooooooooooooo
            return nickname + "  " + Name + "  " + Surname;

        }
        public string GetManagerFullname (string ManagerName)
    {
        return ManagerName;
    }
        public string GetContractInfo(int Summary)
        {
        string Sum = Convert.ToString(Summary);
            return Sum;

        }
    }
}
