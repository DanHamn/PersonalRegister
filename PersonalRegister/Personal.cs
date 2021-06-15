using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    class Personal
    {
        public Personal()
        {
            register = new List<Tuple<string, double>>();
        }

        public void AddInfo(string namn, double lön)
        {
            register.Add(new Tuple<string,double>(namn, lön));
        }
        public void SkrivUt()
        {
            int i = 0;
            foreach (Tuple<string, double> j in register)
            {
                
                Console.WriteLine(register[i]);
                i++;
            }
        }

        public List<Tuple<string,double>> register;
    }
}