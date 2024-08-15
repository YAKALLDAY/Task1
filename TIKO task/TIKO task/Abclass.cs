using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIKO_task
{
    public abstract class Abclass
    {
        public string name { get; set; }
        public string surname { get; set; }
        public enum gender
        {
            male,
            female,
            trans,
            lezbi,
            bi,
            geterosexual,
            Karen,
            Tiko,
            other
        }
        public abstract int GetFullName();
        

    }
}
