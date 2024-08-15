using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TIKO_task
{
    public class Cantractor:Abclass, CommonEMpCon
    {
        private string Manager { get; set; }
        private string Contract { get; set; }

        public override string GetFullName()
        {
            string nickname = Convert.ToString(gender);    // tikoooooooooooooooooo
            return nickname + "  " + name + "  " + surname;

        }
        public string GetManagerFullname (string Managername)
    {
        return Managername;
    }
        public string GetContractInfo(int summary)
        {
        string sum = Convert.ToString(summary);
            return sum;

        }
    }
}
