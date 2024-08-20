using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIKO_task.BaseClass
{
    public abstract class AbstractPerson // CTRL + R, R
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public enum Gender
        {
            Male,
            Female      
        }

        public Gender gender;

        public string GetFullName()
        {
            if (gender == Gender.Male)
                return "Mr" + Name + Surname;
            else 
                return "Mrs" + Name + Surname;
        }
        // text
        // folder for interfaces
        // folder for BaseClass
    }
}
