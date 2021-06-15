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
            register = new List<string>();
        }

        public void AddInfo(string info)
        {
            register.Add(info);
        }
        public void SkrivUt()
        {
            int i = 0;
            foreach (string j in register)
            {
                
                Console.WriteLine(register[i]);
                i++;
            }
        }

        public List<string> register;
    }
}