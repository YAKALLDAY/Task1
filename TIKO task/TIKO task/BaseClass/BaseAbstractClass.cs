using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIKO_task.BaseClass
{
    public abstract class BaseAbstractClass // CTRL + R, R
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public enum Gender
        {
            Male,
            Female,
            Other
        }
        public abstract int GetFullName();
        // text
        // folder for interfaces
        // folder for BaseClass
    }
}
